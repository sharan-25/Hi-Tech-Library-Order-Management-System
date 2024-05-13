using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL.EntityFramework;

namespace Hi_Tech_Library.DAL
{
    public class BookOrdersRepository
    {
        private readonly HiTechOrderManagementDBEntities dBContext;
        private readonly BookRepository bookRepository;
        private readonly OrderRepository orderRepository;

        public BookOrdersRepository()
        {
            dBContext = new HiTechOrderManagementDBEntities();
            bookRepository = new BookRepository();
            orderRepository = new OrderRepository();
        }

        // Method to get book data by ISBN
        
        public IEnumerable<Book> GetBookByISBN() => dBContext.Books.ToList();

        // Method to get order data by OrderId
        public IEnumerable<Order> GetOrderByOrderId() => dBContext.Orders.ToList();
        // Method to add a book order
        public void AddBookOrder(BookOrder bookOrder)
        {
            dBContext.BookOrders.Add(bookOrder);
            dBContext.SaveChanges();
        }

        // Method to update a book order
        public void UpdateBookOrder(BookOrder bookOrder)
        {
            var existingBookOrder = dBContext.BookOrders.Find(bookOrder.BookOrderId);
            if (existingBookOrder != null)
            {
                dBContext.Entry(existingBookOrder).CurrentValues.SetValues(bookOrder);
                dBContext.SaveChanges();
            }
        }

        // Method to delete a book order
        public void DeleteBookOrder(int bookOrderId)
        {
            var bookOrder = dBContext.BookOrders.Find(bookOrderId);
            if (bookOrder != null)
            {
                dBContext.BookOrders.Remove(bookOrder);
                dBContext.SaveChanges();
            }
        }

        // Method to search for a book order by book author ID
        public BookOrder SearchBookOrderByBookOrderId(int bookAuthorId)
        {
            return dBContext.BookOrders.FirstOrDefault(b => b.BookOrderId == bookAuthorId);
        }

        // Method to search for book orders by ISBN
        public IEnumerable<BookOrder> SearchBookOrdersByISBN(string isbn)
        {
            return dBContext.BookOrders.Where(b => b.ISBN == isbn).ToList();
        }

        // Method to search for book orders by order ID
        public IEnumerable<BookOrder> SearchBookOrdersByOrderId(int orderId)
        {
            return dBContext.BookOrders.Where(b => b.OrderId == orderId).ToList();
        }

        // Method to get all book orders
        public IEnumerable<BookOrder> GetAllBookOrders()
        {
            return dBContext.BookOrders.ToList();
        }
    }
}
