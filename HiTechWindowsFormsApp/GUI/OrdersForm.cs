using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Library.BLL;
using Hi_Tech_Library.BLL.EntityFramework;
using HiTechLibrary.VALIDATION;

namespace HiTechWindowsFormsApp.GUI
{
    public partial class OrdersForm : Form
    {
        
        private readonly OrderController orderController;
        private readonly BookOrdersController bookOrdersController;
        public OrdersForm()
        {
            orderController = new OrderController();
            bookOrdersController = new BookOrdersController();
            InitializeComponent();

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadBooks();

            LoadCustomers();
        }

        //Tabl Control -- orderDetails

        //Clear TextBoxes
        public void clearControlsOrder()
        {
            textBoxOrderId.Clear();
            textBoxOrderQuantity.Clear();
            textBoxOrderTotalAmount.Clear();
            comboBoxOrderCustomerID.SelectedIndex = -1;
            comboBoxOrderStatus.SelectedIndex = -1;
            comboBoxOrderType.SelectedIndex = -1;
            dateTimePickerOrderDate.Value = DateTime.Now;
        }

        // Fetching the data of customerId from the repository to show in combobox
        private void LoadCustomers()
        {
            comboBoxOrderCustomerID.Items.Clear();

            try
            {
                var customers = orderController.GetCustomerById();
                foreach (var customer in customers)
                {
                    comboBoxOrderCustomerID.Items.Add(customer.CustomerId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button Save
        private void button_Save_Click(object sender, EventArgs e)
        {

            if (Validator.IsInputEmpty(textBoxOrderTotalAmount.Text) || Validator.IsInputEmpty(textBoxOrderQuantity.Text) || Validator.IsInputEmpty(comboBoxOrderCustomerID.Text) || Validator.IsInputEmpty(comboBoxOrderStatus.Text) || Validator.IsInputEmpty(comboBoxOrderType.Text))
            {
                MessageBox.Show("Input field must be filled!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
          

            // Parsing the input to a double value
            double totalamount;
            if (!double.TryParse(textBoxOrderTotalAmount.Text, out totalamount))
            {
                MessageBox.Show("Total Amount must be a valid number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxOrderTotalAmount.Clear();
                return; // Exit the method if parsing fails
            }

            if (!Validator.IsValidInteger(textBoxOrderQuantity.Text, out int orderQuantty))
            {
                MessageBox.Show("Order Quantity value must be valid integers!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxOrderQuantity.Clear();
                return;
            }


            //Create a new Book

            Order order = new Order()
            {

                OrderDate = dateTimePickerOrderDate.Value,
                TotalAmount = Convert.ToDecimal(textBoxOrderTotalAmount.Text.Trim()),
                OrderQuantity = Convert.ToInt32(textBoxOrderQuantity.Text.Trim()),
                OrderStatus = comboBoxOrderStatus.Text,
                OrderType = comboBoxOrderType.Text,
                CustomerId = Convert.ToInt32(comboBoxOrderCustomerID.Text.Trim())



            };
            orderController.AddOrder(order);

            MessageBox.Show("Order Id will be created automatcally!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("New Order added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearControlsOrder();


        }

        //Update Button
        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the entered Order ID is not empty
                if (Validator.IsInputEmpty(textBoxOrderId.Text.Trim()))
                {
                    MessageBox.Show("Order ID cannot be empty!");
                    return;
                }

                // Parsing the input to a int value
                int orderId;
                if (!int.TryParse(textBoxOrderId.Text, out orderId))
                {
                    MessageBox.Show("OrderId must be a valid number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxOrderId.Clear();
                    return; 
                }


                int orderIdToUpdate = Convert.ToInt32(textBoxOrderId.Text.Trim());

                // Search for the order with the entered ID
                Order orderToUpdate = orderController.SearchOrderById(orderIdToUpdate);

                // Check if the order exists
                if (orderToUpdate != null)
                {
                    // Update order properties
                    orderToUpdate.OrderDate = dateTimePickerOrderDate.Value;
                    orderToUpdate.TotalAmount = Convert.ToDecimal(textBoxOrderTotalAmount.Text.Trim());
                    orderToUpdate.OrderQuantity = Convert.ToInt32(textBoxOrderQuantity.Text.Trim());
                    orderToUpdate.OrderStatus = comboBoxOrderStatus.Text;
                    orderToUpdate.OrderType = comboBoxOrderType.Text;
                    orderToUpdate.CustomerId = Convert.ToInt32(comboBoxOrderCustomerID.Text.Trim());

                    // Save changes to the database
                    orderController.UpdateOrder(orderToUpdate);
                    MessageBox.Show("Order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearControlsOrder();
                }
                else
                {
                    MessageBox.Show("Order not found!", "Invalid Order ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxOrderId.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete button
        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the entered Order ID is not empty
                if (Validator.IsInputEmpty(textBoxOrderId.Text.Trim()))
                {
                    MessageBox.Show("Order ID cannot be empty!");
                    return;
                }
                // Parsing the input to a int value
                int orderId;
                if (!int.TryParse(textBoxOrderId.Text, out orderId))
                {
                    MessageBox.Show("OrderId must be a valid number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxOrderId.Clear();
                    return;
                }

                int orderIdToDelete = Convert.ToInt32(textBoxOrderId.Text.Trim());

                // Ask for confirmation before deleting the order
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Check if order exists in DB
                    Order orderToDelete = orderController.SearchOrderById(orderIdToDelete);

                    if (orderToDelete != null)
                    {
                        orderController.DeleteOrder(orderIdToDelete);
                        MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearControlsOrder();
                    }
                    else
                    {
                        MessageBox.Show("Order not found!", "Invalid Order ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxOrderId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Delete operation canceled.");
                    textBoxOrderId.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //list All button
        private void button_ListAll_Click(object sender, EventArgs e)
        {
            // Fetch all orders from the database
            IEnumerable<Order> orders = orderController.GetAllorders();

            // Clear existing rows and columns in the DataGridView
            dataGridViewOrders.Columns.Clear();

            // Add columns to the DataGridView
            dataGridViewOrders.Columns.Add("OrderID", "Order ID");
            dataGridViewOrders.Columns.Add("OrderDate", "Order Date");
            dataGridViewOrders.Columns.Add("TotalAmount", "Total Amount");
            dataGridViewOrders.Columns.Add("OrderQuantity", "Order Quantity");
            dataGridViewOrders.Columns.Add("OrderStatus", "Order Status");
            dataGridViewOrders.Columns.Add("OrderType", "Order Type");
            dataGridViewOrders.Columns.Add("CustomerId", "Customer ID");

            DisplayOrdersList(orders);
        }

        // Method to display orders in the DataGridView
        private void DisplayOrdersList(IEnumerable<Order> orders)
        {
            dataGridViewOrders.Rows.Clear();
            // Populate the DataGridView with data
            foreach (var order in orders)
            {
                dataGridViewOrders.Rows.Add(
                    order.OrderId,
                    order.OrderDate,
                    order.TotalAmount,
                    order.OrderQuantity,
                    order.OrderStatus,
                    order.OrderType,
                    order.CustomerId
                );
            }
        }

        // Method to display a single order's details
        private void DisplayOrder(Order order)
        {
            clearControlsOrder();
            textBoxOrderId.Text = order.OrderId.ToString();
            dateTimePickerOrderDate.Value = order.OrderDate;
            textBoxOrderTotalAmount.Text = order.TotalAmount.ToString();
            textBoxOrderQuantity.Text = order.OrderQuantity.ToString();
            comboBoxOrderStatus.Text = order.OrderStatus;
            comboBoxOrderType.Text = order.OrderType;
            comboBoxOrderCustomerID.Text = order.CustomerId.ToString();
        }

        //search Button
        private void button_Search_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an option to search.", "Invalid search option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxSearchOrders.SelectedIndex)
            {
                case 0:
                    // Search by Order ID
                    if (Validator.IsInputEmpty(textBoxOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Order ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(textBoxOrderSearch.Text.Trim(), out int orderId))
                    {
                        MessageBox.Show("Invalid input for Order ID. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxOrderSearch.Clear();
                        return;
                    }

                    Order orderById = orderController.SearchOrderById(orderId);
                    if (orderById == null)
                    {
                        MessageBox.Show("Order not found! Invalid Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxOrderSearch.Clear();
                        return;
                    }
                    DisplayOrder(orderById);
                    break;

                case 1:
                    // Search by Order Date
                    if (!DateTime.TryParse(textBoxOrderSearch.Text.Trim(), out DateTime orderDate))
                    {
                        MessageBox.Show("Invalid input for Order Date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxOrderSearch.Clear();
                        return;
                    }

                    IEnumerable<Order> ordersByOrderDate = orderController.SearchOrdersByOrderDate(orderDate);
                    if (ordersByOrderDate == null || !ordersByOrderDate.Any())
                    {
                        MessageBox.Show("No orders found for the specified Order Date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxOrderSearch.Clear();
                        return;
                    }
                    DisplayOrdersList(ordersByOrderDate);
                    break;

                    break;

                case 2:
                    // Search by Total Amount
                    if (Validator.IsInputEmpty(textBoxOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Total Amount cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(textBoxOrderSearch.Text.Trim(), out decimal totalAmount))
                    {
                        MessageBox.Show("Invalid input for Total Amount. Please enter a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxOrderSearch.Clear();
                        return;
                    }

                    IEnumerable<Order> ordersByTotalAmount = orderController.SearchOrdersByTotalAmount(totalAmount);
                    if (ordersByTotalAmount == null || !ordersByTotalAmount.Any())
                    {
                        MessageBox.Show("No orders found for the specified Total Amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxOrderSearch.Clear();
                        return;
                    }
                    DisplayOrdersList(ordersByTotalAmount);
                    break;

                case 3:
                    // Search by Order Status
                    if (Validator.IsInputEmpty(textBoxOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Order Status cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string orderStatus = textBoxOrderSearch.Text.Trim();

                    IEnumerable<Order> ordersByOrderStatus = orderController.SearchOrdersByOrderStatus(orderStatus);
                    if (ordersByOrderStatus == null || !ordersByOrderStatus.Any())
                    {
                        MessageBox.Show("No orders found for the specified Order Status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxOrderSearch.Clear();
                        return;
                    }
                    DisplayOrdersList(ordersByOrderStatus);
                    break;
                    

                case 4:
                    // Search by Order Type
                    if (Validator.IsInputEmpty(textBoxOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Order Type cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string orderType = textBoxOrderSearch.Text.Trim();

                    IEnumerable<Order> ordersByOrderType = orderController.SearchOrdersByOrderType(orderType);
                    if (ordersByOrderType == null || !ordersByOrderType.Any())
                    {
                        MessageBox.Show("No orders found for the specified Order Type.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxOrderSearch.Clear();
                        return;
                    }
                    DisplayOrdersList(ordersByOrderType);
                    break;

                    break;

                case 5:
                    // Search by Customer ID
                    if (Validator.IsInputEmpty(textBoxOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Customer ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(textBoxOrderSearch.Text.Trim(), out int customerId))
                    {
                        MessageBox.Show("Invalid input for Customer ID. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxOrderSearch.Clear();
                        return;
                    }

                    IEnumerable<Order> ordersByCustomerId = orderController.SearchOrdersByCustomerId(customerId);
                    if (ordersByCustomerId == null)
                    {
                        MessageBox.Show("No orders found for the specified Customer ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxOrderSearch.Clear();
                        return;
                    }
                    DisplayOrdersList(ordersByCustomerId);
                    break;
                case 6:
                    // Search by Order Quantity
                    if (Validator.IsInputEmpty(textBoxOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Order Quantity cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(textBoxOrderSearch.Text.Trim(), out int orderQuantity))
                    {
                        MessageBox.Show("Invalid input for Order Quantity. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxOrderSearch.Clear();
                        return;
                    }

                    IEnumerable<Order> ordersByOrderQuantity = orderController.SearchOrdersByOrderQuantity(orderQuantity);
                    if (ordersByOrderQuantity == null || !ordersByOrderQuantity.Any())
                    {
                        MessageBox.Show("No orders found for the specified Order Quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxOrderSearch.Clear();
                        return;
                    }
                    DisplayOrdersList(ordersByOrderQuantity);
                    break;
            }

           

        }
        //Change label text according to selectd option
        private void comboBoxSearchOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearchOrders.SelectedIndex)
            {
                case 0:
                    labelOrderSearch.Text = "Enter Order ID:";
                    break;

                case 1:
                    labelOrderSearch.Text = "Enter Order Date (YYYY-MM-DD):";
                    break;

                case 2:
                    labelOrderSearch.Text = "Enter Total Amount:";
                    break;

                case 3:
                    labelOrderSearch.Text = "Enter Order Status:";
                    break;

                case 4:
                    labelOrderSearch.Text = "Enter Order Type:";
                    break;

                case 5:
                    labelOrderSearch.Text = "Enter Customer ID:";
                    break;

                case 6:
                    labelOrderSearch.Text = "Enter Order Quantity:";
                    break;

                default:
                    labelOrderSearch.Text = "Enter Search Keyword:";
                    break;
            }
        }





        // Tab Control  --2 

        //Clear TextBoxes
        public void clearControlsBookOrder()
        {
            textBoxBookOrderId.Clear();
            comboBoxBookOrderISBN.SelectedIndex = -1;
            comboBoxBookOrdersOrderId.SelectedIndex = -1;
        }

        // Fetching the data of orderId from the repository to show in combobox
        private void LoadOrders()
        {
            comboBoxBookOrdersOrderId.Items.Clear();

            try
            {
                var orders = bookOrdersController.GetOrderByorderId();
                foreach (var order in orders)
                {
                    comboBoxBookOrdersOrderId.Items.Add(order.OrderId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fetching the data of ISBN from the repository to show in combobox
        private void LoadBooks()
        {
            comboBoxBookOrderISBN.Items.Clear();

            try
            {
                var books = bookOrdersController.GetBookByISBN();
                foreach (var book in books)
                {
                    comboBoxBookOrderISBN.Items.Add(book.ISBN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Check if any input fields are empty
            if (Validator.IsInputEmpty(comboBoxBookOrderISBN.Text) || Validator.IsInputEmpty(comboBoxBookOrdersOrderId.Text))
            {
                MessageBox.Show("All input fields must be filled!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validate Book ISBN
            if (!Validator.IsValidISBN(comboBoxBookOrderISBN.Text))
            {
                MessageBox.Show("Invalid Book Order ID!", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxBookOrderId.Clear();
                return;
            }

            // Parse the input to a valid format
            if (!int.TryParse(comboBoxBookOrdersOrderId.Text, out int orderId))
            {
                MessageBox.Show("Order ID must be a valid integer!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxOrderId.Clear();
                return;
            }

            // Create a new Book Order instance
            BookOrder bookOrder = new BookOrder()
            {
               
                ISBN = comboBoxBookOrderISBN.Text.Trim(),
                OrderId = Convert.ToInt32(comboBoxBookOrdersOrderId.Text.Trim())
            };

            // Add the Book Order to the database
            bookOrdersController.AddBookOrder(bookOrder);
            MessageBox.Show("BookOrder Id will be created automatcally!","Done",MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("New Book Order added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

             clearControlsBookOrder();
        }

        //update button
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Check if any input fields are empty
            if (Validator.IsInputEmpty(textBoxBookOrderId.Text) || Validator.IsInputEmpty(comboBoxBookOrderISBN.Text) || Validator.IsInputEmpty(comboBoxBookOrdersOrderId.Text))
            {
                MessageBox.Show("All input fields must be filled!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validate Book Order ID
            if (!Validator.IsValid(textBoxBookOrderId.Text ,5))
            {
                MessageBox.Show("Book Order ID must be 5-digit number!", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxBookOrderId.Clear();
                return;
            }

            // Parse the input to a valid format
            if (!int.TryParse(comboBoxBookOrdersOrderId.Text, out int orderId))
            {
                MessageBox.Show("Order ID must be a valid integer!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxBookOrdersOrderId.SelectedIndex = -1;
                return;
            }

            // Create a new Book Order instance
            BookOrder bookOrder = new BookOrder()
            {
                //BookOrderId = Convert.ToInt32(textBoxBookOrderId.Text.Trim()),
                ISBN = comboBoxBookOrderISBN.Text.Trim(),
                OrderId = Convert.ToInt32(comboBoxBookOrdersOrderId.Text.Trim())
            };

            // Search for the existing Book Order with the entered ID
            BookOrder bookOrderToUpdate = bookOrdersController.SearchOrderById(Convert.ToInt32(textBoxBookOrderId.Text));

            // Check if the Book Order exists
            if (bookOrderToUpdate != null)
            {
                // Update Book Order properties
                bookOrderToUpdate.ISBN = comboBoxBookOrderISBN.Text.Trim();
                bookOrderToUpdate.OrderId = orderId;

                // Save changes to the database
                bookOrdersController.UpdateBookOrder(bookOrderToUpdate);
                MessageBox.Show("Book Order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearControlsBookOrder();
            }
            else
            {
                MessageBox.Show("Book Order not found!", "Invalid Book Order ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookOrderId.Clear();
            }
        }

        //button delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the entered Order ID is not empty
                if (Validator.IsInputEmpty(textBoxBookOrderId.Text.Trim()))
                {
                    MessageBox.Show("BookOrder ID cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse the input to an integer value
                if (!int.TryParse(textBoxBookOrderId.Text, out int orderIdToDelete))
                {
                    MessageBox.Show("BookOrder ID must be a valid integer!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxBookOrderId.Clear();
                    return;
                }

                // Ask for confirmation before deleting the order
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Check if the order exists in the database
                    BookOrder orderToDelete = bookOrdersController.SearchOrderById(orderIdToDelete);

                    if (orderToDelete != null)
                    {
                        bookOrdersController.DeleteBookOrder(orderIdToDelete);
                        MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearControlsBookOrder();
                    }
                    else
                    {
                        MessageBox.Show("Order not found!", "Invalid Order ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookOrderId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Delete operation canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxBookOrderId.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //List all button
        private void buttonListAll_Click(object sender, EventArgs e)
        {
            // Fetch all book orders from the database
            IEnumerable<BookOrder> bookOrders = bookOrdersController.GetAllBookOrders();

            // Clear existing rows and columns in the DataGridView
            dataGridViewBookOrders.Columns.Clear();

            // Add columns to the DataGridView
            dataGridViewBookOrders.Columns.Add("BookOrderID", "BookOrder ID");
            dataGridViewBookOrders.Columns.Add("ISBN", "ISBN");
            dataGridViewBookOrders.Columns.Add("OrderID", "Order ID");

            DisplayBookOrdersList(bookOrders);
        }
        // Method to display book orders in the DataGridView
        private void DisplayBookOrdersList(IEnumerable<BookOrder> bookOrders)
        {
            dataGridViewBookOrders.Rows.Clear();
            // Populate the DataGridView with data
            foreach (var bookOrder in bookOrders)
            {
                dataGridViewBookOrders.Rows.Add(
                    bookOrder.BookOrderId,
                    bookOrder.ISBN,
                    bookOrder.OrderId
                );
            }
        }

        // Method to display a single book order's details
        private void DisplayBookOrder(BookOrder bookOrder)
        {
            clearControlsBookOrder();
            textBoxBookOrderId.Text = bookOrder.BookOrderId.ToString();
            comboBoxBookOrderISBN.Text = bookOrder.ISBN;
            comboBoxBookOrdersOrderId.Text = bookOrder.OrderId.ToString();
        }

        //Search button
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSerachBookOrders.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an option to search.", "Invalid search option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (comboBoxSerachBookOrders.SelectedIndex)
            {
                case 0:
                    // Search by Book Order ID
                    if (Validator.IsInputEmpty(textBoxBookOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Book Order ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(textBoxBookOrderSearch.Text.Trim(), out int bookOrderId))
                    {
                        MessageBox.Show("Invalid input for Book Order ID. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookOrderSearch.Clear();
                        return;
                    }

                    BookOrder bookOrderByID = bookOrdersController.SearchOrderById(bookOrderId);
                    if (bookOrderByID == null)
                    {
                        MessageBox.Show("Book Order not found! Invalid Book Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookOrderSearch.Clear();
                        return;
                    }
                    DisplayBookOrder(bookOrderByID);
                    break;

                case 1:
                    // Search by ISBN
                    if (Validator.IsInputEmpty(textBoxBookOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("ISBN cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!Validator.IsValidISBN(textBoxBookOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Invalid ISBN format", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookOrderSearch.Clear();
                        return;
                    }

                    string isbn = textBoxBookOrderSearch.Text.Trim();
                    IEnumerable<BookOrder> bookOrdersByISBN = bookOrdersController.SearchOrdersByISBN(isbn);
                    if (bookOrdersByISBN == null)
                    {
                        MessageBox.Show("No book orders found for the specified ISBN.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxBookOrderSearch.Clear();
                        return;
                    }
                    DisplayBookOrdersList(bookOrdersByISBN);
                    break;

                case 2:
                    // Search by Order ID
                    if (Validator.IsInputEmpty(textBoxBookOrderSearch.Text.Trim()))
                    {
                        MessageBox.Show("Order ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(textBoxBookOrderSearch.Text.Trim(), out int orderId))
                    {
                        MessageBox.Show("Invalid input for Order ID. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookOrderSearch.Clear();
                        return;
                    }

                    IEnumerable<BookOrder> bookOrdersByOrderID = bookOrdersController.SearchOrdersByOrderId(orderId);
                    if (bookOrdersByOrderID == null)
                    {
                        MessageBox.Show("No book orders found for the specified Order ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxBookOrderSearch.Clear();
                        return;
                    }
                    DisplayBookOrdersList(bookOrdersByOrderID);
                    break;
            }
        }

        private void comboBoxSerachBookOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSerachBookOrders.SelectedIndex)
            {
                case 0:
                    labelSearchBookOrders.Text = "Enter Book Order ID:";
                    break;
                case 1:
                    labelSearchBookOrders.Text = "Enter ISBN:";
                    break;
                case 2:
                    labelSearchBookOrders.Text = "Enter Order ID:";
                    break;
                default:
                    labelSearchBookOrders.Text = "";
                    break;
            }
        }

        //LogOut Button
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to logOut?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                this.Close();
                /*LogInForm logInForm = new LogInForm();
                logInForm.ShowDialog();
                this.Show();*/
            }

        }

       

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            LoadBooks();
            LoadOrders();
        }
    }
}
