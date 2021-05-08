using OyunBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Abstract
{
    public interface ISalesService
    {
        void Buy(Customer customer, Game game);
        void BuyCampaign(Customer customer, Game game, Campaign campaign);
    }
}
