using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Person : IComparable<Person>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Address Address { get; init; }

        public Person(string firstName, string lastName, Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }

        public override string ToString()
        {
            return $"{FirstName}|{LastName}|{Address}";
        }

        public int CompareTo(Person? other)
        {
            return String.Compare(this.LastName, other.LastName);
        }
    }
}
