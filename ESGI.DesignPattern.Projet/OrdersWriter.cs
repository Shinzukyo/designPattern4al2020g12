using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class OrdersWriter
    {
        private Orders orders;

        public OrdersWriter(Orders orders)
        {
            this.orders = orders;
        }

        public string GetContents()
        {
            StringBuilder xml = new StringBuilder();
            xml.Append("<orders>");
            for (int i = 0; i < this.orders.OrderCount(); i++)
            {
                Order order = this.orders.Order(i);
                xml.Append(order.Format());
            }

            xml.Append("</orders>");
            return xml.ToString();
        }
    }
}
