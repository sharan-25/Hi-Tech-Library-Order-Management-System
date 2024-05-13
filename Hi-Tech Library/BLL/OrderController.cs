using System;
using System.Collections.Generic;
using Hi_Tech_Library.BLL.EntityFramework;
using Hi_Tech_Library.DAL;
namespace Hi_Tech_Library.BLL
{
    public class OrderController
    {
        private readonly OrderRepository orderRepository;

        public OrderController()
        {
            orderRepository = new OrderRepository();
        }

        // Method to add an order
        public void AddOrder(Order order)
        {
            orderRepository.AddOrder(order);
        }

        // Method to update an order
        public void UpdateOrder(Order order)
        {
            orderRepository.UpdateOrder(order);
        }

        // Method to delete an order
        public void DeleteOrder(int orderId)
        {
            orderRepository.DeleteOrder(orderId);
        }

        // Method to search for an order by ID
        public Order SearchOrderById(int orderId)
        {
            return orderRepository.SearchOrderById(orderId);
        }

        // Method to search for orders by total amount
        public IEnumerable<Order> SearchOrdersByTotalAmount(decimal totalAmount)
        {
            return orderRepository.SearchOrdersByTotalAmount(totalAmount);
        }

        // Method to search for orders by customer ID
        public IEnumerable<Order> SearchOrdersByCustomerId(int customerId)
        {
            return orderRepository.SearchOrdersByCustomerId(customerId);
        }

        // Method to search for orders by order status
        public IEnumerable<Order> SearchOrdersByOrderStatus(string orderStatus)
        {
            return orderRepository.SearchOrdersByOrderStatus(orderStatus);
        }

        // Method to search for orders by order type
        public IEnumerable<Order> SearchOrdersByOrderType(string orderType)
        {
            return orderRepository.SearchOrdersByOrderType(orderType);
        }

        // Method to search for orders by order date
        public IEnumerable<Order> SearchOrdersByOrderDate(DateTime orderDate)
        {
            return orderRepository.SearchOrdersByOrderDate(orderDate);
        }

        // Method to search for orders by order quantity
        public IEnumerable<Order> SearchOrdersByOrderQuantity(int orderQuantity)
        {
            return orderRepository.SearchOrdersByOrderQuantity(orderQuantity);
        }
        //Get All Orders
        public IEnumerable<Order> GetAllorders() => orderRepository.GetAllOrders();
        // Method to get customer details by customer ID
        public IEnumerable<EntityFramework.Customer> GetCustomerById() => orderRepository.GetCustomerById();
    }
}
