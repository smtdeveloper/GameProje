using GameProje.Consrete;
using GameProje.Entity;
using System;

namespace GameProje
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                DateOfBirth  = new DateTime(1999, 06,07),
                FirstName = " SAMET ",
                LastName = "  AKCA ",
                UserName = " SMTcoder ",
                NationalityId = 444444
            };
           
            Gamer gamer2 = new Gamer
            {
                Id = 2,
                DateOfBirth = new DateTime(1997, 09, 16),
                FirstName = " NAZLI ",
                LastName = " CEKİÇ ",
                UserName = " Sakar ",
                NationalityId = 55555555
            };



            gamerManager.Add(gamer1);

            Console.WriteLine("----------------------------");

            CampaingManager campaingManager = new CampaingManager();
            Campaign campaign = new Campaign { Id =1 , CampaignName = "  %60 İNDİRİMLİ ", DiscountRate = 0.60M   };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "  %80 İNDİRİMLİ ", DiscountRate = 0.80M };
            campaingManager.Add(campaign);

            Console.WriteLine("----------------------------");

            GameManager gameManager = new GameManager();
            Game game1 = new Game { Id = 1, GameName = "Red Dead 2 ", GamePrice = 200 };
            Game game2 = new Game { Id = 2, GameName = "GTA 5  ", GamePrice = 140 };

            gameManager.Add(game2);
            gameManager.Update(game1);

            Console.WriteLine("----------------------------");

            OrderManager orderManager = new OrderManager();
          
            orderManager.CampaignOrder(game1, gamer1, campaign);
            orderManager.Order(game2, gamer2);








        }
    }
}
