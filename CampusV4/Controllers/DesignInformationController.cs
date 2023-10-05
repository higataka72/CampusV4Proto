using System;
using System.Collections.Generic;
using System.Web.Mvc;
using CampusV4.Models;
using Microsoft.Ajax.Utilities;

namespace CampusV4.Controllers
{
    public class DesignInformationController : Controller
    {
        // GET: DesignInformation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DesignInformation()
        {
            var model = new DesignInformationViewModel();

            //model.Quantity = 0;
            model.DrawingScheduleDate = DateTime.Now;
            model.DrawingDate = DateTime.Now;
            model.InspectionDate = DateTime.Now;
            model.CreateScheduleDate = DateTime.Now;
            model.CreateDate = DateTime.Now;
            GetCompDataList(ref model, true);

            return View(model);
        }

        [HttpPost]
        public ActionResult DesignInformation(DesignInformationViewModel model)
        {
            GetCompDataList(ref model, true);
            GetInitData(ref model);

            return View(model);
        }

        //リストボックス値取得
        private void GetCompDataList(ref DesignInformationViewModel model, Boolean flgInitList)
        {
            // 共通項目
            // 部品記号を取得
            var GroupingMarkDataList = new List<GroupingMarkData>();
            GroupingMarkDataList.Add(new GroupingMarkData("　", ""));
            GroupingMarkDataList.Add(new GroupingMarkData("A", "A"));
            GroupingMarkDataList.Add(new GroupingMarkData("B", "B"));
            GroupingMarkDataList.Add(new GroupingMarkData("C", "C"));
            GroupingMarkDataList.Add(new GroupingMarkData("D", "D"));
            GroupingMarkDataList.Add(new GroupingMarkData("E", "E"));
            model.GroupingMarkList = GroupingMarkDataList;

            // 営業担当者情報を取得
            var TantoshaData = new List<EmployeeData>();
            TantoshaData.Add(new EmployeeData("　", ""));
            TantoshaData.Add(new EmployeeData("USR00001", "佐藤　一郎"));
            TantoshaData.Add(new EmployeeData("USR00002", "佐藤　次郎"));
            TantoshaData.Add(new EmployeeData("USR00003", "佐藤　三郎"));
            TantoshaData.Add(new EmployeeData("USR00004", "佐藤　四朗"));
            TantoshaData.Add(new EmployeeData("USR00005", "佐藤　五郎"));
            model.EmployeeDataList = TantoshaData;

        }

        private void GetInitData(ref DesignInformationViewModel model)
        {
            //引合番号
            model.InquiryNo2 = "0000003655";
            //部品記号
            model.GroupingMark = "A";
            //件名
            model.Subject2 = "金型受注の依頼";
            //設計担当者(主)
            model.Manager1Code = "USR00001";
            //設計担当者名(主)
            model.Manager1Name = "佐藤　一郎";
            //出図予定日
            model.DrawingScheduleDate = DateTime.Parse("2023/06/23");
            //設計担当者(従)
            model.Manager2Code = "USR00002";
            //設計担当者名(従)
            model.Manager2Name = "佐藤　次郎";
            //出図日
            model.DrawingDate = DateTime.Parse("2023/06/23");
            //検図担当者
            model.Manager3Code = "USR00003";
            //検図担当者名
            model.Manager3Name = "佐藤　三郎";
            //検図日
            model.InspectionDate = DateTime.Parse("2023/06/23");
            //原価資料担当者
            model.Manager4Code = "USR00004";
            //原価資料担当者名
            model.Manager4Name = "佐藤　四朗";
            //作成予定日
            model.CreateScheduleDate = DateTime.Parse("2023/06/23");
            //作成日
            model.CreateDate = DateTime.Parse("2023/06/23");
        }
    }
}