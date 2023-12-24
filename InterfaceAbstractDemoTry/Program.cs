using InterfaceAbstractDemoTry.Abstract;
using InterfaceAbstractDemoTry.Adapters;
using InterfaceAbstractDemoTry.Concrete;
using InterfaceAbstractDemoTry.Entities;

namespace InterfaceAbstractDemoTry
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer(){FirstName = "BERK", LastName = "KARANFİLOĞLU",BirthYear = 1995, IdNumber = 19384118218});




        }
    }
}
