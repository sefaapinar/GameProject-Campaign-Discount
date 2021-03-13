using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstrct
{
    public interface ICampaignService
    {
        void Add(CampaignGame campaign);
        void Delete(CampaignGame campaign);
        void Update(CampaignGame campaign);
    }
}
