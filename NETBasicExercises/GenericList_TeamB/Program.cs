using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> _people = new List<People>();
            List<Course> _course = new List<Course>();
            _people.Add(new People() {FirstName = "Debabrata",LastName ="Khanra",Discriminator="Student" });
            _people.Add(new People() { FirstName = "X", LastName = "Man", Discriminator = "Instructor" });
            _people.Add(new People() { FirstName = "Spider", LastName = "Man", Discriminator = "Student" });

            _course.Add(new Course() {Credit = 7.5 ,Technology=".Net"});
            _course.Add(new Course() { Credit = 1.5, Technology = ".Net" });
            _course.Add(new Course() { Credit = 8.5, Technology = "Java" });
            _course.Add(new Course() { Credit = 10, Technology = "Angular" });

            //Find out number of Student and Number of Instructor in the list using LINQ statement

            int totalStudentNumber = _people.Where(m => m.Discriminator.Equals("Student")).Count();
            int totalInstructorNumber = _people.Where(m => m.Discriminator == "Instructor").Count();

            //Find out the total credits per a given technology
            //Find out the list of Technologies

            var creditPerTechnology = _course.GroupBy(m => m.Technology).Select(cl => new Course
            {
                Credit = cl.Sum(m=>m.Credit),
                Technology = cl.FirstOrDefault().Technology
            });
            var technology = _course.Distinct().GroupBy(m => m.Technology).Select(cl => new Course
            {
                Technology = cl.FirstOrDefault().Technology

            });


            Console.ReadLine();
        }
    }

   public class People
    {
        static int nextId;
        private int _autoIncrementValue;
        public People()
        {
            _autoIncrementValue = Interlocked.Increment(ref nextId);
        }
        public int PersonId { get { return _autoIncrementValue; } }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Discriminator { get; set; }
    }

    class Course
    {
       
            static int nextId;
            private int _autoIncrementValue;
            public Course()
            {
                _autoIncrementValue = Interlocked.Increment(ref nextId);
            }
            public int CourseId { get { return _autoIncrementValue; } }

            private String Title { get; set; }
            public Double Credit { get; set; }
            public String Technology { get; set; }
        
    }
}
