using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DevTest.Data.DAL;
using DevTest.Data.Entities;
using DevTest.Services.Generic;
using Splats.Services;

namespace DevTest.Web.Areas.Campaigns.Controllers
{
    public class CampaignsController : Controller
    {
		#region Properties
		private readonly UnitOfWork _unitOfWork;
		#endregion

		public CampaignsController(UnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}

		// GET: Campaigns/Campaigns
		public ActionResult Index()
        {
            return View(this._unitOfWork.CampaignService.Get());
        }

        // GET: Campaigns/Campaigns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = this._unitOfWork.CampaignService.GetBy(id.Value);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        // GET: Campaigns/Campaigns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Campaigns/Campaigns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CampaignName,Date,Clicks,Conversions,Impressions,AffiliateName")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
				this._unitOfWork.CampaignService.Insert(campaign);
				return RedirectToAction("Index");
            }

            return View(campaign);
        }

        // GET: Campaigns/Campaigns/Edit/5
        public ActionResult Edit(int? id)
        {
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			var serie = this._unitOfWork.CampaignService.GetBy(id.Value);

			if (serie == null)
			{
				return HttpNotFound();
			}

			return PartialView(serie);
		}

        // POST: Campaigns/Campaigns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CampaignName,Date,Clicks,Conversions,Impressions,AffiliateName")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
				this._unitOfWork.CampaignService.Update(campaign);
				return RedirectToAction("Index");
            }
            return View(campaign);
        }

        // GET: Campaigns/Campaigns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
			Campaign campaign = this._unitOfWork.CampaignService.GetBy(id.Value);
			if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        // POST: Campaigns/Campaigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			this._unitOfWork.CampaignService.Delete(id);
			return RedirectToAction("Index");
        }
    }
}
