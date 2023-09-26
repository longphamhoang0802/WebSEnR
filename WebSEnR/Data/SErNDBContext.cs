
using Microsoft.EntityFrameworkCore;
using WebSEnR.Models;

namespace WebSEnR.Data
{
    public class SErNDBContext : DbContext
    {
        public SErNDBContext(DbContextOptions<SErNDBContext> options) : base(options)
        {

        }
        public DbSet<labproduct> labproducts { get; set; }
        public DbSet<ministerial_project> ministerialprojects { get; set;}
        public DbSet<uni_project> uniprojects { get; set; }
        public DbSet<enterprise_project> enterpriseprojects { get; set; }
        public DbSet<post_etp_queue> posts_etp_queue { get; set; }
        public DbSet<register_queue> registerqueue { get; set; }
        public DbSet<post_lab> posts_lab { get; set; }
        public DbSet<post_etp> posts_etp { get; set; }
        public DbSet<lab_member> lab_members { get; set; }
        
    }
}
