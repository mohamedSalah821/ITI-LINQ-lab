namespace LINQ_Lab_02___Part_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1- Declare a List of numbers as shown :
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            //#region Query1: Display numbers without any repeated Data and sorted
            //var q1_1 = numbers.Distinct().OrderBy(n=>n);

            //Console.WriteLine("Query1 Output:");
            //foreach (var item in q1_1)
            //{
            //    Console.WriteLine(item);
            //}

            #region Query2: using Query1 result and show each number and it’s multiplication
            //var q1_2 = q1_1.Select(n => new { Number = n, Multiply = n * n });

            //Console.WriteLine("Query2 Output:");

            //foreach (var item in q1_2)
            //{
            //     Console.WriteLine($"{{ Number = {item.Number}, Multiply = {item.Multiply} }}");
            //}
            #endregion

            #endregion

            #region 2- declare an array of names as shown :
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            #region Query1: Select names with length equal 3.
            ////Query Expression
            //var qu = from n in names
            //         where n.Length == 3
            //         select n;
            //foreach ( var n in qu )
            //{
            //    Console.WriteLine( n );
            //}

            ////method Expression
            //var ex = names.Where(n=>n.Length == 3);
            //foreach ( var n in ex )
            //{
            //    Console.WriteLine( n );
            //}
            #endregion

            #region Query2: Select names that contains “a” letter (Capital or Small )then sort them by length
            ////Query Expression
            //var qu = from n in names
            //         where n.ToLower().Contains("a")
            //         orderby n.Length
            //         select n;

            //foreach (var n in qu)
            //{
            //    Console.WriteLine(n);
            //}

            ////method Expression

            //var ex = names.Where(n=> n.ToLower().Contains("a")) .OrderBy(n=>n.Length);
            //foreach (var n in ex)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Query3: Display the first 2 names
            ////Query Expression   [Mixed]
            //var qu = (from n in names
            //         select n).Take(2);

            //foreach(var n in qu)
            //{
            //    Console.WriteLine(n);
            //}


            ////method Expression
            //var ex = names.Take(2);
            //foreach ( var n in ex )
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            #endregion

            #region 3- Declare a class Subject that contains the following properties
            List<Student> students = new List<Student>()
                {
                    new Student() { ID = 1, FirstName = "Ali",  LastName = "Mohammed", Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 33, Name = "UML" } } },
                    new Student() { ID = 2, FirstName = "Mona", LastName = "Gala",    Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 34, Name = "XML" }, new Subject() { Code = 25, Name = "JS" } } },
                    new Student() { ID = 3, FirstName = "Yara", LastName = "Yousf",   Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 25, Name = "JS" } } },
                    new Student() { ID = 4, FirstName = "Ali",  LastName = "Ali",     Subjects = new Subject[] { new Subject() { Code = 33, Name = "UML" } } }
                };


            #region Query1: Display Full name and number of subjects for each student as follow
            //var q1 = students.
            //    Select(x => new { FullName = x.FirstName + " "+x.LastName, NumOfSubjects = x.Subjects.Count()});
            //foreach (var student in q1)
            //{
            //    Console.WriteLine($"{{Full Name: {student.FullName}, Number of Subjects: {student.NumOfSubjects}}}");
            //}
            #endregion

            #region Query2:
            //var q = students.OrderByDescending(n => n.FirstName)
            //                .ThenBy(n => n.LastName)
            //                .Select(s => new { s.FirstName, s.LastName });

            //foreach (var student in q)
            //{

            //    Console.WriteLine($"{student.FirstName} {student.LastName}");
            //}

            #endregion


            #region Query3:
            var q = students.SelectMany(
                    s => s.Subjects,
                    (student, subject) => new {
                        StudentName = $"{student.FirstName} {student.LastName}",
                        SubjectName = subject.Name
                    }
                );

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            #region  Then as follow (use GroupBy)
            var groupedByStudent = q.GroupBy(x => x.StudentName);

            foreach (var st in groupedByStudent)
            {
                Console.WriteLine(st.Key);

                foreach (var item in st)
                {
                    Console.WriteLine($"  {item.SubjectName}");
                }
            }

            #endregion
            #endregion


            #endregion






        }
    }
}
