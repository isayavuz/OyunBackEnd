using OyunBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
