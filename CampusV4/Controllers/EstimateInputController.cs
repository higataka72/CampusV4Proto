using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using C1.Web.Mvc;
using CampusV4.Models;
using Microsoft.Ajax.Utilities;


namespace CampusV4.Controllers
{
    public class EstimateInputController : Controller
    {
        // GET: EstimateInput
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

        public ActionResult EstimateInput(int mode)
        {
            ModelState.Clear();
            EstimateInputViewModel model = new EstimateInputViewModel();
            if (mode == 1)
            {
                // 登録モード
                model.Mode = "ins";


            }
            else if (mode == 2)
            {
                // 編集モード
                model.Mode = "upd";
            }

            // 初期データ
            model.InquiryNumber = "000003655";
            model.EstimateNumber = "000003655A";
            model.EstimateDate = DateTime.Parse("2023/12/20");
            model.Subject = "金型Aの見積";
            model.OrderDate = DateTime.Parse("2023/12/20");
            model.CampusId = "A001";
            model.CompanyName = "株式会社 A社";
            model.OrderAccuracy = "高";
            model.SalesCode = "USR00001";
            model.SalesName = "佐藤　一郎";
            model.DeliveryPlace = "京都A工場";
            model.DeliveryDate = "支払後10以内";
            model.PaymentConditions = "銀行振込";
            model.DeliveryDeadlineDate = "3カ月";
            model.Remarks = "1.購入品ボルトの強度区分は12.9以上とし、適応外品は10.9以上の黒ボルトを選択のこと。\n" +
                               "2.Main Cavity Blockは、上下AS状態で、枝番-1を左側、-2を右側にASすること。";
            model.EstimateValueOut = "1,200,000";
            model.Rate = "120";
            model.EstimateValueIn = "1,000,000";
            model.RepeatProduct = "000012345A01";
            model.ProcessingCost = "200,000";
            model.ProcessingRatio = "50";
            model.ApprovalFlag = true;
            model.ApprovalType = "1";

            GetDataList(ref model);

            // 引合照会データ
            GetInquiryData(ref model);

            return View(model);
        }

        [HttpPost]
        public ActionResult EstimateInput()
        {
            ModelState.Clear();
            EstimateInputViewModel model = new EstimateInputViewModel();
            model.Mode = "upd";

            // 初期データ
            model.InquiryNumber = "000003655";
            model.EstimateNumber = "000003655A";
            model.EstimateDate = DateTime.Parse("2023/12/20");
            model.Subject = "金型Aの見積";
            model.OrderDate = DateTime.Parse("2023/12/20");
            model.CampusId = "A001";
            model.CompanyName = "株式会社 A社";
            model.OrderAccuracy = "高";
            model.SalesCode = "USR00001";
            model.SalesName = "佐藤　一郎";
            model.DeliveryPlace = "京都A工場";
            model.DeliveryDate = "支払後10以内";
            model.PaymentConditions = "銀行振込";
            model.DeliveryDeadlineDate = "3カ月";
            model.Remarks = "1.購入品ボルトの強度区分は12.9以上とし、適応外品は10.9以上の黒ボルトを選択のこと。\n" +
                               "2.Main Cavity Blockは、上下AS状態で、枝番-1を左側、-2を右側にASすること。";
            model.EstimateValueOut = "1,200,000";
            model.Rate = "120";
            model.EstimateValueIn = "1,000,000";
            model.RepeatProduct = "000012345A01";
            model.ProcessingCost = "200,000";
            model.ProcessingRatio = "50";
            model.ApprovalFlag = true;
            model.ApprovalType = "1";

            GetDataList(ref model);

            // 引合照会データ
            GetInquiryData(ref model);

            return View("EstimateInput", model);
        }

        [HttpPost]
        public ActionResult AccessoriesDetail(EstimateInputViewModel model)
        {
            return View("AccessoriesDetail", model);
        }

        private void GetDataList(ref EstimateInputViewModel model)
        {
            //受注確度
            var OrderAccuracyData = new List<MasterData>();
            OrderAccuracyData.Add(new MasterData("　", ""));
            OrderAccuracyData.Add(new MasterData("高", "1"));
            OrderAccuracyData.Add(new MasterData("中", "2"));
            OrderAccuracyData.Add(new MasterData("低", "3"));
            model.OrderAccuracyList = OrderAccuracyData;

            // 営業担当者を取得
            var SalesData = new List<SalesData>();
            SalesData.Add(new SalesData("　", ""));
            SalesData.Add(new SalesData("USR00001", "佐藤　一郎"));
            SalesData.Add(new SalesData("USR00002", "佐藤　次郎"));
            SalesData.Add(new SalesData("USR00003", "佐藤　三郎"));
            SalesData.Add(new SalesData("USR00004", "佐藤　四朗"));
            SalesData.Add(new SalesData("USR00005", "佐藤　五郎"));
            model.SalesDataList = SalesData;

            //部品リスト
            var PartsListData = new List<EstimateInput_PartsList>();
            PartsListData.Add(new EstimateInput_PartsList("BGA", "Lower Main Cavity", 10, "個", 100000, 1000000));
            model.PartsList = PartsListData;

        }

        private void GetInquiryData(ref EstimateInputViewModel model)
        {
            model.inq_InquiryNo = "000003655";
            model.inq_UserRequestNo = "0000000001";
            model.inq_RequestDate = DateTime.Parse("2023/11/20");
            model.inq_CampusId = "A001";
            model.inq_CompanyName = "株式会社 A社";
            model.inq_Subject = "金型Aの引合";
            model.inq_HinsyuCode = "ZX-A001";
            model.inq_Hinmei = "金型A図枠組み";
            model.inq_Quantity = "10";
            model.inq_Unit = "個";
            model.inq_ContentValue = "納期回答を早めにお願いいたします。";
            model.inq_QuotationRequestDate = DateTime.Parse("2023/12/10");
            model.inq_DesiredDeliveryDate = DateTime.Parse("2024/01/20");
            model.inq_ReferenceEstimateNo = "";


        }
    }
}