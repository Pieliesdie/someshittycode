using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Common;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private IData data;

        public UserController()
        {
            data = new UsersAndRewardsDataProvider(UsersAndRewardsDataProvider.MemoryType.DataBase);
        }

        public ActionResult Index()
        {
            return View(data.GetUsers());
        }
        [HttpGet]
        public ActionResult Details(User user)
        {
            return View(user);
        }

        public ActionResult Delete(int userId)
        {
            data.DeleteUser(userId);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Common.User user)
        {
            return View("Create",user);
        }

        [HttpPost]
        public ActionResult Edit(User user,List<int> rewards,List<int> removeRewards)
        {
            if (rewards != null)
            {
                data.AddRewardToUser(user.ID, rewards);
            }
            if (removeRewards != null)
            {
                foreach (var i in removeRewards)
                {
                    data.DeleteRewardFromUser(user.ID, i);
                }
            }
            data.UpdateUser(user);
            return View("Index",data.GetUsers());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Common.User user,List<int> rewards)
        {
            if (ModelState.IsValid)
            {
                data.AddUser(user, rewards);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}