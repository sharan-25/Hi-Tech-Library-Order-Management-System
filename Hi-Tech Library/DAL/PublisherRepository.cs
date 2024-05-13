using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL;
using Hi_Tech_Library.BLL.EntityFramework;

namespace Hi_Tech_Library.DAL
{
    public class PublisherRepository
    {
        private readonly HiTechOrderManagementDBEntities dBContext;

        public PublisherRepository()
        {
            dBContext = new HiTechOrderManagementDBEntities();
        }
        //Publisher Methods
        //get the list of all publishers
        public IEnumerable<Publisher> GetAllPublishers() => dBContext.Publishers.ToList();

        //add publisher
        public void addPublisher(Publisher publisher)
        {
            dBContext.Publishers.Add(publisher);
            dBContext.SaveChanges();
        }

        //Search Publisher by id
        public Publisher SearchPublisher(int pId) => dBContext.Publishers.Find(pId);

        //Search publisher by name

        public List<Publisher> SearchPublisherByName(string publisherName) => dBContext.Publishers.Where(p => p.PublisherName == publisherName).ToList();


        // Update Publisher
        public void UpdatePublisher(Publisher publisher)
        {
            
            var existingPublisher = dBContext.Publishers.Find(publisher.PublisherId);
            if (existingPublisher != null)
            {
                dBContext.Entry(existingPublisher).CurrentValues.SetValues(publisher);
                dBContext.SaveChanges();
            }
        }

        // Delete Publisher
        public void DeletePublisher(int pId)
        {
            var publisher = dBContext.Publishers.Find(pId);
            if (publisher != null)
            {
                dBContext.Publishers.Remove(publisher);
                dBContext.SaveChanges();
            }
        }
    }
}
