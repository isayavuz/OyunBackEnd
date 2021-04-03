using OyunBackEnd.Abstract;
using OyunBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Concrete
{
    class CustomerManager : ICustomerService
    {
        ICustomerValidationService _customerCheckManager;

        public CustomerManager(ICustomerValidationService customerValidationService)
        {
            _customerCheckManager = customerValidationService;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckManager.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Müşteri Kaydedildi");
            }
            else
            {
                Console.WriteLine("Müşteri Kaydı Başarısız");
            }
            
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Müşterisi Silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Müşterisi Bilgileri Güncellendi");
        }
    }
}
