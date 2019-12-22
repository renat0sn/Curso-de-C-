using System;
using System.Globalization;
using ConsoleApp4.Entities;
using ConsoleApp4.Entities.Enums;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            client.Name = Console.ReadLine();
            Console.Write("Email: ");
            client.Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());

            Order order = new Order();
            order.Client = client;

            Console.WriteLine("\nEnter order data:");

            Console.Write("Status: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                OrderItem item = new OrderItem();
                Product product = new Product();

                Console.WriteLine("\nEnter #" + i + " item data:");

                Console.Write("Product name: ");
                product.Name = Console.ReadLine();

                Console.Write("Product price: ");
                product.Price = item.Price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                item.Quantity = int.Parse(Console.ReadLine());

                item.Product = product;

                order.Items.Add(item);
            }
            order.Moment = DateTime.Now;

            //------------------------------------------//

            Console.WriteLine("ORDER SUMMARY:");

            Console.WriteLine("Order moment: " + order.Moment);

            Console.WriteLine("Order status: " + order.Status);

            Console.WriteLine("Client: " + client.Name + "(" + client.BirthDate + ") - " + client.Email);

            Console.WriteLine("Order items:");

            double total = 0;
            foreach (OrderItem o in order.Items)
            {
                Console.WriteLine(o.Product.Name 
                    + ", $" 
                    + o.Price.ToString("F2", CultureInfo.InvariantCulture) 
                    + ", Quantity: " 
                    + o.Quantity
                    + ", Subtotal: $"
                    + o.subTotal().ToString("F2", CultureInfo.InvariantCulture));
                total += o.subTotal();
            }

            Console.WriteLine("Total price: $" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
