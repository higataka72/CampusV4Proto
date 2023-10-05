using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class M_EmployeeViewModel
    {
        public string Mode { get; set; }

        //担当者コード
        public string UserId { get; set; }
        //担当者名
        public string UserName { get; set; }
        //担当者名（外国語）
        public string UserNameAlt { get; set; }
        //所属部門コード
        public string DepartmentCode { get; set; }
        //所属部門名
        public string DepartmentName { get; set; }
        //E-mail
        public string Email { get; set; }
        //パスワード
        public string Password { get; set; }
        //メニューID
        public string MenuId { get; set; }
        //メニュー名
        public string MenuName { get; set; }
        //パスワード変更日
        public DateTime? PasswordChangeDate { get; set; }
        //在職区分
        public string IsRetired { get; set; }
        //上長担当者コード
        public string SupervisorPicCode { get; set; }
        //上長担当者名
        public string SupervisorPicName { get; set; }
        //承認者区分
        public string IsApproverStr { get; set; }
        //承認者区分フラグ（承認者区分=1の場合、Ture）
        public bool IsApprover { get; set; }
        //削除フラグ
        public bool DeleteFlg { get; set; }

        //URL
        public string URL { get; set; }

        //作成日
        public DateTime? CreatedAt { get; set; }
        //作成者コード
        public string CreatedBy { get; set; }
        //作成者名
        public string CreatedName { get; set; }
        //作成プログラムID
        public string CreatedPid { get; set; }
        //更新日
        public DateTime? UpdatedAt { get; set; }
        //更新者コード
        public string UpdatedBy { get; set; }
        //更新者名
        public string UpdatedName { get; set; }
        //更新プログラムID
        public string UpdatedPid { get; set; }
        //削除日
        public DateTime? DeletedAt { get; set; }
        //削除者コード
        public string DeletedBy { get; set; }
        //削除者名
        public string DeletedName { get; set; }
        //削除プログラムID
        public string DeletedPid { get; set; }

        
        //所属部門リスト
        public List<MasterData> DepartmentList { get; set; }

        //上長担当者リスト
        public List<EmployeeData> EmployeeList { get; set; }

        //メニューリスト
        public List<MasterData> MenuList { get; set; }
    }


    public class M_EmployeeSearchViewModel
    {

        //担当者コード
        public string UserId { get; set; }
        //担当者名
        public string UserName { get; set; }

        public List<M_EmployeeViewModel> EmployeeDataList { get; set; }

    }
}