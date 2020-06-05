using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Kim";
            p.LastName = "Yoe";
            p.Discriminator = "Instructor";
            p.Print();

            Person p1 = new Person();
            p1.FirstName = "Tony";
            p1.LastName = "Roy";
            p1.Discriminator = "Student";
            p1.Print();

            course c = new course();
            c.print();
            Technology t = new Technology();
            t.print();

            List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "Bob", LastName = "Marley", Discriminator = "Instructor" });
            people.Add(new Person() { FirstName = "Kim", LastName = "Yoo", Discriminator = "Student" });
            people.Add(new Person() { FirstName = "charlette", LastName = "Angelo", Discriminator = "Student" });

            var InstructorCount = people.Where(a => a.Discriminator == "Instructor").Count();
            var StudentCount = people.Where(a => a.Discriminator == "Student").Count();

            Console.WriteLine("Instructor count {0}",InstructorCount);
            Console.WriteLine("Student count {0}",StudentCount);

            List<course> Courses = new List<course>();

            Courses.Add(new course() { Title = "Java", Credits = 3, Technology = "CoreJava" });
            Courses.Add(new course() { Title = "coreJ", Credits = 4, Technology = "CoreJava" });
            Courses.Add(new course() { Title = "Automation", Credits = 2, Technology = "Automation Anywhere" });

            List<string> technologies = new List<string>();



            //foreach (var item in Courses)
            //{
            //    if (technologies.Contains(item.Technology))
            //    {

            //    }
            //    else
            //    {
            //        technologies.Add(item.Technology);
            //    }
            //}
            //foreach (var item in technologies)
            //{
            //    Console.WriteLine(item);
            //}
       

            var Technologies = Courses.GroupBy(d => d.Technology);
            foreach (var item in Technologies)
            {
                Console.WriteLine(item.Key);
            }

            var CreditCount = Courses.GroupBy(d => d.Technology).Select(f => new
            {Credits = f.Sum(ta => ta.Credits), Technology = f.Key }).ToList();

            CreditCount.ForEach(row => Console.WriteLine($"Technology: {row.Technology}, Credits: {row.Credits}"));

            Console.ReadKey();
        }

    }
}
