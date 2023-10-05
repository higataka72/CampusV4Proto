using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class EstimateInputViewModel
    {

        //**主画面***
        public string Mode { get; set; }

        //引合番号
        public string InquiryNumber { get; set; }
        //見積番号
        public string EstimateNumber { get; set; }
        //見積日
        public DateTime? EstimateDate { get; set; }
        //件名
        public string Subject { get; set; }
        //受注予定日
        public DateTime? OrderDate { get; set; }
        //CAMPUS-ID
        public string CampusId { get; set; }
        //CAMPUS-NAME
        public string CompanyName { get; set; }
        //受注確度
        public string OrderAccuracy { get; set; }
        //受注確度リスト
        public List<MasterData> OrderAccuracyList { get; set; }
        //失注日
        public DateTime? LostOrderDate { get; set; }
        //営業担当者コード
        public string SalesCode { get; set; }
        //営業担当者名称
        public string SalesName { get; set; }
        //営業担当者リスト
        public List<SalesData> SalesDataList { get; set; }
        //納品場所
        public string DeliveryPlace { get; set; }
        //納品期日
        public string DeliveryDate { get; set; }
        //支払条件
        public string PaymentConditions { get; set; }
        //有効期限
        public string DeliveryDeadlineDate { get; set; }
        //備考
        public string Remarks { get; set; }

        // 明細部
        public List<EstimateInput_PartsList> PartsList { get; set; }

        // 見積金額（外貨）
        public string EstimateValueOut { get; set; }
        // レート
        public string Rate { get; set; }
        // 見積金額（内貨）
        public string EstimateValueIn { get; set; }
        //リポート元製番
        public string RepeatProduct { get; set; }
        // 外注加工費
        public string ProcessingCost { get; set; }
        // 外注加工比率
        public string ProcessingRatio { get; set; }
        //見積書
        public string EstimateReport { get; set; }
        //承認フラグ
        public Boolean ApprovalFlag { get; set; }
        //承認区分
        public string ApprovalType { get; set; }

        //**引合照会***
        //引合番号
        public string inq_InquiryNo { get; set; }
        //お客様依頼番号
        public string inq_UserRequestNo { get; set; }
        //依頼日
        public DateTime inq_RequestDate { get; set; }
        //CAMPUS-ID
        public string inq_CampusId { get; set; }
        //CAMPUS-NAME
        public string inq_CompanyName { get; set; }
        //件名
        public string inq_Subject { get; set; }
        //品種コード
        public string inq_HinsyuCode { get; set; }
        //品名
        public string inq_Hinmei { get; set; }
        //数量
        public string inq_Quantity { get; set; }
        //単位
        public string inq_Unit { get; set; }
        //お問い合わせ
        public string inq_ContentValue { get; set; }
        //見積回答希望日
        public DateTime? inq_QuotationRequestDate { get; set; }
        //希望納期
        public DateTime? inq_DesiredDeliveryDate { get; set; }
        //概算見積番号
        public string inq_ReferenceEstimateNo { get; set; }
    }

    public class SalesData
    {

        public string SalesCode { get; set; }
        public string SalesName { get; set; }

        public SalesData(string _SalesCode, string _SalesName)
        {
            SalesCode = _SalesCode;
            SalesName = _SalesName;
        }
    }

    public class EstimateInput_PartsList
    {
        //品名コード
        public string HinmeiCode { get; set; }
        //品名
        public string HinmeiName { get; set; }
        //数量
        public double? Suryo { get; set; }
        //単位
        public string Unit { get; set; }
        //単価
        public double? Unitprice { get; set; }
        //金額
        public double? Price { get; set; }

        public EstimateInput_PartsList(string _HinmeiCode, string _HinmeiName, double? _Suryo, string _Unit,
                                       double? _Unitprice, double? _Price)
        {
            HinmeiCode = _HinmeiCode;
            HinmeiName = _HinmeiName;
            Suryo = _Suryo;
            Unit = _Unit;
            Unitprice = _Unitprice;
            Price = _Price;
        }
    }
}