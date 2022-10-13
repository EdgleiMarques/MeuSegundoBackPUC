using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroBackPUC.Models
{
	public class AplicationDBContext : DbContext
	{
		public AplicationDBContext (DbContextOptions<AplicationDBContext> options) : base(options) 
		{
		}
		public DbSet<Veiculo> Veiculos { get; set; }
	}
}
