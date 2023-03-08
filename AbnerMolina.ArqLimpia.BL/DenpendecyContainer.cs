using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AbnerMolina.ArqLimpia.BL.Interfaces;

namespace AbnerMolina.ArqLimpia.BL
{
	public static class DenpendecyContainer
	{
		public static IServiceCollection AddBLDependecies(this IServiceCollection services)
		{
			services.AddTransient<IUserBL, UserBL>();
			return services;
		}
	}
}
