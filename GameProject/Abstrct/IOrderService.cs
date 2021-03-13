using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstrct
{
    public interface IOrderService
    {
       
            void OrderCustomer(User user, CampaignGame campaignGame);
        
    }
}
