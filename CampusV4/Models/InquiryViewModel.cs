using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class InquiryViewModel
    {
        //** 主画面　**//
        // モード
        public string Mode { get; set; }

        public string InquiryNo { get; set; }

        public string UserRequestNo { get; set; }

        public DateTime RequestDate { get; set; }

        public string CampusId { get; set; }
        public string CompanyName{ get; set; }

        public string EmailAddress { get; set; }
        public string Subject { get; set; }

        public string HinsyuCode { get; set; }

        public string Hinmei { get; set; }

        public string Quantity { get; set; }
        public string Unit { get; set; }

        public string ContentValue { get; set; }

        public string Attached1 { get; set; }
        public string Attached2 { get; set; }
        public string Attached3 { get; set; }
        public DateTime? QuotationRequestDate { get; set; }
        public DateTime? DesiredDeliveryDate { get; set; }
        public string ReferenceEstimateNo { get; set; }

        // 品種コードマスタより
        public List<HinshuData> HinsyuDataList { get; set; }

        //** 得意先情報　**//
        // 担当者名
        public string CustomerPerson { get; set; }
        // 部署名
        public string CustomerDepartment { get; set; }
        // 電話番号
        public string CustomerTel { get; set; }
        // E-Mail
        public string CustomerEmail { get; set; }
        // 郵便番号
        public string CustomerPostCode { get; set; }
        // 住所
        public string CustomerAddress { get; set; }
        // 納入郵便番号
        public string CustomerDeliveryPostCode { get; set; }
        // 納入住所
        public string CustomerDeliveryAddress { get; set; }

        //** 引合受け明細　**//
        // 依頼日
        public DateTime DetailRequestDate { get; set; }
        // 営業担当者コード
        public string SalesPersonCode { get; set; }
        // 営業担当者
        public string SalesPersonName { get; set; }

        // 営業担当者リスト
        public List<SalesPersonData> SalesPersoDataList { get; set; }
    }

    public class HinshuData
    {

        public string HinsyuCode { get; set; }
        public string Hinmei { get; set; }

        public HinshuData(string _HinsyuCode, string _Hinmei)
        {
            HinsyuCode = _HinsyuCode;
            Hinmei = _Hinmei;
        }
    }

    public class SalesPersonData
    {

        public string SalesPersonCode { get; set; }
        public string SalesPersonName { get; set; }

        public SalesPersonData(string _SalesPersonCode, string _SalesPersonName)
        {
            SalesPersonCode = _SalesPersonCode;
            SalesPersonName = _SalesPersonName;
        }
    }
}