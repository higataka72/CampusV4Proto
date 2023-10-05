using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class OrderViewModel
    {
        //** 主画面　**//
        // モード
        public string Mode { get; set; }

        // 受注番号
        public string OrderNo { get; set; }
        // 引合番号
        public string InquiryNo { get; set; }
        // 受注日
        public DateTime OrderDate { get; set; }
        // 不具合製番
        public string DefectiveSerialNo { get; set; }
        // 稟議番号
        public string ApprovalNo { get; set; }
        // 納期
        public DateTime? DeadlineDate { get; set; }
        // 契約納期
        public DateTime? ContractDeadlineDate { get; set; }
        // 分類記号
        public string ClassificationSymbol { get; set; }
        // 締め製番
        public string ClosingSerialNo { get; set; }
        // 注文書番号
        public string PurchaseOrderNo { get; set; }
        // 営業担当者
        public string SalesPersonCode { get; set; }
        // 営業担当者名
        public string SalesPersonName { get; set; }
        // 調達担当者
        public string ProcurementPersonCode { get; set; }
        // 調達担当者名
        public string ProcurementPersonName { get; set; }
        // 内示
        public Boolean UnofficialNotice { get; set; }
        // 先行手配（1:有 / 2:無)
        public int PriorArrangements { get; set; }
        // キャンセルフラグ
        public Boolean CancelFlag { get; set; }
        // キャンセル日
        public DateTime? CancelDate { get; set; }
        // 検査成績書（1:要 / 2:不要)
        public int InspectionReport { get; set; }
        // CAMPUS-ID
        public string CampusId { get; set; }
        // CAMUS-NAME
        public string CompanyName { get; set; }
        // 件名
        public string Subject { get; set; }
        // 数量
        public string Quantity { get; set; }
        // 単位
        public string Unit { get; set; }
        // 完納
        public Boolean CompletePayment { get; set; }
        // レート
        public double? Rate { get; set; }
        // 受注額(内貨)
        public double? LocalOrdeReceived { get; set; }
        // 受注額(外貨)
        public double? OutsideOrdeReceived { get; set; }
        // 最終レート
        public double? FinalRate { get; set; }
        // 最終受注額(内貨)
        public double? FinalLocalOrdeReceived { get; set; }
        // 最終受注額(外貨)
        public double? FinalOutsideOrdeReceived { get; set; }
        // 備考
        public string Remarks { get; set; }

        // 分類記号コードマスタより
        public List<Order_ClassificationData> ClassificationDataList { get; set; }
        // 営業担当者コードマスタより
        public List<Order_SalesData> SalesDataList { get; set; }
        // 調達担当者コードマスタより
        public List<Order_ProcurementData> ProcurementDataList { get; set; }

        public List<ProductNumData> ProductNumDataList { get; set; }

    }

    public class Order_ClassificationData
    {

        public string ClassificationCode { get; set; }
        public string ProductNum { get; set; }

        public Order_ClassificationData(string _ClassificationCode, string _ProductNum)
        {
            ClassificationCode = _ClassificationCode;
            ProductNum = _ProductNum;
        }
    }
    public class Order_SalesData
    {

        public string SalesPersonCode { get; set; }
        public string SalesPersonName { get; set; }

        public Order_SalesData(string _SalesPersonCode, string _SalesPersonName)
        {
            SalesPersonCode = _SalesPersonCode;
            SalesPersonName = _SalesPersonName;
        }
    }

    public class Order_ProcurementData
    {

        public string ProcurementPersonCode { get; set; }
        public string ProcurementPersonName { get; set; }

        public Order_ProcurementData(string _ProcurementPersonCode, string _ProcurementPersonName)
        {
            ProcurementPersonCode = _ProcurementPersonCode;
            ProcurementPersonName = _ProcurementPersonName;
        }
    }

    public class ProductNumData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }
        public string Col_8 { get; set; }
        public string Col_9 { get; set; }


        public ProductNumData(string _col_1, string _col_2, string _col_3,
                              string _col_4, string _col_5, string _col_6,
                              string _col_7, string _col_8, string _col_9)
        {
            Col_1 = _col_1;
            Col_2 = _col_2;
            Col_3 = _col_3;
            Col_4 = _col_4;
            Col_5 = _col_5;
            Col_6 = _col_6;
            Col_7 = _col_7;
            Col_8 = _col_8;
            Col_9 = _col_9;
        }
    }
}