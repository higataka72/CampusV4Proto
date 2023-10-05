using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class AccountantAlignmentDataOutputDataViewModel
    {
        //処理選択
        public string ProcessKbn { get; set; }
        //対象伝票 仕入
        public bool SlipKbnPurchase { get; set; }
        //対象伝票 利用料
        public bool SlipKbnUsage { get; set; }
        //対象伝票 売上
        public bool SlipKbnEarnings { get; set; }
        //出力日付
        public DateTime? OutputDate { get; set; }
        //担当者コード
        public string EmployeeCode { get; set; }
        //担当者名
        public string EmployeeName { get; set; }
        //伝票日付From
        public DateTime? SlipDateFrom { get; set; }
        //伝票日付To
        public DateTime? SlipDateTo { get; set; }
        //伝票№From
        public string SlipNoFrom { get; set; }
        //伝票№To
        public string SlipNoTo { get; set; }

        //担当者リスト
        public List<EmployeeData> EmployeeDataList { get; set; }

    }
    public class AccountantAlignmentDataOutputDataDeleteData
    {
        //連番
        public int SeqNo { get; set; }
        //出力日付
        public string OutputDate { get; set; }
        //伝票日付の範囲
        public string SlipDateRange { get; set; }
        //対象伝票
        public string SlipNo { get; set; }

        public AccountantAlignmentDataOutputDataDeleteData(int seqNo,string outputDate, string slipDateRange, string slipNo)
        {
            SeqNo = seqNo;
            OutputDate = outputDate;
            SlipDateRange = slipDateRange;
            SlipNo = slipNo;
        }
    }



}