using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BookshopDLL
{
    public class Company
    {        
        private static List<Role> ROLES = new List<Role>()
        {
            new Role("Administrator"),
            new Role("Employee"),
            new Role("Supervisor"),
            new Role("Customer")
        };

        public static Role GetRole(RoleEnum Role)
        {
            switch (Role)
            {
                case RoleEnum.ADMIN: return ROLES[0];
                case RoleEnum.EMPLOYEE: return ROLES[1];
                case RoleEnum.SUPERVISOR: return ROLES[2];             
                case RoleEnum.CUSTOMER: return ROLES[3];
                default: throw new Exception("...");
            }
        }

    }
}
