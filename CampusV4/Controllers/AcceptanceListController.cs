﻿using System;
using System.Collections.Generic;
using System.Linq;
using C1.Web.Mvc;
using C1.Web.Mvc.Serialization;
using System.Web;
using System.Data;
using System.Web.Mvc;
using System.Data.Entity;
using CampusV4.Models;

// This code was generated by C1 Scaffolder.

namespace CampusV4.Controllers.AcceptanceList
{
    public partial class AcceptanceListController : Controller
    {
        public ActionResult AcceptanceListSearch()
        {
            ModelState.Clear();
            AcceptanceListSearchViewModel model = new AcceptanceListSearchViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AcceptanceListSearch(AcceptanceListSearchViewModel model)
        {
            //ModelState.Clear();
            AcceptanceListViewModel modelList = new AcceptanceListViewModel();
            GetCampusIdList(ref modelList);
            GetInitData(ref modelList);
            return View("AcceptanceList",modelList);
        }

        [HttpPost]
        public ActionResult AcceptanceList(AcceptanceListViewModel model)
        {
            GetCampusIdList(ref model);
            GetInitData2(ref model);
            return View(model);
        }

        [HttpPost]
        public ActionResult AcceptanceListBack(AcceptanceListViewModel model)
        {
            AcceptanceListSearchViewModel modelAcceptanceListSearch = new AcceptanceListSearchViewModel();

            return View("AcceptanceListSearch", modelAcceptanceListSearch);
        }

        private void GetInitData(ref AcceptanceListViewModel model)
        {
            model.AcceptanceDate = DateTime.Parse("2023/01/01");
            model.CampusId = "A001";
            model.CompanyName = "株式会社 A社";

            var dataList = new List<AcceptanceListData>();
            AcceptanceListData acceptanceListData = new AcceptanceListData();
            //伝票日付
            acceptanceListData.AcceptanceDate = DateTime.Parse("2023/01/02");
            //伝票No
            acceptanceListData.PurchasingNumber = "0000100001";
            //製番
            acceptanceListData.ProductionNumber = "000012345A01";
            //品名
            acceptanceListData.PartsName = "Upper Main Cavity";
            //図面番号/型式
            acceptanceListData.DrawingNumber = "001602-A-B001";
            //数量
            acceptanceListData.Quantity = 1000;
            //単価
            acceptanceListData.Unitprice = 200;
            //金額
            acceptanceListData.Price = 200000;
            //消費税
            acceptanceListData.Tax = 20000;
            //合計
            acceptanceListData.SumPrice = 220000;
            //CAMPUS利用料
            acceptanceListData.Campusfee = 1000;


            dataList.Add(acceptanceListData);

            AcceptanceListData acceptanceListData1 = new AcceptanceListData();
            //伝票日付
            acceptanceListData1.AcceptanceDate = DateTime.Parse("2023/01/03");
            //伝票No
            acceptanceListData1.PurchasingNumber = "0000100002";
            //製番
            acceptanceListData1.ProductionNumber = "000012345A01";
            //品名
            acceptanceListData1.PartsName = "Upper Cull Block";
            //図面番号/型式
            acceptanceListData1.DrawingNumber = "001602-A-B002";
            //数量
            acceptanceListData1.Quantity = 2000;
            //単価
            acceptanceListData1.Unitprice = 300;
            //金額
            acceptanceListData1.Price = 600000;
            //消費税
            acceptanceListData1.Tax = 60000;
            //合計
            acceptanceListData1.SumPrice = 660000;
            //CAMPUS利用料
            acceptanceListData1.Campusfee = 2000;

            dataList.Add(acceptanceListData1);
            model.GridDataList = dataList;



            //金額_合計
            model.PriceSum = 800000;
            //消費税_合計
            model.TaxSum = 80000;
            //合計_合計
            model.SumPriceSum = 880000;
            //CAMPUS利用料_合計
            model.CampusfeeSum = 3000;

        }

        private void GetInitData2(ref AcceptanceListViewModel model)
        {
            //model.AcceptanceDate = DateTime.Parse("2023/02/01");
            //model.CampusId = "A001";
            model.CompanyName = "株式会社 B社";

            var dataList = new List<AcceptanceListData>();
            AcceptanceListData acceptanceListData = new AcceptanceListData();
            //伝票日付
            acceptanceListData.AcceptanceDate = DateTime.Parse("2023/02/02");
            //伝票No
            acceptanceListData.PurchasingNumber = "B001";
            //製番
            acceptanceListData.ProductionNumber = "3101A001";
            //品名
            acceptanceListData.PartsName = "Upper Main Cavity";
            //図面番号/型式
            acceptanceListData.DrawingNumber = "001602-A-B001";
            //数量
            acceptanceListData.Quantity = 1000;
            //単価
            acceptanceListData.Unitprice = 200;
            //金額
            acceptanceListData.Price = 200000;
            //消費税
            acceptanceListData.Tax = 20000;
            //合計
            acceptanceListData.SumPrice = 220000;
            //CAMPUS利用料
            acceptanceListData.Campusfee = 1000;


            dataList.Add(acceptanceListData);

            AcceptanceListData acceptanceListData1 = new AcceptanceListData();
            //伝票日付
            acceptanceListData1.AcceptanceDate = DateTime.Parse("2023/02/03");
            //伝票No
            acceptanceListData1.PurchasingNumber = "B002";
            //製番
            acceptanceListData1.ProductionNumber = "3101A002";
            //品名
            acceptanceListData1.PartsName = "Upper Main Cavity2";
            //図面番号/型式
            acceptanceListData1.DrawingNumber = "001602-A-B002";
            //数量
            acceptanceListData1.Quantity = 2000;
            //単価
            acceptanceListData1.Unitprice = 300;
            //金額
            acceptanceListData1.Price = 600000;
            //消費税
            acceptanceListData1.Tax = 60000;
            //合計
            acceptanceListData1.SumPrice = 660000;
            //CAMPUS利用料
            acceptanceListData1.Campusfee = 2000;

            dataList.Add(acceptanceListData1);
            model.GridDataList = dataList;



            //金額_合計
            model.PriceSum = 800000;
            //消費税_合計
            model.TaxSum = 80000;
            //合計_合計
            model.SumPriceSum = 880000;
            //CAMPUS利用料_合計
            model.CampusfeeSum = 3000;

        }

        private void GetCampusIdList(ref AcceptanceListViewModel model)
        {
            List<MasterData> dataList = new List<MasterData>();
            MasterData masterDataA = new MasterData();
            masterDataA.Code = "A001";
            masterDataA.Name = "株式会社 A社";
            dataList.Add(masterDataA);

            MasterData masterDataB = new MasterData();
            masterDataB.Code = "B001";
            masterDataB.Name = "株式会社 B社";
            dataList.Add(masterDataB);

            MasterData masterDataC = new MasterData();
            masterDataC.Code = "C001";
            masterDataC.Name = "株式会社 C社";
            dataList.Add(masterDataC);

            model.CampusIdList = dataList;

        }

    }
}