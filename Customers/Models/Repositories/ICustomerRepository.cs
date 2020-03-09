using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Models.Repositories
{
	public interface ICustomerRepository<TEntity>
	{
		IList<TEntity> list();
		TEntity FindById(int id);
		void Add(TEntity entity);
		void Update(TEntity entity);
		void Delete(int id);
		List<TEntity> Search(string term);
	}
}
