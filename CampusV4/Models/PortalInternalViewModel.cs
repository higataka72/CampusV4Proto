using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class PortalInternalViewModel
    {
        public List<PortalInternalDashboardViewModel> PortalInternalDashboardList { get; set; }
        public List<PortalInternalDetailData> PortalInternalDetailDataList { get; set; }

        public string SelectCol { get; set; }
    }

    public class PortalInternalDashboardViewModel
    {
        //出荷予定数
        public double? EstimatedShippingNum { get; set; }
        //設計予定数
        public double? EstimatedDesignNum { get; set; }
        //発注予定数
        public double? EstimatedOrderNum { get; set; }
        //入荷予定数
        public double? EstimatedComeInNum { get; set; }
        //仕入金額計
        public double? PurchaseAmount { get; set; }
        //売上金額計
        public double? EarningsAmount { get; set; }

    }

    public class PortalInternalDetailViewModel
    {
        public List<PortalInternalDetailData> PortalInternalDetailDataList { get; set; }
        public string SelectProductionNumber { get; set; }
    }
    public class PortalInternalDetailData
    {
        //行
        public double? RowNum { get; set; }
        //得意先名
        public string CustomerName { get; set; }
        //件名
        public string Subject { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //数量
        public double? Quantity { get; set; }
        //単位
        public string Unit { get; set; }
        //単価
        public double? UnitPrice { get; set; }
        //金額
        public double? Aamount { get; set; }

    }

    public class PortalInternalDetailDetailViewModel
    {
        public List<PortalInternalDetailDetailData> PortalInternalDetailDetailDataList { get; set; }
    }

    public class PortalInternalDetailDetailData
    {
        //行
        public double? RowNum { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //部品名
        public string PartsName { get; set; }
        //パートナー工場
        public string PartnerFactoryName { get; set; }
        //図面番号／型式
        public string DrawingNum { get; set; }
        //数量
        public double? Quantity { get; set; }
        //単価
        public double? UnitPrice { get; set; }
        //金額
        public double? Aamount { get; set; }
    }
}