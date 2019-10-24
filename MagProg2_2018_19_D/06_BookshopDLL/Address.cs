using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06_BookshopDLL
{
    public class Address
    {
        private static uint ID = 1;
        public Address(string Postcode, string Town, string Street)
        {
            this.Id = ID; 
            this.Postcode = Postcode;
            this.Town = Town;
            this.Street = Street;
            ID++;
        }

        public uint Id { get; set; }

        private string postcode;
        public string Postcode
        {
            set
            {
                string regex = @"[1-9][0-9]{3}";
                if (Regex.Match(value, regex).Success)
                    postcode = value;
                else throw new Exception("Invalid postcode");
            }
            get
            {
                return postcode;
            }
        }
        public string Town { get; set; }
        public string Street { get; set; }
    }
}
