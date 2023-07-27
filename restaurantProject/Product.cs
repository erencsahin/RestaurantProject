using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantProject
{
    public class Product
    {
        public string ProductName { get; set; }
        public DateTime UretimTarihi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public float CalorieGram { get; set; }
        public float Stock { get; set; }
        public float Price { get; set; }

    }
}
