using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class CostEstimateInputViewModel
    {
        //** 主画面　**//
        // モード
        public string Mode { get; set; }

        // 見積依頼番号
        public string EstimateNo { get; set; }
        // 引合番号
        public string InquiryNo { get; set; }
        // 分類記号
        public string ClassificationSymbol { get; set; }
        // 分類記号名称
        public string ClassificationSymbolName { get; set; }
        // 製番
        public string SerialNo { get; set; }
        // 件名
        public string Subject { get; set; }
        // 公開
        public Boolean Release { get; set; }
        // 品種
        public string HinsyuCode { get; set; }
        // 品名
        public string Hinmei { get; set; }
        // 設計担当者
        public string DesignPersonCode { get; set; }
        // 設計担当者名
        public string DesignPersonName { get; set; }
        // 検査組立担当者
        public string TestAssemblyPersonCode { get; set; }
        // 検査組立担当者名
        public string TestAssemblyPersonName { get; set; }
        // 依頼日
        public DateTime RequestedDate { get; set; }
        // 納入希望日
        public DateTime DeliveryDate { get; set; }
        // 見積回答希望日
        public DateTime EstimateAnswerDate { get; set; }
        // EstimateType（1:概算または出図前見積依頼 / 2:正式見積依頼 / 3:最終見積依頼)
        public int EstimateType { get; set; }
        // ProcessingType（1:1次加工 / 2:型一式等 / 3:2次加工)
        public int ProcessingType { get; set; }
        // ProcessingTypeその他
        public string ProcessingTypeName { get; set; }
        // 出図予定日（1次加工）
        public DateTime? DrawingScheduleDate { get; set; }
        // 出図予定日（型一式等）
        public DateTime? DrawingScheduleDate2 { get; set; }
        // 一次加工品の出荷日(2次加工)
        public DateTime? ShipDate { get; set; }
        // 添付ファイル
        public string Attached1 { get; set; }
        // 備考
        public string Remarks { get; set; }


        // 品種コードマスタより
        public List<CostEstimate_HinshuData> HinsyuDataList { get; set; }
        // 分類記号マスタより
        public List<CostEstimate_ClassificationData> ClassificationDataList { get; set; }
        // 設計担当者コードマスタより
        public List<CostEstimate_DesignPersonData> DesignPersonDataList { get; set; }
        // 検査組立担当者コードマスタより
        public List<CostEstimate_TestAssemblyPersonData> TestAssemblyPersonDataList { get; set; }

        // 部品リスト
        public List<CostEstimate_PartsListData> GridDataList { get; set; }
        // 工場選択：パートナーマスタリスト
        public List<CostEstimate_PartnerListData> GridPartnerListDataList { get; set; }
        // 工場選択：パートナーマスタリスト
        public List<CostEstimate_GrobalListData> GridGrobalListDataList { get; set; }

        // 部品選択リスト
        public List<CostEstimate_PartsSelectListData> GridPartsSelectDataList { get; set; }

        // キーワードマスてメンテナンス
        // 添付ファイル
        public string Key_CampusId { get; set; }
        // 備考
        public string Key_CampusName { get; set; }

    }

    public class CostEstimate_HinshuData
    {

        public string HinsyuCode { get; set; }
        public string Hinmei { get; set; }

        public CostEstimate_HinshuData(string _HinsyuCode, string _Hinmei)
        {
            HinsyuCode = _HinsyuCode;
            Hinmei = _Hinmei;
        }
    }

    public class CostEstimate_ClassificationData
    {

        public string ClassificationCode { get; set; }
        public string ClassificationSymbolName { get; set; }

        public CostEstimate_ClassificationData(string _ClassificationCode, string _ClassificationSymbolName)
        {
            ClassificationCode = _ClassificationCode;
            ClassificationSymbolName = _ClassificationSymbolName;
        }
    }

    public class CostEstimate_DesignPersonData
    {

        public string DesignPersonCode { get; set; }
        public string DesignPersonName { get; set; }

        public CostEstimate_DesignPersonData(string _DesignPersonCod, string _DesignPersonName)
        {
            DesignPersonCode = _DesignPersonCod;
            DesignPersonName = _DesignPersonName;
        }
    }

    public class CostEstimate_TestAssemblyPersonData
    {

        public string TestAssemblyPersonCode { get; set; }
        public string TestAssemblyPersonName { get; set; }

        public CostEstimate_TestAssemblyPersonData(string _TestAssemblyPersonCode, string _TestAssemblyPersonName)
        {
            TestAssemblyPersonCode = _TestAssemblyPersonCode;
            TestAssemblyPersonName = _TestAssemblyPersonName;
        }
    }

    //部品リスト一覧
    public class CostEstimate_PartsListData
    {
        //行番号
        public double? RowNumber { get; set; }
        //No
        public double? No { get; set; }
        //部品分類
        public string PartsCode { get; set; }
        //部品名
        public string PartsName { get; set; }
        //図面番号/型式
        public string DrawingNumber { get; set; }
        //入数
        public double? IriSu { get; set; }
        //個数
        public double? Kosu { get; set; }
        //単位
        public string Tani { get; set; }
        //表面処理コード
        public string SurfaceCode { get; set; }
        //メーカー
        public string SurfaceProcess { get; set; }
        public CostEstimate_PartsListData()
        {
        }
    }

    //部品選択リスト一覧
    public class CostEstimate_PartsSelectListData
    {
        public Boolean RowCheck { get; set; }
        public double? RowNumber { get; set; }
        public double? No { get; set; }
        public string PartsCategory { get; set; }
        public string PartsName { get; set; }
        public string DrawingNumber { get; set; }
        public double? IriSu { get; set; }
        public double? Kosu { get; set; }
        public CostEstimate_PartsSelectListData(Boolean _rowcheck, double? rownumber, double? _rowno, string _partscategory,
                                                string _partsname, string _drawingnumber, double? _irisu, double? _kosu)
        {
            RowCheck = _rowcheck;
            No = _rowno;
            RowNumber = rownumber;
            PartsCategory = _partscategory;
            PartsName = _partsname;
            DrawingNumber = _drawingnumber;
            IriSu = _irisu;
            Kosu = _kosu;
        }
    }

    public class CostEstimate_PartnerListData
    {
        //行チェック
        public Boolean? RowCheck { get; set; }
        //行番号
        public double? RowNumber { get; set; }
        //パートナー工場
        public string PartnerName { get; set; }
        //担当者名
        public string PersonName { get; set; }
        //会員区分
        public string MemberType { get; set; }
        //品質
        public double? Quality { get; set; }
        //納期
        public double? Deadline { get; set; }
        //費用
        public double? Cost { get; set; }
        //対応
        public double? Correspondence { get; set; }
        //短縮
        public double? Shortening { get; set; }
        //効率
        public double? Efficiency { get; set; }
        public CostEstimate_PartnerListData(Boolean? _rowcheck, double? _rownumber, string _partnername, string _personname,
                                            string _membertype, double? _quality, double? _deadline, double? _cost, 
                                            double? _correspondence, double? _shortening, double? _efficiency)
        {
            RowCheck = _rowcheck;
            RowNumber = _rownumber;
            PartnerName = _partnername;
            PersonName = _personname;
            MemberType = _membertype;
            Quality = _quality;
            Deadline = _deadline;
            Cost = _cost;
            Correspondence = _correspondence;
            Shortening = _shortening;
            Efficiency = _efficiency;
        }
    }

    public class CostEstimate_GrobalListData
    {
        //行番号
        public double? RowNumber { get; set; }
        //サイトURL
        public string SiteUrl { get; set; }
        //主検索キーワード
        public string SearchKeyword { get; set; }
        //サブキーワード
        public string SubKeyword { get; set; }
        public CostEstimate_GrobalListData(double? _rownumber, string _siteurl, string _searchkeyword, string _subkeyword)
        {
            RowNumber = _rownumber;
            SiteUrl = _siteurl;
            SearchKeyword = _searchkeyword;
            SubKeyword = _subkeyword;
        }
    }

}