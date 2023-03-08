using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbnerMolina.ArqLimpia.EN;
using Microsoft.EntityFrameworkCore;

namespace AbnerMolina.ArqLimpia.DAL
{
	public class AbnerAdonisDBContext : DbContext
	{
		public AbnerAdonisDBContext(DbContextOptions<AbnerAdonisDBContext> options): base(options) { }
		public DbSet<User> Users { get; set; }
	}
}
