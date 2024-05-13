using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL.EntityFramework;
using Hi_Tech_Library.DAL;

namespace Hi_Tech_Library.BLL
{
    public class PublisherController
    {
        private readonly PublisherRepository publisherRepository;

        public PublisherController()
        {
            publisherRepository = new PublisherRepository();
        }
        //Publishers Methods
        // Method to retrieve all publishers
        public IEnumerable<Publisher> GetPublishers() => publisherRepository.GetAllPublishers();

        // Method to add a new publisher
        public void AddPublisher(Publisher publisher) => publisherRepository.addPublisher(publisher);

        // Method to update an existing publisher
        public void UpdatePublisher(Publisher publisher) => publisherRepository.UpdatePublisher(publisher);

        // Method to delete a publisher by its ID
        public void DeletePublisher(int publisherId) =>publisherRepository.DeletePublisher(publisherId);

        // Method to search for a publisher by its ID
        public Publisher SearchPublisher(int publisherId) => publisherRepository.SearchPublisher(publisherId);

        // Method to search for a publisher by name
        public List<Publisher> SearchPublisherByName(string publisherName) => publisherRepository.SearchPublisherByName(publisherName);
    }
}
