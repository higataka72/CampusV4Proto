using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class ReferenceEstimateViewModel
    {
        //品種コード
        public string VarietyCode { get; set; }
        //品名
        public string ProductName { get; set; }
        //ＰＫＧサイズ
        public double? PkgSize { get; set; }
        //ＰＫＧ数行
        public double? PkgNumRow { get; set; }
        //ＰＫＧ数列
        public double? PkgNumCol { get; set; }
        //フレームサイズ縦
        public double? FreamSizeHight { get; set; }
        //フレームサイズ横
        public double? FreamSizeWidth { get; set; }
        //搭載装置コード
        public double? MountingDeviceCode { get; set; }
        //搭載装置名
        public string MountingDeviceName { get; set; }
        //タブレットサイズ
        public double? TabletSize { get; set; }
        //型数
        public double? TypeNum { get; set; }

        // 品種コードマスタより
        public List<HinshuData> HinsyuDataList { get; set; }

        // 製品情報リスト
        public List<VarietyData> VarietyDataList { get; set; }

        //品種コード　ツールチップ
        public string VarietyCodeTT { get; set; }
        //ＰＫＧサイズ　ツールチップ
        public string PkgSizeTT { get; set; }
        //ＰＫＧ数行　ツールチップ
        public string PkgNumTT { get; set; }
        //フレームサイズ縦　ツールチップ
        public string FreamSizeTT { get; set; }
        //搭載装置コード　ツールチップ
        public string MountingDeviceTT { get; set; }
        //タブレットサイズ　ツールチップ
        public string TabletSizeTT { get; set; }
    }

    public class ProductionAddInfoViewModel
    {
        //ＣＡＶ材質コード
        public string CavMaterialCode { get; set; }
        //ＣＡＶ材質
        public string CavMaterial { get; set; }
        //表面処理コード
        public string SurfaceTreatmentCode { get; set; }
        //表面処理
        public string SurfaceTreatment { get; set; }

        // ＣＡＶ材質リスト
        public List<VarietyData> CavMaterialDataList { get; set; }

        // 表面処理リスト
        public List<VarietyData> SurfaceTreatmentDataList { get; set; }

        // オプションリスト
        public List<OptionData> OptionList { get; set; }

        //ＣＡＶ材質 ツールチップ
        public string CavMaterialTT { get; set; }
        //表面処理 ツールチップ
        public string SurfaceTreatmentTT { get; set; }

    }

    public class ReferenceEstimatePriceViewModel
    {
        //概算見積金額From
        public double? ApproximatePriceFrom { get; set; }
        //概算見積金額To
        public double? ApproximatePriceTo { get; set; }
    }

    public class CustomerBaseInfoViewModel
    {
        //御社名
        public string Company { get; set; }
        //部署名
        public string Department { get; set; }
        //ご担当者様名
        public string ManagerName { get; set; }
        //連絡先
        public string ContactAddress { get; set; }
        //メールアドレス
        public string EMail { get; set; }
        //確認用メールアドレス
        public string ConfirmerEMail { get; set; }
        //郵便番号
        public string PostCode { get; set; }
        //住所
        public string Address { get; set; }
        //伝達事項
        public string TransmissionMatters { get; set; }
    }

    public class DesiredInterviewViewModel
    {
        //希望日付
        public DateTime? DesiredDate { get; set; }
        //希望時間
        public string DesiredTime { get; set; }
        //希望時間リスト
        public List<MasterData> DesiredTimeList { get; set; }
    }

    public class VarietyData
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }

        public VarietyData(string _ItemCode, string _ItemName)
        {
            ItemCode = _ItemCode;
            ItemName = _ItemName;
        }
    }

    public class OptionData
    {
        public string OptionCode { get; set; }
        public bool OptionFlg { get; set; }
        public string OptionName { get; set; }
        public string OptionTT { get; set; }

        public OptionData(string _OptionCode, bool _OptionFlg, string _OptionName, string _OptionTT)
        {
            OptionCode = "Option_" + _OptionCode;
            OptionFlg = _OptionFlg;
            OptionName = _OptionName;
            OptionTT = _OptionTT;
        }
    }
}