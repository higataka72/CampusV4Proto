using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class OrderInputViewModel
    {

        //製番
        public string Seiban { get; set; }
        //発注番号
        public string HatyuNo { get; set; }
        //発注日
        public DateTime? HatyuDate { get; set; }
        // 仮発注フラグ
        public Boolean KariHatyuFlag { get; set; }
        //CUMPAS-ID
        public string CumpasId { get; set; }
        //CUMPAS-NAME
        public string CumpasName { get; set; }
        // 社内発注
        public Boolean SyanaiFlag { get; set; }
        //部署名
        public string BusyoName { get; set; }
        //ご担当者様名
        public string TantouName { get; set; }
        //連絡先
        public string Address { get; set; }
        //メールアドレス
        public string MailAddress { get; set; }
        //発注担当者
        public string HatyuTantouCode { get; set; }
        //稟議番号
        public string RingiNo { get; set; }
        //不良伝票
        public string FuryoDenpyoNo { get; set; }
        // 発注フラグ
        public Boolean HatyuFlag { get; set; }
        // 現品票
        public Boolean GenpinFlag { get; set; }
        //備考
        public string Memo { get; set; }

        //承認区分
        public string ApprovalType { get; set; }

        //部品コード
        public string PartsListCode { get; set; }
        //部品名称
        public string　PartsListName { get; set; }
        //表面処理コード
        public string SurfaceListCode { get; set; }
        //表面処理名称
        public string SurfaceListName { get; set; }
        //設計担当者コード
        public string DesignManListCode { get; set; }
        //設計担当者名称
        public string DesignManListName { get; set; }
        //設計担当者コード
        public string OrderManListCode { get; set; }
        //設計担当者名称
        public string OrderManListName { get; set; }

        // 部品リスト
        public List<MasterData> oim_PartsListData { get; set; }

        //部品明細リスト
        public List<Order_PartsListData> oim_GridPartsDataList { get; set; }
        // 部品選択リスト
        public List<OrderInput_PartsSelectListData> GridPartsSelectDataList { get; set; }

        // 表面処理
        public List<MasterData> oim_SurfaceListData { get; set; }

        // 設計担当者
        public List<MasterData> oim_DesignManListData { get; set; }
        // 発注担当者
        public List<MasterData> oim_OrderManListData { get; set; }
    }

    public class PartsSelectData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
    }

    public class Order_PartsListData
    {
        //行番号
        public double? RowNumber { get; set; }
        //辞退区分
        public Boolean? Decline { get; set; } = false;
        //部品分類
        public string PartsCode { get; set; }
        //部品名
        public string PartsName { get; set; }
        //図面番号／型式
        public string DrawingNumber { get; set; }
        //入数
        public double? IriSu { get; set; }
        //個数
        public double? Quantity { get; set; }
        //数量
        public double? Suryo { get; set; }
        //単位
        public string Unit { get; set; }
        //表面処理コード
        public string SurfaceTreatment { get; set; }
        //表面処理
        public string SurfaceTreatmentName { get; set; }
        //単価
        public double? Unitprice { get; set; }
        //金額
        public double? Price { get; set; }
        //納期
        public DateTime? ShippingDate { get; set; }
        //備考
        public string Remarks { get; set; }
        //検収フラグ
        public Boolean? Acceptance { get; set; } = false;

        public Order_PartsListData(double? _rownumber, Boolean? _decline, string _partscode, string _partsname,
                                   string _drawingnumber, double? _irisu, double? _quantity, double? _suryo, string _unit,
                                   string _surfacetreatment, string _surfacetreatmentname, double? _unitprice, double? _price,
                                   DateTime? _shippingdate, string _remarks, Boolean? _acceptance)
        {
            RowNumber = _rownumber;
            Decline = _decline;
            PartsCode = _partscode;
            PartsName = _partsname;
            DrawingNumber = _drawingnumber;
            IriSu = _irisu;
            Quantity = _quantity;
            Suryo = _suryo;
            Unit = _unit;
            SurfaceTreatment = _surfacetreatment;
            SurfaceTreatmentName = _surfacetreatmentname;
            Unitprice = _unitprice;
            Price = _price;
            ShippingDate = _shippingdate;
            Remarks = _remarks;
            Acceptance = _acceptance;
        }
    }

    //部品選択リスト一覧
    public class OrderInput_PartsSelectListData
    {
        public Boolean RowCheck { get; set; }
        public double? RowNumber { get; set; }
        public double? No { get; set; }
        public string PartsCategory { get; set; }
        public string PartsName { get; set; }
        public string DrawingNumber { get; set; }
        public double? IriSu { get; set; }
        public double? Kosu { get; set; }
        public OrderInput_PartsSelectListData(Boolean _rowcheck, double? rownumber, double? _rowno, string _partscategory,
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
}