using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Sale sale);
        void CampaignSale(Gamer gamer, Sale sale, Campaign campaign);
    }
}
