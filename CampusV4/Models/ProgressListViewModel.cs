using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class ProgressListViewModel
    {
        //引合番号
        public string InquiryNumber { get; set; }
        //営業担当者コード
        public string SalesEmployeeCode { get; set; }
        //営業担当者名
        public string SalesEmployeeName { get; set; }
        //受注予定月From
        public DateTime? ExpectedOrderDateFrom { get; set; }
        //受注予定月To
        public DateTime? ExpectedOrderDateTo { get; set; }
        //受注月From
        public DateTime? ReceptionDateFrom { get; set; }
        //受注月To
        public DateTime? ReceptionDateTo { get; set; }
        //納期From
        public DateTime? ShippingDateFrom { get; set; }
        //納期To
        public DateTime? ShippingDateTo { get; set; }
        //更新日From
        public DateTime? UpdatedOnFrom { get; set; }
        //更新日To
        public DateTime? UpdatedOnTo { get; set; }
        //ステータスFrom
        public string StatusFrom { get; set; }
        //ステータスFrom
        public string StatusNameFrom { get; set; }
        //ステータスTo
        public string StatusTo { get; set; }
        //ステータスTo
        public string StatusNameTo { get; set; }

        //得意先名
        public string CustomerName { get; set; }
        //品名
        public string ProductName { get; set; }

        // ステータスリスト
        public List<MasterData> StatusDataList { get; set; }

        //担当者リスト
        public List<EmployeeData> SalesEmployeeDataList { get; set; }

        //進捗一覧リスト
        public List<ProgressListData> GridDataList { get; set; }

    }


    //進捗一覧
    public class ProgressListData
    {
        //見積マーク
        public string EstimatedMark { get; set; }
        //引合番号
        public string InquiryNumber { get; set; }
        //進捗詳細
        public string ProgressDetails { get; set; }
        //内示マーク
        public string InternalAnnouncementMark { get; set; }
        //依頼日
        public DateTime? RequestDate { get; set; }
        //得意先名
        public string CustomerName { get; set; }
        //品名
        public string ProductName { get; set; }
        //原価資料作成予定日
        public DateTime? ExpectedCostDocumentDate { get; set; }
        //原価見積作成予定日
        public DateTime? ExpectedCostEstimateDate { get; set; }
        //出荷予定日
        public DateTime? EstimatedShippingDate { get; set; }
        //発注日
        public DateTime? OrderDate { get; set; }
        //入荷予定日
        public DateTime? ExpectedReceiptDate { get; set; }
        //完成予定日
        public DateTime? ExpectedCompleteDate { get; set; }
        //出荷指示日
        public DateTime? ShippingInstructionDate { get; set; }
        //出荷日
        public DateTime? ShipDate { get; set; }
        //営業担当者
        public string SalesEmployeeName { get; set; }


        public ProgressListData()
        {
        }
     }
    
}