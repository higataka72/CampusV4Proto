using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using C1.Web.Mvc;
using CampusV4.Models;
using Microsoft.Ajax.Utilities;


namespace CampusV4.Controllers.Transfer
{
    public partial class TransferController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TransferInput()
        {
            ModelState.Clear();
            TransferViewModel model = new TransferViewModel();
            //if (mode == 1)
            //{
            //    // 登録モード
            //    model.Mode = "ins";


            //}
            //else
            //{
            //    // 編集モード
            //    model.Mode = "upd";
            //    //GetInitData(ref model);
            //}

            // 編集モード
            model.Mode = "upd";
            model.Splitdelivery = 0;
            model.ReceivedQuantity = 0;
            model.Quantity = 0;
            model.Unitprice = "0";
            model.Tax = "0";
            model.TaxRate = "";
            model.Price = "0";
            model.AcceptQuantity = 0;

            GetCombDataList(ref model);

            return View(model);
        }


        [HttpPost]
        public ActionResult TransferInput(TransferViewModel model)
        {
            ModelState.Clear();
            if (model.Mode == "upd")
            {
                // 編集モード
                GetInitData(ref model);
                GetCombDataList(ref model);
            }

            return View(model);
        }

        [HttpPost]
        public JsonResult GetSplitdeliveryData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<SplitDeliverySelectListData>();

            dataList.Add(new SplitDeliverySelectListData(1, 1, 10, 10, DateTime.Parse("2023/01/01").ToString("yyyy/MM/dd"), DateTime.Parse("2023 /01/10").ToString("yyyy/MM/dd"), DateTime.Parse("2023/02/01").ToString("yyyy/MM/dd"), true));
            dataList.Add(new SplitDeliverySelectListData(2, 2, 20, 40, DateTime.Parse("2023/01/02").ToString("yyyy/MM/dd"), DateTime.Parse("2023/01/20").ToString("yyyy/MM/dd"), DateTime.Parse("2023/02/02").ToString("yyyy/MM/dd"), false));
            dataList.Add(new SplitDeliverySelectListData(3, 3, 30, 90, DateTime.Parse("2023/01/03").ToString("yyyy/MM/dd"), DateTime.Parse("2023/01/30").ToString("yyyy/MM/dd"), DateTime.Now.ToString("yyyy/MM/dd"), true));

            string resultJson = "";

            resultJson = sz.Serialize(dataList);

            return Json(resultJson);
        }

        private void GetInitData(ref TransferViewModel model)
        {
            //受入番号
            model.PurchasingNumber = "0000000001";
            //発注番号
            model.OrderNumber = "0000000001";
            //製番
            model.ProductionNumber = "000012345A";
            //分納回数
            model.Splitdelivery = 1;
            //CAMPUS-ID
            model.CampusId = "0000010001";
            //会社名
            model.CompanyName = "京都金型工業";
            //手配区分
            model.ArrangementCodeFlg = false;
            //部署名
            model.DepartmentName = "営業部";
            //ご担当者様名
            model.SuppliersName = "佐藤　一郎";
            //連絡先
            model.PhoneNumber = "000-000-0000";
            //メールアドレス
            model.Email = "xxxxx@xxx.com";
            //部品番号
            model.PartsType = "B";
            //図面番号／型式
            model.DrawingNumber = "001602-A-B002";
            //会計連携日
            model.AlignmentDate = DateTime.Parse("2023/12/28");
            //部品名
            model.PartsName = "Upper Cull Block";
            //加工区分
            model.ProcessingDivision = "1";
            //測定日
            model.MeasurementDate = DateTime.Parse("2023/12/28");
            //表面処理コード
            model.SurfaceTreatmentCode = "1001";
            //表面処理
            model.SurfaceTreatment = "表明処理１";
            //設計担当者コード
            model.DesignEmployeeCode = "USR00001";
            //設計担当者名
            model.DesignEmployeeName = "佐藤　一郎";
            //検査組立担当者コード
            model.TestAssemblyEmployeeCode = "USR00002";
            //検査組立担当者名
            model.TestAssemblyEmployeeName = "佐藤　次郎";
            //受入担当者コード
            model.ReceiptEmployeeCode = "USR00003";
            //受入担当者名
            model.ReceiptEmployeeName = "佐藤　三郎";
            //受入日
            model.ReceiptDate = DateTime.Parse("2023/03/01");
            //発行区分検収書
            model.IssueTypeReceipt = false;
            //発行区分利用料
            model.IssueTypeUsageFee = true;
            //検査担当者コード
            model.AcceptanceEmployeeCode = "USR00004";
            //検査担当者名
            model.AcceptanceEmployeeName = "佐藤　四朗";
            //検収日
            model.AcceptanceDate = DateTime.Parse("2023/12/28");
            //支払予定日
            model.PaymentDate = DateTime.Parse("2024/01/31");
            //受入数量
            model.ReceivedQuantity = 5;
            //単位
            model.ReceivedQuantityUnit = "式";
            //受入区分
            model.ReceivedType = false;
            //完納区分
            model.CompletePaymentType = true;
            //数量指定区分
            model.QuantityType = "1";
            //数量
            model.Quantity = 5;
            //検収数量
            model.AcceptQuantity = 5;
            //単位
            model.QuantityUnit = "式";
            //単価
            model.Unitprice = "10,000";
            //消費税
            model.Tax = "26,000";
            //税率
            model.TaxRate = "10";
            //金額
            model.Price = "50,000";
            //備考
            model.Notes = "備考";
            //承認
            model.ApprovalFlg = false;

            GetTransferListData(ref model);
        }

        private void GetTransferListData(ref TransferViewModel model)
        {
            var gridDataList = new List<ProductNoData>();
            for (int i = 1; i <= 5; i++)
            {
                ProductNoData ProductNoListData = new ProductNoData();
                ProductNoListData.Col_1 = "000012345";
                ProductNoListData.Col_2 = "A";
                ProductNoListData.Col_3 = "0" + i.ToString();
                ProductNoListData.Col_4 = "1";
                ProductNoListData.Col_5 = "0";

                gridDataList.Add(ProductNoListData);
            }

            model.ProductNumDataList = gridDataList;
        }

        //リストボックス値取得
        private void GetCombDataList(ref TransferViewModel model)
        {
            //表面処理
            var SurfaceTreatmentData = new List<MasterData>();
            SurfaceTreatmentData.Add(new MasterData("　", ""));
            SurfaceTreatmentData.Add(new MasterData("1001", "表面処理A"));
            SurfaceTreatmentData.Add(new MasterData("1002", "表面処理B"));
            model.SurfaceTreatmentList = SurfaceTreatmentData;

            //税率
            var RateData = new List<MasterData>();
            RateData.Add(new MasterData("　", ""));
            RateData.Add(new MasterData("0", "0"));
            RateData.Add(new MasterData("8", "8"));
            RateData.Add(new MasterData("10", "10"));
            model.TaxRateList = RateData;


            // 担当者情報を取得
            var EmployeeData = new List<EmployeeData>();
            EmployeeData.Add(new EmployeeData("　", ""));
            EmployeeData.Add(new EmployeeData("USR00001", "佐藤　一郎"));
            EmployeeData.Add(new EmployeeData("USR00002", "佐藤　次郎"));
            EmployeeData.Add(new EmployeeData("USR00003", "佐藤　三郎"));
            EmployeeData.Add(new EmployeeData("USR00004", "佐藤　四朗"));
            EmployeeData.Add(new EmployeeData("USR00005", "佐藤　五郎"));
            model.EmployeeDataList = EmployeeData;

            // 品種情報を取得
            var PartnerDataList = new List<PartnerData>();
            PartnerDataList.Add(new PartnerData("　", ""));
            PartnerDataList.Add(new PartnerData("0000000001", "（株）阿部製作所"));
            PartnerDataList.Add(new PartnerData("0000000002", "（株）ゲートジャパン"));
            PartnerDataList.Add(new PartnerData("0000010001", "京都金型工業"));
            model.PartnerDataList = PartnerDataList;
            model.PartnerName = "（株）阿部製作所";
            model.ProductNumber = "000012345A01";

            // 発注伝票リスト
            var SlipSelectListData = new List<SlipSelectListData>();
            SlipSelectListData.Add(new SlipSelectListData("", "", "3101A001", "Upper Main Cavity", "001602-A-B001", 1000, 200));
            SlipSelectListData.Add(new SlipSelectListData(DateTime.Parse("2023/01/03").ToString("yyyy/MM/dd"), "A002", "3101A001", "Upper Main Cavity", "001602-A-B001", 1000, 200));
            model.GridSlipSelectDataList = SlipSelectListData;
        }
    }
}