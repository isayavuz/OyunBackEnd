using OyunBackEnd.Abstract;
using OyunBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Concrete
{
    public class CustomerValidationManager:ICustomerValidationService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.DateOfBirth.Year <= 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
