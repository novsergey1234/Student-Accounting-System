using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public static class DatabaseService
    {
        private static string _dbPath;
        private static string ConnectionString => $"Data Source={_dbPath};Version=3;";

        public static void Initialize()
        {
            try
            {
                _dbPath = Path.Combine(Application.StartupPath, "students.db");
                bool isNewDatabase = !File.Exists(_dbPath);

                if (isNewDatabase)
                {
                    SQLiteConnection.CreateFile(_dbPath);
                    CreateTables();
                }
                else
                {
                    MigrateDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации базы данных: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private static void MigrateDatabase()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                EnableForeignKeys(conn);

                using (var cmd = new SQLiteCommand(@"
                    CREATE TABLE IF NOT EXISTS GroupSubjects (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        GroupId INTEGER NOT NULL,
                        Name TEXT NOT NULL,
                        FOREIGN KEY (GroupId) REFERENCES Groups(Id) ON DELETE CASCADE
                    )", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Check if Subjects table exists
                bool subjectsTableExists = false;
                using (var cmd = new SQLiteCommand(
                    "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Subjects'", conn))
                {
                    subjectsTableExists = (long)cmd.ExecuteScalar() > 0;
                }

                if (subjectsTableExists)
                {
                    bool hasColumn = false;
                    using (var cmd = new SQLiteCommand("PRAGMA table_info(Subjects)", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(1) == "GroupSubjectId")
                            {
                                hasColumn = true;
                                break;
                            }
                        }
                    }

                    if (!hasColumn)
                    {
                        using (var cmd = new SQLiteCommand(
                            "ALTER TABLE Subjects ADD COLUMN GroupSubjectId INTEGER REFERENCES GroupSubjects(Id)", conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    // Create Subjects table with new schema
                    using (var cmd = new SQLiteCommand(@"
                        CREATE TABLE IF NOT EXISTS Subjects (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentId INTEGER NOT NULL,
                            GroupSubjectId INTEGER,
                            Name TEXT NOT NULL,
                            Semester1Grade INTEGER DEFAULT 0,
                            Semester2Grade INTEGER DEFAULT 0,
                            FinalGrade INTEGER DEFAULT 0,
                            FOREIGN KEY (StudentId) REFERENCES Students(Id) ON DELETE CASCADE,
                            FOREIGN KEY (GroupSubjectId) REFERENCES GroupSubjects(Id) ON DELETE SET NULL
                        )", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void EnableForeignKeys(SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        private static void CreateTables()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                EnableForeignKeys(conn);
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Groups (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            SubGroups TEXT NOT NULL
                        );

                        CREATE TABLE IF NOT EXISTS Students (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            GroupId INTEGER NOT NULL,
                            LastName TEXT NOT NULL,
                            FirstName TEXT NOT NULL,
                            MiddleName TEXT,
                            BirthDate TEXT,
                            Phone TEXT,
                            Email TEXT,
                            Address TEXT,
                            Status INTEGER NOT NULL,
                            SubGroup TEXT,
                            FOREIGN KEY (GroupId) REFERENCES Groups(Id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS GroupSubjects (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            GroupId INTEGER NOT NULL,
                            Name TEXT NOT NULL,
                            FOREIGN KEY (GroupId) REFERENCES Groups(Id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS Subjects (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentId INTEGER NOT NULL,
                            GroupSubjectId INTEGER,
                            Name TEXT NOT NULL,
                            Semester1Grade INTEGER DEFAULT 0,
                            Semester2Grade INTEGER DEFAULT 0,
                            FinalGrade INTEGER DEFAULT 0,
                            FOREIGN KEY (StudentId) REFERENCES Students(Id) ON DELETE CASCADE,
                            FOREIGN KEY (GroupSubjectId) REFERENCES GroupSubjects(Id) ON DELETE SET NULL
                        );
                    ";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Group> LoadAllData()
        {
            var groups = new List<Group>();
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand("SELECT Id, Name, SubGroups FROM Groups", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var subGroupsStr = reader.GetString(2);
                            var subGroupsList = string.IsNullOrEmpty(subGroupsStr) 
                                ? new List<string>() 
                                : new List<string>(subGroupsStr.Split(','));
                            
                            groups.Add(new Group
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                SubGroups = subGroupsList
                            });
                        }
                    }

                    foreach (var group in groups)
                    {
                        LoadGroupSubjectsForGroup(conn, group);

                        using (var cmd = new SQLiteCommand(
                            "SELECT Id, LastName, FirstName, MiddleName, BirthDate, Phone, Email, Address, Status, SubGroup FROM Students WHERE GroupId = @groupId", 
                            conn))
                        {
                            cmd.Parameters.AddWithValue("@groupId", group.Id);
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var student = new Student
                                    {
                                        Id = reader.GetInt32(0),
                                        LastName = reader.GetString(1),
                                        FirstName = reader.GetString(2),
                                        MiddleName = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                        BirthDate = reader.IsDBNull(4) ? DateTime.MinValue : DateTime.Parse(reader.GetString(4)),
                                        Phone = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                        Email = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                        Address = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                        Status = (StudentStatus)reader.GetInt32(8),
                                        SubGroup = reader.IsDBNull(9) ? "" : reader.GetString(9)
                                    };

                                    LoadSubjectsForStudent(conn, student);
                                    group.Students.Add(student);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return groups;
        }

        private static void LoadSubjectsForStudent(SQLiteConnection conn, Student student)
        {
            using (var cmd = new SQLiteCommand(
                "SELECT Id, Name, Semester1Grade, Semester2Grade, FinalGrade, GroupSubjectId FROM Subjects WHERE StudentId = @studentId", 
                conn))
            {
                cmd.Parameters.AddWithValue("@studentId", student.Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        student.Subjects.Add(new Subject
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Semester1Grade = reader.GetInt32(2),
                            Semester2Grade = reader.GetInt32(3),
                            FinalGrade = reader.GetInt32(4),
                            GroupSubjectId = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5)
                        });
                    }
                }
            }
        }

        private static void LoadGroupSubjectsForGroup(SQLiteConnection conn, Group group)
        {
            using (var cmd = new SQLiteCommand(
                "SELECT Id, Name FROM GroupSubjects WHERE GroupId = @groupId", conn))
            {
                cmd.Parameters.AddWithValue("@groupId", group.Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        group.GroupSubjects.Add(new GroupSubject
                        {
                            Id = reader.GetInt32(0),
                            GroupId = group.Id,
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
        }

        public static void SaveGroup(Group group)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        "INSERT INTO Groups (Name, SubGroups) VALUES (@name, @subGroups); SELECT last_insert_rowid();", 
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@name", group.Name);
                        cmd.Parameters.AddWithValue("@subGroups", string.Join(",", group.SubGroups));
                        group.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения группы: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void UpdateGroup(Group group)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        "UPDATE Groups SET Name = @name, SubGroups = @subGroups WHERE Id = @id", 
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@id", group.Id);
                        cmd.Parameters.AddWithValue("@name", group.Name);
                        cmd.Parameters.AddWithValue("@subGroups", string.Join(",", group.SubGroups));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления группы: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void DeleteGroup(int groupId)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        "DELETE FROM Subjects WHERE StudentId IN (SELECT Id FROM Students WHERE GroupId = @id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", groupId);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = new SQLiteCommand("DELETE FROM Students WHERE GroupId = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", groupId);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = new SQLiteCommand("DELETE FROM Groups WHERE Id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", groupId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления группы: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void SaveStudent(Student student, int groupId)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        @"INSERT INTO Students (GroupId, LastName, FirstName, MiddleName, BirthDate, Phone, Email, Address, Status, SubGroup) 
                          VALUES (@groupId, @lastName, @firstName, @middleName, @birthDate, @phone, @email, @address, @status, @subGroup);
                          SELECT last_insert_rowid();", 
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@groupId", groupId);
                        cmd.Parameters.AddWithValue("@lastName", student.LastName);
                        cmd.Parameters.AddWithValue("@firstName", student.FirstName);
                        cmd.Parameters.AddWithValue("@middleName", student.MiddleName ?? "");
                        cmd.Parameters.AddWithValue("@birthDate", student.BirthDate == DateTime.MinValue ? "" : student.BirthDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@phone", student.Phone ?? "");
                        cmd.Parameters.AddWithValue("@email", student.Email ?? "");
                        cmd.Parameters.AddWithValue("@address", student.Address ?? "");
                        cmd.Parameters.AddWithValue("@status", (int)student.Status);
                        cmd.Parameters.AddWithValue("@subGroup", student.SubGroup ?? "");
                        student.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    foreach (var subject in student.Subjects)
                    {
                        SaveSubject(subject, student.Id, conn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения студента: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void UpdateStudent(Student student)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        @"UPDATE Students SET LastName = @lastName, FirstName = @firstName, MiddleName = @middleName, 
                          BirthDate = @birthDate, Phone = @phone, Email = @email, Address = @address, Status = @status, SubGroup = @subGroup 
                          WHERE Id = @id", 
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@id", student.Id);
                        cmd.Parameters.AddWithValue("@lastName", student.LastName);
                        cmd.Parameters.AddWithValue("@firstName", student.FirstName);
                        cmd.Parameters.AddWithValue("@middleName", student.MiddleName ?? "");
                        cmd.Parameters.AddWithValue("@birthDate", student.BirthDate == DateTime.MinValue ? "" : student.BirthDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@phone", student.Phone ?? "");
                        cmd.Parameters.AddWithValue("@email", student.Email ?? "");
                        cmd.Parameters.AddWithValue("@address", student.Address ?? "");
                        cmd.Parameters.AddWithValue("@status", (int)student.Status);
                        cmd.Parameters.AddWithValue("@subGroup", student.SubGroup ?? "");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления студента: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void DeleteStudent(int studentId)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand("DELETE FROM Students WHERE Id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления студента: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void SaveSubject(Subject subject, int studentId, SQLiteConnection conn = null)
        {
            try
            {
                bool shouldCloseConnection = false;
                if (conn == null)
                {
                    conn = new SQLiteConnection(ConnectionString);
                    conn.Open();
                    EnableForeignKeys(conn);

                    shouldCloseConnection = true;
                }

                try
                {
                    using (var cmd = new SQLiteCommand(
                        @"INSERT INTO Subjects (StudentId, GroupSubjectId, Name, Semester1Grade, Semester2Grade, FinalGrade) 
                          VALUES (@studentId, @gsId, @name, @sem1, @sem2, @final);
                          SELECT last_insert_rowid();", 
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@gsId", (object)subject.GroupSubjectId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@name", subject.Name);
                        cmd.Parameters.AddWithValue("@sem1", subject.Semester1Grade);
                        cmd.Parameters.AddWithValue("@sem2", subject.Semester2Grade);
                        cmd.Parameters.AddWithValue("@final", subject.FinalGrade);
                        subject.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                finally
                {
                    if (shouldCloseConnection)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения предмета: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void UpdateSubject(Subject subject)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        @"UPDATE Subjects SET Name = @name, Semester1Grade = @sem1, Semester2Grade = @sem2, FinalGrade = @final 
                          WHERE Id = @id", 
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@id", subject.Id);
                        cmd.Parameters.AddWithValue("@name", subject.Name);
                        cmd.Parameters.AddWithValue("@sem1", subject.Semester1Grade);
                        cmd.Parameters.AddWithValue("@sem2", subject.Semester2Grade);
                        cmd.Parameters.AddWithValue("@final", subject.FinalGrade);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления предмета: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void DeleteSubject(int subjectId)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE Id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", subjectId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления предмета: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void SaveGroupSubject(GroupSubject groupSubject, int groupId)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        "INSERT INTO GroupSubjects (GroupId, Name) VALUES (@groupId, @name); SELECT last_insert_rowid();", conn))
                    {
                        cmd.Parameters.AddWithValue("@groupId", groupId);
                        cmd.Parameters.AddWithValue("@name", groupSubject.Name);
                        groupSubject.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Create subject entries for all students in the group
                    foreach (var student in DataStore.Groups.First(g => g.Id == groupId).Students)
                    {
                        using (var cmd = new SQLiteCommand(
                            @"INSERT INTO Subjects (StudentId, GroupSubjectId, Name, Semester1Grade, Semester2Grade, FinalGrade) 
                              VALUES (@studentId, @gsId, @name, 0, 0, 0); SELECT last_insert_rowid();", conn))
                        {
                            cmd.Parameters.AddWithValue("@studentId", student.Id);
                            cmd.Parameters.AddWithValue("@gsId", groupSubject.Id);
                            cmd.Parameters.AddWithValue("@name", groupSubject.Name);
                            var subId = Convert.ToInt32(cmd.ExecuteScalar());
                            student.Subjects.Add(new Subject
                            {
                                Id = subId,
                                StudentId = student.Id,
                                GroupSubjectId = groupSubject.Id,
                                Name = groupSubject.Name,
                                Semester1Grade = 0,
                                Semester2Grade = 0,
                                FinalGrade = 0
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения предмета группы: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void UpdateGroupSubject(GroupSubject groupSubject)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        "UPDATE GroupSubjects SET Name = @name WHERE Id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", groupSubject.Id);
                        cmd.Parameters.AddWithValue("@name", groupSubject.Name);
                        cmd.ExecuteNonQuery();
                    }

                    // Also update subject names for all students
                    using (var cmd = new SQLiteCommand(
                        "UPDATE Subjects SET Name = @name WHERE GroupSubjectId = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", groupSubject.Id);
                        cmd.Parameters.AddWithValue("@name", groupSubject.Name);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления предмета группы: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void DeleteGroupSubject(int groupSubjectId)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    using (var cmd = new SQLiteCommand(
                        "DELETE FROM Subjects WHERE GroupSubjectId = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", groupSubjectId);
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new SQLiteCommand(
                        "DELETE FROM GroupSubjects WHERE Id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", groupSubjectId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Update in-memory data
                foreach (var group in DataStore.Groups)
                {
                    var gs = group.GroupSubjects.FirstOrDefault(s => s.Id == groupSubjectId);
                    if (gs != null)
                    {
                        group.GroupSubjects.Remove(gs);
                        break;
                    }
                }
                foreach (var group in DataStore.Groups)
                {
                    foreach (var student in group.Students)
                    {
                        student.Subjects.RemoveAll(s => s.GroupSubjectId == groupSubjectId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления предмета группы: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void CreateSubjectsForNewStudent(Student student, int groupId)
        {
            try
            {
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    EnableForeignKeys(conn);

                    var group = DataStore.Groups.First(g => g.Id == groupId);
                    foreach (var gs in group.GroupSubjects)
                    {
                        using (var cmd = new SQLiteCommand(
                            @"INSERT INTO Subjects (StudentId, GroupSubjectId, Name, Semester1Grade, Semester2Grade, FinalGrade) 
                              VALUES (@studentId, @gsId, @name, 0, 0, 0); SELECT last_insert_rowid();", conn))
                        {
                            cmd.Parameters.AddWithValue("@studentId", student.Id);
                            cmd.Parameters.AddWithValue("@gsId", gs.Id);
                            cmd.Parameters.AddWithValue("@name", gs.Name);
                            var subId = Convert.ToInt32(cmd.ExecuteScalar());
                            student.Subjects.Add(new Subject
                            {
                                Id = subId,
                                StudentId = student.Id,
                                GroupSubjectId = gs.Id,
                                Name = gs.Name,
                                Semester1Grade = 0,
                                Semester2Grade = 0,
                                FinalGrade = 0
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания предметов для студента: {ex.Message}", "Ошибка БД", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
