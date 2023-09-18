using Microsoft.EntityFrameworkCore;
using MyPc.Models;

namespace MyPc.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> op) :base(op)
        { 
        }
        public BancoContext() 
        { 
        }
        public DbSet<SetupModel> Setup { get; set; }
        public DbSet<UserModel> User { get; set; }


    }
}
