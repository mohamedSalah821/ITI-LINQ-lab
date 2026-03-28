namespace LINQ_lab
{
    public static class Repository
    {
        /*------------------------------------------------------------------*/
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student { Id = 1, FirstName = "Ali", LastName = "Ahmed", Age = 22, Salary = 5000, TrackId = 1 },
                new Student { Id = 2, FirstName = "Sara", LastName = "Mohamed", Age = 23, Salary = 6000, TrackId = 2 },
                new Student { Id = 3, FirstName = "Omar", LastName = "Hassan", Age = 21, Salary = 4000, TrackId = 1 },
                new Student { Id = 4, FirstName = "Mona", LastName = "Adel", Age = 24, Salary = 7000, TrackId = 3 },
                new Student { Id = 5, FirstName = "Youssef", LastName = "Khaled", Age = 22, Salary = 5500, TrackId = 4 },
                new Student { Id = 6, FirstName = "Nour", LastName = "Tarek", Age = 23, Salary = 6200, TrackId = 1 },
                new Student { Id = 7, FirstName = "Hassan", LastName = "Ali", Age = 25, Salary = 8000, TrackId = 2 },
                new Student { Id = 8, FirstName = "Salma", LastName = "Mostafa", Age = 21, Salary = 4500, TrackId = 3 },
                new Student { Id = 9, FirstName = "Karim", LastName = "Samy", Age = 22, Salary = 5300, TrackId = 4 },
                new Student { Id = 10, FirstName = "Laila", LastName = "Hesham", Age = 24, Salary = 7100, TrackId = 1 },
                new Student { Id = 11, FirstName = "Amr", LastName = "Fathy", Age = 33, Salary = 6000, TrackId = 2 },
                new Student { Id = 12, FirstName = "Dina", LastName = "Wael", Age = 22, Salary = 5200, TrackId = 3 },
                new Student { Id = 13, FirstName = "Mahmoud", LastName = "Nabil", Age = 26, Salary = 9000, TrackId = 4 },
                new Student { Id = 14, FirstName = "Huda", LastName = "Ibrahim", Age = 21, Salary = 4300, TrackId = 1 },
                new Student { Id = 15, FirstName = "Tamer", LastName = "Gamal", Age = 35, Salary = 9500, TrackId = 2 }

            };
        }

        /*------------------------------------------------------------------*/
        public static List<Track> GetTracks()
        {
            return new List<Track>()
            {
                new Track { TrackId = 1, TrackName = "C#" },
                new Track { TrackId = 2, TrackName = "Java" },
                new Track { TrackId = 3, TrackName = "Python" },
                new Track { TrackId = 4, TrackName = "JavaScript" }
            };

        }
    }
}
