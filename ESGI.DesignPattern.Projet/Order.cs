using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class Order: IXmlFormattable
    {
        public int Id { get; }

        private readonly List<IXmlFormattable> _products;

        public Order(int id)
        {
            this._products = new List<IXmlFormattable>();
            this.Id = id;
        }

        public void Add(Product product)
        {
            this._products.Add(product);
        }

        public int ProductCount()
        {
            return this._products.Count;
        }

        public IXmlFormattable Product(int insertionIndex)
        {
            return this._products[insertionIndex];
        }
        
        public string Format()
        {
            return XmlConverter
                .Create(XmlConverter.FormattableType.Order)
                .Convert(this);
        }
    }
}
