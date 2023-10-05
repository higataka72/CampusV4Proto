using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class ApproximateEstimateViewModel
    {

        // ***部品一覧画面***
        // 引合番号
        public string InquiryNo { get; set; }
        //分類記号
        public string GroupingMark { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //登録日
        public DateTime? RegistDate { get; set; }
        // 件名
        public string Subject { get; set; }
        //数量
        public string Quantity { get; set; }
        //単位
        public string Unit { get; set; }
        //納期
        public DateTime? DeadlineDate { get; set; }
        //品種コード
        public string HinsyuCode { get; set; }
        //品名
        public string Hinmei { get; set; }
        //担当者コード
        public string ManagerCode { get; set; }
        //担当者名称
        public string ManagerName { get; set; }
        //注記
        public string Notes { get; set; }
        // 類似製番
        public string SimilarProductNo { get; set; }
        // 総額
        public string TotalAmount { get; set; }

        // 明細部
        public List<ApproximateEstimatePartsListData> PartsList { get; set; }
        // 品種コードマスタより
        public List<HinshuData> HinsyuDataList { get; set; }
        // 担当者リスト
        public List<SalesPersonData> ManagerDataList { get; set; }
        //部品記号リスト
        public List<GroupingMarkData> GroupingMarkList { get; set; }
    }

    public class ProductNumberSpecificationData
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
        public string Col_10 { get; set; }

        public ProductNumberSpecificationData(string _Col_1, string _Col_2, string _Col_3, string _Col_4,
                                                string _Col_5, string _Col_6, string _Col_7, string _Col_8, 
                                                string _Col_9, string _Col_10)
        {
            Col_1 = _Col_1;
            Col_2 = _Col_2;
            Col_3 = _Col_3;
            Col_4 = _Col_4;
            Col_5 = _Col_5;
            Col_6 = _Col_6;
            Col_7 = _Col_7;
            Col_8 = _Col_8;
            Col_9 = _Col_9;
            Col_10 = _Col_10;
        }
    }

    public class EstimateAnswerData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }

        public EstimateAnswerData(string _Col_1, string _Col_2, string _Col_3, string _Col_4, string _Col_5, string _Col_6)
        {
            Col_1 = _Col_1;
            Col_2 = _Col_2;
            Col_3 = _Col_3;
            Col_4 = _Col_4;
            Col_5 = _Col_5;
            Col_6 = _Col_6;
        }
    }

    public class ApproximateEstimatePartsListData
    {
        public string Col_0 { get; set; }
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }
        public string Col_7_1 { get; set; }
        public string Col_8 { get; set; }
        public string Col_9 { get; set; }
        public string Col_10 { get; set; }
        public string Col_11 { get; set; }
        public string Col_12 { get; set; }

        public ApproximateEstimatePartsListData(string _Col_0, string _Col_1, string _Col_2, string _Col_3, string _Col_4,
                                                string _Col_5, string _Col_6, string _Col_7, string _Col_7_1,
                                                string _Col_8, string _Col_9, string _Col_10, string _Col_11,
                                                string _Col_12)
        {
            Col_0 = _Col_0;
            Col_1 = _Col_1;
            Col_2 = _Col_2;
            Col_3 = _Col_3;
            Col_4 = _Col_4;
            Col_5 = _Col_5;
            Col_6 = _Col_6;
            Col_7 = _Col_7;
            Col_7_1 = _Col_7_1;
            Col_8 = _Col_8;
            Col_9 = _Col_9;
            Col_10 = _Col_10;
            Col_11 = _Col_11;
            Col_12 = _Col_12;
        }
    }
}