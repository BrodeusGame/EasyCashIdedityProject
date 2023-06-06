using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Abstrat
{
	public interface IGenericDal<T> where T : class
	{
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		T GetByID(T entity);
		List<T> GetList();


	}
}
