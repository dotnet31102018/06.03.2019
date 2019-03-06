using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603Dict
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }


        public Customer(int id, string name, int birthYear, string address)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
        }

        public override string ToString()
        {
            return $"Customer Id: {Id} Name: {Name} BirthYear: {BirthYear} " +
                $"Address: {Address} ";
        }
    }
}
