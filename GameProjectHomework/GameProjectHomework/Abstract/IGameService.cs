using GameProjectHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
