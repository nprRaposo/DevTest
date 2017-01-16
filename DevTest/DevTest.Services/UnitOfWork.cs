using DevTest.Data.DAL;
using DevTest.Data.Entities;
using DevTest.Services.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splats.Services
{
	public class UnitOfWork : IDisposable
	{
		protected DevTestContext _context;
		private Service<Campaign> _campaignService;

		public UnitOfWork(DevTestContext context)
		{
			this._context = context;
		}

		public Service<Campaign> CampaignService
		{
			get
			{

				if (this._campaignService == null)
				{
					var repository = new Repository<Campaign>(this._context);
					this._campaignService = new Service<Campaign>(repository);
				}
				return this._campaignService;
			}
		}

		public void Save()
		{
			this._context.SaveChanges();
		}

		private bool disposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this._context.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			this._context.Dispose();
		}
	}
}
