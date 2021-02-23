using GameProje.Abstract;
using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Consrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName   + "  : Oyunu Eklendi. " );
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "  : Oyunu Silidi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "  :Oyunu Güncellendi. ");
        }
    }
}
