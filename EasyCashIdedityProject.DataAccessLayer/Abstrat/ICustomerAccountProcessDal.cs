﻿using EasyCashIdentityProject.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Abstrat
{
	public interface ICustomerAccountProcessDal : IGenericDal<CustomerAccountProcess>
	{
		CustomerAccountProcess GetByID(int id);
	}
}
