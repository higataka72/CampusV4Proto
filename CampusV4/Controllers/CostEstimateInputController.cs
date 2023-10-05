using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using CampusV4.Models;
using Microsoft.Ajax.Utilities;

namespace CampusV4.Controllers
{
    public class CostEstimateInputController : Controller
    {
        // GET: CostEstimateInput
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

        public ActionResult CostEstimateInput(int mode = 0)
        {
            var model = new CostEstimateInputViewModel();

            // 画面モード
            model.Mode = (mode == 0) ? "0" : "1";

            // 画面値
            if (model.Mode == "0")
            {
                model.RequestedDate = DateTime.Now;
                model.DeliveryDate = DateTime.Now;
                model.EstimateAnswerDate = DateTime.Now;
                model.ProcessingType = 1;
                model.EstimateType = 1;
                model.ProcessingType = 1;
                model.ProcessingTypeName = "その他";
                model.EstimateType = 0;
                model.DrawingScheduleDate = DateTime.Now;
                model.DrawingScheduleDate2 = DateTime.Now;
                model.ShipDate = DateTime.Now;

                GetDataList(ref model, true);
            } else
            {
                model.EstimateNo = "0000023452";
                model.InquiryNo = "000000123";
                model.ClassificationSymbol = "A";
                model.ClassificationSymbolName = "半導体金型・部品";
                model.SerialNo = "000000123A";
                model.Subject = "原価見積の依頼分";
                model.Release = true;
                model.DesignPersonCode = "USR00001";
                model.DesignPersonName = "佐藤　一郎";
                model.TestAssemblyPersonCode = "USR00002";
                model.TestAssemblyPersonName = "佐藤　次郎";
                model.RequestedDate = DateTime.Parse("2023/05/02");
                model.DeliveryDate = DateTime.Parse("2023/06/02");
                model.EstimateAnswerDate = DateTime.Parse("2023/05/10");
                model.Attached1 = "設計書1.xlsx";
                model.ProcessingType = 1;
                model.ProcessingTypeName = "その他";
                model.EstimateType = 1;
                model.DrawingScheduleDate = DateTime.Parse("2023/05/03");
                model.Remarks = "1.購入品ボルトの強度区分は12.9以上とし、適応外品は10.9以上の黒ボルトを選択のこと。\n" +
                               "2.Main Cavity Blockは、上下AS状態で、枝番-1を左側、-2を右側にASすること。";
                GetDataList(ref model, false);
            }
            
            return View(model);
        }

        [HttpPost]
        public ActionResult CostEstimateInput(CostEstimateInputViewModel model)
        {
            if (model.InquiryNo.IsNullOrWhiteSpace())
            {
                ModelState.Clear();
                model = new CostEstimateInputViewModel();
                model.RequestedDate = DateTime.Now;
                model.DeliveryDate = DateTime.Now;
                model.EstimateAnswerDate = DateTime.Now;
                model.EstimateType = 1;
                model.ProcessingType = 1;
                model.ProcessingTypeName = "その他";
                model.DrawingScheduleDate = DateTime.Now;
                model.DrawingScheduleDate = DateTime.Now;
                model.DrawingScheduleDate2 = DateTime.Now;
                model.ShipDate = DateTime.Now;
                GetDataList(ref model, true);
            }
            else
            {
                // 画面値
                model.EstimateNo = "0000023452";
                model.InquiryNo = "000000123";
                model.ClassificationSymbol = "A";
                model.ClassificationSymbolName = "半導体金型・部品";
                model.SerialNo = "000000123A";
                model.Subject = "原価見積の依頼分";
                model.Release = true;
                model.DesignPersonCode = "USR00001";
                model.DesignPersonName = "佐藤　一郎";
                model.TestAssemblyPersonCode = "USR00002";
                model.TestAssemblyPersonName = "佐藤　次郎";
                model.RequestedDate = DateTime.Parse("2023/05/02");
                model.DeliveryDate = DateTime.Parse("2023/06/02");
                model.EstimateAnswerDate = DateTime.Parse("2023/05/10");
                model.Attached1 = "設計書1.xlsx";
                model.ProcessingType = 1;
                model.ProcessingTypeName = "その他";
                model.EstimateType = 1;
                model.DrawingScheduleDate = DateTime.Parse("2023/05/03");
                model.Remarks = "1.購入品ボルトの強度区分は12.9以上とし、適応外品は10.9以上の黒ボルトを選択のこと。\n" +
                               "2.Main Cavity Blockは、上下AS状態で、枝番-1を左側、-2を右側にASすること。";
                GetDataList(ref model, false);

            }

            return View(model);
        }

        public ActionResult FactorySelection(int mode = 0)
        {
            var model = new CostEstimateInputViewModel();
            // 画面モード
            model.Mode = (mode == 0) ? "0" : "1";

            if (model.Mode == "0")
            {
            }
            else
            {
                // パートナー工場データ
                var partnerDataList = new List<CostEstimate_PartnerListData>();
                partnerDataList.Add(new CostEstimate_PartnerListData(false, 1, "パートナー工場A", "佐藤 一郎", "有償", 80, 98, 98, 95, 93, 92));
                partnerDataList.Add(new CostEstimate_PartnerListData(false, 2, "パートナー工場B", "佐藤 次郎", "無償", 98, 81, 82, 83, 84, 95));
                model.GridPartnerListDataList = partnerDataList;

                // パートナー工場グローバルデータ
                var grobalDataList = new List<CostEstimate_GrobalListData>();
                grobalDataList.Add(new CostEstimate_GrobalListData(1, "http://capableeng.com/portalcampus/campus.html", "金型", "ポータル"));
                grobalDataList.Add(new CostEstimate_GrobalListData(2, "http://capableeng.com/portalcampus/campus.html", "金型", "ポータル"));
                model.GridGrobalListDataList = grobalDataList;

            }

            return View(model);
        }

        public ActionResult ConditionsMaintenance()
        {
            var model = new CostEstimateInputViewModel();
            return View(model);
        }

        [HttpPost]
        public JsonResult GetCostEstimateData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<CostEstimate_PartsListData>();
            CostEstimate_PartsListData partsListData = new CostEstimate_PartsListData();
            //行番号
            partsListData.RowNumber = 1;
            //部品分類
            partsListData.PartsCode = "A";
            //部品名
            partsListData.PartsName = "Upper Main Cavity";
            //図面番号/型式
            partsListData.DrawingNumber = "001602-A-B001";
            //入数
            partsListData.IriSu = 2;
            //個数
            partsListData.Kosu = 5;
            //単位
            partsListData.Tani = "式";
            //表面処理コード
            partsListData.SurfaceCode = "1001";
            //表面処理
            partsListData.SurfaceProcess = "表面処理A";
            dataList.Add(partsListData);

            CostEstimate_PartsListData partsListData1 = new CostEstimate_PartsListData();
            //行番号
            partsListData1.RowNumber = 2;
            //部品分類
            partsListData1.PartsCode = "B";
            //部品名
            partsListData1.PartsName = "Upper Cull Block";
            //図面番号/型式
            partsListData1.DrawingNumber = "001602-A-B002";
            //入数
            partsListData1.IriSu = 5;
            //個数
            partsListData1.Kosu = 5;
            //単位
            partsListData1.Tani = "式";
            //表面処理コード
            partsListData1.SurfaceCode = "1002";
            //表面処理
            partsListData1.SurfaceProcess = "表面処理B";
            dataList.Add(partsListData1);

            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetPartnerData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<CostEstimate_PartnerListData>();
            dataList.Add(new CostEstimate_PartnerListData(false, 1, "パートナー工場A", "佐藤 一郎", "有償", 80, 98, 98, 95, 93, 92));
            dataList.Add(new CostEstimate_PartnerListData(false, 2, "パートナー工場B", "佐藤 次郎", "無償", 98, 81, 82, 83, 84, 95));
            string str = sz.Serialize(dataList);
            return Json(str);
        }

        [HttpPost]
        public JsonResult GetGrobalData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<CostEstimate_GrobalListData>();
            dataList.Add(new CostEstimate_GrobalListData(1, "http://capableeng.com/portalcampus/campus.html", "金型", "ポータル"));
            dataList.Add(new CostEstimate_GrobalListData(2, "http://capableeng.com/portalcampus/campus.html", "金型", "ポータル"));

            string str = sz.Serialize(dataList);
            return Json(str);
        }

        private void GetDataList(ref CostEstimateInputViewModel model, Boolean flgInitList)
        {
            // 分類記号
            var ClassificationdataList = new List<CostEstimate_ClassificationData>();
            ClassificationdataList.Add(new CostEstimate_ClassificationData("　", ""));
            ClassificationdataList.Add(new CostEstimate_ClassificationData("A", "半導体金型・部品"));
            ClassificationdataList.Add(new CostEstimate_ClassificationData("B", "Chase Holder"));
            ClassificationdataList.Add(new CostEstimate_ClassificationData("C", "Kit"));
            ClassificationdataList.Add(new CostEstimate_ClassificationData("D", "装置ユニット・装置部品"));
            ClassificationdataList.Add(new CostEstimate_ClassificationData("E", "打抜金型・部品"));
            ClassificationdataList.Add(new CostEstimate_ClassificationData("G", "LED金型・部品"));
            ClassificationdataList.Add(new CostEstimate_ClassificationData("H", "車載用金型・部品"));
            model.ClassificationDataList = ClassificationdataList;

            // 品種
            var HinshudataList = new List<CostEstimate_HinshuData>();
            HinshudataList.Add(new CostEstimate_HinshuData("　", ""));
            HinshudataList.Add(new CostEstimate_HinshuData("ZX-A001", "金型A図枠組み"));
            HinshudataList.Add(new CostEstimate_HinshuData("ZX-B001", "金型B図枠組み"));
            HinshudataList.Add(new CostEstimate_HinshuData("ZX-C001", "金型C図枠組み"));
            HinshudataList.Add(new CostEstimate_HinshuData("ZX-D001", "金型D図枠組み"));
            HinshudataList.Add(new CostEstimate_HinshuData("ZX-E001", "金型E図枠組み"));
            HinshudataList.Add(new CostEstimate_HinshuData("ZX-F001", "金型F図枠組み"));
            HinshudataList.Add(new CostEstimate_HinshuData("ZX-G001", "金型G図枠組み"));
            model.HinsyuDataList = HinshudataList;

            // 設計担当者情報を取得
            var DesignPersonDataList = new List<CostEstimate_DesignPersonData>();
            DesignPersonDataList.Add(new CostEstimate_DesignPersonData("　", ""));
            DesignPersonDataList.Add(new CostEstimate_DesignPersonData("USR00001", "佐藤　一郎"));
            DesignPersonDataList.Add(new CostEstimate_DesignPersonData("USR00002", "佐藤　次郎"));
            DesignPersonDataList.Add(new CostEstimate_DesignPersonData("USR00003", "佐藤　三郎"));
            DesignPersonDataList.Add(new CostEstimate_DesignPersonData("USR10004", "佐藤　四朗"));
            DesignPersonDataList.Add(new CostEstimate_DesignPersonData("USR10005", "佐藤　五郎"));
            model.DesignPersonDataList = DesignPersonDataList;

            // 検査組立担当者情報を取得
            var TestAssemblyPersonDataList = new List<CostEstimate_TestAssemblyPersonData>();
            TestAssemblyPersonDataList.Add(new CostEstimate_TestAssemblyPersonData("　", ""));
            TestAssemblyPersonDataList.Add(new CostEstimate_TestAssemblyPersonData("USR00001", "佐藤　一郎"));
            TestAssemblyPersonDataList.Add(new CostEstimate_TestAssemblyPersonData("USR00002", "佐藤　次郎"));
            TestAssemblyPersonDataList.Add(new CostEstimate_TestAssemblyPersonData("USR00003", "佐藤　三郎"));
            TestAssemblyPersonDataList.Add(new CostEstimate_TestAssemblyPersonData("USR10004", "佐藤　四朗"));
            TestAssemblyPersonDataList.Add(new CostEstimate_TestAssemblyPersonData("USR10005", "佐藤　五郎"));
            model.TestAssemblyPersonDataList = TestAssemblyPersonDataList;

            var dataList = new List<CostEstimate_PartsListData>();
            if (flgInitList == true)
            {
                //空行追加


            }
            else
            {
                CostEstimate_PartsListData partsListData1 = new CostEstimate_PartsListData();
                //行番号
                partsListData1.RowNumber = 2;
                //No
                partsListData1.No = 2;
                //部品分類
                partsListData1.PartsCode = "B";
                //部品名
                partsListData1.PartsName = "Upper Cull Block";
                //図面番号/型式
                partsListData1.DrawingNumber = "001602-A-B002";
                //入数
                partsListData1.IriSu = 1;
                //個数
                partsListData1.Kosu = 2;
                //単位
                partsListData1.Tani = "式";
                //表面処理コード
                partsListData1.SurfaceCode = "1002";
                //表面処理
                partsListData1.SurfaceProcess = "表面処理B";

                dataList.Add(partsListData1);

            }
            model.GridDataList = dataList;


            // 部品選択用リスト
            var partsSelectListData = new List<CostEstimate_PartsSelectListData>();
            partsSelectListData.Add(new CostEstimate_PartsSelectListData(false, 1, 1, "A", "Upper Main Cavity", "001602-A-B001", 2, 8));
            partsSelectListData.Add(new CostEstimate_PartsSelectListData(true,  2, 2, "B", "Upper Cull Block", "001602-A-B002", 1, 2));
            partsSelectListData.Add(new CostEstimate_PartsSelectListData(false, 3, 5, "D", "Upper Holder Vase", "001602-A-B003", 1, 2));
            partsSelectListData.Add(new CostEstimate_PartsSelectListData(false, 4, 8, "A", "Lower Main Cavity", "001602-A-B004", 1, 2));
            partsSelectListData.Add(new CostEstimate_PartsSelectListData(false, 5, 9, "A", "Lower Main Cavity", "001602-A-B004", 1, 2));
            partsSelectListData.Add(new CostEstimate_PartsSelectListData(false, 6, 12, "B", "Lower Port Block", "001602-A-B005", 1, 2));
            model.GridPartsSelectDataList = partsSelectListData;

        }
    }
}