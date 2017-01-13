using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Data.Entities
{
	public class Campaign
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(255)]
		public string CampaignName { get; set; }

		public DateTime Date { get; set; }

		public int Clicks { get; set; }

		public int Conversions { get; set; }

		public int Impressions { get; set; }

		[MaxLength(255)]
		public string AffiliateName { get; set; }
	}
}
