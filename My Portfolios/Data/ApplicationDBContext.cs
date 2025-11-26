using Microsoft.EntityFrameworkCore;
using My_Portfolios.Models;

namespace My_Portfolios.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<ContactForm> ContactForms { get; set; }
    }
  
}
