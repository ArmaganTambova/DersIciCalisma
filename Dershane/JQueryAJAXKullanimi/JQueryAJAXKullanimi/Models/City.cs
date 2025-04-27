using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQueryAJAXKullanimi.Models
{
	public class City
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public virtual ICollection<County> Countries { get; set; }
    }
}