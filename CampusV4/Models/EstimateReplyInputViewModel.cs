using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class EstimateReplyInputViewModel
    {
        //見積回答番号
        public string EstimateReplyNo { get; set; }
        //見積依頼番号
        public string EstimateRequestNo { get; set; }
        //見積回答日
        public DateTime? EstimateReplyDate { get; set; }

        //引合番号
        public string InquiryNumber { get; set; }
        //分類記号
        public string GroupingMark { get; set; }
        //製番
        public string ProductionNumber { get; set; }

        //件名
        public string Subject { get; set; }
        //品種コード
        public string VarietyCode { get; set; }
        //品名
        public string ProductName { get; set; }

        //設計担当者コード
        public string DesignEmployeeCode { get; set; }
        //設計担当者名
        public string DesignEmployeeName { get; set; }

        //依頼日
        public DateTime? RequestDate { get; set; }
        //納入希望日
        public DateTime? RequestedShippingDate { get; set; }
        //見積回答希望日
        public DateTime? QuotationBy { get; set; }

        //CAMPUS-ID
        public string CampusId { get; set; }
        //会社名
        public string CompanyName { get; set; }

        //ご担当者様名
        public string SuppliersName { get; set; }
        //部署名
        public string DepartmentName { get; set; }

        //連絡先
        public string PhoneNumber { get; set; }
        //E-Mail
        public string Email { get; set; }

        //備考
        public string Notes { get; set; }

        //資料添付
        public string Attached1 { get; set; }
        public string Attached2 { get; set; }
        public string Attached3 { get; set; }

        //見積依頼区分
        public string RfqClassification { get; set; }

        //確認
        public bool Confirm { get; set; }

        // 品種コードリスト
        public List<HinshuData> HinsyuDataList { get; set; }
        //部品記号リスト
        public List<GroupingMarkData> GroupingMarkList { get; set; }
        //担当者リスト
        public List<EmployeeData> EmployeeDataList { get; set; }

        //明細リスト
        public List<EstimateReplyListData> GridDataList { get; set; }

        //分納明細リスト
        public List<SplitDeliveryListData> SplitDeliveryList { get; set; }

        // 担当者選択(簡易登録)
        public List<SupplierSearchAddData> SupplierSearchAddDataList { get; set; }

    }


    //明細リストデータ
    public class EstimateReplyListData
    {
            //行番号
            public double? RowNumber { get; set; }
            //見積辞退区分
            public Boolean? Decline { get; set; } = false;
            //部品分類
            public string PartsCode { get; set; }
            //部品名
            public string PartsName { get; set; }
            //図面番号／型式
            public string DrawingNumber { get; set; }
            //入数
            public double? IriSu { get; set; }
            //個数
            public double? Quantity { get; set; }
            //単位
            public string Unit { get; set; }
            //表面処理コード
            public string SurfaceTreatment { get; set; }
            //表面処理
            public string SurfaceTreatmentName { get; set; }
            //単価
            public double? Unitprice { get; set; }
            //金額
            public double? Price { get; set; }
            //納期
            public DateTime? ShippingDate { get; set; }

            public EstimateReplyListData()
            {
            }
    }

    //分納リストデータ
    public class SplitDeliveryListData
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
        public DateTime? ShippingDate { get; set; }

        public SplitDeliveryListData()
        {
        }
    }

    // 担当者データ
    public class SupplierSearchAddData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }


        public SupplierSearchAddData(string _col_1, string _col_2, string _col_3, string _col_4, string _col_5)
        {
            Col_1 = _col_1;
            Col_2 = _col_2;
            Col_3 = _col_3;
            Col_4 = _col_4;
            Col_5 = _col_5;
        }
    }
}