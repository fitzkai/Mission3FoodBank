using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3FoodBank
{
    internal class FoodItem
    {       
        public string Name;
        public string Category;
        public int Quantity;
        public string ExpirationDate;

        public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }
    }
}
