using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
