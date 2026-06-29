using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Accounting_System
{
    public enum StudentStatus
    {
        Active,    // Учится
        Academic,  // Академотпуск
        Debtor     // Должник
    }

    public class GroupSubject
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int? GroupSubjectId { get; set; }
        public string Name { get; set; }
        public int Semester1Grade { get; set; }
        public int Semester2Grade { get; set; }
        public int FinalGrade { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public StudentStatus Status { get; set; }
        public string SubGroup { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public string FullName => $"{LastName} {FirstName} {MiddleName}".Trim();

        public double AverageGrade
        {
            get
            {
                if (Subjects.Count == 0) return 0;
                return Subjects.Average(s => s.FinalGrade > 0 ? s.FinalGrade : (s.Semester1Grade + s.Semester2Grade) / 2.0);
            }
        }

        public string StatusLabel
        {
            get
            {
                switch (Status)
                {
                    case StudentStatus.Active: return "Учится";
                    case StudentStatus.Academic: return "Академотпуск";
                    case StudentStatus.Debtor: return "Должник";
                    default: return "Учится";
                }
            }
        }
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> SubGroups { get; set; } = new List<string>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<GroupSubject> GroupSubjects { get; set; } = new List<GroupSubject>();

        public string FullName => Name;
    }

    public static class DataStore
    {
        private static int _nextStudentId = 100;
        private static int _nextGroupId = 10;
        private static int _nextSubjectId = 200;
        private static int _nextGroupSubjectId = 50;

        public static int NextStudentId() => _nextStudentId++;
        public static int NextGroupId() => _nextGroupId++;
        public static int NextSubjectId() => _nextSubjectId++;
        public static int NextGroupSubjectId() => _nextGroupSubjectId++;

        public static List<Group> Groups { get; } = new List<Group>();

        static DataStore()
        {
            var loadedGroups = DatabaseService.LoadAllData();
            if (loadedGroups.Count == 0)
            {
                //SeedData();
            }
            else
            {
                Groups.Clear();
                foreach (var g in loadedGroups)
                    Groups.Add(g);
                
                if (Groups.Count > 0)
                {
                    _nextGroupId = Groups.Max(g => g.Id) + 1;
                    var allStudents = Groups.SelectMany(g => g.Students).ToList();
                    if (allStudents.Count > 0)
                    {
                        _nextStudentId = allStudents.Max(s => s.Id) + 1;
                        var allSubjects = allStudents.SelectMany(s => s.Subjects).ToList();
                        if (allSubjects.Count > 0)
                            _nextSubjectId = allSubjects.Max(sub => sub.Id) + 1;
                    }
                    var allGroupSubjects = Groups.SelectMany(g => g.GroupSubjects).ToList();
                    if (allGroupSubjects.Count > 0)
                        _nextGroupSubjectId = allGroupSubjects.Max(gs => gs.Id) + 1;
                }
            }
        }

        private static void SeedData()
        {
            var g1 = new Group { Id = 1, Name = "ИС-21", SubGroups = new List<string> { "А", "Б" } };
            g1.Students.Add(MakeStudent(1, "Иванов", "Иван", "Сергеевич", "2003-05-12", "+7 900 123-45-67", "ivanov@example.com", "г. Москва, ул. Примерная, д. 1", StudentStatus.Active, "А",
                new[] { (5, 4, 5), (4, 5, 5), (5, 5, 5) }));
            g1.Students.Add(MakeStudent(2, "Петров", "Пётр", "Ильич", "2003-08-20", "+7 901 234-56-78", "petrov@example.com", "г. Москва, ул. Лесная, д. 5", StudentStatus.Academic, "А",
                new[] { (4, 4, 4), (3, 4, 4), (4, 5, 4) }));
            g1.Students.Add(MakeStudent(3, "Сидорова", "Мария", "Алексеевна", "2002-11-03", "+7 902 345-67-89", "sidorova@example.com", "г. Москва, ул. Садовая, д. 10", StudentStatus.Active, "Б",
                new[] { (5, 5, 5), (5, 5, 5), (5, 5, 5) }));
            g1.Students.Add(MakeStudent(4, "Козлов", "Алексей", "Викторович", "2003-02-14", "+7 903 456-78-90", "kozlov@example.com", "г. Москва, пр. Мира, д. 22", StudentStatus.Debtor, "А",
                new[] { (3, 3, 3), (2, 3, 3), (3, 2, 3) }));
            g1.Students.Add(MakeStudent(5, "Новикова", "Анна", "Петровна", "2003-07-25", "+7 904 567-89-01", "novikova@example.com", "г. Москва, ул. Цветочная, д. 8", StudentStatus.Active, "Б",
                new[] { (5, 5, 5), (4, 5, 5), (5, 4, 5) }));

            var g2 = new Group { Id = 2, Name = "ПИ-21", SubGroups = new List<string> { "А" } };
            g2.Students.Add(MakeStudent(6, "Морозов", "Дмитрий", "Игоревич", "2003-03-10", "+7 905 678-90-12", "morozov@example.com", "г. Москва, ул. Северная, д. 3", StudentStatus.Active, "А",
                new[] { (4, 4, 4), (5, 4, 4), (4, 4, 4) }));
            g2.Students.Add(MakeStudent(7, "Волкова", "Екатерина", "Дмитриевна", "2003-06-18", "+7 906 789-01-23", "volkova@example.com", "г. Москва, ул. Восточная, д. 15", StudentStatus.Active, "А",
                new[] { (5, 5, 5), (5, 5, 5), (4, 5, 5) }));
            g2.Students.Add(MakeStudent(8, "Лебедев", "Константин", "Андреевич", "2002-12-29", "+7 907 890-12-34", "lebedev@example.com", "г. Москва, ул. Западная, д. 7", StudentStatus.Debtor, "А",
                new[] { (2, 3, 3), (3, 2, 2), (3, 3, 3) }));

            var g3 = new Group { Id = 3, Name = "ПИ-22", SubGroups = new List<string> { "А", "Б" } };
            g3.Students.Add(MakeStudent(9, "Смирнов", "Андрей", "Олегович", "2004-01-15", "+7 908 901-23-45", "smirnov@example.com", "г. Москва, ул. Советская, д. 12", StudentStatus.Active, "А",
                new[] { (5, 5, 5), (5, 5, 5), (5, 5, 5) }));
            g3.Students.Add(MakeStudent(10, "Кузнецова", "Ольга", "Владимировна", "2004-04-22", "+7 909 012-34-56", "kuznetsova@example.com", "г. Москва, ул. Новая, д. 4", StudentStatus.Active, "Б",
                new[] { (4, 5, 5), (5, 4, 4), (5, 5, 5) }));
            g3.Students.Add(MakeStudent(11, "Попов", "Виктор", "Николаевич", "2004-09-08", "+7 910 123-45-67", "popov@example.com", "г. Москва, ул. Старая, д. 19", StudentStatus.Academic, "А",
                new[] { (3, 4, 4), (4, 3, 3), (4, 4, 4) }));
            g3.Students.Add(MakeStudent(12, "Фёдорова", "Наталья", "Сергеевна", "2004-07-30", "+7 911 234-56-78", "fedorova@example.com", "г. Москва, ул. Молодёжная, д. 6", StudentStatus.Debtor, "Б",
                new[] { (2, 2, 2), (3, 2, 2), (2, 3, 3) }));

            Groups.Add(g1);
            Groups.Add(g2);
            Groups.Add(g3);

            foreach (var group in Groups)
            {
                DatabaseService.SaveGroup(group);
                foreach (var student in group.Students)
                {
                    DatabaseService.SaveStudent(student, group.Id);
                }
            }
        }

        private static Student MakeStudent(int id, string last, string first, string mid, string birth, string phone, string email, string addr, StudentStatus status, string subGroup, (int s1, int s2, int fin)[] grades)
        {
            var subjectNames = new[] { "Математика", "Физика", "Программирование" };
            var s = new Student
            {
                Id = id,
                LastName = last,
                FirstName = first,
                MiddleName = mid,
                BirthDate = DateTime.Parse(birth),
                Phone = phone,
                Email = email,
                Address = addr,
                Status = status,
                SubGroup = subGroup
            };
            for (int i = 0; i < grades.Length; i++)
            {
                s.Subjects.Add(new Subject
                {
                    Id = i + 1,
                    Name = subjectNames[i],
                    Semester1Grade = grades[i].s1,
                    Semester2Grade = grades[i].s2,
                    FinalGrade = grades[i].fin
                });
            }
            return s;
        }
    }
}
