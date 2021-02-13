using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.TcNo == "4532532" && gamer.FirstName == "Burak" && gamer.LastName == "YILDIZ" && gamer.BirthDate == "2000")
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
