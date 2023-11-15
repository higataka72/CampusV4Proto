using System;
using System.Collections.Generic;
using System.Web.Mvc;
using CampusV4.Models;
using Microsoft.Ajax.Utilities;

namespace CampusV4.Controllers
{
    public class InspectController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(InspectViewModel model)
        {
            
                return View(model);
            

        }


        public ActionResult InspectDataList()
        {
            var model = new InspectViewModel();


            GetComboDataList(ref model, true);
           

            return View(model);
        }

        [HttpPost]
        public ActionResult InspectDataList(InspectViewModel model)
        {



            GetComboDataList(ref model, false);
            GetInspectListData(ref model);




            return View(model);
        }
        //リストボックス値取得
        private void GetComboDataList(ref InspectViewModel model, Boolean flgInitList)
        {
            // 共通項目
            // CAMPUS_IDの取得
            var CampusData = new List<CampusData>();
            CampusData.Add(new CampusData("　", ""));
            CampusData.Add(new CampusData("0000010001", "株式会社ASP"));
            CampusData.Add(new CampusData("0000010002", "株式会社BSP"));
            CampusData.Add(new CampusData("0000010003", "株式会社CSP"));
            CampusData.Add(new CampusData("0000010004", "株式会社DSP"));
            CampusData.Add(new CampusData("0000010005", "株式会社ESP"));
            model.CampusDataList = CampusData;            
        }
        //一覧取得
        private void GetInspectListData(ref InspectViewModel model)
        {
            var gridDataList = new List<InspectListData>();
            InspectListData InquiryListData = new InspectListData();
            //検
            InquiryListData.InspectCheck = true;
            //状態
            InquiryListData.Situation = "〇";
            //製番
            InquiryListData.ProductionNumber = "000012345A01";
            //発注日
            InquiryListData.OrderDate = DateTime.Parse("2023/01/01");
            //発注番号
            InquiryListData.OrderNumber = "A002";
            //受入日
            InquiryListData.ReceiptDate = DateTime.Parse("2023/03/01");
            //受入番号
            InquiryListData.ReceiptNumber = "000125";
            //品名
            InquiryListData.PartsName = "Upper Cull Block";
            //図面番号/型式
            InquiryListData.DrawingNumber = "001602-A-B002";
            //発注数
            InquiryListData.OrderQuantity = 20;
            //受入数
            InquiryListData.ReceiptQuantity = 17;
            //不良数
            InquiryListData.DefectsQuantity = 3;
            //検収数
            InquiryListData.AcceptanceQuantity = 14;
            //単価
            InquiryListData.Unitprice = 2000;
            //金額
            InquiryListData.Price = 40000;
            //検収日
            InquiryListData.AcceptanceDate = DateTime.Parse("2023/01/01");
            //検収担当
            InquiryListData.AcceptancePicCode = "佐藤　一郎";
            //検収担当
            InquiryListData.AccountingConnectedDate = DateTime.Parse("2023/01/01");


            gridDataList.Add(InquiryListData);


            InspectListData InquiryListData1 = new InspectListData();

            //検
            InquiryListData1.InspectCheck = true;
            //状態
            InquiryListData1.Situation = "△";
            //製番
            InquiryListData1.ProductionNumber = "000012345A01";
            //発注日
            InquiryListData1.OrderDate = DateTime.Parse("2023/02/01");
            //発注番号
            InquiryListData1.OrderNumber = "A002";
            //受入日
            InquiryListData1.ReceiptDate = DateTime.Parse("2023/04/01");
            //受入番号
            InquiryListData1.ReceiptNumber = "000126";
            //品名
            InquiryListData1.PartsName = "Upper Cull Block２";
            //図面番号/型式
            InquiryListData1.DrawingNumber = "001602-A-B002";
            //発注数
            InquiryListData1.OrderQuantity = 30;
            //受入数
            InquiryListData1.ReceiptQuantity = 27;
            //不良数
            InquiryListData1.DefectsQuantity = 3;
            //検収数
            InquiryListData1.AcceptanceQuantity = 24;
            //単価
            InquiryListData1.Unitprice = 2000;
            //金額
            InquiryListData1.Price = 60000;
            //検収日
            InquiryListData1.AcceptanceDate = DateTime.Parse("2023/01/01");
            //検収担当
            InquiryListData1.AcceptancePicCode = "佐藤　一郎";
            //検収担当
            InquiryListData1.AccountingConnectedDate = DateTime.Parse("2023/01/01");

            gridDataList.Add(InquiryListData1);

            model.GridDataList = gridDataList;
        }







    }
}