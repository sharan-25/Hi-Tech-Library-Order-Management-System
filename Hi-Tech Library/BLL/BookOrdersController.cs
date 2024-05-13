using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL.EntityFramework;
using Hi_Tech_Library.DAL;

namespace Hi_Tech_Library.BLL
{
    public class BookOrdersController
    {
        private readonly BookOrdersRepository bookOrderRepository;

        public BookOrdersController()
        {
            bookOrderRepository = new BookOrdersRepository();
        }

        // Method to add an bookorder
        public void AddBookOrder(BookOrder order)
        {
            bookOrderRepository.AddBookOrder(order);
        }

        // Method to update an Bookorder
        public void UpdateBookOrder(BookOrder order)
        {
            bookOrderRepository.UpdateBookOrder(order);
        }

        // Method to delete an Bookorder
        public void DeleteBookOrder(int orderId)
        {
            bookOrderRepository.DeleteBookOrder(orderId);
        }

        // Method to search for an Bookorder by ID
        public BookOrder SearchOrderById(int bookorderId)
        {
            return bookOrderRepository.SearchBookOrderByBookOrderId(bookorderId);
        }

        // Method to search for Bookorders by ISBN
        public IEnumerable<BookOrder> SearchOrdersByISBN(string isbn)
        {
            return bookOrderRepository.SearchBookOrdersByISBN(isbn);
        }

        // Method to search for Bookorders by order id
        public IEnumerable<BookOrder> SearchOrdersByOrderId(int orderId)
        {
            return bookOrderRepository.SearchBookOrdersByOrderId(orderId);
        }
        // Method to get Book details by ISBN
        
        public IEnumerable<Book> GetBookByISBN() => bookOrderRepository.GetBookByISBN();

        // Method to get Order details by order id
        public IEnumerable<Order> GetOrderByorderId() => bookOrderRepository.GetOrderByOrderId();

        //Get All BookOrders
        public IEnumerable<BookOrder> GetAllBookOrders() => bookOrderRepository.GetAllBookOrders();

    }
}
