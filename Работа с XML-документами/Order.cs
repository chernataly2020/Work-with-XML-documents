using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Работа_с_XML_документами
{
    /// <summary>
	/// Класс, инкапсулирующий информацию о заказе.
	/// </summary>
    class Order
    {
        string address;
        DateTime date;
        ArrayList goods;	// массив товаров

        public Order(string address, DateTime date)
        {
            this.address = address;
            this.date = date;
            goods = new ArrayList();
        }

        public string Address
        {
            get { return address; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public ArrayList Goods
        {
            get { return goods; }
        }

        public void AddGood(string name, float price)
        {
            goods.Add(new Good(name, price));
        }
    }
}
