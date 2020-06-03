using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PrintObject

            Person P1 = new Person();
            P1.FirstName = "Thomas";
            P1.LastName = "Edition";
            P1.Discriminator = "Instructor";
            P1.PrintPerson();

            Technology T1 = new Technology();
            T1.TechnologyName = "Computer";
            T1.PrintTechnology();

            Course C1 = new Course();
            C1.Title = "Operating System";
            C1.Credits = 12.5M;
            C1.Technology = "Computer";
            C1.PrintCourse();

            #endregion

            #region Person

            Console.WriteLine("{0} **********Person List********** {1}", Environment.NewLine, Environment.NewLine);

            List<Person> People = new List<Person>();
            People.Add(new Person() { FirstName="Albert", LastName="Einstein", Discriminator="Instructor" });
            People.Add(new Person() { FirstName = "James", LastName = "Watson", Discriminator = "Student" });
            People.Add(new Person() { FirstName = "Marie", LastName = "Curie", Discriminator = "Instructor" });
            People.Add(new Person() { FirstName = "Thomas", LastName = "Edition", Discriminator = "Instructor" });
            People.Add(new Person() { FirstName = "George", LastName = "Washington", Discriminator = "Student" });
            People.ForEach(s => Print(s));
            Console.WriteLine("Total Number of Person are {0}", People.Count);

            List<Person> Students = People.Where(n => n.Discriminator.Equals("Student")).ToList();
            List<Person> Instructor = People.Where(n => n.Discriminator.Equals("Instructor")).ToList();

            Console.WriteLine("{0} **********Students List********** {1}", Environment.NewLine, Environment.NewLine);
            Students.ForEach(s => Print(s));
            Console.WriteLine("Total Number of students are {0}", Students.Count);

            Console.WriteLine("{0} **********Students List********** {1}", Environment.NewLine, Environment.NewLine);
            Instructor.ForEach(i => Print(i));
            Console.WriteLine("Total Number of students are {0}", Instructor.Count);
            
            #endregion

            #region Course

            Console.WriteLine("{0} **********Course Information********** {1}", Environment.NewLine, Environment.NewLine);

            List<Course> Courses = new List<Course>();
            Courses.Add(new Course() { Title = "Cloud Computing", Technology = "Computer", Credits = 5.5m });
            Courses.Add(new Course() { Title = "Artificial Intelligence", Technology = "Computer", Credits = 6.5m });
            Courses.Add(new Course() { Title = "Accounts", Technology = "BM", Credits = 7 });
            
            Courses.GroupBy(c => c.Technology)
                    .Select(s => new 
                    {
                        TechnologyName = s.Key, 
                        TotalCredit =s.Sum(a => a.Credits)
                    }).ToList()
                    .ForEach(t => { Console.WriteLine("{0} technology has {1} credits", t.TechnologyName, t.TotalCredit);});

            Console.WriteLine("{0} **********List of Technologies********** {1}", Environment.NewLine, Environment.NewLine);

            Courses.GroupBy(C => C.Technology)
                    .Select(s => new { TechnologyName = s.Key }).ToList()
                    .ForEach(t => { Console.WriteLine("{0}", t.TechnologyName); });

            #endregion
            
            Console.ReadLine();
        }

        public static void Print<T>(T PersonList) where T : Person
        {
            Console.WriteLine("{0} {1} is a {2} : {3}", PersonList.FirstName, PersonList.LastName, PersonList.Discriminator, PersonList.PersonID);
        }
    }
}
