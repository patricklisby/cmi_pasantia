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
		public DbSet<Cmi> Cmis { get; set; }
		public DbSet<ConfiguracionTema> ConfiguracioneTemas { get; set; }
		public DbSet<Empresa> Empresas {  get; set; }
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
			// Generación de la tabla relacional entre Persona y Rol
			modelBuilder.Entity<Persona>() 
				.HasMany(fr => fr.Roles)
				.WithMany(wo => wo.Persona)
				.UsingEntity(j => j.ToTable("PersonaRol"));

			// Identifica que las llaves son foraneas 
			modelBuilder.Entity<PermisoRolSeccion>().HasKey(fr => new { fr.PermisoId, fr.RolId, fr.SeccionId });
			
			// Generación de la tabla teraria entre Permiso, Rol y Seccion
			modelBuilder.Entity<PermisoRolSeccion>() 
				.HasOne(fr => fr.Permiso)
				.WithMany(f => f.PermisoRolSeccion)
				.HasForeignKey(fr => fr.PermisoId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<PermisoRolSeccion>()
				.HasOne(fr => fr.Rol)
				.WithMany(f => f.PermisoRolSeccion)
				.HasForeignKey(fr => fr.RolId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<PermisoRolSeccion>()
				.HasOne(fr => fr.SeccionSistema)
				.WithMany(f => f.PermisoRolSeccion)
				.HasForeignKey(fr => fr.SeccionId)
				.OnDelete(DeleteBehavior.Cascade);

			// Identifica que las llaves son foraneas 
			modelBuilder.Entity<PermisoEmpresaModulo>().HasKey(fr => new { fr.PermisoId, fr.EmpresaId, fr.ModuloId });

			// Generación de la tabla teraria entre Permiso, Empresa y Modulo
			modelBuilder.Entity<PermisoEmpresaModulo>() 
				.HasOne(fr => fr.Empresa)
				.WithMany(f => f.PermisoEmpresaModulo)
				.HasForeignKey(fr => fr.EmpresaId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<PermisoEmpresaModulo>()
				.HasOne(fr => fr.Permiso)
				.WithMany(f => f.PermisoEmpresaModulo)
				.HasForeignKey(fr => fr.PermisoId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<PermisoEmpresaModulo>()
				.HasOne(fr => fr.Modulo)
				.WithMany(f => f.PermisoEmpresaModulo)
				.HasForeignKey(fr => fr.ModuloId)
				.OnDelete(DeleteBehavior.Cascade);


			// Generación de la tabla relacional entre Usuario y Empresa
			modelBuilder.Entity<Persona>()
				.HasMany(fr => fr.Roles)
				.WithMany(wo => wo.Persona)
				.UsingEntity(j => j.ToTable("PersonaRol"));
		}
	}
}
