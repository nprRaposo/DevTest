using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DevTest.Data.DAL
{
	public class DevTestContext : DbContext
	{
		private static DevTestContext _instance { get; set; }

		public DevTestContext() : base("DevTestContext")
        {
		}

		public static DevTestContext GetInstance()
		{
			if (_instance == null)
				_instance = new DevTestContext();
			return _instance;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public System.Data.Entity.DbSet<DevTest.Data.Entities.Campaign> Campaigns { get; set; }
	}
}
