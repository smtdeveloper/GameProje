using GameProje.Abstract;
using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Consrete
{
    class OrderManager : IOrderService
    {
        public void CampaignOrder(Game game, Gamer gamer, Campaign campaign)
        {
            decimal indirimOranı = game.GamePrice - (game.GamePrice * campaign.DiscountRate);

            Console.WriteLine(" Sayın " + gamer.FirstName + " " + gamer.LastName + " " + campaign.CampaignName + " " + game.GameName +  " : Oyununu  " + 
               indirimOranı + " TL' ye Satın Aldınız" );

        }

        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Satın Aldı : " + game.GameName +  "  " + game.GamePrice + " TL "   );
        }
    }
}
