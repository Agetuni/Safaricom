using Microsoft.EntityFrameworkCore;
using Safaricom.Data.Model;

namespace Safaricom.Data.Context
{
    public class ApplicationContext :DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }
        public DbSet<Client> Client { get; set; }

    }
}
