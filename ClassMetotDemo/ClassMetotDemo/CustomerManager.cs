using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Adi+" "+customer.Soyadi+" isim soyisimli müsteri eklendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Adi+" "+customer.Soyadi+" isim- soyisimli musteri silindi");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Adi+" "+customer.Soyadi+" isim-soyisimli müşteri güncellendi");
        }

    }
}
