using Microsoft.EntityFrameworkCore;
using Student_Platform.Web.Models.Entities;

namespace Student_Platform.Web.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
            
        }
        public DbSet<Student> Students {  get; set; }
    }
}
