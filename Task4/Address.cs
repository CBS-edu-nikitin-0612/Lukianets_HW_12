using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Address
    {
        private string _country, _city, _street, _house;
        private int _index, _apartment;

        public int Index
        {
            get { return _index; }
            set
            {
                if (value > 0)
                    _index = value;
                else
                    Console.WriteLine("Wrong index");
            }
        }

        public string Country
        {
            get { return _country; }
            set
            {
                if (value != null)
                    _country = value;
                else
                    Console.WriteLine("Wrong country");
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (value != null)
                    _city = value;
                else
                    Console.WriteLine("Wrong city");
            }
        }

        public string Street
        {
            get { return _street; }
            set
            {
                if (value != null)
                    _street = value;
                else
                    Console.WriteLine("Wrong street");
            }
        }

        public string House
        {
            get { return _house; }
            set
            {
                if (value != null)
                    _house = value;
                else
                    Console.WriteLine("Wrong house");
            }
        }

        public int Apartment
        {
            get { return _apartment; }
            set
            {
                if (value > 0)
                    _apartment = value;
                else
                    Console.WriteLine("Wrong apartment");
            }
        }

        public Address(int index, string country, string city, string street, string house, int apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public override string ToString()
        {
            return $"{Country} {Index}, {City}, Str. {Street}, h. {House}, apt. {Apartment}.\n";
        }
    }
}
