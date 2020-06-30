using System;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        [Fact]
        public void GetContents_produces_all_orders()
        {
            var orders = new Orders();
            var order = new Order(1234);
            order.Add(new Product(4321, "T-Shirt", new MediumSize(), new Price("21.00", "USD"), "red"));
            order.Add(new Product(6789, "Socks", new MediumSize(), new Price("8.00", "USD"), "red"));
            orders.Add(order);

            var ordersWriter = orders.Format();

            var expectedOrder =
                "<orders>" +
                    "<order id='1234'>" +
                        "<product id='4321' color='red' size='medium'>" +
                            "<price currency='USD'>" +
                            "21.00" +
                            "</price>" +
                        "T-Shirt" +
                        "</product>" +
                        "<product id='6789' color='red' size='medium'>" +
                            "<price currency='USD'>" +
                            "8.00" +
                            "</price>" +
                        "Socks" +
                        "</product>" +
                    "</order>" +
                "</orders>";
            Assert.Equal(expectedOrder, ordersWriter);
        }

        [Fact]
        public void GetContents_produces_no_orders()
        {
            var orders = new Orders();
            var ordersWriter = orders.Format();

            var expectedOrder =
            "<orders>" +
            "</orders>";

            Assert.Equal(expectedOrder, ordersWriter);
        }
    }
}

