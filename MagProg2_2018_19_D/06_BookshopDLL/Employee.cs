using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BookshopDLL
{
    public class Employee : User
    {
        public Employee(uint Id, string Name, string Password, 
            string Email, Bookshop Bookshop) 
            : base(Id, Name, Password, Email, Company.GetRole(RoleEnum.EMPLOYEE))
        {
            this.Bookshop = Bookshop;          
        }

        public Bookshop Bookshop { get; set; }
    }
}
