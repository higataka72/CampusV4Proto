using CampusV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CampusV4.Controllers
{
    public class InquiryCostEstimateController : Controller
    {


        // GET: InquiryCostEstimate
        public ActionResult Index()
        {
            var model = new InquiryCostEstimateViewModel();
            // 分類記号
            var ClassificationdataList = new List<InguiryCostEstimate_ClassificationData>();
            ClassificationdataList.Add(new InguiryCostEstimate_ClassificationData("　", ""));
            ClassificationdataList.Add(new InguiryCostEstimate_ClassificationData("A", "半導体金型・部品"));
            ClassificationdataList.Add(new InguiryCostEstimate_ClassificationData("B", "Chase Holder"));
            ClassificationdataList.Add(new InguiryCostEstimate_ClassificationData("C", "Kit"));
            ClassificationdataList.Add(new InguiryCostEstimate_ClassificationData("D", "装置ユニット・装置部品"));
            ClassificationdataList.Add(new InguiryCostEstimate_ClassificationData("E", "打抜金型・部品"));
            ClassificationdataList.Add(new InguiryCostEstimate_ClassificationData("G", "LED金型・部品"));
            ClassificationdataList.Add(new InguiryCostEstimate_ClassificationData("H", "車載用金型・部品"));
            model.ClassificationDataList = ClassificationdataList;

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

            model.ClassificationSymbol = "A";
            return View(model);
        }

        public ActionResult EstimateReply(string partsClass, string partsName)
        {
            var model = new InquiryCostEstimateViewModel();
            var dataList = new List<EstimateReplyData>();
            dataList.Add(new EstimateReplyData("0000023452", "0000023534", "（株）阿部製作所", "8", "", "1", "", "概算", "型一式", "", "8", "280,000", "2,240,000", "2023/12/20", "2,300,000", "2023/12/21", "-60,000", true, 4, false));
            dataList.Add(new EstimateReplyData("0000023463", "0000023675", "（株）ゲートジャパン", "8", "", "1", "", "概算", "サンプル加工", "", "8", "295,000", "2,360,000", "2023/12/15", "2,300,000", "2023/12/21", "60,000", false, 0, false));
            dataList.Add(new EstimateReplyData("0000023464", "0000237874", "（株）メイホー", "8", "", "1", "非表示", "概算", "型一式", "辞退", "", "", "", "", "", "", "", false, 0, false));
            model.EstimateReplyDataList = dataList;

            model.selectPartsClass = partsClass;
            model.selectPartsName = partsName;

            return View(model);
        }

        [HttpPost]
        public ActionResult EstimateReplyAll()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<EstimateReplyData>();
            dataList.Add(new EstimateReplyData("0000023452", "0000023534", "（株）阿部製作所", "8", "", "1", "", "概算", "型一式", "", "8", "280,000", "2,240,000", "2023/12/20", "2,300,000", "2023/12/21", "-60,000", true, 4, false));
            dataList.Add(new EstimateReplyData("0000023463", "0000023675", "（株）ゲートジャパン", "8", "", "1", "", "概算", "サンプル加工", "", "8", "295,000", "2,360,000", "2023/12/15", "2,300,000", "2023/12/21", "60,000", false, 0, false));
            dataList.Add(new EstimateReplyData("0000023464", "0000237874", "（株）メイホー", "8", "", "1", "非表示", "概算", "型一式", "辞退", "", "", "", "", "", "", "", false, 0, false));
            string str = sz.Serialize(dataList);
            return Json(str);
        }


        [HttpPost]
        public ActionResult EstimateReplyDisplay()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<EstimateReplyData>();
            dataList.Add(new EstimateReplyData("0000023452", "0000023534", "（株）阿部製作所", "8", "", "1", "", "概算", "型一式", "", "8", "280,000", "2,240,000", "2023/12/20", "2,300,000", "2023/12/21", "-60,000", true, 4, false));
            dataList.Add(new EstimateReplyData("0000023463", "0000023675", "（株）ゲートジャパン", "8", "", "1", "", "概算", "サンプル加工", "", "8", "295,000", "2,360,000", "2023/12/15", "2,300,000", "2023/12/21", "60,000", false, 0, false));
            string str = sz.Serialize(dataList);
            return Json(str);
        }

        public ActionResult MailManager()
        {
            var model = new InquiryCostEstimateViewModel();
            var dataList = new List<MailManagerData>();
            dataList.Add(new MailManagerData("（株）阿部製作所", "採用", "test001@test.com", "", "採択結果", "採用となりました"));
            dataList.Add(new MailManagerData("（株）ゲートジャパン", "採用", "test001@test.com", "", "採択結果", "採用となりました"));
            dataList.Add(new MailManagerData("（株）メイホー", "不採用", "test001@test.com", "", "採択結果", "不採用となりました"));

            model.MailManagerDataList = dataList;

            return View(model);
        }

        public ActionResult MailSendHistory()
        {
            var model = new InquiryCostEstimateViewModel();
            var dataList = new List<MailSendHistoryData>();
            dataList.Add(new MailSendHistoryData("2023/07/01 12:20:01", "送信済", "パートナー工場", "1000100001", "（株）大阪製作所", "test001@test.com", "", "不採用メール", "採択結果", "不採用となりました"));
            dataList.Add(new MailSendHistoryData("2023/07/01 12:20:02", "送信済", "パートナー工場", "1000100002", "（株）京都製作所", "test001@test.com", "", "不採用メール", "採択結果", "不採用となりました"));
            dataList.Add(new MailSendHistoryData("2023/07/02 15:00:05", "送信済", "パートナー工場", "1000100003", "（株）兵庫工業", "test001@test.com", "", "不採用メール", "採択結果", "不採用となりました"));
            model.MailSendHistoryDataList = dataList;

            var dataList1 = new List<MailCategoryData>();
            dataList1.Add(new MailCategoryData("1", "　"));
            dataList1.Add(new MailCategoryData("2", "採用メール"));
            dataList1.Add(new MailCategoryData("", "不採用メール"));
            model.MailCategoryDataList = dataList1;

            model.SendDateFrom = DateTime.Now;
            model.SendDateTo = DateTime.Now;

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

        [HttpPost]
        public JsonResult GetAssemblableReferenceData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<AssemblableReferenceData>();
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());
            dataList.Add(new AssemblableReferenceData());

            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetInquiryCostEstimateData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<InquiryCostEstimateData>();
            dataList.Add(new InquiryCostEstimateData("1", "1", "A", "Upper Main Cavity", "001602-A-B001", true, "D", "2", "8", 300000, "3", "4", "1,120,000", "2023/12/20", "", " ", "〇"));
            dataList.Add(new InquiryCostEstimateData("2", "2", "B", "Upper Cull Block", "001602-A-B002", false, "A", "1", "2", 260000, "1", "0", "", "", "在庫品引当", " ", "〇"));
            dataList.Add(new InquiryCostEstimateData("3", "5", "D", "Upper Holder Vase", "001602-A-B003", false, "E", "1", "2", 150000, "1", "0", "", "", "", " ", "〇"));
            dataList.Add(new InquiryCostEstimateData("4", "8", "A", "Lower Main Cavity", "001602-A-B004_1", false, "B", "1", "2", 350000, "1", "0", "", "", "", " ", "〇"));
            dataList.Add(new InquiryCostEstimateData("5", "9", "A", "Lower Main Cavity", "001602-A-B004_2", false, "B", "1", "2", 350000, "1", "0", "", "", "", " ", "〇"));
            dataList.Add(new InquiryCostEstimateData("6", "12", "B", "Lower Port Block", "001602-A-B005", false, "A", "1", "2", 100000, "1", "0", "", "", "", " ", "〇"));

            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetDrawingNumberData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<DrawingNumberData>();
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());
            dataList.Add(new DrawingNumberData());

            string str = sz.Serialize(dataList);
            return Json(str);
        }
        [HttpPost]
        public JsonResult GetEstimateReferenceData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<EstimateReference>();
            dataList.Add(new EstimateReference("1,100", "2023/06/15"));
            dataList.Add(new EstimateReference("1,200", "2023/06/16"));
            dataList.Add(new EstimateReference("1,300", "2023/06/17"));
            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetEstimateSecurityData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<EstimateSecurityData>();
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());
            dataList.Add(new EstimateSecurityData());

            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetInstallmentPaymentData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<InstallmentPaymentData>();
            dataList.Add(new InstallmentPaymentData("1", "4", "280,000", "1,120,000", "2023/12/15"));
            dataList.Add(new InstallmentPaymentData("2", "4", "280,000", "1,120,000", "2023/12/20"));

            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetMailManagerData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<MailManagerData>();
            dataList.Add(new MailManagerData("（株）阿部製作所", "採用", "test001@test.com", "", "採択結果", "採用となりました"));
            dataList.Add(new MailManagerData("（株）ゲートジャパン", "採用", "test002@test.com", "", "採択結果", "採用となりました"));
            dataList.Add(new MailManagerData("（株）メイホー", "不採用", "test003@test.com", "", "採択結果", "不採用となりました"));

            string str = sz.Serialize(dataList);
            return Json(str);
        }
    }
}