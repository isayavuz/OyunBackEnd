using OyunBackEnd.Concrete;
using OyunBackEnd.Entities;
using System;

namespace OyunBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "isa",
                LastName = "yavuz",
                DateOfBirth = new DateTime(1995, 1, 1),
                NationalityId = "123456789"
            };

            Game game1 = new Game
            {
                Id=1,
                NameOfTheGame="ETS2",
                Category="simulator",
                Price=200,
                ReleaseDate= new DateTime(2012, 1, 1)
            };

            Game game2 = new Game
            {
                Id = 2,
                NameOfTheGame = "word of tanks",
                Category = "warfare",
                Price = 450,
                ReleaseDate = new DateTime(2015, 1, 1)
            };
            Campaign campaign1 = new Campaign
            {
                Id=1,
                CampingName="İlkbahar indirimleri",
                Discount=14,
                CampaignStartDate= new DateTime(2021, 3, 20),
                ExpiryTime= new DateTime(2021, 6, 21)

            };

            CustomerManager managerDal = new CustomerManager(new CustomerValidationManager());
            SalesManager salesManager1 = new SalesManager();
            CampaignManager campaignManager1 = new CampaignManager();
            
            managerDal.Add(customer1);
            managerDal.Delete(customer1);
            campaignManager1.Add(campaign1);

            salesManager1.Buy(customer1, game2);
            salesManager1.BuyCampaign(customer1, game1, campaign1);
            Console.ReadLine();
        }
    }
}
