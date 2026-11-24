List<Employee> employees = new List<Employee>()
{
    new Employee()
    {
        Id=1,
        FirstName="Abdullo",
        LastName="Kholov",
        Age=16,
        Salary=6000,
        Experience=3
    },

    new Employee()
    {
        Id=2,
        FirstName="Muso",
        LastName="Safarov",
        Age=16,
        Salary=5000,
        Experience=2
    },

    new Employee()
    {
        Id=3,
        FirstName="Muhammad",
        LastName="Ismatov",
        Age=17,
        Salary=4000,
        Experience=2
    },

    new Employee()
    {
        Id=4,
        FirstName="Saad",
        LastName="Abdulozoda",
        Age=13,
        Salary=2000,
        Experience=1
    },
};

//method syntax
// var res = employees.Select(x=>x.Salary);
// foreach(var e in res)
// {
//     Console.WriteLine(e);
// }
//query syntax
// var ress = from x in employees
//             select x.Salary;
// foreach (var item in ress)
// {
//     Console.WriteLine(item);
// }

//2 method syntax
// var res = employees.Where(x=>x.FirstName.Length>6);
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName);
// }

//query syntax
// var ress = from x in employees
//             where x.FirstName.Length>6
//             select x;
// foreach (var item in ress)
// {
//     Console.WriteLine(item.FirstName);   
// }

// 3 method syntax
// var metho = employees.Where(x=>x.Age>employees[0].Age).Select(x=>x.FirstName);
// foreach (var item in metho)
// {
//     Console.WriteLine(item);
// }

// query syntax
// var method = from x in employees
//             where x.Age>employees[0].Age
//             select x.FirstName;
// foreach (var item in method)
// {
//     Console.WriteLine(item);
// }

//4 method syntax
// var res = employees.Where(x=>x.Experience>x.Age/2);
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName);
// }

//query syntax
// var res = from x in employees
//             where x.Experience>x.Age/2
//             select x;
// foreach(var x in res)
// {
//     Console.WriteLine(x);
// }

//5 method syntax
// var res = employees.Where(x=>x.Salary>5000).OrderBy(x=>x.Experience).Take(3);
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName);
// }

//query syntax
// var res = (from x in employees
//             where x.Salary>5000
//             orderby x.Experience
//             select x).Take(3);
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName);
// }

// ================== Hame Task ==========================
// List<Student> students = new List<Student>()
// {
//     new Student
//     {
//         Id = 1,
//         FirstName = "Abdullo",
//         LastName = "Kholov",
//         Age = 20,
//         Gender = Gender.Male,
//         Status = Status.Active,
//         DateOfStart = new DateTime(2023, 9, 1),
//         DateOfFinish = new DateTime(2026, 6, 1)
//     },
//     new Student
//     {
//         Id = 2,
//         FirstName = "Ali",
//         LastName = "Rahimov",
//         Age = 19,
//         Gender = Gender.Male,
//         Status = Status.InActive,
//         DateOfStart = new DateTime(2022, 9, 1),
//         DateOfFinish = new DateTime(2025, 6, 1)
//     },
//     new Student
//     {
//         Id = 3,
//         FirstName = "Madina",
//         LastName = "Safarova",
//         Age = 22,
//         Gender = Gender.Female,
//         Status = Status.Active,
//         DateOfStart = new DateTime(2021, 9, 1),
//         DateOfFinish = new DateTime(2024, 6, 1)
//     },
//     new Student
//     {
//         Id = 4,
//         FirstName = "Islom",
//         LastName = "Ismoilov",
//         Age = 17,
//         Gender = Gender.Male,
//         Status = Status.Active,
//         DateOfStart = new DateTime(2024, 9, 1),
//         DateOfFinish = new DateTime(2027, 6, 1)
//     },
//     new Student
//     {
//         Id = 5,
//         FirstName = "Aziza",
//         LastName = "Yusupova",
//         Age = 16,
//         Gender = Gender.Female,
//         Status = Status.InActive,
//         DateOfStart = new DateTime(2023, 9, 1),
//         DateOfFinish = new DateTime(2026, 6, 1)
//     }
// };

//1 method syntex
// var res = students.Where(x=>x.Gender==Gender.Male);
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName);
// }

//query syntex
// var res = from x in students
//             where x.Gender==Gender.Male
//             select x;
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName);
// }

//2 method syntex
// var res = students.Where(x=>x.Status==Status.InActive);
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName);
// }

//query syntex
// var res = from x in students
//             where x.Status==Status.InActive
//             select x.FirstName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//3 method syntex
// var res = students.Where(x=>DateTime.Now.Year-x.Age>2000);
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName);
// }

//query syntex
// var res = from x in students
//             where DateTime.Now.Year-x.Age>2000
//             select x.FirstName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//4 method syntex
// var res = students.Where(x=>x.Age>20 && x.Status==Status.Active).Select(x=>x.FirstName);
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//query syntex
// var res = from x in students
//             where x.Age>20 && x.Status==Status.Active
//             select x.FirstName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//5 method syntex
// var res = students.Where(x=>x.Age==16).Select(x=>x.FirstName);
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//query syntex
// var res = from x in students
//             where x.Age==16
//             select x.FirstName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }            

// 6 method syntex
// var res = students.Where(x=>x.Age>=18).Select(x=>x.FirstName);
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//query syntex
// var res = from x in students
//             where x.Age>=18
//             select x.FirstName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//7 method syntex
// var res = students.Where(x=>x.FirstName.StartsWith("A") || x.FirstName.StartsWith("I")).Select(x=>x.FirstName);
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//query syntex
// var res = from x in students
//             where x.FirstName.StartsWith("A") || x.FirstName.StartsWith("I")
//             select x.FirstName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//8 method syntex
// var res = students.Where(x=>x.FirstName[0]==x.LastName[0]);
// foreach (var item in res)
// {
//     Console.WriteLine(item.FirstName+" "+item.LastName);
// }

//query syntex
// var res = from x in students
//             where x.FirstName[0]==x.LastName[0]
//             select x.FirstName+" "+x.LastName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//9 method syntex
// var res = students.Where(x=>x.Age<18 && x.Status==Status.Active).Select(x=>x.FirstName); 
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//query syntex
// var res = from x in students
//             where x.Age<18 && x.Status==Status.Active
//             select x.FirstName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//10 method syntex
// var res = students.Where(x=>x.Gender!=Gender.Female && x.Status==Status.Active && x.DateOfStart.Year<DateTime.Now.Year-2 && x.Age<16).Select(x=>x.FirstName);
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

// query syntex
// var res = from x in students
//             where x.Gender!=Gender.Female && x.Status==Status.Active && x.DateOfStart.Year<DateTime.Now.Year-2 && x.Age<16
//             select x.FirstName;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }
//==================== Pract ========================
List<Person> people = new List<Person>
{
    new Person 
    { 
        Id = 1, 
        Name = "Ali", 
        Age = 20, 
        CityId = 1 
    },

    new Person 
    { 
        Id = 2, 
        Name = "Ahmad", 
        Age = 30, 
        CityId = 2 
    },
    new Person 
    { 
        Id = 3, 
        Name = "Said", 
        Age = 15, 
        CityId = 1 
    },
    new Person 
    {
        Id = 4, 
        Name = "Jahon", 
        Age = 27, 
        CityId = 3 
    },
    new Person 
    {
        Id = 5, 
        Name = "Amina",
        Age = 5, 
        CityId = 2 
    }
};

List<City> cities = new List<City>()
{
    new City 
    { 
        Id = 1, 
        CityName = "Dushanbe" 
    },
    new City 
    { 
        Id = 2, 
        CityName = "Astana" 
    },
    new City 
    { 
        Id = 3, 
        CityName = "London" 
    },
    new City 
    { 
        Id = 4, 
        CityName = "Ankara" 
    },
    new City 
    { 
        Id = 5, 
        CityName = "Paris" 
    }
};

//1 method syntex
// var res = people.Where(x=>x.Age>25).Select(x=>new
//                                     {
//                                         x.Name,
//                                         x.Age
//                                     });
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Age);
// }

// query syntex
// var res = from x in people
//             where x.Age>25
//             select x;
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Age);
// }

//2 method syntex
// var res = people.OrderBy(x=>x.Age).ThenBy(x=>x.Name);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Age);
// }

// query syntex
// var res = from x in people
//             orderby x.Age,x.Name
//             select x;
// foreach(var x in res)
// {
//     Console.WriteLine(x.Name+" "+x.Age);
// }

//3 method syntex
// var res = people.GroupBy(x=>x.Name[0]);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Key);
// }

// query syntex
// var res = from x in people
//             group x by x.Name[0];
// foreach (var item in res)
// {
//     Console.WriteLine(item.Key);
// }

//4 method syntex
// var res = people.Join(cities, p => p.CityId, c => c.Id, (p, c) => new
// {
//     p.Name,
//     CityName=c.CityName
// });

// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.CityName);
// }

//query syntex
// var res = from p in people
//             join c in cities on p.CityId equals c.Id
//             select new
//             {
//                 p.Name,
//                 CityName = c.CityName
//             };
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.CityName);
// }

//5 method syntex
// var res = people.Where(x=>x.Name[0]=='A' || x.Name[0]=='E'|| x.Name[0]=='I' || x.Name[0]=='O' || x.Name[0]=='U').Sum(x=>x.Age);
// Console.WriteLine(res);

//query syntex
// var res = (from x in people where x.Name[0]=='A' || x.Name[0]=='E'|| x.Name[0]=='I' || x.Name[0]=='O' || x.Name[0]=='U' select x).Sum(x=>x.Age);
// Console.WriteLine(res);

//6 method syntex
// var res = people.GroupBy(x=>x.Name[0]);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Key+" "+item.Count());
// }

//query syntex
// var res = from x in people
//             group x by x.Name[0];
// foreach (var item in res)
// {
//     Console.WriteLine(item.Key+" "+item.Count());
// }

//7 method synetx
// var res = people.GroupBy(x=>x.CityId).OrderByDescending(x=>x.Count()).First();
// var city = cities.First(x=>x.Id==res.Key);
// Console.WriteLine(city.CityName);

//query syntex
// var res = (from x in people
//             group x by x.CityId).OrderByDescending(x=>x.Count()).First();
// var city = cities.First(x=>x.Id==res.Key);
// Console.WriteLine(city.CityName);

//8 methor syntex
// var res = people.Join(cities,p=>p.CityId,c=>c.Id,(p,c)=> new {p,c}).Where(x=>x.p.Age>=2 && x.p.Age<=7 && x.c.CityName[0]=='A');
// foreach (var item in res)
// {
//     Console.WriteLine(item.p.Name);
// }

//query syntex
// var res = from p in people
//             join c in cities on p.CityId equals c.Id
//             where p.Age>=2 && p.Age<=7 && c.CityName[0]=='A'
//             select p;
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name);
// }

//================== HomeTask =======================
List<Students> student = new List<Students>
{
new Students { Id = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) },
new Students { Id = 2, Name = "Bob", DateOfBirth = new DateTime(1999, 8, 25) },
new Students { Id = 3, Name = "Charlie", DateOfBirth = new DateTime(2001, 3, 10) }
};

List<Course> courses = new List<Course>
{
new Course { Id = 101, Title = "Mathematics", Credits = 4 },
new Course { Id = 102, Title = "Computer Science", Credits = 3 },
new Course { Id = 103, Title = "Physics", Credits = 4 }
};

List<Enrollment> enrollments = new List<Enrollment>
{
new Enrollment { Id = 1, StudentId = 1, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 15) },
new Enrollment { Id = 2, StudentId = 1, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 20) },
new Enrollment { Id = 3, StudentId = 2, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 18) },
new Enrollment { Id = 4, StudentId = 3, CourseId = 103, EnrollmentDate = new DateTime(2023, 1, 22) },
new Enrollment { Id = 5, StudentId = 3, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 25) },
new Enrollment { Id = 6, StudentId = 3, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 30) }
};

//1 method syntex
// var res = student.Join(enrollments,s=>s.Id,e=>e.StudentId,(s,e)=>e).Join(courses,e=>e.CourseId,c=>c.Id,(e,c)=>c).Where(x=>x.Title=="Mathematics");
// foreach (var item in res)
// {
//     Console.WriteLine(item.Title);
// }

//query syntex
// var res = from s in student
//             join e in enrollments on s.Id equals e.StudentId
//             join c in courses on e.CourseId equals c.Id
//             where c.Title=="Mathematics"
//             select s;
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name);
// }

//2 method syntex
// var res = student.Join(enrollments,s=>s.Id,e=>e.StudentId,(s,e)=> new {s,e}).Join(courses,x=>x.e.CourseId,c=>c.Id,(x,c)=> new {x.s,c}).Where(x=>x.s.Name=="Charlie");
// foreach (var item in res)
// {
//     Console.WriteLine(item.c.Title);
// }

//query syntex
// var res = from s in student
//             join e in enrollments on s.Id equals e.StudentId
//             join c in courses on e.CourseId equals c.Id
//             where s.Name=="Charlie"
//             select c.Title;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//3 method syntex
// var res = enrollments.GroupBy(x=>x.StudentId).Where(x=>x.Count()>1).SelectMany(x=>student.Where(s=>s.Id==x.Key)).Select(x=>x.Name);
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//query syntex
// var res = (from e in enrollments
//             group e by e.StudentId).Where(x=>x.Count()>1).SelectMany(x=>student.Where(s=>s.Id==x.Key)).Select(x=>x.Name);
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// } 

//4 method syntex
// var res = student.Join(enrollments,s=>s.Id,e=>e.StudentId,(s,e)=> new{s,e})
// .Join(courses,x=>x.e.CourseId,c=>c.Id,(x,c)=>new {x.s,x.e,c})
// .GroupBy(x=>new {Age=(DateTime.Now.Year-x.s.DateOfBirth.Year)/10*10,x.c.Title})
// .Select(a => new
// {
//     a.Key.Age,
//     a.Key.Title,
//     Average = a.Average(x=>DateTime.Now.Year-x.s.DateOfBirth.Year)
// });
// foreach (var item in res)
// {
//     Console.WriteLine(item.Age+" | "+item.Title+" | "+item.Average);
// }

//query syntex
// var res = from s in student
//             join e in enrollments on s.Id equals e.StudentId
//             join c in courses on e.CourseId equals c.Id 
//             group s by new
//             {
//                 Age = (DateTime.Now.Year-s.DateOfBirth.Year)/10*10,courses=c.Title
//             }into x 
//             select new
//             {
//                 Age=x.Key.Age,
//                 courses = x.Key.courses,
//                 Avg = x.Average(x=>DateTime.Now.Year-x.DateOfBirth.Year)
//             };
// foreach (var item in res)
// {
//     Console.WriteLine($"{item.Age} | {item.courses} | Avg: {item.Avg}");
// }

//5 method syntex
// var res = student.Join(enrollments,s=>s.Id,e=>e.StudentId,(s,e)=> new {s,e})
// .Join(courses,x=>x.e.CourseId,c=>c.Id,(x,c)=> new {x.e,x.s,c})
// .Where(x=>x.e.EnrollmentDate>new DateTime(2023,1,20) && x.c.Credits>=4)
// .Select(x=> new
// {
//     x.s.Name,
//     x.c.Title,
//     x.e.EnrollmentDate,
//     x.c.Credits
// });
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" | "+item.Title+" | "+item.EnrollmentDate+" | "+item.Credits);
// }

//query syntex
// var res = from s in student
//             join e in enrollments on s.Id equals e.StudentId
//             join c in courses on e.CourseId equals c.Id
//             where e.EnrollmentDate>new DateTime(2023,1,20) && c.Credits>=4
//             select new
//             {
//                 s.Name,
//                 c.Title,
//                 e.EnrollmentDate,
//                 c.Credits
//             };
// foreach (var item in res)
// {
//     Console.WriteLine($"{item.Name} | {item.Title} | {item.EnrollmentDate} | {item.Credits}");
// }

//6 method syntex
// var res = student.Join(enrollments,s=>s.Id, e=>e.StudentId,(s,e)=>new {s,e})
//                   .Join(courses,x=>x.e.CourseId,c=>c.Id,(x,c)=> new {x.s,x.e,c})
//                   .GroupBy(x=>x.s.Name)
//                   .Select(x => new
//                   {
//                       Name=x.Key,
//                       Credits = x.Sum(x=>x.c.Credits)
//                   });
// foreach (var item in res)
// {
//     Console.WriteLine($"{item.Name} | {item.Credits}");
// }

//query syntex
// var res = from s in student
//             join e in enrollments on s.Id equals e.StudentId
//             join c in courses on e.CourseId equals c.Id
//             group c by s.Name into s
//             select new
//             {
//                 Name=s.Key,
//                 Credits = s.Sum(x=>x.Credits)
//             };
// foreach (var item in res)
// {
//     Console.WriteLine($"{item.Name} | {item.Credits}");
// }

//7 method syntex
// var res = student.Join(enrollments,s=>s.Id, e=>e.StudentId,(s,e)=> new {s,e})
//                   .Join(courses,x=>x.e.CourseId,c=>c.Id,(x,c) =>new {x.s,x.e,c})
//                   .GroupBy(x=>x.c.Title)
//                   .Select(x => new
//                   {
//                       course = x.Key,
//                       Count = x.Count()
//                   });
// foreach (var item in res)
// {
//     Console.WriteLine($"{item.course} | {item.Count}");
// }

//query syntex
// var res = from s in student
//             join e in enrollments on s.Id equals e.StudentId
//             join c in courses on e.CourseId equals c.Id
//             group s by c.Title into c
//             select new
//             {
//                 course = c.Key,
//                 Count = c.Count()
//             };
// foreach (var item in res)
// {
//     Console.WriteLine($"{item.course} | {item.Count}");
// }

//8 method syntex
// var res = courses.Where(c=>enrollments.Join(student,e=>e.StudentId,s=>s.Id,(e,s)=>new {e,s})
//                   .Any(x=>x.s.Name=="Bob" && x.e.CourseId==c.Id))
//                   .Select(c=>c.Title);
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//query syntex
var res = from c in courses 
                where (from e in enrollments join s in student on e.StudentId equals s.Id
                where )