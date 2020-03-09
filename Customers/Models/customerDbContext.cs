using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Models
{
	public class customerDbContext: DbContext
	{
		public customerDbContext(DbContextOptions<customerDbContext> options) : base(options)
		{

		}
		public DbSet<CustomerType> CustomersType { get; set; }
	}
}
