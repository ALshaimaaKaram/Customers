using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Models
{
	public class CustomerType
	{
		[Required]
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Insert_Date { get; set; }
		public int User_ID { get; set; }
		public string User_Name { get; set; }
		public string Machine_IP { get; set; }
		public string Machine_Name { get; set; }
		public int User_ID_Update { get; set; }
		public DateTime Update_Date { get; set; }
	}
}
