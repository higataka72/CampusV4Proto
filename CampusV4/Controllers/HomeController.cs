using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CampusV4.Models;

namespace CampusV4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel();
            var dataList = new List<ManagerIndexGridData>();
            dataList.Add(new ManagerIndexGridData("有", "0001A01-01", "受", "内", "2021/12/15", "株式会社CAPABLE", "インジェクション", "佐藤 一郎"));
            dataList.Add(new ManagerIndexGridData("有", "0001A01-01", "受", "内", "2021/12/15", "株式会社CAPABLE", "インジェクション", "佐藤 一郎"));
            dataList.Add(new ManagerIndexGridData("無", "0001A01-01", "受", "内", "2021/12/15", "株式会社CAPABLE", "インジェクション", "佐藤 一郎"));
            dataList.Add(new ManagerIndexGridData("有", "0001A01-01", "受", "内", "2021/12/15", "株式会社CAPABLE", "インジェクション", "佐藤 一郎"));
            model.ManagerIndexDataList = dataList;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "アプリケーション説明ページ。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "連絡先ページ。";

            return View();
        }
    }
}