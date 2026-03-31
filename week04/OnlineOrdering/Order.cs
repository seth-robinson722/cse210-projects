using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.CalculateTotalCost();
            }

            // Determine shipping cost
            double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;

            return total + shippingCost;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in _products)
            {
                label += $"- {product.GetNameAndId()}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetFullAddress()}";
        }
    }
}