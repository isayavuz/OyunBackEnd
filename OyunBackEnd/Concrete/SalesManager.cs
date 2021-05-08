using OyunBackEnd.Abstract;
using OyunBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Concrete
{
    class SalesManager : ISalesService
    {
        public void Buy(Customer customer, Game game)
        {
            Console.WriteLine(game.NameOfTheGame+" oyunu "+customer.FirstName+" kişisine "+ game.Price +"TL fiyat karşılığında satıldı.");
        }

        public void BuyCampaign(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.NameOfTheGame + " oyunu " + customer.FirstName + " kişisine " + (game.Price-campaign.Discount) + "TL fiyat karşılığında satıldı.");
        }
    }
}
