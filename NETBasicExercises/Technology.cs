using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Technology
    {
        private int technologyID;
        private string technologyName;

        public int TechnologyID
        {
            get
            {
                return technologyID;
            }
            private set
            {
                technologyID = value;
            }
        }

        public string TechnologyName
        {
            get
            {
                return technologyName;
            }
            private set
            {
                technologyName = value;
            }
        }

        public void print()
        {
            TechnologyID = 10;
            TechnologyName = "DotNet";

            Console.WriteLine("The ID of {0} is {1}", TechnologyName, TechnologyID);
            Console.ReadKey();
        }
    }
}
