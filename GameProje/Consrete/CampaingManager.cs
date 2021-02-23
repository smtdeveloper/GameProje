using GameProje.Abstract;
using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Consrete
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi :  " + campaign.CampaignName );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi : " + campaign.CampaignName);
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaign.CampaignName);
        }
    }
}
