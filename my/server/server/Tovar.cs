using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    [Serializable]
    public class Tovar
    {
        private String name;
        private String ingredients;
        private int sroki;
        private double price;
        private int quantity;
        private String recept;
        private int sum;
        public Tovar()
        {
            this.name = "";
            this.ingredients = "";
            this.sroki = 0;
            this.price = 0;
            this.quantity = 0;
            this.recept = "";
            this.sum = 0;
        }
        public Tovar(String name, String ingredients, int sroki, double price, int quantity, String recept, int sum)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.sroki = sroki;
            this.price = price;
            this.quantity = quantity;
            this.recept = recept;
            this.sum = sum;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getIngredients()
        {
            return ingredients;
        }
        public void setIngredients(String ingredients)
        {
            this.ingredients = ingredients;
        }
        public int getSroki()
        {
            return sroki;
        }
        public void setSroki(int sroki)
        {
            this.sroki = sroki;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public String getRecept()
        {
            return recept;
        }
        public void setRecept(string recept)
        {
            this.recept = recept;
        }

        public int getSum()
        {
            return sum;
        }
        public void setSum(int sum)
        {
            this.sum = sum;
        }
    }

}
