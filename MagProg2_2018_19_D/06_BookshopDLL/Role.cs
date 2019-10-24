using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BookshopDLL
{
    public class Role
    {
        private static byte ID = 1;

        public Role(string Name)
        {
            this.Id = Role.ID; ID++;
            this.Name = Name;
        }

        public byte Id { get; private set; }
        public string Name { get; private set; }
    }
}
