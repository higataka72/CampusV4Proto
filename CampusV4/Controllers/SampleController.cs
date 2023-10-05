using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CampusV4.Models;

namespace CampusV4.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            var model = new Sample1ViewModel();
            var dataList = new List<IndexGridData>();
            dataList.Add(new IndexGridData("1", "A", "Upper Main Cavity A", "1","2","10","2023/01/01", "2023/01/02"));
            dataList.Add(new IndexGridData("2", "B", "Upper Cull Block B", "3", "4", "20", "2023/02/01", "2023/02/02"));
            dataList.Add(new IndexGridData("3", "C", "Upper Main Cavity C", "5", "6", "30", "2023/03/01", "2023/03/02"));
            dataList.Add(new IndexGridData("4", "D", "Upper Cull Block D", "1", "2", "40", "2023/04/01", "2023/04/02"));
            dataList.Add(new IndexGridData("5", "A", "Upper Main Cavity A", "3", "4", "50", "2023/05/01", "2023/05/02"));
            dataList.Add(new IndexGridData("6", "B", "Upper Cull Block B", "5", "6", "60", "2023/06/01", "2023/06/02"));
            dataList.Add(new IndexGridData("7", "C", "Upper Main Cavity C", "1", "2", "70", "2023/07/01", "2023/07/02"));
            dataList.Add(new IndexGridData("8", "D", "Upper Cull Block D", "3", "4", "80", "2023/08/01", "2023/08/02"));

            model.IndexDataList = dataList;

            var subDataList = new List<DialogGridData>();
            subDataList.Add(new DialogGridData());
            subDataList.Add(new DialogGridData());
            subDataList.Add(new DialogGridData());
            subDataList.Add(new DialogGridData());
            subDataList.Add(new DialogGridData());
            subDataList.Add(new DialogGridData());
            subDataList.Add(new DialogGridData());
            subDataList.Add(new DialogGridData());

            model.DialogDataList = subDataList;

            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Input1()
        {
            return View();
        }

        public ActionResult InquiryRegister()
        {
            return View();
        }

        public ActionResult Input2()
        {
            var model = new Sample1ViewModel();
            var dataList = new List<SeibanData>();
            dataList.Add(new SeibanData("1"));
            dataList.Add(new SeibanData("2"));
            dataList.Add(new SeibanData("3"));
            dataList.Add(new SeibanData("4"));
            dataList.Add(new SeibanData("5"));
            dataList.Add(new SeibanData("6"));
            dataList.Add(new SeibanData("7"));
            dataList.Add(new SeibanData("8"));
            dataList.Add(new SeibanData("9"));
            dataList.Add(new SeibanData("10"));

            model.GridDataList = dataList;
            return View(model);
        }

        public ActionResult Input3()
        {
            var model = new Sample2ViewModel();
            var dataList = new List<MitsumoriData>();
            dataList.Add(new MitsumoriData("001"));
            dataList.Add(new MitsumoriData("002"));
            dataList.Add(new MitsumoriData("003"));
            dataList.Add(new MitsumoriData("004"));
            dataList.Add(new MitsumoriData("005"));
            dataList.Add(new MitsumoriData("006"));
            dataList.Add(new MitsumoriData("007"));
            dataList.Add(new MitsumoriData("008"));
            dataList.Add(new MitsumoriData("009"));
            dataList.Add(new MitsumoriData("010"));

            model.GridDataList = dataList;
            return View(model);
        }

    }
}