using CuadroMandoIntegral.Models;
using Microsoft.EntityFrameworkCore;

namespace CuadroMandoIntegral.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // Los DBset permiten que Entity reconozca los modelos para así poder interactuar con las entidades de la base de datos

        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public DbSet<Cmi> Cmis { get; set; }
        public DbSet<ConfiguracionTema> ConfiguracionTemas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Indicadores> Indicadores { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Objetivos> Objetivos { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<PermisoEmpresaModulo> PermisoEmpresaModulos { get; set; }
        public DbSet<PermisoRolSeccion> PermisoRolSecciones { get; set; }
        public DbSet<Perspectivas> Perspectivas { get; set; }
        public DbSet<SeccionSistema> SeccionSistemas { get; set; }
        public DbSet<UsuarioEmpresa> UsuarioEmpresas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir la clave primaria para todas las entidades
            modelBuilder.Entity<Alerta>()
                .HasKey(a => a.IdAlerta);

            modelBuilder.Entity<Persona>()
                .HasKey(p => p.IdPersona);

            modelBuilder.Entity<Rol>()
                .HasKey(r => r.IdRol);

            modelBuilder.Entity<Cmi>()
                .HasKey(c => c.IdCmi);

            modelBuilder.Entity<ConfiguracionTema>()
                .HasKey(ct => ct.IdConfiguracion);

            modelBuilder.Entity<Empresa>()
                .HasKey(e => e.IdEmpresa);

            modelBuilder.Entity<Departamento>()
                .HasKey(d => d.IdDepartamento);

            modelBuilder.Entity<Indicadores>()
                .HasKey(i => i.IdIndicador);

            modelBuilder.Entity<Modulo>()
                .HasKey(m => m.IdModulo);

            modelBuilder.Entity<Objetivos>()
                .HasKey(o => o.IdObjetivo);

            modelBuilder.Entity<Permiso>()
                .HasKey(p => p.IdPermiso);

            modelBuilder.Entity<PermisoEmpresaModulo>()
                .HasKey(pem => new { pem.IdPermiso, pem.IdEmpresa, pem.IdModulo });

            modelBuilder.Entity<PermisoRolSeccion>()
                .HasKey(prs => new { prs.IdPermiso, prs.IdRol, prs.IdSeccion });

            modelBuilder.Entity<Perspectivas>()
                .HasKey(p => p.IdPerspectiva);

            modelBuilder.Entity<SeccionSistema>()
                .HasKey(ss => ss.IdSeccion);

            modelBuilder.Entity<UsuarioEmpresa>()
                .HasKey(ue => ue.IdUsuario);

            // Relaciones adicionales y configuración personalizada

            // Generación de la tabla relacional entre Persona y Rol
            modelBuilder.Entity<Persona>()
                .HasMany(fr => fr.Roles)
                .WithMany(wo => wo.Persona)
                .UsingEntity(j => j.ToTable("PersonaRol"));

            // Configuración de las relaciones de PermisoRolSeccion
            modelBuilder.Entity<PermisoRolSeccion>()
                .HasOne(fr => fr.Permiso)
                .WithMany(f => f.PermisoRolSeccion)
                .HasForeignKey(fr => fr.IdPermiso)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PermisoRolSeccion>()
                .HasOne(fr => fr.Rol)
                .WithMany(f => f.PermisoRolSeccion)
                .HasForeignKey(fr => fr.IdRol)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PermisoRolSeccion>()
                .HasOne(fr => fr.SeccionSistema)
                .WithMany(f => f.PermisoRolSeccion)
                .HasForeignKey(fr => fr.IdSeccion)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuración de las relaciones de PermisoEmpresaModulo
            modelBuilder.Entity<PermisoEmpresaModulo>()
                .HasOne(fr => fr.Empresa)
                .WithMany(f => f.PermisoEmpresaModulo)
                .HasForeignKey(fr => fr.IdEmpresa)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PermisoEmpresaModulo>()
                .HasOne(fr => fr.Permiso)
                .WithMany(f => f.PermisoEmpresaModulo)
                .HasForeignKey(fr => fr.IdPermiso)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PermisoEmpresaModulo>()
                .HasOne(fr => fr.Modulo)
                .WithMany(f => f.PermisoEmpresaModulo)
                .HasForeignKey(fr => fr.IdModulo)
                .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }
    }
}
