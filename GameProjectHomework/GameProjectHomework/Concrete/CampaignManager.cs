using GameProjectHomework.Abstract;
using GameProjectHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası başladı! Hemen bu fırsattan yararlan!");
            Console.WriteLine("Bitiş tarihi: " + campaign.CampaignEndDate);
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
