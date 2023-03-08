using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbnerMolina.ArqLimpia.EN.Interfaces;

namespace AbnerMolina.ArqLimpia.DAL
{
	public class UnitOfWork: IUnitOfWork
	{    
        readonly AbnerAdonisDBContext dbContext;
		public UnitOfWork(AbnerAdonisDBContext pDbContext)
		{
			dbContext = pDbContext;
		}
		public Task<int> SaveChangesAsync()
		{
			return dbContext.SaveChangesAsync();
		}
	}
}

