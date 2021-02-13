using GameProjectHomework.Abstract;
using GameProjectHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.TcNo == "43254235" && gamer.FirstName == "Burak" && gamer.LastName == "YILDIZ" && gamer.BirthDate == "2000")
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
