using EasyCashIdentityProject.BusinesLayer.Abstarct;
using EasyCashIdentityProject.DataAccessLayer.Abstrat;
using EasyCashIdentityProject.EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinesLayer.Concrete
{
	public class CustomerAccountProcessManager : ICustomerAccountProcessService
	{
		private readonly ICustomerAccountProcessDal _customerAccountDal;

		public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountDal)
		{
			_customerAccountDal = customerAccountDal;
		}

		public void TDelete(CustomerAccountProcess entity)
		{
			_customerAccountDal.Delete(entity);
		}

		public CustomerAccountProcess TGetByID(int id)
		{
			return _customerAccountDal.GetByID(id);
		}

		public List<CustomerAccountProcess> TGetList()
		{
			return _customerAccountDal.GetList();
		}

		public void TInsert(CustomerAccountProcess entity)
		{
			_customerAccountDal.Insert(entity);
		}

		public void TUpdate(CustomerAccountProcess entity)
		{
			_customerAccountDal.Update(entity);
		}
	}
}
