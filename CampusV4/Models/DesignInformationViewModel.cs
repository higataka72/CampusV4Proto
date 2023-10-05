using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class DesignInformationViewModel
    {
        //引合番号
        public string InquiryNo2 { get; set; }
        //分類記号
        public string GroupingMark { get; set; }
        //件名
        public string Subject2 { get; set; }
        //設計担当者コード(主)
        public string Manager1Code { get; set; }
        //設計担当者名(主)
        public string Manager1Name { get; set; }
        //出図予定日
        public DateTime? DrawingScheduleDate { get; set; }
        //設計担当者コード(従)
        public string Manager2Code { get; set; }
        //設計担当者名(従)
        public string Manager2Name { get; set; }
        //出図日
        public DateTime? DrawingDate { get; set; }
        //検図担当者コード
        public string Manager3Code { get; set; }
        //検図担当者名
        public string Manager3Name { get; set; }
        //検図日
        public DateTime? InspectionDate { get; set; }
        //原価資料担当者コード
        public string Manager4Code { get; set; }
        //原価資料担当者名
        public string Manager4Name { get; set; }
        //作成予定日
        public DateTime? CreateScheduleDate { get; set; }
        //作成日
        public DateTime? CreateDate { get; set; }


        //部品記号リスト
        public List<GroupingMarkData> GroupingMarkList { get; set; }
        //担当者リスト
        public List<EmployeeData> EmployeeDataList { get; set; }

    }

    //分類記号データ
    public class DI_GroupingMarkData
    {

        public string GroupingMarkCode { get; set; }
        public string GroupingMarkName { get; set; }

        public DI_GroupingMarkData(string _GroupingMarkCode, string _GroupingMarkName)
        {
            GroupingMarkCode = _GroupingMarkCode;
            GroupingMarkName = _GroupingMarkName;
        }
    }



    //担当者データ
    public class DI_EmployeeData
    {

        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }

        public DI_EmployeeData(string _EmployeeCode, string _EmployeeName)
        {
            EmployeeCode = _EmployeeCode;
            EmployeeName = _EmployeeName;
        }
    }
}