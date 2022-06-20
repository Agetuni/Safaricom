using Microsoft.EntityFrameworkCore;

namespace Safaricom.Data.Context
{
    public class ApplicationContext :DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }
       
    }
}
