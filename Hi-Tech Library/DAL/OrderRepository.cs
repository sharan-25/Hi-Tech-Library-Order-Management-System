using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL.EntityFramework;

namespace Hi_Tech_Library.DAL
{
    public class OrderRepository
    {
        private readonly HiTechOrderManagementDBEntities dBContext;

        public OrderRepository()
        {
            dBContext = new HiTechOrderManagementDBEntities();
        }

        // Get all orders
        public IEnumerable<Order> GetAllOrders() => dBContext.Orders.ToList();

        // Add an order
        public void AddOrder(Order order)
        {
            dBContext.Orders.Add(order);
            dBContext.SaveChanges();
        }

        // Update an order
        public void UpdateOrder(Order order)
        {
            var existingOrder = dBContext.Orders.Find(order.OrderId);
            if (existingOrder != null)
            {
                dBContext.Entry(existingOrder).CurrentValues.SetValues(order);
                dBContext.SaveChanges();
            }
        }

        // Delete an order
        public void DeleteOrder(int orderId)
        {
            var order = dBContext.Orders.Find(orderId);
            if (order != null)
            {
                dBContext.Orders.Remove(order);
                dBContext.SaveChanges();
            }
        }

        // Search order by ID
        public Order SearchOrderById(int orderId) => dBContext.Orders.Find(orderId);

        // Search orders by total amount
        public IEnumerable<Order> SearchOrdersByTotalAmount(decimal totalAmount) =>
            dBContext.Orders.Where(o => o.TotalAmount == totalAmount).ToList();

        // Search orders by customer ID
        public IEnumerable<Order> SearchOrdersByCustomerId(int customerId) =>
            dBContext.Orders.Where(o => o.CustomerId == customerId).ToList();

        // Search orders by order status
        public IEnumerable<Order> SearchOrdersByOrderStatus(string orderStatus) =>
            dBContext.Orders.Where(o => o.OrderStatus == orderStatus).ToList();

        // Search orders by order type
        public IEnumerable<Order> SearchOrdersByOrderType(string orderType) =>
            dBContext.Orders.Where(o => o.OrderType == orderType).ToList();

        // Search orders by order date
        public IEnumerable<Order> SearchOrdersByOrderDate(DateTime orderDate) =>
            dBContext.Orders.Where(o => o.OrderDate == orderDate).ToList();

        // Search orders by order quantity
        public IEnumerable<Order> SearchOrdersByOrderQuantity(int orderQuantity) =>
            dBContext.Orders.Where(o => o.OrderQuantity == orderQuantity).ToList();

        // Get customer by ID
        public IEnumerable<Customer> GetCustomerById()
        {
            return dBContext.Customers.ToList();
        }
    }
}

