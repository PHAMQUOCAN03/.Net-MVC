using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Models.Entities;

namespace DemoMvc.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext > options)
            : base(options)
            
        {
        }
        public DbSet<Student> Student { get; set;} = default!;
    }
    
}