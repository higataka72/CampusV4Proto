using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class InquiryListViewModel
    {
        //引合番号
        public string InquiryNumber { get; set; }
        //営業担当者コード
        public string SalesEmployeeCode { get; set; }
        //営業担当者名
        public string SalesEmployeeName { get; set; }
        //依頼日From
        public DateTime? RequestDateFrom { get; set; }
        //依頼日To
        public DateTime? RequestDateTo { get; set; }

        //受注予定日From
        public DateTime? ExpectedOrderDateFrom { get; set; }
        //受注予定日From
        public DateTime? ExpectedOrderDateTo { get; set; }

        //受注月From
        public DateTime? ReceptionDateFrom { get; set; }
        //受注月From
        public DateTime? ReceptionDateTo { get; set; }

        //進捗詳細From
        public string ProgressDetailsCodeFrom { get; set; }
        //進捗詳細名From
        public string ProgressDetailsNameFrom { get; set; }
        //進捗詳細To
        public string ProgressDetailsCodeTo { get; set; }
        //進捗詳細名To
        public string ProgressDetailsNameTo { get; set; }

        //得意先名
        public string CustomerName { get; set; }
        //品名
        public string ProductName { get; set; }

        // 進捗詳細Fromリスト
        public List<MasterData> ProgressDetailsCodeListFrom { get; set; }

        // 進捗詳細Toリスト
        public List<MasterData> ProgressDetailsCodeListTo { get; set; }

        //担当者リスト
        public List<EmployeeData> SalesEmployeeDataList { get; set; }

        //部品リスト
        public List<InquiryListData> GridDataList { get; set; }

    }

    
    //引合リスト一覧
    public class InquiryListData
    {
        //行番号
        public double? RowNumber { get; set; }
        //受注予定月
        public DateTime? ExpectedOrderDate { get; set; }
        //受付月
        public DateTime? ReceptionDate { get; set; }
        //内示マーク
        public string InternalAnnouncementMark { get; set; }
        //営業担当者
        public string SalesEmploeeName { get; set; }
        //得意先名
        public string CustomerName { get; set; }
        //品名
        public string ProductName { get; set; }
        //引合番号
        public string InquiryNumber { get; set; }
        //受注確率
        public double? OrderProbability { get; set; }
        //外注原価
        public double? SubcontractCost { get; set; }
        //加工比率
        public double? ProcessingRatio { get; set; }
        //見積金額
        public double? EstimatedAmount { get; set; }
        //受注金額
        public double? OrderAmount { get; set; }
        //最終受注金額
        public double? LastOrderAmount { get; set; }
        //納期
        public DateTime? ShippingDate { get; set; }
        //更新日
        public DateTime? UpdatedOn { get; set; }
        //URL(見積回答入力)
        public string URL { get; set; }


        public InquiryListData()
        {
        }
     }
    
}