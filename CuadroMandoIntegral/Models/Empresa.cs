using System.ComponentModel.DataAnnotations.Schema;

namespace CuadroMandoIntegral.Models
{
	public class Empresa
	{
		public int IdEmpresa { get; set; }

		public string NombreEmpresa { get; set; }

		public bool Estado { get; set; }

		public string CorreoElectronico { get; set; }

		public string Telefono { get; set; }

		public string Logo	{ get; set; }

		public int ConfiguracionId {  get; set; }

		[ForeignKey("ConfiguracionId")]
		public ConfiguracionTema Configuracion { get; set; }

		public virtual ICollection<PermisoEmpresaModulo> PermisoEmpresaModulo { get; set; }

		public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }

		public virtual ICollection<Cmi> Cmis { get; set; }
	}
}
