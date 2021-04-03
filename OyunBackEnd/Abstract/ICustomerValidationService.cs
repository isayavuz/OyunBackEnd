using OyunBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Abstract
{
    interface ICustomerValidationService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
