using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinesLayer.Abstarct
{
	public interface IGenericService<T> where T : class
	{
		void TInsert(T entity);
		void TUpdate(T entity);
		void TDelete(T entity);
		T TGetByID(int id);
		List<T> TGetList();

	}
}
