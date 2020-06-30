using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class Product: IXmlFormattable
    {
        public Product(int id, string name, ProductSize size, string price)
        {
            this.Id = id;
            this.Name = name;
            this.Size = size;
            this.Price = price;
        }

        public string Name { get; }
        public ProductSize Size { get; }
        public string Price { get; }
        public int Id { get; }
        public string Format()
        {
            StringBuilder xml = new StringBuilder();
            xml.Append("<product");
            xml.Append(" id='");
            xml.Append(Id);
            xml.Append("'");
            xml.Append(" color='");
            xml.Append(this.Color());
            xml.Append("'");
            if (Size != (int)ProductSize.NotApplicable)
            {
                xml.Append(" size='");
                xml.Append(this.SizeToString());
                xml.Append("'");
            }

            xml.Append(">");
            xml.Append("<price");
            xml.Append(" currency='");
            xml.Append(Currency());
            xml.Append("'>");
            xml.Append(Price);
            xml.Append("</price>");
            xml.Append(Name);
            xml.Append("</product>");

            return xml.ToString();
        }
        
        private string Currency()
        {
            return "USD";
        }

        private string SizeToString()
        {
            switch (Size)
            {
                case ProductSize.Medium:
                    return "medium";
                default:
                    return "NOT APPLICABLE";
            }
        }

        private string Color()
        {
            return "red";
        }
    }
}
