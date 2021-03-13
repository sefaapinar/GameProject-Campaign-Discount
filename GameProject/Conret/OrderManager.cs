using GameProject.Abstrct;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Conret
{
    public class OrderManager : IOrderService
    {
        public void OrderCustomer(User user, CampaignGame campaignGame)
        {
            Console.WriteLine(user.FirstName+"İsimli Müşteri"
                +campaignGame.CampaignName+"Kampanyasından Faydalanarak"
                + campaignGame.CampaignGameName+"Ürünü Satın Almıştır.");
        }
    }
}
