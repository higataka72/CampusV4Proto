using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CampusV4.Models;

namespace CampusV4.Controllers
{
    public class InquiryController : Controller
    {
        // GET: Inquiry
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InquiryReceivedDetail()
        {
            var model = new InquiryViewModel();
            model.DetailRequestDate = DateTime.Now;
            // 営業担当者情報を取得
            var SalesPersondataList = new List<SalesPersonData>();
            SalesPersondataList.Add(new SalesPersonData("　", ""));
            SalesPersondataList.Add(new SalesPersonData("USR00001", "佐藤　一郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00002", "佐藤　次郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00003", "佐藤　三郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00004", "佐藤　四朗"));
            SalesPersondataList.Add(new SalesPersonData("USR00005", "佐藤　五郎"));
            model.SalesPersoDataList = SalesPersondataList;
            return View(model);
        }

        public ActionResult Customerinfo()
        {
            var model = new InquiryViewModel();
            model.DetailRequestDate = DateTime.Now;
            model.InquiryNo = "3101";
            model.CompanyName = "株式会社 A社";
            model.Subject = "A機枠組み";
            return View(model);
        }

        [HttpPost]
        public ActionResult FileUpload()
        {
            string fileName = "";
            foreach (string fName in Request.Files)
            {
                fileName = fName;
            }

            return Json(new { Message = fileName });
        }

        [HttpPost]
        public ActionResult FileDelete(string name)
        {
            return Json(new { Message = name });
        }

        public ActionResult InquiryRegist(int mode)
        {
            // モード
            int modeValue = mode;
            var model = new InquiryViewModel();

            // 共通項目
            // 品種情報を取得
            var HinshudataList = new List<HinshuData>();
            HinshudataList.Add(new HinshuData("　", ""));
            HinshudataList.Add(new HinshuData("ZX-A001", "金型A図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-B001", "金型B図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-C001", "金型C図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-D001", "金型D図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-E001", "金型E図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-F001", "金型F図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-G001", "金型G図枠組み"));
            model.HinsyuDataList = HinshudataList;

            // 営業担当者情報を取得
            var SalesPersondataList = new List<SalesPersonData>();
            SalesPersondataList.Add(new SalesPersonData("　", ""));
            SalesPersondataList.Add(new SalesPersonData("USR00001", "佐藤　一郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00002", "佐藤　次郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00003", "佐藤　三郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00004", "佐藤　四朗"));
            SalesPersondataList.Add(new SalesPersonData("USR00005", "佐藤　五郎"));
            model.SalesPersoDataList = SalesPersondataList;

            // モード対応
            if (modeValue == 1)
            {
                // 登録モード
                model.Mode = "ins";
                model.RequestDate = DateTime.Now;
                model.QuotationRequestDate = null;
                model.DesiredDeliveryDate = null;


            } else if (modeValue == 2)
            {
                // 編集モード
                model.Mode = "upd";
                model.InquiryNo = "3101";
                model.UserRequestNo = "1001";
                model.RequestDate = DateTime.Parse("2022/11/01");
                model.CampusId = "A001";
                model.CompanyName = "株式会社 A社";
                model.EmailAddress = "xxxxx@xxx.com";
                model.Subject = "A機枠組み";
                model.HinsyuCode = "ZX-A001";
                model.Hinmei = "金型A図枠組み";
                model.Quantity = "100";
                model.Unit = "10";
                model.ContentValue = "最短納期を検討中";
                model.Attached1 = "A機パネル１図面.xlsx";
                model.Attached2 = "A機パネル２図面.xlsx";
                model.Attached3 = "";
                model.QuotationRequestDate = DateTime.Parse("2022/11/05");
                model.DesiredDeliveryDate = DateTime.Parse("2022/12/20");
                model.ReferenceEstimateNo = "B10";

                model.DetailRequestDate = DateTime.Now;
            }
            else
            {
                // モードなし
            }

            
            return View(model);
        }
    }
}