using LINQtoObject;

namespace LINQ_Lab_02___Part_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data
            var books = SampleData.Books;
            var authors = SampleData.Authors;
            var publishers = SampleData.Publishers;
            var subjects = SampleData.Subjects;
            #endregion

            #region 1-	Display book title and its ISBN
            //var q1 = books.
            //            Select(b=>new { b.Title , b.Isbn});

            //foreach (var b in books)
            //{
            //    Console.WriteLine($"Title: {b.Title}, ISBN: {b.Isbn}");
            //}
            #endregion


            #region 2-	Display the first 3 books with price more than 25.

            //var q2 = books.Where(b => b.Price > 25)
            //    .Take(3);

            //foreach (var book in q2)
            //{
            //    Console.WriteLine($"Title: {book.Title}, Price: {book.Price:C}");
            //}

            #endregion

            #region 3-	Display Book title along with its publisher name.
            //var q3 = books
            //     .Select(b => new { b.Title, PublisherName = b.Publisher.Name });

            //foreach (var book in q3)
            //{
            //    Console.WriteLine($"Title: {book.Title}, Publisher: {book.PublisherName}");
            //}
            #endregion

            #region 4-	Find the number of books which cost more than 20.
            //var q4 = books
            //            .Count(b => b.Price > 20);
            //Console.WriteLine($"Number of books with price > 20: {q4}");

            #endregion

            #region 5-	Display book title, price and subject name sorted by its subject name ascending and by its price descending.
            //var q5 = books
            //    .Select(b => new { b.Title, b.Price, SubjectName = b.Subject.Name })
            //    .OrderBy(b => b.SubjectName)
            //    .ThenByDescending(b => b.Price)
            //                    ;

            //foreach (var book in q5)
            //{
            //    Console.WriteLine($"Title: {book.Title}, Price: {book.Price:C}, Subject: {book.SubjectName}");
            //}
            #endregion

            #region 6-	Display all subjects with books related to this subject. (Using 2 methods).
            //var q6_1 = subjects
            //            .Select(s => new
            //            {
            //                SubjectName = s.Name,
            //                Books = books.Where(b => b.Subject.Name == s.Name)
            //                               .Select(b => b.Title).ToList()
            //            });
            //foreach (var item in q6_1)
            //{
            //    Console.WriteLine($"Subject: {item.SubjectName}");
            //    foreach (var title in item.Books)
            //    {
            //        Console.WriteLine($"  - {title}");
            //    }
            //}
            //Console.WriteLine("-------------------------------");

            //var q6_2 = from s in subjects
            //           select new { 
            //            SubjectName = s.Name , 
            //            Books = from b in books
            //                     where b.Subject.Name == s.Name
            //                     select b.Title

            //           };

            //foreach (var item in q6_2)
            //{
            //    Console.WriteLine($"Subject: {item.SubjectName}");
            //    foreach (var title in item.Books)
            //    {
            //        Console.WriteLine($"  - {title}");
            //    }
            //}
            #endregion

            #region 7-	Display books grouped by publisher & Subject.
            //var q7 = books
            //        .GroupBy(b => b.Publisher.Name)            
            //        .Select(pubGroup => new
            //        {
            //            Publisher = pubGroup.Key,
            //            Subjects = pubGroup
            //                .GroupBy(b => b.Subject.Name)      
            //                .Select(subGroup => new
            //                {
            //                    Subject = subGroup.Key,
            //                    Titles = subGroup.Select(b => b.Title).ToList()
            //                })
            //                .ToList()
            //        });

            //foreach (var pub in q7)
            //{
            //    Console.WriteLine($"Publisher: {pub.Publisher}");
            //    foreach (var sub in pub.Subjects)
            //    {
            //        Console.WriteLine($"  Subject: {sub.Subject}");
            //        foreach (var title in sub.Titles)
            //        {
            //            Console.WriteLine($"    - {title}");
            //        }
            //    }
            //}
            #endregion




        }
    }
}
