namespace LINQ_lab
{
    internal class Program
    {
        #region 12.  FindStudentsSorted

        public static void FindStudentsSorted(string way ,  string order)
        {
            IEnumerable<Student> sortedsts;
            var students = Repository.GetStudents();
            var tracks = Repository.GetTracks();


            if (way.ToLower() =="name")
            {
                sortedsts =
                            order.ToLower() == "asc" ? students.OrderBy(s => s.FirstName) : students.OrderByDescending(s => s.FirstName);
            }
            else if(way.ToLower() == "age")
            {
                sortedsts = 
                    order.ToLower() == "asc" ? students.OrderBy(s=>s.Age) : students.OrderByDescending(s=>s.Age);
            }
            else if(way.ToLower() =="salary")
            {
                sortedsts=
                    order.ToLower() =="asc" ?  students.OrderBy(s=>s.Salary) : students.OrderByDescending(s=>s.Salary);
            }
            else
            {
                Console.WriteLine("Invalid way, default sorting by Name ASC.");
                sortedsts = students.OrderBy(s => s.FirstName);
            }

            foreach (var s in sortedsts)
            {
                Console.WriteLine($"Name: {s.FirstName} - Age: {s.Age} - Salary: {s.Salary}");
            }

        }

        #endregion

        static void Main(string[] args)
        {

            #region Respository
            var students = Repository.GetStudents();
            var tracks = Repository.GetTracks();
            #endregion


            #region 1.	Display all Student using LINQ Query Expression.
            //var q1 = from s in students
            //         select s;
            //Console.WriteLine("All Students:");
            //foreach (var student in q1)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName}");
            //}
            #endregion

            #region 2.	Display all Student using LINQ Method Syntax [fluent syntax].
            //var q2 = students.Select(s => s);
            //Console.WriteLine("All Students:");
            //foreach (var student in q2)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName}");
            //}
            #endregion

            #region 3.	Display all Students with Age > 30 using LINQ Query Expression.
            //var q3= from s in students
            //        where s.Age > 30
            //        select s;
            //Console.WriteLine("Students with Age > 30:");
            //foreach (var student in q3)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName} - Age: {student.Age}");
            //}
            #endregion

            #region 4.	Display all Students with Salary < 5000 using LINQ Method Syntax [fluent syntax].
            //var q4 = students.Where(s => s.Salary < 5000);
            //foreach(var item in q4)
            //{
            //    Console.WriteLine($"{item.FirstName} - {item.Salary}");
            //}


            #endregion

            #region 5.	Display all Students with TrackId =1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.
            //var q5 = from s in students
            //         where s.TrackId == 1 && s.Salary > 4000
            //         orderby s.FirstName descending
            //         select s;

            //foreach (var item in q5)
            //{
            //    Console.WriteLine($"Name : {item.FirstName} , Track : {item.TrackId} , Salary : {item.Salary} ");
            //}


            #endregion

            #region 6.	Display all Students with TrackId = 1 and first name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax [fluent syntax].
            //var q6 = students
            //        .Where(s => s.TrackId == 1 && s.FirstName.ToLower().Contains("m"))
            //        .OrderBy(s => s.Salary);


            //foreach ( var item in q6)
            //{
            //    Console.WriteLine($"First Name : {item.FirstName} - Track : {item.TrackId} - Salary : {item.Salary}");
            //}


            #endregion

            #region 7.	Find First Student with Salary more than 5000. 
            //var q7_1 = students.First(s => s.Salary > 5000);
            //Console.WriteLine($"Name : {q7_1.FirstName} - Salary : {q7_1.Salary}");

            //    //First : When not found throw exception


            //var q7_2 = students.FirstOrDefault(s => s.Salary > 5000);
            //if (q7_2 != null)
            //{
            //    Console.WriteLine($"Name : {q7_2.FirstName} - Salary : {q7_2.Salary}");
            //}
            //else
            //{
            //    Console.WriteLine("No student found");
            //}

            //   //FirstorDefault : When not found return default [null] not throw exception

            #endregion

            #region 8.	Find Last Student in Track number 10.
            //var q8_1 = students.Last(s=>s.TrackId==10);
            //Console.WriteLine($"Name : {q8_1.FirstName} - Track  : {q8_1.TrackId}");

            //   //Last : When not found throw exception [  Sequence contains no matching element ]


            //var q8_2 = students.LastOrDefault(s => s.TrackId == 10);
            //if (q8_2 != null)
            //{
            //    Console.WriteLine($"Name : {q8_2.FirstName} - Track : {q8_2.TrackId}");
            //}
            //else
            //{
            //    Console.WriteLine("No student found in this track");
            //}

            ////  LastOrDefault : When not found return default [null] not throw exception

            #endregion

            #region 9.	Find Student with Age equal 25.
            //var q9_1 = students.Single(s => s.Age == 25);
            //Console.WriteLine($"Name : {q9_1.FirstName} - Age : {q9_1.Age}");

            ///*
            //    Single:
            //    - لازم عنصر واحد فقط
            //    - 0 عناصر → Exception
            //    - أكثر من عنصر → Exception

            // */


            //var q9_2 = students.SingleOrDefault(s=>s.Age == 25);
            //if(q9_2 != null )
            //{
            //    Console.WriteLine($"Name : {q9_2.FirstName} - Age : {q9_2.Age}");
            //}
            //else
            //{
            //    Console.WriteLine("Student Not found");
            //}
            ///*
            //    SingleOrDefault:
            //    - 0 عناصر → null
            //    - 1 عنصر → يرجعه
            //    - أكثر من عنصر → Exception
            //*/

            #endregion

            #region 10.	Find Student with TrackId equal 8.
            ////var q10_1 = students.Single(s => s.TrackId == 8);
            ////Console.WriteLine($"Name : {q10_1.FirstName} - Track : {q10_1.TrackId}");

            ///*
            //    Single:
            //    - لازم عنصر واحد فقط
            //    - 0 عناصر → Exception
            //    - أكثر من عنصر → Exception

            // */

            //var q10_2 = students.SingleOrDefault(s => s.TrackId == 8);
            //if (q10_2 != null)
            //{
            //    Console.WriteLine($"Name : {q10_2.FirstName} - Track : {q10_2.TrackId}");
            //}
            //else
            //{
            //    Console.WriteLine("Student Not found");
            //}
            ///*
            //    SingleOrDefault:
            //    - 0 عناصر → null
            //    - 1 عنصر → يرجعه
            //    - أكثر من عنصر → Exception
            //*/

            #endregion

            #region 11.	Find Student in index 4.
            //var q11 = students.ElementAt(4);
            //Console.WriteLine($"Name : {q11.FirstName} - Age : {q11.Age} - Salary : {q11.Salary}");

            #endregion

            #region 12.	Ask the user for sorting method (by Name,  Age, etc….) and sorting way (ASC. Or DESC.)…. And implement a function named FindStudentsSorted() that displays all Students sorted as the user requested.
           
            //    Console.WriteLine("Enter sorting way (Name, Age, Salary):");
            //    string way = Console.ReadLine();
           
            //    Console.WriteLine("Enter sorting order (ASC/DESC):");
            //    string order = Console.ReadLine();

            //FindStudentsSorted(way, order);


            #endregion


        }
    }
}
