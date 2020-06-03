using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class course
    {
        private string title;
        private int credits;
        private string technology;
        private int courseID;

        public int CourseID
        {
            get
            {
                return courseID;
            }
            set
            {
                courseID = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }
            set
            {
                credits = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Technology
        {
            get
            {
                return technology;
            }
            set
            {
                technology = value;
            }
        }

        public void print()
        {
            Title = "Asp.net";
            Technology = "Dotnet";
            Credits = 4;
            CourseID = 100;

            Console.WriteLine("{0} has {1} credits", Technology, Credits);
            Console.ReadKey();
        }
    }
}
