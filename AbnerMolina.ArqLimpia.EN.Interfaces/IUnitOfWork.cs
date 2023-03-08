﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbnerMolina.ArqLimpia.EN.Interfaces
{
	public interface IUnitOfWork
	{
		Task<int> SaveChangesAsync();
	}
}
