using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroBackPUC.Models
{
	[Table("Veiculos")]
	public class Veiculo
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "É obrigatório informar um modelo")]
		public string Modelo { get; set; }
		[Required(ErrorMessage = "É obrigatório informar uma placa do veiculo")]

		public string Placa { get; set; }
		public string Marca { get; set; }
	}
}
