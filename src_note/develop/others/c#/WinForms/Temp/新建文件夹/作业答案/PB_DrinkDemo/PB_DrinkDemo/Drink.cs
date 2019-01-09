using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_DrinkDemo
{
    public abstract class Drink
    {
        private string name;//名称

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string taste;//口味

        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }

        public Drink()
        {
        }
        public Drink(string name, string taste)
        {
            this.name = name;
            this.taste = taste;
        }
        //饮用的方法
        public abstract void Drinking();  
    }
}
