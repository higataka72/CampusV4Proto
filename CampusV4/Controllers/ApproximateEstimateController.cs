using CampusV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;


namespace CampusV4.Controllers
{
    public class ApproximateEstimateController : Controller
    {
        // GET: ApproximateEstimate
        public ActionResult ConditionSpecification()
        {
            return View();
        }

        public ActionResult PartsList()
        {
            ModelState.Clear();
            ApproximateEstimateViewModel model = new ApproximateEstimateViewModel();
            model.InquiryNo = "";
            model.GroupingMark = "";
            model.ProductionNumber = "";
            model.RegistDate = DateTime.Now;
            model.Subject = "";
            model.Quantity = "";
            model.Unit = "";
            model.DeadlineDate = DateTime.Now;
            model.HinsyuCode = "";
            model.Hinmei = "";
            model.ManagerCode = "";
            model.ManagerName = "";
            model.Notes = "";
            model.SimilarProductNo = "0000002055A";
            model.TotalAmount = "185,000";
            // 部品記号を取得
            var GroupingMarkDataList = new List<GroupingMarkData>();
            GroupingMarkDataList.Add(new GroupingMarkData("　", ""));
            GroupingMarkDataList.Add(new GroupingMarkData("A", "A"));
            GroupingMarkDataList.Add(new GroupingMarkData("B", "B"));
            GroupingMarkDataList.Add(new GroupingMarkData("C", "C"));
            GroupingMarkDataList.Add(new GroupingMarkData("D", "D"));
            GroupingMarkDataList.Add(new GroupingMarkData("E", "E"));
            model.GroupingMarkList = GroupingMarkDataList;
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
            // 担当者情報を取得
            var SalesPersondataList = new List<SalesPersonData>();
            SalesPersondataList.Add(new SalesPersonData("　", ""));
            SalesPersondataList.Add(new SalesPersonData("USR00001", "佐藤　一郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00002", "佐藤　次郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00003", "佐藤　三郎"));
            SalesPersondataList.Add(new SalesPersonData("USR00004", "佐藤　四朗"));
            SalesPersondataList.Add(new SalesPersonData("USR00005", "佐藤　五郎"));
            model.ManagerDataList = SalesPersondataList;
            //部品リスト
            var dataList = new List<ApproximateEstimatePartsListData>();
            dataList.Add(new ApproximateEstimatePartsListData("★","1", "A", "Upper Main Cavity", "001602-A-B001", "2", "8", "10,000", "160,000", "2024/01/20", "パートナー工場A", "出来る限り早めに", "KYOTO", "000003655A"));
            dataList.Add(new ApproximateEstimatePartsListData("","2", "B", "Upper Cull Block", "001602-A-B002", "5", "5", "1,000", "25,000", "2024/01/20", "パートナー工場A", "出来る限り早めに", "KYOTO", "000003655A"));
            model.PartsList = dataList;
            return View(model);
        }

        [HttpPost]
        public JsonResult GetProductNumberSpecificationData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<ProductNumberSpecificationData>();
            dataList.Add(new ProductNumberSpecificationData("京都金型工業", "000012345A01","1","1,000,000", "1,000,000","2022/10/09","2023/01/20","0000100001","500,000","50"));
            dataList.Add(new ProductNumberSpecificationData("大阪金型工業", "000012346A01", "1", "2,000,000", "2,000,000", "2022/10/09", "2023/01/20", "0000100001", "1,000,000", "50"));
            dataList.Add(new ProductNumberSpecificationData("兵庫金型工業", "000012347A01", "1", "3,000,000", "3,000,000", "2022/10/09", "2023/01/20", "0000100001", "1,500,000", "50"));
            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetEstimateAnswerData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<EstimateAnswerData>();
            dataList.Add(new EstimateAnswerData("1", "パートナー工場A", "10,000", "160,000", "2024/01/24", "前回と同じく見積"));
            dataList.Add(new EstimateAnswerData("2", "パートナー工場B", "9,800", "156,800", "2024/02/01",""));
            dataList.Add(new EstimateAnswerData("3", "パートナー工場C", "12,000", "192,000", "2024/01/24","単価は上がります"));
            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetPartsListData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<ApproximateEstimatePartsListData>();
            string str = sz.Serialize(dataList);
            return Json(str);
        }

        private void GetDataList(ref ApproximateEstimateViewModel model)
        {

            //部品リスト
            var dataList = new List<ApproximateEstimatePartsListData>();
            dataList.Add(new ApproximateEstimatePartsListData("★","1","A", "Upper Main Cavity", "001602-A-B001","2","8", "10000","160000","2024/01/20", "パートナー工場A","出来る限り早めに","KYOTO","SS"));
            dataList.Add(new ApproximateEstimatePartsListData("","1", "B", "Upper Cull Block", "001602-A-B002", "5", "5", "1000", "25000", "2024/01/20", "パートナー工場A", "出来る限り早めに", "KYOTO", ""));
            model.PartsList = dataList;

        }
    }
}