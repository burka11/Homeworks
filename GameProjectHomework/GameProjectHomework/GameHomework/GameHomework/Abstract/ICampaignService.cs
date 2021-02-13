using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void UpDate(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
