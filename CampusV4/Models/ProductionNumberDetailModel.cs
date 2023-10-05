using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace CampusV4.Models
{
    public class ProductionNumberDetailModel
    {
        //引合番号
        public string InquiryNumber { get; set; }
        //分類記号
        public string GroupingMark { get; set; }
        //件名
        public string Subject { get; set; }
        //CAMPUS-ID
        public string CampusId { get; set; }
        //会社名
        public string CompanyName { get; set; }
        //品種コード
        public string VarietyCode { get; set; }
        //品名
        public string ProductName { get; set; }
        //見積提出日
        public DateTime? EstimatedSubmitDate { get; set; }
        //営業担当者コード
        public string SalesEmployeeCode { get; set; }
        //営業担当者名
        public string SalesEmployeeName { get; set; }
        //受注確度
        public string OrderProbability { get; set; }
        //受注日
        public DateTime? OrderDate { get; set; }
        //失注日
        public DateTime? LostOrderDate { get; set; }
        //キャンセル日
        public DateTime? CancelDate { get; set; }
        //納期
        public DateTime? ShippingDate { get; set; }
        //調達担当者コード
        public string ProcurementPersonCode { get; set; }
        //調達担当者名
        public string ProcurementPersonName { get; set; }
        //数量
        public double? Quantity { get; set; }
        //単位
        public string Unit { get; set; }
        //レート
        public double? Rate { get; set; }
        //受注額（内貨）
        public double? LocalOrdeReceived { get; set; }
        //受注額（外貨）
        public double? OutsideOrdeReceived { get; set; }
        //設計担当者（主）コード
        public string MainDesignEmployeeCode { get; set; }
        //設計担当者（主）名
        public string MainDesignEmployeeName { get; set; }
        //提案日
        public DateTime? ProposedDate { get; set; }
        //設計担当者（従）コード
        public string SubDesignEmployeeCode { get; set; }
        //設計担当者（従）名
        public string SubDesignEmployeeName { get; set; }
        //出図日
        public DateTime? DrawingDate { get; set; }
        //検査組立担当者コード
        public string TestAssemblyEmployeeCode { get; set; }
        //検査組立担当者名
        public string TestAssemblyEmployeeName { get; set; }
        //正式原価確認担当者コード
        public string CostConfirmationEmployeeCode { get; set; }
        //正式原価確認担当者名
        public string CostConfirmationEmployeeName { get; set; }
        //検査成績書
        public string InspectionEeport { get; set; }
        //発注件数
        public double? OrderCount { get; set; }
        //発注金額
        public double? OrderPrice { get; set; }
        //発注加工比率
        public double? OrderProcessingRatio { get; set; }
        //発注残金額
        public double? OrderBalance { get; set; }
        //仕入件数
        public double? PurchaseCount { get; set; }
        //仕入金額
        public double? PurchasePrice { get; set; }
        //仕入加工比率
        public double? PurchaseProcessingRatio { get; set; }
        //総仕入額
        public double? TotalPurchasePrice { get; set; }
        //予想加工比率
        public double? ForecastProcessingRatio { get; set; }
       

        //部品記号リスト
        public List<MasterData> GroupingMarkList { get; set; }
        //受注確度リスト
        public List<MasterData> OrderProbabilityList { get; set; }

        //製品仕様一覧

        public List<ProductionSpecificationListData> ProductionSpecificationList { get; set; }
}

    //製番明細
    public class ProductionNumberDetailListData
    {
        //製番
        public string ProductionNumber { get; set; }
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
        //売上番号
        public string EarningsNumber { get; set; }
        //完成予定日
        public string ExpectedCompleteDate { get; set; }
        //出荷指示日
        public string ShippingInstructionDate { get; set; }

        public ProductionNumberDetailListData(
            string _ProductionNumber,
            double _Quantity,
            double _Unitprice,
            double _Price,
            string _ShipDate,
            string _AcceptanceDate,
            string _EarningsNumber,
            string _ExpectedCompleteDate,
            string _ShippingInstructionDate
            )
        {
            ProductionNumber = _ProductionNumber;
            Quantity = _Quantity;
            Unitprice = _Unitprice;
            Price = _Price;
            ShipDate = _ShipDate;
            AcceptanceDate = _AcceptanceDate;
            EarningsNumber = _EarningsNumber;
            ExpectedCompleteDate = _ExpectedCompleteDate;
            ShippingInstructionDate = _ShippingInstructionDate;

        }
    }

    //発注明細
    public class OrderDetailListData
    {
        //製番
        public string ProductionNumber { get; set; }
        //発注番号
        public string OrderNumber { get; set; }
        //パートナー工場
        public string PartnerName { get; set; }
        //部品名
        public string PartsName { get; set; }
        //数量
        public double? Quantity { get; set; }
        //金額
        public double? Price { get; set; }
        //受入日
        public string ReceiptDate { get; set; }
        //検収日
        public string AcceptanceDate { get; set; }
        //完納
        public bool CompletePayment { get; set; }
        public OrderDetailListData(
            string _ProductionNumber,
            string _OrderNumber,
            string _PartnerName,
            string _PartsName,
            double? _Quantity,
            double? _Price,
            string _ReceiptDate,
            string _AcceptanceDate,
            bool _CompletePayment) 
        {
            ProductionNumber = _ProductionNumber;
            OrderNumber = _OrderNumber;
            PartnerName = _PartnerName;
            PartsName = _PartsName;
            Quantity = _Quantity;
            Price = _Price;
            ReceiptDate = _ReceiptDate;
            AcceptanceDate = _AcceptanceDate;
            CompletePayment = _CompletePayment;
        }
    }

    //分納明細
    public class SplitDeliveryListData_Pn
    {
        //回数
        public double? RowNumber { get; set; }
        //数量
        public double? Quantity { get; set; }
        //単価
        public double? Unitprice { get; set; }
        //金額
        public double? Price { get; set; }
        //納期
        public string ShippingDate { get; set; }
        //完納
        public bool CompletepPayment { get; set; }

        public SplitDeliveryListData_Pn(
            double _RowNumber,
            double _Quantity,
            double _Unitprice,
            double _Price,
            string _ShippingDate,
            bool _CompletepPayment)
        {
            RowNumber = _RowNumber;
            Quantity = _Quantity;
            Unitprice = _Unitprice;
            Price = _Price;
            ShippingDate = _ShippingDate;
            CompletepPayment = _CompletepPayment;
        }
    }

    //連絡確認
    public class ContactConfirmListData
    {
        //登録日
        public string RegistDate { get; set; }
        //入力内容
        public string InputContents { get; set; }
        //確認者
        public string ConfirmEmployeeName { get; set; }
        public ContactConfirmListData(
            string _RegistDate,
            string _InputContents,
            string _ConfirmEmployeeName) 
        {
            RegistDate= _RegistDate;
            InputContents= _InputContents;
            ConfirmEmployeeName= _ConfirmEmployeeName;
                
        }
    }

    //製品仕様
    public class ProductionSpecificationListData
    {
        public string ItemName { get; set; }
        public string ItemValue { get; set; }
        public string ItemType { get; set; }

        public double ItemNumDigits { get; set; }

        public List<MasterData> ItemCombValue { get; set; }

        public ProductionSpecificationListData(string _ItemName, string _ItemValue, string _ItemType, double _ItemNumDigits, List<MasterData> _ItemCombValue)
        {
            this.ItemName = _ItemName;
            this.ItemValue = _ItemValue;
            this.ItemType = _ItemType;
            this.ItemNumDigits = _ItemNumDigits;
            this.ItemCombValue = _ItemCombValue;
        }
    }
}