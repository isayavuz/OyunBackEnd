using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampingName { get; set; }
        public decimal Discount { get; set; }
        public DateTime CampaignStartDate { get; set; }
        public DateTime ExpiryTime { get; set; }
    }
}
