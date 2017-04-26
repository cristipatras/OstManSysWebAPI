using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstManSysMVVM.Model
{
    public class Apartment
    {
        public int ApartmentID { get; set; }
        public string Address { get; set; }
        public int Size { get; set; }
        public int NumberOfRooms { get; set; }
        public int Rent { get; set; }
        public string Condition { get; set; }

        public Apartment() { }

        public Apartment(int aid, string add, int size, int nor, int rent, string c)
        {
            ApartmentID = aid;
            Address = add;
            Size = size;
            NumberOfRooms = nor;
            Rent = rent;
            Condition = c;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", ApartmentID, Address, Size, NumberOfRooms, Rent,
                Condition);
        }
    }
}
