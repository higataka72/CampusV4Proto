using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class MeasurementCheckSheetInputViewModel
    {

        //製造担当者コード
        public string ProductionEmployeeCode { get; set; }
        //製造担当者名
        public string ProductionEmployeeName { get; set; }
        //受入番号
        public string PurchasingNumber { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //分納回数
        public double? Splitdelivery { get; set; }
        //CAMPUS-ID
        public string CampusId { get; set; }
        //会社名
        public string CompanyName { get; set; }
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
        //部品名
        public string PartsName { get; set; }
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
        //予定着手日
        public DateTime? ScheduleStartDate { get; set; }
        //予定着手時間
        public string ScheduleStartTime { get; set; }
        //予定完了日
        public DateTime? ScheduleCompletionDate { get; set; }
        //予定完了時間
        public string ScheduleCompletionTime { get; set; }
        //予定時間
        public Decimal? ScheduleTime { get; set; }
        //実績着手日
        public DateTime? AchievementStartDate { get; set; }
        //実績着手時間
        public string AchievementStartTime { get; set; }
        //実績完了日
        public DateTime? AchievementCompletionDate { get; set; }
        //実績完了時間
        public string AchievementCompletionTime { get; set; }
        //実績時間
        public Decimal? AchievementTime { get; set; }

        //担当者リスト
        public List<EmployeeData> EmployeeDataList { get; set; }
        //時間リスト
        public List<MasterData> TimeList { get; set; }


    }
}