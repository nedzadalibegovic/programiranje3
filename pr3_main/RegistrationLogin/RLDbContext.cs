using System.Data.Entity;

namespace RegistrationLogin {
    class RLDbContext : DbContext {
        public DbSet<User> Users { get; set; }

        public RLDbContext() : base("DatabaseConnection") { }
    }
}