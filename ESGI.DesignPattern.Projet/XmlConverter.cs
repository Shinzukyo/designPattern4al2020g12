using System;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public interface IXmlConverter
    {
        string Convert(IXmlFormattable xmlFormattable);
    }

    public class XmlProduct : IXmlConverter
    {
        public string Convert(IXmlFormattable xmlFormattable)
        {
            if (!(xmlFormattable is Product)) throw new Exception();
            var product = (Product) xmlFormattable;
            StringBuilder xml = new StringBuilder();
            xml.Append("<product");
            xml.Append(" id='");
            xml.Append(product.Id);
            xml.Append("'");
            xml.Append(" color='");
            xml.Append(product.Color);
            xml.Append("'");
            if (!(product.Size is NotApplicableSize))
            {
                xml.Append(" size='");
                xml.Append(product.Size.Name);
                xml.Append("'");
            }

            xml.Append(">");
            xml.Append("<price");
            xml.Append(" currency='");
            xml.Append(product.Cost.Amount);
            xml.Append("'>");
            xml.Append(product.Cost.Currency);
            xml.Append("</price>");
            xml.Append(product.Name);
            xml.Append("</product>");

            return xml.ToString();
        }
    }

    public class XmlOrder : IXmlConverter
    {
        public string Convert(IXmlFormattable xmlFormattable)
        {
            if (!(xmlFormattable is Order)) throw new Exception();
            var order = (Order) xmlFormattable;
            StringBuilder xml = new StringBuilder();
            xml.Append("<order");
            xml.Append(" id='");
            xml.Append(order.Id);
            xml.Append("'>");
            for (int j = 0; j < order.ProductCount(); j++)
            {
                IXmlFormattable product = order.Product(j);
                xml.Append(product.Format());
            }

            xml.Append("</order>");

            return xml.ToString();
        }
    }

    public class XmlOrders : IXmlConverter
    {
        public string Convert(IXmlFormattable xmlFormattable)
        {
            if (!(xmlFormattable is Orders)) throw new Exception();
            var orders = (Orders) xmlFormattable;
            StringBuilder xml = new StringBuilder();
            xml.Append("<orders>");
            for (int i = 0; i < orders.OrderCount(); i++)
            {
                Order order = orders.Order(i);
                xml.Append(order.Format());
            }

            xml.Append("</orders>");
            return xml.ToString();
        }
    }
    
    public class XmlConverter
    {
        public enum FormattableType
        {
            Product,
            Order,
            Orders
        }

        public static IXmlConverter Create(FormattableType format)
        {
            switch (format)
            {
                case FormattableType.Product: return new XmlProduct();
                case FormattableType.Order: return new XmlOrder();
                case FormattableType.Orders: return new XmlOrders();
                default: throw new Exception("...");
            }
        }
    }
}