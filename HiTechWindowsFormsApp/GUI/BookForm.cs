using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using Hi_Tech_Library.BLL.EntityFramework;
using HiTechLibrary.DAL;
using HiTechLibrary.VALIDATION;
using System.ComponentModel.DataAnnotations;
using Validator = HiTechLibrary.VALIDATION.Validator;
using System.Linq.Expressions;
using Hi_Tech_Library.BLL;

namespace HiTechWindowsFormsApp.GUI
{
    public partial class BookForm : Form
    {


        //declare bookController of type class BookController
        private readonly BookController bookController;

        //declare publisherController of type class PublisherController
        private readonly PublisherController publisherController;

        //declare categoryController of type class CategoryController
        private readonly CategoryController categoryController;

        //declare authorController of type class AuthorController
        private readonly AuthorController authorController;
        //declare bookAuthorController of type class BookAuthorController
        private readonly BookAuthorController bookAuthorController;
        public BookForm()
        {
            //intialize
            bookController = new BookController();
            publisherController = new PublisherController();
            categoryController = new CategoryController();
            authorController = new AuthorController();
            bookAuthorController = new BookAuthorController();
            InitializeComponent();
           
        }

        private void BookForm_Load(object sender, EventArgs e)
        {


            LoadCategories(); // Load categories into ComboBox
            LoadPublishers(); // Load publishers into ComboBox
            LoadISBN(); // Load Book ISBN into ComboBox
            LoadAuthorId(); // Load Authors into ComboBox


        }
        // Fetching the data of categoryId from the repository to show in combobox
        private void LoadCategories()
        {
            comboBoxBookCategoryID.Items.Clear();

            try
            {
                var categories = bookController.GetAllCategories();
                foreach (var category in categories)
                {
                    comboBoxBookCategoryID.Items.Add(category.CategoryId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fetching the data of publisherId from the repository to show in combobox
        private void LoadPublishers()
        {
            comboBoxBookPublisherID.Items.Clear();

            try
            {
                var publishers = bookController.GetPublishers();
                foreach (var publisher in publishers)
                {
                    comboBoxBookPublisherID.Items.Add(publisher.PublisherId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading publishers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button Save

        private void button_Save_Click(object sender, EventArgs e)
        {
            //try
            //{
                //Input Validation
                if (Validator.IsInputEmpty(textBoxISBN.Text)||Validator.IsInputEmpty(textBoxBookTitle.Text) || Validator.IsInputEmpty(textBoxBookUnitPrice.Text) || Validator.IsInputEmpty(textBoxBookYearPublished.Text) || Validator.IsInputEmpty(textBoxBookQOH.Text) || Validator.IsInputEmpty(comboBoxBookCategoryID.Text) || Validator.IsInputEmpty(comboBoxBookPublisherID.Text))
                {
                    MessageBox.Show("Input field must be filled!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //Validate ISBN
                if(!Validator.IsValidISBN(textBoxISBN.Text))
                {
                    MessageBox.Show("Invalid ISBN number!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxISBN.Clear();
                    return;
                }
                // Check if ISBN is unique
                if (!bookController.IsISBNUnique(textBoxISBN.Text.Trim()))
                {
                    MessageBox.Show("ISBN number already exists!", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxISBN.Clear();
                    return;
                }

            // Parsing the input to a double value
            double unitPrice;
                if (!double.TryParse(textBoxBookUnitPrice.Text, out unitPrice))
                {
                    MessageBox.Show("Unit Price must be a valid number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxBookUnitPrice.Clear();
                    return; // Exit the method if parsing fails
                }

                if (!Validator.IsValidInteger(textBoxBookYearPublished.Text, out int yearPublished) ||!Validator.IsValidInteger(textBoxBookQOH.Text, out int qoh) ||!Validator.IsValidInteger(comboBoxBookCategoryID.Text, out int categoryId) ||
                  !Validator.IsValidInteger(comboBoxBookPublisherID.Text, out int publisherId))
                {
                    MessageBox.Show("Value must be valid integers!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxBookYearPublished.Clear();
                    textBoxBookQOH.Clear();
                    comboBoxBookCategoryID.Items.Clear();
                    comboBoxBookPublisherID.Items.Clear();
                    return; 
                }


                //Create a new Book
               
                Book book = new Book
                {
                    ISBN = textBoxISBN.Text.Trim(),
                    BookTitle = textBoxBookTitle.Text.Trim(),
                    UnitPrice = Convert.ToDouble(textBoxBookUnitPrice.Text),
                    YearPublished = Convert.ToInt32(textBoxBookYearPublished.Text),
                    QOH = Convert.ToInt32(textBoxBookQOH.Text),
                    CategoryId = Convert.ToInt32(comboBoxBookCategoryID.Text),
                    PublisherId = Convert.ToInt32(comboBoxBookPublisherID.Text)

                };
            bookController.AddBook(book);



                MessageBox.Show("New Book added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearControls();

            //}

            /*catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        //Button Update
        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // check if the entered ISBN is not empty
                if (Validator.IsInputEmpty(textBoxISBN.Text.Trim()))
                {
                    MessageBox.Show("ISBN number cannot be empty!");
                    
                    return;
                }
                //Validate ISBN
                if (!Validator.IsValidISBN(textBoxISBN.Text))
                {
                    MessageBox.Show("Invalid ISBN number!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxISBN.Clear();
                    return;
                }
                string isbnToUpdate = textBoxISBN.Text.Trim();

                // Search for the book with the entered ISBN
                Book bookToUpdate = (Book)bookController.searchBookById(isbnToUpdate);

                // Check if the book exists
                if (bookToUpdate != null)
                {
                    // Update book properties
                    bookToUpdate.BookTitle = textBoxBookTitle.Text.Trim();
                    bookToUpdate.UnitPrice = Convert.ToDouble(textBoxBookUnitPrice.Text);
                    bookToUpdate.YearPublished = Convert.ToInt32(textBoxBookYearPublished.Text);
                    bookToUpdate.QOH = Convert.ToInt32(textBoxBookQOH.Text);
                    bookToUpdate.CategoryId = Convert.ToInt32(comboBoxBookCategoryID.Text);
                    bookToUpdate.PublisherId = Convert.ToInt32(comboBoxBookPublisherID.Text);

                    // Save changes to the database
                    bookController.UpdateBook(bookToUpdate);
                    MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Book not found!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxISBN.Clear() ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Delete button
        private void button_Delete_Click(object sender, EventArgs e)
        {
           

                // check if the entered ISBN is not empty
                if (Validator.IsInputEmpty(textBoxISBN.Text.Trim()))
                {
                    MessageBox.Show("ISBN number cannot be empty!");
                  
                    return;
                }
                //Validate ISBN
                if (!Validator.IsValidISBN(textBoxISBN.Text))
                {
                    MessageBox.Show("Invalid ISBN number!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxISBN.Clear();
                    return;
                }
            // Ask for confirmation before deleting the publisher
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string bookToDelete = textBoxISBN.Text.Trim();
                //Check if book exists in DB
                bookController.searchBookById(bookToDelete);
                if (bookToDelete != null)
                {
                    bookController.DeleteBook(bookToDelete);

                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Book not found!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxISBN.Clear();
                }

            }
            else
            {
                MessageBox.Show("Delete operation canceled.");
                textBoxISBN.Clear();
            }

            
        }

        /* // dispose  the DbContext when done -- The Dispose() method is usually responsible for performing cleanup tasks such as closing file handles, releasing database connections, or closing network sockets. It's good practice to call the Dispose() method as soon as you're done with an object, especially if it's holding onto resources that are limited or expensive
         protected override void Dispose(bool disposing)
         {
             if (disposing)
             {
                 _dbContext.Dispose();
             }
             base.Dispose(disposing);
         }
        */


        

        //Search
        private void button_Search_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectSearchOption.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a option to search.", "Invalid search option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxSelectSearchOption.SelectedIndex)
            {
                case 0:

                    

                    //Following checks handles the exception rased by the code while converting string to int

                    string ISBNText = textBoxBookSearch.Text.Trim();

                    // Check if the input string is empty
                    if (Validator.IsInputEmpty(ISBNText))
                    {
                        MessageBox.Show("ISBN cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    //Validate ISBN
                    if (!Validator.IsValidISBN(textBoxBookSearch.Text.Trim()))
                    {
                        MessageBox.Show("Invalid ISBN number!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBoxBookSearch.Clear();
                        return;
                    }


                    string bookIsbn = textBoxBookSearch.Text.Trim();

                    Book bookToSearch = (Book)bookController.searchBookById(bookIsbn);
                    if (bookToSearch == null)
                    {
                        MessageBox.Show("Book not found!. Invalid ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }
                    DisplayBooks(bookToSearch);
                    break;
                case 1:
                    ClearControls();
                    
                    // Check if the input string is empty
                    if (Validator.IsInputEmpty(textBoxBookSearch.Text.Trim()))
                    {
                        MessageBox.Show("BookTitle cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }
                    List<Book> booktitle = bookController.searchBookByTitle(textBoxBookSearch.Text.Trim());
                    if (booktitle == null)
                    {
                        MessageBox.Show("Book not found!. Invalid Book Title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }
                    //This will call the function pass the list which contains one element- firstName
                    DisplayBooksList((IEnumerable<Book>)booktitle);
                    break;

                case 2:
                    ClearControls();
                    
                    // Search for books based on the year published

                    // Check if the input string is empty
                    if (Validator.IsInputEmpty(textBoxBookSearch.Text.Trim()))
                    {
                        MessageBox.Show("Year cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    if (!Validator.IsValidInteger(textBoxBookSearch.Text.Trim(), out int yearPublished))
                    {
                        MessageBox.Show("Invalid input for year published. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }

                    IEnumerable <Book> bookPublisedyear = bookController.searchBookByYearPublished(Convert.ToInt32(textBoxBookSearch.Text.Trim()));

                    if (bookPublisedyear == null)
                    {
                        MessageBox.Show("No books found for the specified year published.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxBookSearch.Clear();
                        return;
                    }
                    // Display the found books in the DataGridView
                    DisplayBooksList((IEnumerable<Book>)bookPublisedyear);
                    break;
                case 3:
                    ClearControls();
                    
                    // Search for books based on unit price
                    // Check if the input string is empty
                    if (Validator.IsInputEmpty(textBoxBookSearch.Text.Trim()))
                    {
                        MessageBox.Show("Unit Price cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }
                    if (!double.TryParse(textBoxBookSearch.Text.Trim(), out double searchUnitPrice))
                    {
                        MessageBox.Show("Invalid input for unit price. Please enter a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }

                     IEnumerable <Book> booksByUnitPrice = bookController.searchBookByUnitprice(Convert.ToDouble(textBoxBookSearch.Text.Trim()));
                    if (booksByUnitPrice == null)
                    {
                        MessageBox.Show("No books found for the specified unit price.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxBookSearch.Clear();
                        return;
                    }
                    // Display the found books in the DataGridView
                    DisplayBooksList((IEnumerable<Book>)booksByUnitPrice);
                    break;




                case 4:
                    ClearControls();
                    
                    // Search for books based on category ID
                    // Check if the input string is empty
                    if (Validator.IsInputEmpty(textBoxBookSearch.Text.Trim()))
                    {
                        MessageBox.Show("Category cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }
                    if (!Validator.IsValidInteger(textBoxBookSearch.Text.Trim(), out int categoryId))
                    {
                        MessageBox.Show("Invalid input for category ID. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }
                    if (!Validator.IsValid(textBoxBookSearch.Text.Trim(),4))
                    {
                        MessageBox.Show("category ID must be 4-digit number. Please enter a valid Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }

                    IEnumerable <Book> booksByCategoryId = bookController.searchBookByCategory(Convert.ToInt32(textBoxBookSearch.Text.Trim()));
                    if (booksByCategoryId == null)
                    {
                        MessageBox.Show("No books found for the specified category ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxBookSearch.Clear();
                        return;
                    }

                    // Display the found books in the DataGridView
                    DisplayBooksList((IEnumerable<Book>)booksByCategoryId);
                    break;

                case 5:
                    ClearControls();
                    
                    // Search for books based on publisher ID
                    // Check if the input string is empty
                    if (Validator.IsInputEmpty(textBoxBookSearch.Text.Trim()))
                    {
                        MessageBox.Show("Publisher Id cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }
                    if (!Validator.IsValidInteger(textBoxBookSearch.Text.Trim(), out int publisherId))
                    {
                        MessageBox.Show("Invalid input for publisher ID. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }
                    if (!Validator.IsValid(textBoxBookSearch.Text.Trim(),4))
                    {
                        MessageBox.Show("Publisher ID must be 4-digit number. Please enter a valid Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }

                    IEnumerable <Book> booksByPublisherId = bookController.searchBookByPublisher(Convert.ToInt32(textBoxBookSearch.Text.Trim()));

                    if (booksByPublisherId == null)
                    {
                        MessageBox.Show("No books found for the specified publisher ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxBookSearch.Clear();
                        return;
                    }

                    // Display the found books in the DataGridView
                    DisplayBooksList((IEnumerable<Book>)booksByPublisherId);
                    break;

                case 6:
                    ClearControls();
                    
                    // Search for books based on quantity on hand (QOH)
                    ClearControls();
                    textBoxBookSearch.Clear();
                    // Check if the input string is empty
                    if (Validator.IsInputEmpty(textBoxBookSearch.Text.Trim()))
                    {
                        MessageBox.Show("QOH cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }
                    if (!Validator.IsValidInteger(textBoxBookSearch.Text.Trim(), out int qoh))
                    {
                        MessageBox.Show("Invalid input for quantity on hand (QOH). Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxBookSearch.Clear();
                        return;
                    }

                    IEnumerable <Book> booksByQoh =bookController.searchBookByQOH(Convert.ToInt32(textBoxBookSearch.Text.Trim()));

                    if (booksByQoh == null)
                    {
                      MessageBox.Show("No books found for the specified quantity on hand (QOH).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxBookSearch.Clear();
                        return;
                    }

                    // Display the found books in the DataGridView
                    DisplayBooksList((IEnumerable<Book>)booksByQoh);
                    break;
            }
        }
        //List
        private void button_ListAll_Click(object sender, EventArgs e)
        {
            // Fetch all books from the database
            IEnumerable<Book> books = bookController.GetBooks();

            // Clear existing rows and columns in the DataGridView
            //dataGridViewBook.Rows.Clear();
            dataGridViewBook.Columns.Clear();

            // Add columns to the DataGridView
            dataGridViewBook.Columns.Add("ISBN", "ISBN");
            dataGridViewBook.Columns.Add("BookTitle", "Book Title");
            dataGridViewBook.Columns.Add("UnitPrice", "Unit Price");
            dataGridViewBook.Columns.Add("YearPublished", "Year Published");
            dataGridViewBook.Columns.Add("QOH", "Quantity On Hand");
            dataGridViewBook.Columns.Add("CategoryId", "Category ID");
            dataGridViewBook.Columns.Add("PublisherId", "Publisher ID");

            DisplayBooksList(books);
        }
            // Method to display books in the DataGridView
            private void DisplayBooksList(IEnumerable<Book> books)
            {
                dataGridViewBook.Rows.Clear();
            // Populate the DataGridView with data
            foreach (var book in books)
                {
                    dataGridViewBook.Rows.Add(
                        book.ISBN,
                        book.BookTitle,
                        book.UnitPrice,
                        book.YearPublished,
                        book.QOH,
                        book.CategoryId,
                        book.PublisherId
                    );
                }
            }
            // Method to display a single book's details
        private void DisplayBooks(Book book)
        {
            ClearControls();
            textBoxISBN.Text = book.ISBN.ToString();
            textBoxBookTitle.Text = book.BookTitle;
            textBoxBookUnitPrice.Text = book.YearPublished.ToString();
            textBoxBookQOH.Text = book.QOH.ToString();
            comboBoxBookCategoryID.Text = book.CategoryId.ToString();
            comboBoxBookPublisherID.Text = book.PublisherId.ToString();
        }

        //Tab Control 2-- Publisher tab

        
        //Save button
        private void SavePublisher_Click(object sender, EventArgs e)
        {
            if (Validator.IsInputEmpty(textBoxPublisherName.Text))
            {
                MessageBox.Show("Publisher Name cannot be Empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            // Create a new Publisher object with data from the text boxes
            Publisher publisher = new Publisher
            {
                // PublisherId will be assigned automatically by the database
                PublisherName = textBoxPublisherName.Text.Trim(),
            };

            // Add the new publisher using the PublisherController
            publisherController.AddPublisher(publisher);

            // Inform the user that the PublisherId will be created automatically
            MessageBox.Show("PublisherId will be created automatically!");

            // Inform the user that the new publisher has been added successfully
            MessageBox.Show("New Publisher added successfully!");
            ClearControlsPublishers();

        }

        //Update Button
        private void UpdatePublisher_Click(object sender, EventArgs e)
        {
            if (Validator.IsInputEmpty(textBoxPublisherId.Text))
            {
                MessageBox.Show("Publisher Id cannot be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Parse the entered PublisherId
            int publisherId;
            if (!Validator.IsValidInteger(textBoxPublisherId.Text, out publisherId))
            {
                MessageBox.Show("Publisher Id must contain valid Integers!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPublisherId.Clear();
                return;
            }
            //Validate PublisherId Format
            if (!Validator.IsValid(textBoxPublisherId.Text.Trim(), 4))
            {
                MessageBox.Show("Publisher ID must be 4-digit number. Please enter a valid Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPublisherId.Clear();
                return;
            }

            
            // Search for the publisher with the entered PublisherId
            Publisher publisher = publisherController.SearchPublisher(publisherId);

            // Check if the publisher exists

            if (publisher==null)
            {
                MessageBox.Show("PublisherId does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPublisherId.Clear();
                return;
            }

            // Create a Publisher object with the updated data
            Publisher updatedPublisher = new Publisher
            {
                PublisherId = publisherId,
                PublisherName = textBoxPublisherName.Text.Trim()
            };

            // Call the UpdatePublisher method of the HiTechManagementController
            publisherController.UpdatePublisher(updatedPublisher);

            // Inform the user that the publisher has been updated successfully
            MessageBox.Show("Publisher updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Clear the text boxes
            ClearControlsPublishers();
        }

        //Delete Button
        private void DeletePublisher_Click(object sender, EventArgs e)
        {

            if (Validator.IsInputEmpty(textBoxPublisherId.Text))
            {
                MessageBox.Show("Publisher Id cannot be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Parse the entered PublisherId to delete
            int publisherId;
            if (!int.TryParse(textBoxPublisherId.Text, out publisherId))
            {
                MessageBox.Show("Publisher Id must contain valid Integers!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPublisherId.Clear();
                return;
            }
            if (!Validator.IsValid(textBoxPublisherId.Text.Trim(), 4))
            {
                MessageBox.Show("Publisher ID must be 4-digit number. Please enter a valid Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPublisherId.Clear();
                return;
            }
            // Check if the publisherId exists

            if (publisherId == 0)
            {
                MessageBox.Show("PublisherId does not exist in the Records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPublisherId.Clear();
                return;
            }
            // Ask for confirmation before deleting the publisher
            DialogResult result = MessageBox.Show("Are you sure you want to delete this publisher?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Call the DeletePublisher method of the PublisherController
                publisherController.DeletePublisher(publisherId);

                // Inform the user that the publisher has been deleted successfully
                MessageBox.Show($"Publisher with {publisherId} id deleted successfully!");

                // Clear the text boxes
                ClearControlsPublishers();
            }
            else
            {
                MessageBox.Show("Delete operation canceled.");
                textBoxPublisherId.Clear();
            }
        }

        //List button
        private void ListPublisher_Click(object sender, EventArgs e)
        {
            // Fetch all publishers from the database
            IEnumerable<Publisher> publishers = publisherController.GetPublishers();

            // Clear existing rows and columns in the DataGridView
            //dataGridViewPublishers.Rows.Clear();
            dataGridViewPublishers.Columns.Clear();

            // Add columns to the DataGridView
            dataGridViewPublishers.Columns.Add("PublisherId", "Publisher Id");
            dataGridViewPublishers.Columns.Add("PublisherName", "Publisher Name");
            /*  // Populate the DataGridView with data
              foreach (var publisher in publishers)
              {

                  dataGridViewPublishers.Rows.Add(publisher.PublisherId, publisher.PublisherName);
              }*/
            displayPublisherData(publishers);

        }

        //Display function to display specific publisher data in dataGridview
      
        public void displayPublisherData(IEnumerable<Publisher> publishers)
        {
            dataGridViewPublishers.Rows.Clear();
            foreach (var publisher in publishers)
            { 
                dataGridViewPublishers.Rows.Add(publisher.PublisherId, publisher.PublisherName);
            }
        }

        //Search button
        private void SearchPublisher_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectSearchPublisherOption.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a option to search.", "Invalid search option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch(comboBoxSelectSearchPublisherOption.SelectedIndex)
            {
                case 0:

                    labelSearchPublisher.Text = "Enter Publisher Id";
                    //If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchPublisherInput.Text))
                    {
                        MessageBox.Show("PublisherId cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    //if input value is not integer
                    int publisherId;
                    if (!Validator.IsValidInteger(textBoxSearchPublisherInput.Text, out publisherId))
                    {
                        MessageBox.Show("Invalid PublisherId. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchPublisherInput.Clear();
                        return;
                    }
                    //validate Publisher ID format
                    if (!Validator.IsValid(textBoxSearchPublisherInput.Text.Trim(), 4))
                    {
                        MessageBox.Show("Publisher ID must be 4-digit number. Please enter a valid Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchPublisherInput.Clear();
                        return;
                    }
                    // If found, show the data in text boxes
                    Publisher foundPublisher = publisherController.SearchPublisher(publisherId);
                    if (foundPublisher != null)
                    {
                        ClearControlsPublishers();
                        textBoxPublisherId.Text = foundPublisher.PublisherId.ToString();
                        textBoxPublisherName.Text = foundPublisher.PublisherName;
                      
                    }
                    else
                    {
                        MessageBox.Show("Publisher not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchPublisherInput.Clear();
                    }
                    break;
                case 1:
                    ClearControlsPublishers();
                    labelSearchPublisher.Text = "Enter Publisher Name";

                    //If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchPublisherInput.Text))
                    {
                        MessageBox.Show("Publisher Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // Validate publisher name
                    string publisherName = textBoxSearchPublisherInput.Text.Trim();
                    if (!Validator.IsValidName(publisherName))
                    {
                        MessageBox.Show("Invalid Publisher Name. Please enter a valid name containing letters and spaces only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchPublisherInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    List<Publisher> foundPublisherRecord = publisherController.SearchPublisherByName(publisherName);
                    if (foundPublisherRecord != null)
                    {
                        
                        displayPublisherData(foundPublisherRecord);

                    }
                    else
                    {
                        MessageBox.Show("Publisher not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchPublisherInput.Clear();
                    }
                    break;
                

            }
        }

        //Tab Control -- 3 -- Category

        //Save button
        private void Save_Categories_Click(object sender, EventArgs e)
        {
            //Check Input Empty or not
            if (Validator.IsInputEmpty(textBoxCategoryName.Text))
            {
                MessageBox.Show("Category Name cannot be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Create a new Category

            Category category = new Category
            {
                //CategoryId = Convert.ToInt32(textBoxCategoryId.Text),
                CategoryName = textBoxCategoryName.Text.Trim(),


            };

            categoryController.addCategory(category);
            

            MessageBox.Show("CategoryId will be created automatically!");

            MessageBox.Show("New Category added successfully!");
            
            ClearControlsCategory();

        }

        //Update Button
        private void Update_Categories_Click(object sender, EventArgs e)
        {
            //Chack if input is empty
           if (Validator.IsInputEmpty(textBoxCategoryId.Text.Trim()))
            {
                MessageBox.Show("CategoryId cannot be Empty!.","Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Parse the entered CategoryId
            int categoryId;
            if (!Validator.IsValidInteger(textBoxCategoryId.Text.Trim(), out categoryId))
            {
                MessageBox.Show("CategoryId must be a valid Integer Value!.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxCategoryId.Clear();
                return;
            }
            //Check Format
            if (!Validator.IsValid(textBoxCategoryId.Text.Trim(), 4))
            {
                MessageBox.Show("CategoryId must be 4-digit Value!.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxCategoryId.Clear();
                return;
            }
            //Chack if input is empty
            if (Validator.IsInputEmpty(textBoxCategoryName.Text.Trim()))
            {
                MessageBox.Show("CategoryName cannot be Empty!.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Search for the category with the entered CategoryId
            Category category = categoryController.searchCategorybyId(categoryId);

            // Check if the category exists
            if (category == null)
            {
                MessageBox.Show("Category with the given CategoryId does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCategoryId.Clear();
                return;
            }

            // Create a Category object with the updated data
            Category updatedCategory = new Category
            {
                CategoryId = categoryId,
                CategoryName = textBoxCategoryName.Text.Trim()
            };

            // Call the UpdateCategory method of the CategoryController
            categoryController.updateCategory(updatedCategory);

            // Inform the user that the category has been updated successfully
            MessageBox.Show("Category updated successfully.");

            // Clear the text boxes
            ClearControlsCategory();

        }

        //Delete Button
        private void Delete_Categories_Click(object sender, EventArgs e)
        {
            //Chack if input is empty
            if (Validator.IsInputEmpty(textBoxCategoryId.Text))
            {
                MessageBox.Show("CategoryId cannot be Empty!.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Parse the entered CategoryId to delete
            int categoryId;
            if (!int.TryParse(textBoxCategoryId.Text, out categoryId))
            {
                MessageBox.Show("CategoryId must be valid Integer value!.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxCategoryId.Clear();
                return;
            }
            //Check Format
            if (!Validator.IsValid(textBoxCategoryId.Text, 4))
            {
                MessageBox.Show("CategoryId must be 4-digit Value!.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxCategoryId.Clear();
                return;
            }
            // Check if the categoryId exists
            if (categoryController.searchCategorybyId(categoryId) == null)
            {
                MessageBox.Show("CategoryId does not exist in the records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCategoryId.Clear();
                return;
            }
            
            // Ask for confirmation before deleting the category
            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Call the DeleteCategory method of the CategoryController
                categoryController.deleteCategory(categoryId);

                // Inform the user that the category has been deleted successfully
                MessageBox.Show($"Category with {categoryId} id deleted successfully!");

                // Clear the text boxes
                ClearControlsCategory();
            }
            else
            {
                MessageBox.Show("Delete operation canceled.");
                textBoxCategoryId.Clear();
            }

        }

        //List Button
        private void List_Categories_Click(object sender, EventArgs e)
        {
            // Fetch all categories from the database
            IEnumerable<Category> categories = categoryController.GetCategories();

            // Clear existing columns in the DataGridView
            dataGridViewCategories.Columns.Clear();

            // Add columns to the DataGridView
            dataGridViewCategories.Columns.Add("CategoryId", "Category Id");
            dataGridViewCategories.Columns.Add("CategoryName", "Category Name");

            // Display the categories in the DataGridView
            DisplayCategoryData(categories);
        }

        // Display function to populate DataGridView with category data
        public void DisplayCategoryData(IEnumerable<Category> categories)
        {
            dataGridViewCategories.Rows.Clear();
            foreach (var category in categories)
            {
                dataGridViewCategories.Rows.Add(category.CategoryId, category.CategoryName);
            }
        }

        //Search Button
        private void Search_BookCategory_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an option to search.", "Invalid search option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxSearchCategory.SelectedIndex)
            {
                case 0:
                    
                    labelBookCategorySearch.Text = "Enter Category Id";

                    // If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchCategoryInput.Text))
                    {
                        MessageBox.Show("Category Id cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // If input value is not an integer
                    int categoryId;
                    if (!Validator.IsValidInteger(textBoxSearchCategoryInput.Text, out categoryId))
                    {
                        MessageBox.Show("Invalid Category Id. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchCategoryInput.Clear();
                        return;
                    }
                    //Check Format
                    if (!Validator.IsValid(textBoxSearchCategoryInput.Text, 4))
                    {
                        MessageBox.Show("CategoryId must be 4-digit Value!.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBoxSearchCategoryInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    Category foundCategory = categoryController.searchCategorybyId(categoryId);
                    if (foundCategory != null)
                    {
                        ClearControlsCategory();
                        textBoxCategoryId.Text = foundCategory.CategoryId.ToString();
                        textBoxCategoryName.Text = foundCategory.CategoryName;
                    }
                    else
                    {
                        MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchCategoryInput.Clear();
                    }
                    break;

                case 1:
                    //labelSearchCategory.Text = "Enter Category Name";
                     ClearControlsCategory();
                    // If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchCategoryInput.Text))
                    {
                        MessageBox.Show("Category Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // Validate category name
                    string categoryName = textBoxSearchCategoryInput.Text.Trim();
                    if (!Validator.IsValidName(categoryName))
                    {
                        MessageBox.Show("Invalid Category Name. Please enter a valid name containing letters and spaces only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchCategoryInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    List<Category> foundCategoryRecord = categoryController.searchCategoryByName(categoryName);
                    if (foundCategoryRecord != null && foundCategoryRecord.Count > 0)
                    {
                        DisplayCategoryData(foundCategoryRecord);
                    }
                    else
                    {
                        MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchCategoryInput.Clear();
                    }
                    break;
            }
        }
        //Tab Control 4 -- Author Form

        //Save Button
        private void Save_Author_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if(Validator.IsInputEmpty(textBoxAuthorFirstName.Text)|| Validator.IsInputEmpty(textBoxAuthorLastName.Text) || Validator.IsInputEmpty(textBoxAuthorEmail.Text))
            {
                MessageBox.Show("Input Field cannot be Empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validator.IsValidName(textBoxAuthorFirstName.Text.Trim()))
            {
                MessageBox.Show("Invalid First Name. Please enter a valid name containing letters and spaces only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorFirstName.Clear();
                return;
            }
            if (!Validator.IsValidName(textBoxAuthorLastName.Text.Trim()))
            {
                MessageBox.Show("Invalid Last Name. Please enter a valid name containing letters and spaces only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorLastName.Clear();
                return;
            }
            
            if (!Validator.IsValidEmail(textBoxAuthorEmail.Text.Trim()))
            {
                MessageBox.Show("Invalid Email Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorEmail.Clear();
                return;
            }
            // Create a new Author object with data from the input fields
            Author author = new Author
            {
                FirstName = textBoxAuthorFirstName.Text.Trim(),
                LastName = textBoxAuthorLastName.Text.Trim(),
                Email = textBoxAuthorEmail.Text.Trim()
            };

            // Call the AddAuthor method of the AuthorController to add the new author
            authorController.addAuthor(author);
            MessageBox.Show("AuthorId will be created automatically!");
            // Inform the user that the author has been saved successfully
            MessageBox.Show("Author saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields
            ClearControlsAuthor();

        }

        //Button 
        private void Update_Author_Click(object sender, EventArgs e)
        {
            if (Validator.IsInputEmpty(textBoxAuthorId.Text))
            {
                MessageBox.Show("Author Id cannot be Empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the author ID
            int authorId;
            if (!int.TryParse(textBoxAuthorId.Text, out authorId))
            {
                MessageBox.Show("Invalid Author ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorId.Clear();
                return;
            }
            if (!Validator.IsValid(textBoxAuthorId.Text, 5))
            {
                MessageBox.Show("Author Id must be a 5-digit value.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorId.Clear();
                return;
            }
            // Check if the author exists
            Author existingAuthor = authorController.searchAuthorById(authorId);
            if (existingAuthor == null)
            {
                MessageBox.Show("Author with the provided ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorId.Clear();
                return;
            }

            // Create a new Author object with updated data
            Author updatedAuthor = new Author
            {
                AuthorId = authorId,
                FirstName = textBoxAuthorFirstName.Text.Trim(),
                LastName = textBoxAuthorLastName.Text.Trim(),
                Email = textBoxAuthorEmail.Text.Trim()
            };

            // Call the UpdateAuthor method of the AuthorController
            authorController.updateAuthor(updatedAuthor);

            // Inform the user that the author has been updated successfully
            MessageBox.Show("Author updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields
            ClearControlsAuthor();
        }

        //Delete button
        private void Delete_Author_Click(object sender, EventArgs e)
        {
            //Chack if input is empty
            if (Validator.IsInputEmpty(textBoxAuthorId.Text))
            {
                MessageBox.Show("Author Id cannot be Empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the author ID
            int authorId;
            if (!int.TryParse(textBoxAuthorId.Text, out authorId))
            {
                MessageBox.Show("Invalid Author ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorId.Clear();
                return;
            }
            if (!Validator.IsValid(textBoxAuthorId.Text, 5))
            {
                MessageBox.Show("Author Id must be a 5-digit value.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorId.Clear();
                return;
            }

            // Check if the authorId exists
            if (authorController.searchAuthorById(authorId) == null)
            {
                MessageBox.Show("AuthorId does not exist in the records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorId.Clear();
                return;
            }

            // Ask for confirmation before deleting the author
            DialogResult result = MessageBox.Show("Are you sure you want to delete this author?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Call the DeleteAuthor method of the AuthorController
                authorController.deleteAuthor(authorId);

                // Inform the user that the author has been deleted successfully
                MessageBox.Show($"Category with {authorId} id deleted successfully!");

                // Clear the text boxes
                ClearControlsAuthor();
            }
            else
            {
                MessageBox.Show("Delete operation canceled.");
                textBoxAuthorId.Clear();
            }

        }

        //List button
        private void List_Author_Click(object sender, EventArgs e)
        {
            // Fetch all author from the database
            IEnumerable<Author> author = authorController.getAuthors();

            // Clear existing columns in the DataGridView
            dataGridViewAuthor.Columns.Clear();

            // Add columns to the DataGridView
            dataGridViewAuthor.Columns.Add("AuthorId", "Author Id");
            dataGridViewAuthor.Columns.Add("FirstName", "First Name");
            dataGridViewAuthor.Columns.Add("LastName", "Last Name");
            dataGridViewAuthor.Columns.Add("Email", "Email");

            // Display the categories in the DataGridView
            DisplayAuthorData(author);
        }

        // Display function to populate DataGridView with category data
        public void DisplayAuthorData(IEnumerable<Author> author)
        {
            dataGridViewAuthor.Rows.Clear();
            foreach (var authors in author)
            {
                dataGridViewAuthor.Rows.Add(authors.AuthorId, authors.FirstName, authors.LastName, authors.Email);
            }
        }

        //Search button
        private void Search_Author_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchAuthor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an option to search.", "Invalid search option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxSearchAuthor.SelectedIndex)
            {
                case 0:
                    if (Validator.IsInputEmpty(textBoxSearchAuthorInput.Text))
                    {
                        MessageBox.Show("Author Id cannot be Empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Parse the author ID
                    int authorId;
                    if (!int.TryParse(textBoxSearchAuthorInput.Text, out authorId))
                    {
                        MessageBox.Show("Invalid Author ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                        return;
                    }
                    if (!Validator.IsValid(textBoxSearchAuthorInput.Text, 5))
                    {
                        MessageBox.Show("Author Id must be a 5-digit value.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    Author foundAuthor = authorController.searchAuthorById(authorId);
                    if (foundAuthor != null)
                    {
                        ClearControlsAuthor();
                        textBoxAuthorId.Text = foundAuthor.AuthorId.ToString();
                        textBoxAuthorFirstName.Text = foundAuthor.FirstName;
                        textBoxAuthorLastName.Text = foundAuthor.LastName;
                        textBoxAuthorEmail.Text = foundAuthor.Email;
                    }
                    else
                    {
                        MessageBox.Show("Author not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                    }
                    break;

                case 1:
                    ClearControlsAuthor();
                    // If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchAuthorInput.Text))
                    {
                        MessageBox.Show("First Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // Validate first name
                    string firstName = textBoxSearchAuthorInput.Text.Trim();
                    if (!Validator.IsValidName(firstName))
                    {
                        MessageBox.Show("Invalid First Name. Please enter a valid name containing letters and spaces only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    List<Author> foundAuthorsByFirstName = authorController.searchAuthorsByFirstName(firstName);
                    if (foundAuthorsByFirstName != null && foundAuthorsByFirstName.Count > 0)
                    {
                        DisplayAuthorData(foundAuthorsByFirstName);
                    }
                    else
                    {
                        MessageBox.Show("Authors with given First Name not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                    }
                    break;

                case 2:
                    ClearControlsAuthor();
                    // If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchAuthorInput.Text))
                    {
                        MessageBox.Show("Last Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // Validate last name
                    string lastName = textBoxSearchAuthorInput.Text.Trim();
                    if (!Validator.IsValidName(lastName))
                    {
                        MessageBox.Show("Invalid Last Name. Please enter a valid name containing letters and spaces only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    List<Author> foundAuthorsByLastName = authorController.searchAuthorsByLastName(lastName);
                    if (foundAuthorsByLastName != null && foundAuthorsByLastName.Count > 0)
                    {
                        DisplayAuthorData(foundAuthorsByLastName);
                    }
                    else
                    {
                        MessageBox.Show("Authors with given Last Name not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                    }
                    break;

                case 3:
                    ClearControlsAuthor();
                    // If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchAuthorInput.Text))
                    {
                        MessageBox.Show("Email cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // Validate email
                    string email = textBoxSearchAuthorInput.Text.Trim();
                    if (!Validator.IsValidEmail(email))
                    {
                        MessageBox.Show("Invalid Email. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    List<Author> foundAuthorByEmail = authorController.searchAuthorsByEmail(email);
                    if (foundAuthorByEmail != null)
                    {
                        DisplayAuthorData(foundAuthorByEmail);

                    }
                    else
                    {
                        MessageBox.Show("Author with given Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchAuthorInput.Clear();
                    }
                    break;
            }
        }

        //Tab Control -- 5 -- BookAuthor

        // Fetching the data of AuthorId from the repository to show in combobox
        private void LoadAuthorId()
        {
            comboBoxBookAuthorIDFK.Items.Clear();

            try
            {
                var authors = bookAuthorController.GetAllAuthorId();
                foreach (var author in authors)
                {
                    comboBoxBookAuthorIDFK.Items.Add(author.AuthorId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading authors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fetching the data of ISBN from the repository to show in combobox
        private void LoadISBN()
        {
            comboBoxBookAuthorISBN.Items.Clear();

            try
            {
                var isbn = bookAuthorController.GetAllbookISBN();
                foreach (var Isbn in isbn)
                {
                    comboBoxBookAuthorISBN.Items.Add(Isbn.ISBN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ISBN: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Save button
        private void Save_BookAuthor_Click(object sender, EventArgs e)
        {

            //Validate Empty input or not
            if (Validator.IsInputEmpty(comboBoxBookAuthorISBN.Text) || Validator.IsInputEmpty(comboBoxBookAuthorIDFK.Text))
            {
                MessageBox.Show("Input Field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a new BookAuthor object with data from the input fields
            BookAuthor bookAuthor = new BookAuthor
            {
                ISBN = comboBoxBookAuthorISBN.Text.Trim(),
                AuthorId = Convert.ToInt32(comboBoxBookAuthorIDFK.Text.Trim()), 
            };

            // Calling the AddBookAuthor method of the BookAuthorController to add the new book author
            bookAuthorController.addBookAuthor(bookAuthor);
            MessageBox.Show("BookAuthorId will be created automatically!");
            // Inform the user that the book author has been saved successfully
            MessageBox.Show("Book author saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields
            ClearControlsBookAuthor();
        }

        //Update Button
        private void Update_BookAuthor_Click(object sender, EventArgs e)
        {
            // Validate input fields
            // If input is empty
            if (Validator.IsInputEmpty(textBoxBookAuthorId.Text)|| Validator.IsInputEmpty(comboBoxBookAuthorISBN.Text) || Validator.IsInputEmpty(comboBoxBookAuthorIDFK.Text))
            {
                MessageBox.Show("Input field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            //Parse the int value
            
            int bookAuthorId;
            if (!int.TryParse(textBoxBookAuthorId.Text, out bookAuthorId))
            {
                MessageBox.Show("Invalid BookAuthor ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookAuthorId.Clear();
                return;
            }
            // Validate BookAuthorId
            
            if (!Validator.IsValid(textBoxBookAuthorId.Text.Trim(),4))
            {
                MessageBox.Show("BookAuthor Id must be 4-digit number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookAuthorId.Clear();
                return;
            }

            // Check if the book author exists
            BookAuthor existingBookAuthor = bookAuthorController.searchBookAuthorById(bookAuthorId);
            if (existingBookAuthor == null)
            {
                MessageBox.Show("BookAuthor with the provided ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookAuthorId.Clear();
                return;
            }

            // Create a new BookAuthor object with updated data
            BookAuthor updatedBookAuthor = new BookAuthor
            {
                BookAuthorId = bookAuthorId,
                ISBN =comboBoxBookAuthorISBN.Text.Trim(),
                AuthorId = Convert.ToInt32(comboBoxBookAuthorIDFK.Text.Trim())  
            };

            // Call the UpdateBookAuthor method of the BookAuthorController
            bookAuthorController.updateBookAuthor(updatedBookAuthor);

            // Inform the user that the book author has been updated successfully
            MessageBox.Show("Book author updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields
            ClearControlsBookAuthor();
        }

        //Delete button
        private void Delete_BookAuthor_Click(object sender, EventArgs e)
        {
            // If input is empty
            if (Validator.IsInputEmpty(textBoxBookAuthorId.Text))
            {
                MessageBox.Show("Author Id cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            //Parse the int value

            int bookAuthorId;
            if (!int.TryParse(textBoxBookAuthorId.Text, out bookAuthorId))
            {
                MessageBox.Show("Invalid BookAuthor ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookAuthorId.Clear();
                return;
            }
            // Validate BookAuthorId

            if (!Validator.IsValid(textBoxBookAuthorId.Text.Trim(), 4))
            {
                MessageBox.Show("BookAuthor Id must be 4-digit number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookAuthorId.Clear();
                return;
            }

            // Check if the BookAuthorId exists
            if (bookAuthorController.searchBookAuthorById(bookAuthorId) == null)
            {
                MessageBox.Show("BookAuthorId does not exist in the records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookAuthorId.Clear();
                return;
            }

            // Ask for confirmation before deleting the book author
            DialogResult result = MessageBox.Show("Are you sure you want to delete this book author?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Call the DeleteBookAuthor method of the BookAuthorController
                bookAuthorController.deleteBookAuthor(bookAuthorId);

                // Inform the user that the book author has been deleted successfully
                MessageBox.Show($"BookAuthor with ID {bookAuthorId} deleted successfully!");

                // Clear the text boxes
                ClearControlsBookAuthor();
            }
            else
            {
                MessageBox.Show("Delete operation canceled.");
                textBoxBookAuthorId.Clear();
            }
        }

        //List All
        private void List_BookAuthor_Click(object sender, EventArgs e)
        {
            // Fetch all book authors from the database
            IEnumerable<BookAuthor> bookAuthors = bookAuthorController.GetBookAuthors();

            // Clear existing columns in the DataGridView
            dataGridViewBookAuthor.Columns.Clear();

            // Add columns to the DataGridView
            dataGridViewBookAuthor.Columns.Add("BookAuthorId", "BookAuthor Id");
            dataGridViewBookAuthor.Columns.Add("ISBN", "ISBN");
            dataGridViewBookAuthor.Columns.Add("AuthorId", "Author Id");

            // Display the book authors in the DataGridView
            DisplayBookAuthorData(bookAuthors);
        }

        // Display function to populate DataGridView with book author data
        public void DisplayBookAuthorData(IEnumerable<BookAuthor> bookAuthors)
        {
            dataGridViewBookAuthor.Rows.Clear();
            foreach (var bookAuthor in bookAuthors)
            {
                dataGridViewBookAuthor.Rows.Add(bookAuthor.BookAuthorId, bookAuthor.ISBN, bookAuthor.AuthorId);
            }
        }

        //Search Button
        private void Search_BookAuthor_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchBookAuthor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an option to search.", "Invalid search option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxSearchBookAuthor.SelectedIndex)
            {
                case 0:
                    // If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchBookAuthorInput.Text))
                    {
                        MessageBox.Show("BookAuthor Id cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // If input value is not an integer
                    int bookAuthorId;
                    if (!Validator.IsValidInteger(textBoxSearchBookAuthorInput.Text, out bookAuthorId))
                    {
                        MessageBox.Show("Invalid BookAuthor Id. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchBookAuthorInput.Clear();
                        return;
                    }
                    // Validate BookAuthorId

                    if (!Validator.IsValid(textBoxSearchBookAuthorInput.Text.Trim(), 4))
                    {
                        MessageBox.Show("BookAuthor Id must be 4-digit number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchBookAuthorInput.Clear();
                        return;
                    }
                    // If found, show the data in text boxes
                    BookAuthor foundBookAuthor = bookAuthorController.searchBookAuthorById(bookAuthorId);
                    if (foundBookAuthor != null)
                    {
                        ClearControlsBookAuthor();
                        textBoxBookAuthorId.Text = foundBookAuthor.BookAuthorId.ToString();
                        comboBoxBookAuthorISBN.Text = foundBookAuthor.ISBN.ToString();
                        comboBoxBookAuthorIDFK.Text = foundBookAuthor.AuthorId.ToString();
                    }
                    else
                    {
                        MessageBox.Show("BookAuthor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchBookAuthorInput.Clear();
                    }
                    break;

                case 1:
                    ClearControlsBookAuthor();  
                    // If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchBookAuthorInput.Text))
                    {
                        MessageBox.Show("ISBN cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }
                    // Validate ISBN

                    if (!Validator.IsValidISBN(textBoxSearchBookAuthorInput.Text.Trim()))
                    {
                        MessageBox.Show("Invalid ISBN number!", "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchBookAuthorInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    string isbn = textBoxSearchBookAuthorInput.Text.Trim();
                    List<BookAuthor> foundBookAuthorByISBN = bookAuthorController.searchBookAuthorsByISBN(isbn);
                    if (foundBookAuthorByISBN != null)
                    {
                        DisplayBookAuthorData(foundBookAuthorByISBN);
                    }
                    else
                    {
                        MessageBox.Show("BookAuthor with the provided ISBN not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchBookAuthorInput.Clear();
                    }
                    break;

                case 2:
                    ClearControlsBookAuthor();
                    // If input is empty
                    if (Validator.IsInputEmpty(textBoxSearchBookAuthorInput.Text))
                    {
                        MessageBox.Show("AuthorId cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // If input value is not an integer
                    int authorId;
                    if (!Validator.IsValidInteger(textBoxSearchBookAuthorInput.Text, out authorId))
                    {
                        MessageBox.Show("Invalid AuthorId. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchBookAuthorInput.Clear();
                        
                        return;
                    }
                    // Validate AuthorId

                    if (!Validator.IsValid(textBoxSearchBookAuthorInput.Text.Trim(), 5))
                    {
                        MessageBox.Show("Author Id must be 5-digit number!", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchBookAuthorInput.Clear();
                        return;
                    }

                    // If found, show the data in text boxes
                    List<BookAuthor> foundBookAuthorsByAuthorId = bookAuthorController.searchBookAuthorsByAuthorId(authorId);
                    if (foundBookAuthorsByAuthorId != null && foundBookAuthorsByAuthorId.Count > 0)
                    {
                        DisplayBookAuthorData(foundBookAuthorsByAuthorId);
                    }
                    else
                    {
                        MessageBox.Show("BookAuthors with the provided AuthorId not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSearchBookAuthorInput.Clear();
                    }
                    break;
            }
        }

            // Method to clear input controls for Book
            private void ClearControls()
            {
                textBoxISBN.Clear();
                textBoxBookTitle.Clear();
                textBoxBookUnitPrice.Clear();
                textBoxBookYearPublished.Clear();
                textBoxBookQOH.Clear();
                comboBoxBookCategoryID.SelectedIndex = -1;
                comboBoxBookPublisherID.SelectedIndex=-1;
            }
            // Method to clear input controls for Publisher
            private void ClearControlsPublishers()
            {
                textBoxPublisherId.Clear();
                textBoxPublisherName.Clear();
                
            }
            // Method to clear input controls for Category
            private void ClearControlsCategory()
            {
                textBoxCategoryId.Clear();
                textBoxCategoryName.Clear();

            }
            // Method to clear input controls for Author
            private void ClearControlsAuthor()
            {
                textBoxAuthorId.Clear();
                textBoxAuthorFirstName.Clear();
                textBoxAuthorLastName.Clear();
                textBoxAuthorEmail.Clear();

        }
            // Method to clear input controls for BookAuthor
            private void ClearControlsBookAuthor()
            {
                textBoxBookAuthorId.Clear();
                comboBoxBookAuthorIDFK.SelectedIndex = -1;
                comboBoxBookAuthorISBN.SelectedIndex = -1;

            }
        //Displaying text in the label according to Search by option
        
        private void comboBoxSelectSearchPublisherOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectSearchPublisherOption.SelectedIndex)
            {
                case 0:
                    labelSearchPublisher.Text = "Enter Publisher Id";
                    break;
                case 1:
                    labelSearchPublisher.Text = "Enter Publisher Name";
                    break;
            } 
        }

        private void comboBoxSelectSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxSelectSearchOption.SelectedIndex)
            {
                case 0:
                    labelSearchBook.Text = "Enter Book ISBN";
                    break;
                case 1:
                    labelSearchBook.Text = "Enter Book Title";
                    break;
                case 2:
                    labelSearchBook.Text = "Enter YearPublished";
                    break;
                case 3:
                    labelSearchBook.Text = "Enter Unit Price";
                    break;
                case 4:
                    labelSearchBook.Text = "Enter Category Id";
                    break;
                case 5:
                    labelSearchBook.Text = "Enter Publisher Id";
                    break;
                case 6:
                    labelSearchBook.Text = "Enter QOH";
                    break;
            }
        }

        private void comboBoxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearchCategory.SelectedIndex)
            {
                case 0:
                    labelBookCategorySearch.Text = "Enter Category Id";
                    break; 
                case 1:
                    labelBookCategorySearch.Text = "Enter Category Name";
                    break;
            }
        }

        private void comboBoxSearchAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearchAuthor.SelectedIndex)
            {
                case 0:
                    labelSearchAuthor.Text = "Enter Author Id";
                    break;
                case 1:
                    labelSearchAuthor.Text = "Enter First Name";
                    break;
                case 2:
                    labelSearchAuthor.Text = "Enter Last Name";
                    break;
                case 3:
                    labelSearchAuthor.Text = "Enter Email Address";
                    break;
            }
        }

        private void comboBoxSearchBookAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxSearchBookAuthor.SelectedIndex)
            {
                case 0:
                    labelSearchBookAuthor.Text = "Enter BookAuthor Id";
                    break;
                case 1:
                    labelSearchBookAuthor.Text = "Enter Book ISBN";
                    break;
                case 2:
                    labelSearchBookAuthor.Text = "Enter Author Id";
                    break;
            }
        }

        //Exit Button
        private void buttonExit_Click(object sender, EventArgs e)
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

        private void labelSearchPublisher_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearchPublisherInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
