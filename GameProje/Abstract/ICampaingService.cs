using GameProje.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Abstract
{
    interface ICampaingService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void UpDate(Campaign campaign);
    }
}
