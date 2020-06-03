using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement
{
    class Person
    {              
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Discriminator{ get; set; }
        public Guid PersonID { get; set; }

        public Person()
        {
           PersonID = Guid.NewGuid();
        }

        public void PrintPerson()
        {
            Console.WriteLine("{0} {1} is a {2} : {3}", FirstName, LastName, Discriminator, PersonID);
        }
    }
}
