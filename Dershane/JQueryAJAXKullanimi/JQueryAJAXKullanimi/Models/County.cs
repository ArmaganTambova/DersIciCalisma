using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JQueryAJAXKullanimi.Models
{
	public class County
	{
		public int ID { get; set; }
        
		public string Name { get; set; }

		public int? City_ID { get; set; }
		[ForeignKey("City_ID")]

		public virtual City City { get; set; }
    }
}