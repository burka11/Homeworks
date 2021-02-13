using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);

    }
}
