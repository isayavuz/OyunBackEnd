using OyunBackEnd.Abstract;
using OyunBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampingName+" Kampanyası eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampingName + " Kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampingName + " Kampanyası güncellendi.");
        }
    }
}
