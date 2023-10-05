using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class AcceptanceListViewModel
    {
        //締次検収日
        public DateTime? AcceptanceDate { get; set; }

        //CAMPUS-ID
        public string CampusId { get; set; }

        //会社名
        public string CompanyName { get; set; }

        //金額_合計
        public double? PriceSum { get; set; }
        //消費税_合計
        public double? TaxSum { get; set; }
        //合計_合計
        public double? SumPriceSum { get; set; }
        //CAMPUS利用料_合計
        public double? CampusfeeSum { get; set; }
        //検収明細リスト
        public List<AcceptanceListData> GridDataList { get; set; }

        //CAMPUS-IDリスト
        public List<MasterData>CampusIdList { get; set; }


    }

    //検収明細リスト一覧
    public class AcceptanceListData
    {

        //伝票日付
        public DateTime? AcceptanceDate { get; set; }
        //伝票№
        public string PurchasingNumber { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //品名
        public string PartsName { get; set; }
        //図面番号／型式
        public string DrawingNumber { get; set; }
        //数量
        public double? Quantity { get; set; }
        //単価
        public double? Unitprice { get; set; }
        //金額
        public double? Price { get; set; }
        //消費税
        public double? Tax { get; set; }
        //合計
        public double? SumPrice { get; set; }
        //CAMPUS利用料
        public double? Campusfee { get; set; }

        public AcceptanceListData()
        {
        }
     }
}