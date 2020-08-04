using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Работа_с_XML_документами
{
    /// <summary>
	/// Класс, инкапсулирующий информацию о товаре.
	/// </summary>
   public class Good
    {
        string name;
        float price;

        public Good(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
        }

        public float Price
        {
            get { return price; }
        }
    }
}

