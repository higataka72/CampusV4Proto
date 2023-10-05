using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class PartsListViewModel
    {
        //引合番号
        public string InquiryNo { get; set; }

        //分類記号
        public string GroupingMark { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //登録日付
        public DateTime? RegistDate { get; set; }
        //件名
        public string Subject { get; set; }
        //数量
        public double? Quantity { get; set; }
        //数量単位
        public string Unit { get; set; }
        //納期
        public DateTime? ShippingDate { get; set; }
        //品種
        public string VarietyCode { get; set; }
        //品名
        public string ProductName { get; set; }
        //担当者コード
        public string EmployeeCode { get; set; }
        //担当者名
        public string EmployeeName { get; set; }
        //注記
        public string Notice{ get; set; }

        //設計図書
        public string Attached1 { get; set; }
        public string Attached2 { get; set; }
        public string Attached3 { get; set; }

        //最終更新日
        public DateTime? LastUpdateDate { get; set; }

        //完了
        public bool Complete { get; set; }

        // 品種コードリスト
        public List<HinshuData> VarietyCodeList { get; set; }
        //部品記号リスト
        public List<GroupingMarkData> GroupingMarkList { get; set; }
        //担当者リスト
        public List<EmployeeData> EmployeeDataList { get; set; }

        //部品リスト
        public List<PartsListData> GridDataList { get; set; }
        // ファイルパス
        public List<Parts_FileSettingListData> GridFileSettingDataList { get; set; }

    }

    //分類記号データ
    public class GroupingMarkData
    {

        public string GroupingMarkCode { get; set; }
        public string GroupingMarkName { get; set; }

        public GroupingMarkData(string _GroupingMarkCode, string _GroupingMarkName)
        {
            GroupingMarkCode = _GroupingMarkCode;
            GroupingMarkName = _GroupingMarkName;
        }
    }


    
    //担当者データ
    public class EmployeeData
    {

        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }

        public EmployeeData(string _EmployeeCode, string _EmployeeName)
        {
            EmployeeCode = _EmployeeCode;
            EmployeeName = _EmployeeName;
        }
    }

    //部品リスト一覧
    public class PartsListData
     {
        //図面チェック
        public Boolean? RowCheck { get; set; }
        //No
        public double? RowNumber { get; set; }
        //行No
        public double? RowNo { get; set; }
        //List Rev
        public string ListRev { get; set; }
        //部品分類
        public string PartsCode { get; set; }
        //部品名
        public string PartsName { get; set; }
        //図面番号/型式
        public string DrawingNumber { get; set; }
        //DWG/Rev
        public string DwgRev { get; set; }
        //入数
        public double? IriSu { get; set; }
        //個数
        public double? Kosu { get; set; }
        //注記
        public string Notice { get; set; }
        //メーカー
        public string Maker { get; set; }
        //原価見積番号
        public string CostEstimateNumber { get; set; }
        public PartsListData()
        {
        }
     }

    //ファイル設定リスト
    public class Parts_FileSettingListData
    {

        public string RowNumber { get; set; }
        public string FilePath { get; set; }

        public Parts_FileSettingListData(string _rownumber, string _filepath)
        {
            RowNumber = _rownumber;
            FilePath = _filepath;
        }
    }
}