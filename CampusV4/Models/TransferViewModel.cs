using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class TransferViewModel
    {
        public string Mode { get; set; }

        //受入番号
        public string PurchasingNumber { get; set; }
        //発注番号
        public string OrderNumber { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //分納回数
        public double? Splitdelivery { get; set; }
        //CAMPUS-ID
        public string CampusId { get; set; }
        //会社名
        public string CompanyName { get; set; }
        //手配区分
        public bool ArrangementCodeFlg { get; set; }
        //部署名
        public string DepartmentName { get; set; }
        //ご担当者様名
        public string SuppliersName { get; set; }
        //連絡先
        public string PhoneNumber { get; set; }
        //メールアドレス
        public string Email { get; set; }
        //部品種別
        public string PartsType { get; set; }
        //図面番号／型式
        public string DrawingNumber { get; set; }
        //会計連携日
        public DateTime? AlignmentDate { get; set; }
        //部品名
        public string PartsName { get; set; }
        //加工区分
        public string ProcessingDivision { get; set; }
        //測定日
        public DateTime? MeasurementDate { get; set; }
        //表面処理コード
        public string SurfaceTreatmentCode { get; set; }
        //表面処理
        public string SurfaceTreatment { get; set; }
        //設計担当者コード
        public string DesignEmployeeCode { get; set; }
        //設計担当者名
        public string DesignEmployeeName { get; set; }
        //検査組立担当者コード
        public string TestAssemblyEmployeeCode { get; set; }
        //検査組立担当者名
        public string TestAssemblyEmployeeName { get; set; }
        //受入担当者コード
        public string ReceiptEmployeeCode { get; set; }
        //受入担当者名
        public string ReceiptEmployeeName { get; set; }
        //受入日
        public DateTime? ReceiptDate { get; set; }
        //発行区分検収書
        public bool IssueTypeReceipt { get; set; }
        //発行区分利用料
        public bool IssueTypeUsageFee { get; set; }
        //検査担当者コード
        public string AcceptanceEmployeeCode { get; set; }
        //検査担当者名
        public string AcceptanceEmployeeName { get; set; }
        //検収日
        public DateTime? AcceptanceDate { get; set; }
        //支払予定日
        public DateTime? PaymentDate { get; set; }
        //受入数量
        public double? ReceivedQuantity { get; set; }
        //単位
        public string ReceivedQuantityUnit { get; set; }
        //受入区分
        public bool ReceivedType { get; set; }
        //完納区分
        public bool CompletePaymentType { get; set; }
        //数量指定区分
        public string QuantityType { get; set; }
        //数量
        public double? Quantity { get; set; }
        //検収数量
        public double? AcceptQuantity { get; set; }
        //単位
        public string QuantityUnit { get; set; }
        //単価
        public string Unitprice { get; set; }
        //消費税
        public string Tax { get; set; }
        //税率
        public string TaxRate { get; set; }
        //金額
        public string Price { get; set; }
        //備考
        public string Notes { get; set; }
        //承認
        public bool ApprovalFlg { get; set; }

        //表面処理
        public List<MasterData> SurfaceTreatmentList { get; set; }

        //税率リスト
        public List<MasterData> TaxRateList { get; set; }

        //担当者リスト
        public List<EmployeeData> EmployeeDataList { get; set; }

        //部品リスト
        public List<PartsListData> GridDataList { get; set; }

        // CAMPUS-IDリスト
        public List<PartnerData> PartnerDataList { get; set; }
        // パートナー名称
        public string PartnerName { get; set; }
        // 製番
        public string ProductNumber { get; set; }

        // 発注伝票リスト
        public List<SlipSelectListData> GridSlipSelectDataList { get; set; }

        public List<ProductNoData> ProductNumDataList { get; set; }

    }

    public class ProductNoData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
    }

    //分納選択リスト一覧
    //public class SplitDeliverySelectListData
    //{
    //    //回数
    //    public double? RowNumber { get; set; }
    //    //数量
    //    public double? Quantity { get; set; }
    //    //単価
    //    public double? Unitprice { get; set; }
    //    //金額
    //    public double? Price { get; set; }
    //    //納期
    //    public string ShippingDate { get; set; }
    //    //連携
    //    public string AlignmentDate { get; set; }
    //    //測定
    //    public string MeasurementSstartDate { get; set; }
    //    //完納
    //    public bool CompletepPayment { get; set; }

    //public SplitDeliverySelectListData(
    //    double _RowNumber,
    //    double _Quantity,
    //    double _Unitprice,
    //    double _Price,
    //    string _ShippingDate,
    //    string _AlignmentDate,
    //    string _MeasurementSstartDate,
    //    bool _CompletepPayment)
    //{
    //    RowNumber = _RowNumber;
    //    Quantity = _Quantity;
    //    Unitprice = _Unitprice;
    //    Price = _Price;
    //    ShippingDate = _ShippingDate;
    //    AlignmentDate = _AlignmentDate;
    //    MeasurementSstartDate = _MeasurementSstartDate;
    //    CompletepPayment = _CompletepPayment;
    //}
    //}

    //public class PartnerData
    //{

    //    public string PartnerCode { get; set; }
    //    public string PartnerName { get; set; }

    //    public PartnerData(string _PartnerCode, string _PartnerName)
    //    {
    //        PartnerCode = _PartnerCode;
    //        PartnerName = _PartnerName;
    //    }
    //}

    //public class SlipSelectListData
    //{
    //    public String SlipDate { get; set; }
    //    public String SlipNo { get; set; }
    //    public String ProductNumber { get; set; }
    //    public string ProductName { get; set; }
    //    public string DrawingNumber { get; set; }
    //    public double? Suryo { get; set; }
    //    public double? Tanka { get; set; }
    //    public SlipSelectListData(String _SlipDate, String _SlipNo, String _ProductNumber, string _ProductName,
    //                              string _DrawingNumber, double? _Suryo, double? _Tanka)
    //    {
    //        SlipDate = _SlipDate;
    //        SlipNo = _SlipNo;
    //        ProductNumber = _ProductNumber;
    //        ProductName = _ProductName;
    //        DrawingNumber = _DrawingNumber;
    //        Suryo = _Suryo;
    //        Tanka = _Tanka;
    //    }
    //}
}