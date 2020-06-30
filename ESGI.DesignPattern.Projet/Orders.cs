using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class Orders: IXmlFormattable
    {
        private readonly List<Order> _orders;

        public Orders()
        {
            this._orders = new List<Order>();
        }

        public void Add(Order order)
        {
            this._orders.Add(order);
        }

        public int OrderCount()
        {
            return this._orders.Count;
        }

        public Order Order(int insertionIndex)
        {
            return this._orders[insertionIndex];
        }

        public string Format()
        {
            StringBuilder xml = new StringBuilder();
            xml.Append("<orders>");
            for (int i = 0; i < OrderCount(); i++)
            {
                Order order = Order(i);
                xml.Append(order.Format());
            }

            xml.Append("</orders>");
            return xml.ToString();
        }
    }
}
