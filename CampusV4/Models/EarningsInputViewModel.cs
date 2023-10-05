using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class EarningsInputViewModel
    {
        // モード
        public string Mode { get; set; }
        //売上番号
        public string EarningsNo { get; set; }
        //引合番号
        public string InquiryNo { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //受注番号
        public string OrderNum { get; set; }
        //分納回数
        public double? Splitdelivery { get; set; }
        //CAMPUS-ID
        public string CampusId { get; set; }
        //会社名
        public string CompanyName { get; set; }
        //件名
        public string Subject { get; set; }
        //請求書番号
        public string InvoiceNum { get; set; }
        //請求書発行区分（出荷伝票）
        public bool InvoideDivision_ShipSlip { get; set; }
        //請求書発行区分（請求書）
        public bool InvoideDivision_Invoice { get; set; }

        //営業担当者コード
        public string SalesEmployeeCode { get; set; }
        //営業担当者名
        public string SalesEmployeeName { get; set; }
        //出荷担当者コード
        public string ShipEmployeeCode { get; set; }
        //出荷担当者名
        public string ShipEmployeeName { get; set; }
        //出荷日
        public DateTime? ShipDate { get; set; }
        //検収担当者コード
        public string AcceptanceEmployeeCode { get; set; }
        //検収担当者名
        public string AcceptanceEmployeeName { get; set; }
        //検収日
        public DateTime? AcceptanceDate { get; set; }
        //税抜
        public double? TaxExcluded { get; set; }

        //出荷数量
        public double? ShipQuantity { get; set; }
        //単位
        public string unit { get; set; }
        //会計連携日
        public DateTime? AlignmentDate { get; set; }
        //レート
        public double? RorderRate { get; set; }
        //売上額（外貨）
        public double? EarningsForeigncurrency { get; set; }
        //消費税
        public double? Tax { get; set; }
        //税率
        public string TaxRate { get; set; }
        //売上額（内貨）
        public double? EarningsInternalcurrency { get; set; }
        //備考
        public string Notes { get; set; }
        //承認
        public bool ApprovalFlg { get; set; }
        //承認区分
        public string ApprovalType { get; set; }

        //担当者リスト
        public List<EmployeeData> EmployeeDataList { get; set; }
        //税率リスト
        public List<MasterData> TaxRateList { get; set; }

        //製番明細
        public List<ProductionNumberDetailListData_Earnings> GridProductionNumberDataList { get; set; }
        public List<ProductNumData> ProductNumDataList { get; set; }

        //検収明細
        public List<ScceptanceDetailListData_Earnings> GridScceptanceDataList { get; set; }

    }

    //製番明細
    public class ProductionNumberDetailListData_Earnings
    {
        //製番
        public string ProductionNumber { get; set; }
        //数量
        public double? Quantity { get; set; }
        //単価
        public double? Unitprice { get; set; }
        //金額
        public double? Price { get; set; }
        //納期
        public string DeliveryDate { get; set; }
        //摘要
        public string Summary { get; set; }

        public ProductionNumberDetailListData_Earnings(
            string _ProductionNumber,
            double _Quantity,
            double _Unitprice,
            double _Price,
            string _DeliveryDate,
            string _Summary
            )
        {
            ProductionNumber = _ProductionNumber;
            Quantity = _Quantity;
            Unitprice = _Unitprice;
            Price = _Price;
            DeliveryDate = _DeliveryDate;
            Summary = _Summary;
        }
    }

    //検収明細
    public class ScceptanceDetailListData_Earnings
    {
        //回
        public double? Count { get; set; }
        //注文書番号
        public string PurchaseOrderNo { get; set; }
        //数量
        public double? Quantity { get; set; }
        //単価
        public double? Unitprice { get; set; }
        //金額
        public double? Price { get; set; }
        //出荷日
        public string ShipDate { get; set; }
        //検収日
        public string AcceptanceDate { get; set; }
        //キャンセル日
        public string CancelDate { get; set; }

        public ScceptanceDetailListData_Earnings(
            double _Count,
            string _PurchaseOrderNo,
            double _Quantity,
            double _Unitprice,
            double _Price,
            string _ShipDate,
            string _AcceptanceDate,
            string _CancelDate
            )
        {
            Count = _Count;
            PurchaseOrderNo = _PurchaseOrderNo;
            Quantity = _Quantity;
            Unitprice = _Unitprice;
            Price = _Price;
            ShipDate = _ShipDate;
            AcceptanceDate = _AcceptanceDate;
            CancelDate = _CancelDate;

        }
    }
}