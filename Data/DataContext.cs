using DatingApp_API.Model;
using Microsoft.EntityFrameworkCore;

namespace DatingApp_API.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base (options) 
        {
                
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
