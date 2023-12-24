using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemoTry.Abstract;
using InterfaceAbstractDemoTry.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemoTry.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
