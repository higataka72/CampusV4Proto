using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using CampusV4.Models;

namespace CampusV4.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
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

        public ActionResult InspectionDetail()
        {
            var model = new OrderViewModel();
            return View(model);
        }

        public ActionResult ProductNumDetail()
        {
            var model = new OrderViewModel();
            var dataList = new List<ProductNumData>();
            dataList.Add(new ProductNumData("000003101", "A", "01", "10", "1,200", "12,000", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "01", "10", "1,200", "12,000", "2023/01/10", "", ""));

            model.ProductNumDataList = dataList;

            return View(model);
        }

        [HttpPost]
        public JsonResult ProductNumDetailData(int mode)
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<ProductNumData>();
            dataList.Add(new ProductNumData("000003101", "A", "01", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "02", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "03", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "04", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "05", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "06", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "07", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "08", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "09", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "A", "10", "1", "1,200", "1,200", "2023/01/10", "", ""));

            dataList.Add(new ProductNumData("000003101", "B", "01", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "02", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "03", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "04", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "05", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "06", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "07", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "08", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "09", "1", "1,200", "1,200", "2023/01/10", "", ""));
            dataList.Add(new ProductNumData("000003101", "B", "10", "1", "1,200", "1,200", "2023/01/10", "", ""));

            string str = sz.Serialize(dataList);
            return Json(str);
        }

        public ActionResult OrderRegist(int mode)
        {
            // モード
            int modeValue = mode;
            var model = new OrderViewModel();

            // 共通項目
            // 分類記号情報を取得
            var ClassificationdataList = new List<Order_ClassificationData>();
            ClassificationdataList.Add(new Order_ClassificationData("　", ""));
            ClassificationdataList.Add(new Order_ClassificationData("A0101", "A1-01記号製"));
            ClassificationdataList.Add(new Order_ClassificationData("A0102", "A1-02記号製"));
            ClassificationdataList.Add(new Order_ClassificationData("A0201", "A2-01記号製"));
            ClassificationdataList.Add(new Order_ClassificationData("B0101", "B1-01記号製"));
            ClassificationdataList.Add(new Order_ClassificationData("B0102", "B1-02記号製"));
            ClassificationdataList.Add(new Order_ClassificationData("B0103", "B1-03記号製"));
            ClassificationdataList.Add(new Order_ClassificationData("B0104", "B1-04記号製"));
            model.ClassificationDataList = ClassificationdataList;

            // 営業担当者情報を取得
            var SalesDataList = new List<Order_SalesData>();
            SalesDataList.Add(new Order_SalesData("　", ""));
            SalesDataList.Add(new Order_SalesData("USR00001", "佐藤　一郎"));
            SalesDataList.Add(new Order_SalesData("USR00002", "佐藤　次郎"));
            SalesDataList.Add(new Order_SalesData("USR00003", "佐藤　三郎"));
            SalesDataList.Add(new Order_SalesData("USR10004", "佐藤　四朗"));
            SalesDataList.Add(new Order_SalesData("USR10005", "佐藤　五郎"));
            model.SalesDataList = SalesDataList;

            // 営業担当者情報を取得
            var ProcurementDataList = new List<Order_ProcurementData>();
            ProcurementDataList.Add(new Order_ProcurementData("　", ""));
            ProcurementDataList.Add(new Order_ProcurementData("USR00001", "佐藤　一郎"));
            ProcurementDataList.Add(new Order_ProcurementData("USR00002", "佐藤　次郎"));
            ProcurementDataList.Add(new Order_ProcurementData("USR00003", "佐藤　三郎"));
            ProcurementDataList.Add(new Order_ProcurementData("USR10004", "佐藤　四朗"));
            ProcurementDataList.Add(new Order_ProcurementData("USR10005", "佐藤　五郎"));
            model.ProcurementDataList = ProcurementDataList;

            // モード対応
            if (modeValue == 1)
            {
                // 登録モード
                model.Mode = "ins";
                model.OrderDate = DateTime.Now;
                model.DeadlineDate = null;
                model.CancelDate = null;
                model.UnofficialNotice = false;
                model.PriorArrangements = 2;
                model.InspectionReport = 2;
                model.CancelFlag = false;
                model.CompletePayment = false;
                model.Rate = 0;
                model.LocalOrdeReceived = 0;
                model.OutsideOrdeReceived = 0;
                model.FinalRate = 0;
                model.FinalLocalOrdeReceived = 0;
                model.FinalOutsideOrdeReceived = 0;

            }
            else if (modeValue == 2)
            {
                // 編集モード
                model.Mode = "upd";
                model.OrderNo = "2101";
                model.InquiryNo = "3101";
                model.OrderDate = DateTime.Parse("2023/04/20");
                model.DefectiveSerialNo = "3101A001";
                model.ApprovalNo = "3101A001-001";
                model.DeadlineDate = DateTime.Parse("2023/06/02");
                model.ContractDeadlineDate = DateTime.Parse("2023/06/02");
                model.ClassificationSymbol = "A0101";
                model.ClosingSerialNo = "A1-01記号製";
                model.PurchaseOrderNo = "A20230501";
                model.SalesPersonCode = "USR00001";
                model.SalesPersonName = "佐藤　一郎";
                model.ProcurementPersonCode = "USR00002";
                model.ProcurementPersonName = "佐藤　次郎";
                model.UnofficialNotice = true;
                model.PriorArrangements = 1;
                model.CancelFlag = true;
                model.CancelDate = DateTime.Parse("2023/05/02");
                model.InspectionReport = 1;
                model.CampusId = "A001";
                model.CompanyName = "株式会社 A社";
                model.Subject = "A機枠組み";
                model.Quantity = "100";
                model.Unit = "10";
                model.Remarks = "コメント";
                model.CompletePayment = true;
                model.Rate = 120;
                model.LocalOrdeReceived = 100000;
                model.OutsideOrdeReceived = 120000;
                model.FinalRate = 120;
                model.FinalLocalOrdeReceived = 100000;
                model.FinalOutsideOrdeReceived = 120000;

            }
            else
            {
                // モードなし
            }


            return View(model);
        }
    }
}