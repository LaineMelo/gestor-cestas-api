using Microsoft.EntityFrameworkCore;

namespace gestor_cestas_api.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        // Define DbSet para cada entidade do modelo
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }
        public DbSet<RegistroCesta> RegistroCestas { get; set; }
        public DbSet<ListaNecessidade> ListaNecessidades { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura as chaves estrangeiras
            modelBuilder.Entity<RegistroCesta>()
                .HasOne(ce => ce.Beneficiario)
                .WithMany(b => b.RegistroCesta)
                .HasForeignKey(ce => ce.IdBeneficiario);

            modelBuilder.Entity<RegistroCesta>()
                .HasOne(ce => ce.Voluntario)
                .WithMany(v => v.RegistroCesta)
                .HasForeignKey(ce => ce.IdVoluntario);

            modelBuilder.Entity<ListaNecessidade>()
                .HasOne(ln => ln.Beneficiario)
                .WithMany(b => b.ListaNecessidade)
                .HasForeignKey(ln => ln.IdBeneficiario);

            modelBuilder.Entity<Dependente>()
                .HasOne(d => d.Beneficiario)
                .WithMany(b => b.Dependente)
                .HasForeignKey(d => d.IdBeneficiario);

            base.OnModelCreating(modelBuilder);

        }
    }
}
