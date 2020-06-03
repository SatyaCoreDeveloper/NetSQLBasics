using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement
{
    class Course
    {
        string title;
        decimal credits;
        string technology;

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
        public decimal Credits
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

        public void PrintCourse()
        {
            Console.WriteLine("{0} course is in {1} technology with {2} credits", Title, Technology, Credits);
        }
    }
}
