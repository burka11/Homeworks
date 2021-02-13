using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Adi = "Engin";
            customer1.Soyadi = "Varan";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);

            Customer customer2 = new Customer();
            customer2.Adi = "Barış";
            customer2.Soyadi = "Yılmaz";
            
            customerManager.Delete(customer2);

            Customer customer3 = new Customer();
            customer3.Adi = "Taner";
            customer3.Soyadi = "Ilgaz";

            customerManager.Update(customer3);
        }
    }
}
