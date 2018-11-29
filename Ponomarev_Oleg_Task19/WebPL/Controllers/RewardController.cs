using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Common;

namespace WebApplication1.Controllers
{
    public class RewardController : Controller
    {
        private IData data;

        public RewardController()
        {
            data = new UsersAndRewardsDataProvider(UsersAndRewardsDataProvider.MemoryType.DataBase);
        }
        // GET: Reward
        public ActionResult Index()
        {
            return View(data.GetRewards());
        }
        [HttpGet]
        public ActionResult Delete(int idReward)
        {
            data.DeleteReward(idReward);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Common.Reward reward)
        {
            data.AddReward(reward);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Common.Reward reward)
        {
            return View("Create", reward);
        }

        [HttpPost]
        public ActionResult Edit(Reward reward,string id)
        {
            if (reward.Decription == null)
            {
                reward.Decription = String.Empty;
            }
            data.UpdateReward(reward);
            return RedirectToAction("Index");
        }
    }
}