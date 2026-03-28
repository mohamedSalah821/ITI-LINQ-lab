using System.Linq;

namespace LINQ_Lab_02___Part_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Respository
            var employees = Repository.GetEmployees();
            var departments = Repository.GetDepartments();
            #endregion


            #region 1.	First 4 Employees in the List Using Method Syntax [fluent syntax].
            //var q1 = employees.Take(4);

            //foreach ( var emp in q1 )
            //{
            //    Console.WriteLine( emp );
            //}
            #endregion

            #region 2.	First 3 Employees in the List with Salary more than 5000 Using Method Syntax [fluent syntax].
            //var q2 = employees.Where(e => e.Salary > 5000)
            //                    .Take(3);
            //foreach (var emp in q2)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 3.	Last 4 Employees in the List Using Method Syntax [fluent syntax].
            //var q3 = employees.TakeLast(4);
            //foreach (var emp in q3)
            //{
            //    Console.WriteLine(emp);
            //}

            #endregion

            #region 4.	Second 2 Employees in the List Using Method Syntax [fluent syntax].
            //var q4 = employees .Skip(2)
            //                   .Take(2);           

            //foreach (var emp in q4)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 5.	All Employees While Name length < 5 Using Method Syntax [fluent syntax].
            ////var q5 = employees
            ////     .Where(e => e.Name.Length < 5);

            //var q5 = employees.TakeWhile(e => e.Name.Length < 5);

            //foreach( var employee in q5 )
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region 6.	Distinct Employees. Hint: (Using IEqualityComparer) Using Method Syntax [fluent syntax].
            //var q6 = employees.Distinct(new EmpComparer());

            ///*
            // or : 
            //    var q6_2 = employees.DistinctBy(e=>e.Id);
            // */

            //foreach (var emp in q6)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region 7.	Name and Id of All Employees Using Method Syntax [fluent syntax].
            //var q7 = employees.Select(e => new {e.Name  , e.Id});
            //foreach (var emp in q7)
            //{
            //    Console.WriteLine($"Id: {emp.Id} - Name: {emp.Name}");
            //}
            #endregion

            #region 8.	Name and Id of All Employees Using Query Syntax.
            //var q8 = from emp in employees
            //         select new { emp.Name , emp.Id };

            //foreach (var emp in q8)
            //{
            //    Console.WriteLine($"Id: {emp.Id} - Name: {emp.Name}");
            //}
            #endregion

            #region 9.	Name and DeptName of All Employees Using Query Syntax.
            //var q9 = from emp in employees 
            //        join  dept in departments
            //        on emp.DeptId equals dept.DeptId
            //        select new { emp.Name , dept.DeptName};

            //foreach ( var item in q9 )
            //{
            //    Console.WriteLine($"Name : {item.Name} - DeptName : {item.DeptName}");
            //}

            #endregion

            #region 10.	 Name and DeptName of All Employees Using Method Syntax [fluent syntax].
            //var q10 = employees.Join(
            //           departments,
            //           e=>e.DeptId ,
            //           d=>d.DeptId,
            //           (e,d)=> new {Name = e.Name , DeptName = d.DeptName}
            //    );

            //foreach ( var item in q10 )
            //{
            //    Console.WriteLine($"Name : {item.Name} - DeptName : {item.DeptName}");
            //}
            #endregion

            #region 11.	 All Employees Group by DeptName Using Method Syntax [fluent syntax].
            //var q11 = employees.Join(
            //           departments,
            //           e => e.DeptId,
            //           d => d.DeptId,
            //           (e, d) => new { Name = e, DeptName = d.DeptName }
            //    ).GroupBy(e=>e.DeptName);

            //foreach (var item in q11)
            //{
            //    Console.WriteLine("Department: " + item.Key);
            //    foreach (var emp in item)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}
            #endregion

            #region 12.	 All Employees Group by DeptName Using Query Syntax.
            //var q12 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          group e by d.DeptName;

            //foreach (var item in q12)
            //{
            //    Console.WriteLine("Department: " + item.Key);
            //    foreach (var emp in item)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}


            #endregion

            #region 13.	 Min Salary, Max Salary, Avg Salary.
            //var q13_1 = employees.Min(e => e.Salary);
            //var q13_2 = employees.Max(e => e.Salary);
            //var q13_3 = employees.Average(e => e.Salary);

            //Console.WriteLine(q13_1);
            //Console.WriteLine(q13_2);
            //Console.WriteLine(q13_3);

            #endregion

            #region 14.	 Employee Where Salary < Avg Salary.
            //var avgSalary = employees.Average(e => e.Salary);

            //var q14 = employees.Where(e=>e.Salary <avgSalary);

            //foreach (var emp in q14)
            //{
            //    Console.WriteLine($"Name: {emp.Name} - Salary: {emp.Salary}");
            //}
            #endregion

            #region 15.	 Create two lists of int and try Expect, Concat, Union, Intersect.
            //List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            //List<int> list2 = new List<int> { 4, 5, 6, 7, 8 };

            //var q15_1 = list1.Except(list2);
            //var q15_2 = list1.Concat(list2);
            //var q15_3 = list1.Union(list2);
            //var q15_4 = list1.Intersect(list2);

            //foreach(var item in q15_1)
            //{
            //    Console.WriteLine($" Except : {item}");

            //}
            //Console.WriteLine("------------------------------");
            //foreach (var item in q15_2)
            //{
            //    Console.WriteLine($" Concat : {item}");

            //}
            //Console.WriteLine("------------------------------");
            //foreach (var item in q15_3)
            //{
            //    Console.WriteLine($" Union  : {item}");

            //}
            //Console.WriteLine("------------------------------");
            //foreach (var item in q15_4)
            //{
            //    Console.WriteLine($" Intersect : {item}");

            //}

            #endregion

            #region 16.	 Create list of Phone Number and Names and try Zip Operator.
            //List<string> names = new List<string> { "Ali", "Sara", "Mona", "Ahmed" };
            //List<string> phoneNumbers = new List<string> { "01011111111", "01022222222", "01033333333", "01044444444" };

            //var q16 = names.Zip(phoneNumbers);
            //foreach(var item in q16)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
