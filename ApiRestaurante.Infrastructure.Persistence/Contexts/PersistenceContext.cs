using ApiRestaurante.Core.Domain.Common;
using ApiRestaurante.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace RestauranteApi.Infrastructure.Persistence.Contexts
{
    public class PersistenceContext : DbContext
    {
        public PersistenceContext(DbContextOptions<PersistenceContext> options) : base(options) { }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Plate> Plates { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PlateIngredient> PlateIngredients { get; set; }
        public DbSet<OrderPlate> OrderPlates { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tables Configuration

            modelBuilder.Entity<Ingredient>().ToTable("Ingredients");
            modelBuilder.Entity<Plate>().ToTable("Plates");
            modelBuilder.Entity<Table>().ToTable("Tables");
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<PlateIngredient>().ToTable("PlateIngredients");
            modelBuilder.Entity<OrderPlate>().ToTable("OrderPlates");

            #endregion

            #region Primary Keys

            modelBuilder.Entity<Ingredient>().HasKey(ingredient => ingredient.Id);
            modelBuilder.Entity<Plate>().HasKey(plate => plate.Id);
            modelBuilder.Entity<Table>().HasKey(table => table.Id);
            modelBuilder.Entity<Order>().HasKey(order => order.Id);
            modelBuilder.Entity<PlateIngredient>().HasKey(pi => new { pi.PlateId, pi.IngredientId });
            modelBuilder.Entity<OrderPlate>().HasKey(op => new { op.OrderId, op.PlateId });

            #endregion

            #region Relationships

            modelBuilder.Entity<PlateIngredient>()
                .HasOne(pi => pi.Plate)
                .WithMany(p => p.PlateIngredients)
                .HasForeignKey(pi => pi.PlateId);

            modelBuilder.Entity<PlateIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany()
                .HasForeignKey(pi => pi.IngredientId);

            modelBuilder.Entity<OrderPlate>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderPlate)
                .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderPlate>()
                .HasOne(op => op.Plate)
                .WithMany()
                .HasForeignKey(op => op.PlateId);

            #endregion

            #region Property Configurations

            modelBuilder.Entity<Plate>()
                .Property(plate => plate.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Plate>()
                .Property(plate => plate.Price)
                .IsRequired();

            modelBuilder.Entity<Plate>()
                .Property(plate => plate.Category)
                .IsRequired();

            modelBuilder.Entity<Ingredient>()
                .Property(ingredient => ingredient.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Table>()
                .Property(table => table.Description)
                .HasMaxLength(100);

            modelBuilder.Entity<Table>()
                .Property(table => table.Status)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(order => order.Subtotal)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(order => order.Status)
                .IsRequired();

            #endregion
        }
    }
}
