using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Abstract
{
    interface IOrderService
    {
        void Order(Game game, Gamer gamer);

        void CampaignOrder(Game game, Gamer gamer, Campaign campaign);
    }
}
