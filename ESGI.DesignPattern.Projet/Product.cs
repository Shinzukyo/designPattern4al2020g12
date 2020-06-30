using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class Product: IXmlFormattable
    {
        public Product(int id, string name, IProductSize size, Price cost, string color)
        {
            Id = id;
            Name = name;
            Size = size;
            Cost = cost;
            Color = color;
        }

        public string Name { get; }
        public string Color { get; }
        public IProductSize Size { get; }
        public Price Cost { get; }
        public int Id { get; }
        public string Format()
        {
            return XmlConverter
                .Create(XmlConverter.FormattableType.Product)
                .Convert(this);
        }
    }

    public class Price
    {
        public Price(string currency, string amount)
        {
            Currency = currency;
            Amount = amount;
        }

        public string Amount { get; }
        public string Currency { get; }
    }
}
