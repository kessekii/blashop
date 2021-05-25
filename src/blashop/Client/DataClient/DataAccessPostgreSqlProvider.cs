using blashop.Shared;

using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blashop.Client.DataClient
{
    public class DataAccessPostgreSqlProvider : IDataAccessProvider
    {
        private readonly DataContext _context;
        private readonly ILogger _logger;

        public DataAccessPostgreSqlProvider(DataContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("DataAccessPostgreSqlProvider");
        }

        public DataAccessPostgreSqlProvider()
        {
        }

        public void AddRecord(CartItem item)
        {
            
               _context.CartItems.Add(item);
            
        
            
            _context.SaveChanges();
        }

        

        public void UpdateRecord(CartItem item)
        {
            _context.CartItems.Update(item);
            _context.SaveChanges();
        }

        public void DeleteRecord(string id)
        {
            var entity = _context.Users.First(t => t.Id == id);
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public User GetSingleRecord(string id)
        {
            return _context.Users.First(t => t.Id == id);
        }

        public List<User> GetRecords()
        {
            return _context.Users.ToList();
        }

    }
}