using GameProje.Abstract;
using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Consrete
{
    class GamerManager : IGamerService
    {
        IGamerCheckManager _gamerCheckManager;

        public GamerManager(IGamerCheckManager gamerCheckService)
        {
            _gamerCheckManager = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true )
            {
                Console.WriteLine(" BAŞARILI ");
                Console.WriteLine(gamer.UserName + "   : Oyuncusu Eklendi 43 ");
            }
            else
            {
                Console.WriteLine(" Bi daha bu  mekana Gelme :) sahtekar seni ... ");
            }            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + "   : Oyuncusu Silindi ");
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
                Console.WriteLine(" BAŞARILI");
                Console.WriteLine(gamer.UserName + "   : Oyuncusu Güncellendi  ");
            }
            else
            {
                Console.WriteLine(" Güncelleme Basarısız  ");
            }
        }
    }
}
