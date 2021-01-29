using System;

namespace OOP2
{
    class Program
    {
        //inheritance = miras
        //SOLID
        static void Main(string[] args)
        {
            CorporateCustomer customer1 = new CorporateCustomer();
            customer1.Id = 1001;
            customer1.customerNumber = "1";
            customer1.companyName = "Tolan Films";
            customer1.taxNumber = "12345";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 1002;
            customer2.customerNumber = "2";
            customer2.name = "Cihad";
            customer2.surName = "Acar";
            customer2.nationalId = "11111111111";

            Customer customer3 = new CorporateCustomer();
            Customer customer4 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
