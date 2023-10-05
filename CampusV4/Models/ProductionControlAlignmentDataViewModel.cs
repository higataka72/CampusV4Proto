using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class ProductionControlAlignmentDataViewModel
    {
        //処理選択
        public string ProcessKbn { get; set; }
        //対象伝票 受注
        public bool SlipKbnOrderJ { get; set; }
        //対象伝票 発注
        public bool SlipKbnOrderH { get; set; }
        //対象伝票 部品リスト
        public bool SlipKbnPartsList { get; set; }
        //パターン
        public string Pattern { get; set; }
        //製番From
        public string ProductNoFrom { get; set; }
        //製番To
        public string ProductNoTo { get; set; }
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
    public class ProductionControlAlignmentDataDeleteData
    {
        //連番
        public int SeqNo { get; set; }
        //出力日付
        public string OutputDate { get; set; }
        //伝票日付の範囲
        public string SlipDateRange { get; set; }
        //対象伝票
        public string SlipNo { get; set; }

        public ProductionControlAlignmentDataDeleteData(int seqNo,string outputDate, string slipDateRange, string slipNo)
        {
            SeqNo = seqNo;
            OutputDate = outputDate;
            SlipDateRange = slipDateRange;
            SlipNo = slipNo;
        }
    }



}