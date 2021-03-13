using GameProject.Abstrct;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Conret
{
    public class CampaignManager : ICampaignService
    {
        public void Add(CampaignGame campaign)
        {
            Console.WriteLine("Add Campaign Completed.");
        }

        public void Delete(CampaignGame campaign)
        {
            Console.WriteLine("Deleted Campaign Completed.");
        }

        public void Update(CampaignGame campaign)
        {
            Console.WriteLine("Updated Campaign Completed.");
        }
    }
}
