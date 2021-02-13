using GameProjectHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
