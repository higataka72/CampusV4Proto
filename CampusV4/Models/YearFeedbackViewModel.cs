using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class YearFeedbackViewModel
    {
        //CAMPUS-ID
        public string CampusId { get; set; }
        //会社名
        public string CompanyName { get; set; }
        //部署名
        public string Department { get; set; }
        //ご担当者様名
        public string ManagerName { get; set; }
        //評価年度の範囲From
        public DateTime? Evaluation_yymm_From { get; set; }
        //評価年度の範囲To
        public DateTime? Evaluation_yymm_To { get; set; }
        //コメント入力者コード
        public string CommentInputCode { get; set; }
        //コメント入力者名
        public string CommentInputName { get; set; }
        //比較先１コード
        public string Comparison1Code { get; set; }
        //比較先１名
        public string Comparison1Name { get; set; }
        //比較先２コード
        public string Comparison2Code { get; set; }
        //比較先２名
        public string Comparison2Name { get; set; }
        //参考仕入１
        public string ReferenceEestimate1 { get; set; }
        //参考仕入２
        public string ReferenceEestimate2 { get; set; }
        //参考仕入３
        public string ReferenceEestimate3 { get; set; }
        //参考見積１
        public string ReferencePurchase1 { get; set; }
        //参考見積２
        public string ReferencePurchase2 { get; set; }
        //参考見積３
        public double? ReferencePurchase3 { get; set; }
        //コメント
        public string Comment_YearFeedback { get; set; }

        // 比較先リスト
        public List<MasterData> ComparisonDataList { get; set; }
        //担当者リスト
        public List<EmployeeData> CommentInputDataList { get; set; }
    }
    public class YearFeedbackPrintViewModel
    {
        public List<YearFeedbackRadarData> RadarDataList { get; set; }

        //対前年評価
        public string PreviousYearEvaluation { get; set; }
        //対前々年評価
        public string TwoYearsBeforeEvaluation { get; set; }

        //評価年度の範囲From
        public DateTime? Evaluation_yymm_From { get; set; }
        //評価年度の範囲To
        public DateTime? Evaluation_yymm_To { get; set; }
        //総合評価ランク
        public string TotalEvaluationRank { get; set; }
        //総合評価
        public string TotalEvaluationName { get; set; }
        //年間順位
        public string Rank { get; set; }
        //コメント入力者名
        public string CommentInputName { get; set; }
        //コメント
        public string Comment_Print { get; set; }

        //提出件数（当年）
        public double? FilingNum_CurrentYear { get; set; }
        //不採用件数（当年）
        public double? NotAdopted_CurrentYear { get; set; }
        //採用件数（当年）
        public double? AdoptionNum_CurrentYear { get; set; }
        //対前年比（見積）
        public double? PreviousYearRatioEstimate { get; set; }
        //対前々年比（見積）
        public double? TwoYearsBeforeRatioEstimate { get; set; }
        //提出件数（前年）
        public double? FilingNum_LastYear { get; set; }
        //不採用件数（前年）
        public double? NotAdopted_LastYear { get; set; }
        //採用件数（前年）
        public double? AdoptionNum_LastYear { get; set; }
        //提出件数（前々年）
        public double? FilingNum_TwoYearsBefore { get; set; }
        //不採用件数（前々年）
        public double? NotAdopted_TwoYearsBefore { get; set; }
        //採用件数（前々年）
        public double? AdoptionNum_TwoYearsBefore { get; set; }

        //受注件数（当年）
        public double? OrderNum_CurrentYear { get; set; }
        //受注金額（当年）
        public double? OrderPrice_CurrentYear { get; set; }
        //受注件数（前年）
        public double? OrderNum_LastYear { get; set; }
        //受注金額（前年）
        public double? OrderPrice_LastYear { get; set; }
        //受注件数（前々年）
        public double? OrderNum_TwoYearsBefore { get; set; }
        //受注金額（前々年）
        public double? OrderPrice_TwoYearsBefore { get; set; }

        //対前年比（件数）（受注）
        public double? PreviousYearRatioOrder_Number { get; set; }
        //対前々年比（件数）（受注）
        public double? TwoYearsBeforeRatioOrder_Number { get; set; }
        //対前年比（金額）（受注）
        public double? PreviousYearRatioOrder_Price { get; set; }
        //対前々年比（金額）（受注）
        public double? TwoYearsBeforeRatioOrder_Price { get; set; }

        public List<YearFeedbackTransactionHistory> TransactionHistoryList { get; set; }

    }

    public class YearFeedbackRadarData
    {
        public string colName { get; set; }

        public List<RadarValue> RadarValueList{ get; set; }

        public YearFeedbackRadarData(
            string _ColName,
            List<RadarValue> _RadarValueList
            )
        {
            colName = _ColName;
            RadarValueList = _RadarValueList;
        }
    }
    public class RadarValue
    {
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public double Value { get; set; }
    }
    public class YearFeedbackTransactionHistory
    {
        //取引履歴区分
        public string TransactionHistoryKbn { get; set; }
        //取引年月
        public string Transaction { get; set; }
        //部品分類コード
        public string PartsCode { get; set; }
        //部品名
        public string PartsName { get; set; }
        //分納回数
        public double? Splitdelivery { get; set; }
        //数量
        public double? Quantity { get; set; }
        //金額
        public double? Price { get; set; }

        public YearFeedbackTransactionHistory(
            string _TransactionHistoryKbn,
            string _Transaction,
            string _PartsCode,
            string _PartsName,
            double _Splitdelivery,
            double _Quantity,
            double _Price
        )
        {
            TransactionHistoryKbn = _TransactionHistoryKbn;
            Transaction = _Transaction;
            PartsCode = _PartsCode;
            PartsName = _PartsName;
            Splitdelivery = _Splitdelivery;
            Quantity = _Quantity;
            Price = _Price;

        }
    }

    

}