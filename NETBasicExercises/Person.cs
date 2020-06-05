using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Person
    {
        private string firstName;
        private String lastname;
        private string discriminator;
        private int personID;
        public int num;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Discriminator
        {
            get
            {
                return discriminator;
            }
            set
            {
                discriminator = value;
            }
        }

        public int PersonID
        {
            get
            {
                return personID;
            }
            set
            {
                personID = value;
            }
        }


        public void Print()
        {
            var integer = new Random().Next();
            PersonID = Convert.ToInt32(integer);
            Console.WriteLine("Hello {0}!", FirstName);
            Console.WriteLine("{0} {1} is a {2} with ID {3}", FirstName, LastName, Discriminator, PersonID);
            Console.ReadKey();
        }
    }
}
