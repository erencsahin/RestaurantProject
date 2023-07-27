using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantProject
{
    public class Order
    {
        public List<Food> Meals { get; set; }

        public Order()
        {
            Meals = new List<Food>();
        }

        public void YemekEkle(Food yemek)
        {
            Meals.Add(yemek);
        }

        public void YemekSil(Food yemek)
        {
            Meals.Remove(yemek);
        }

        public void SiparisYazdir()
        {
            Console.WriteLine("Siparişler:");
            foreach (var yemek in Meals)
            {
                Console.WriteLine("Yemek Adı: " + yemek.Name);
                Console.WriteLine("Cinsi: " + yemek.Type);
                Console.WriteLine("Fiyatı: " + yemek.Price);
                Console.WriteLine("KDV Oranı: " + yemek.TaxPercent);
                Console.WriteLine("-------------------------");
            }
        }

    }
}
