using OyunBackEnd.Abstract;
using OyunBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Concrete
{
    class SalesManager : ISalesService
    {
        public void Buy(Customer customer, Game game, float Price)
        {
            Console.WriteLine(game.NameOfTheGame+" oyunu "+customer.FirstName+" kişisine "+ Price +"TL fiyat karşılığında satıldı.");
        }
    }
}
