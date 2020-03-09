using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Models.Repositories
{
	public class CustomerDBRepository : ICustomerRepository<CustomerType>
	{
		private readonly customerDbContext db;

		public CustomerDBRepository(customerDbContext _db)
		{
			db = _db;
		}
		public void Add(CustomerType entity)
		{
			db.CustomersType.Add(entity);
			db.SaveChanges();
		}

		public void Delete(int id)
		{
			var customerType = FindById(id);
			db.CustomersType.Remove(customerType);
			db.SaveChanges();
		}

		public CustomerType FindById(int id)
		{
			var customerType = db.CustomersType.SingleOrDefault(c => c.Id == id);

			return customerType;
		}

		public IList<CustomerType> list()
		{
			return db.CustomersType.ToList();
		}

		public List<CustomerType> Search(string term)
		{
			return db.CustomersType.Where(c => c.Name.Contains(term)).ToList();
		}

		public void Update(CustomerType entity)
		{
			db.Update(entity);
			db.SaveChanges();
		}

	}
}
