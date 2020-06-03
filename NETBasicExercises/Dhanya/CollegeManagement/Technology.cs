using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement
{
    class Technology
    {
        string technologyName;

        public string TechnologyName
        {
            get
            {
                return technologyName;
            }
            set
            {
                technologyName = value;
            }
        }

        public void PrintTechnology()
        {
            Console.WriteLine("Technology - {0}", TechnologyName);
        }
    }
}
