using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemoTry.Abstract;
using InterfaceAbstractDemoTry.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemoTry.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = client.TCKimlikNoDogrulaAsync(customer.IdNumber, customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.BirthYear);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
