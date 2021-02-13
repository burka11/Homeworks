﻿using GameProjectHomework.Abstract;
using GameProjectHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu çıktı! FİYATI: " + game.GamePrice + "TL");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu satıştan kalktı.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu indirimde, İNDİRİMLİ FİYAT: " + game.GamePrice);
        }
    }
}
