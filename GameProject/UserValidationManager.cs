using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1997 && gamer.FirstName =="TOLGA" 
                && gamer.LastName=="DUMAN" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                  return false;
            }
        }
    }
}
