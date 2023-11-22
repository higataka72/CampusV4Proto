using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class ContactConfirmationInputViewModel
    {
        //確認者コード
        public string Seiban { get; set; }
        //登録日
        public DateTime? RegistDate { get; set; }
        //確認日
        public DateTime? ConfirmerDate { get; set; }
        //入力者コード
        public string InputManCode { get; set; }
        //確認者コード
        public string ConfirmerCode { get; set; }
        //確認チェック
        public bool ConfirmationCheck { get; set; }
        //入力内容
        public string InputNote { get; set; }
        //確認済
        public bool ConfirmedCheck { get; set; }
        //入力者名
        public string InputManName { get; set; }
        //確認者名
        public string ConfirmerName { get; set; }

        //入力者リスト
        public List<EmployeeData> InputManDataList { get; set; }
        //確認者リスト
        public List<EmployeeData> ConfirmerDataList { get; set; }

        //確認者リスト
        public List<ContactConfirmationListData> ContactConfirmationList { get; set; }

        //部品名
        public string PartsName { get; set; }

        //検索項目
        public string SearchItem { get; set; }

    }
    public class ContactConfirmationListData
    {
        //登録日
        public DateTime? RegistDate { get; set; }
        //入力内容
        public string InputNote { get; set; }
        //確認者名
        public string ConfirmerName { get; set; }
        //確認日
        public DateTime? ConfirmerDate { get; set; }
        //部品名
        public string PartsName { get; set; }
        //検索項目
        public string SearchItem { get; set; }

        public ContactConfirmationListData(string _partsname, string _searchitem, DateTime? _registDate, string _inputNote, string _confirmerName, DateTime? _confirmerDate)
        {
            PartsName = _partsname;
            SearchItem = _searchitem;
            RegistDate = _registDate;
            InputNote = _inputNote;
            ConfirmerName = _confirmerName;
            ConfirmerDate = _confirmerDate;
        }
    }
}