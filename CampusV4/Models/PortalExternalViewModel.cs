using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class PortalExternalViewModel
    {
        public List<PortalExternalPartnerData> PortalExternalPartnerDataList { get; set; }
        public List<PortalExternalPartnerData> PortalExternalPartnerAchievementDataList { get; set; }
    }

    public class PortalExternalPartnerData
    {
        //ID
        public string Id { get; set; }
        //ファイルパス
        public string FilePath { get; set; }
        //ファイル名
        public string FileName { get; set; }
    }

    public class PortalExternalDetailViewModel
    {
        //品種
        public string Variety { get; set; }
        //製作区分
        public string ProductionCategory { get; set; }
        //フレームセット数
        public double? FreamSetNum { get; set; }
        //材質
        public string Material { get; set; }
        //表面処理
        public string SurfaceTreatment { get; set; }
        //PKG数　連　From
        public double? PkgNumSerialFrom { get; set; }
        //PKG数　連　To
        public double? PkgNumSerialTo { get; set; }
        //PKG数　列　From
        public double? PkgNumColumnFrom { get; set; }
        //PKG数　列　To
        public double? PkgNumColumnTo { get; set; }
        //PKGサイズ　幅　From
        public double? PkgSizeWidthFrom { get; set; }
        //PKGサイズ　幅　To
        public double? PkgSizeWidthTo { get; set; }
        //PKGサイズ　長　From
        public double? PkgSizeLengthFrom { get; set; }
        //PKGサイズ　長　To
        public double? PkgSizeLengthTo { get; set; }
        //PKGサイズ　厚　From
        public double? PkgSizeThicknessFrom { get; set; }
        //PKGサイズ　厚　To
        public double? PkgSizeThicknessTo { get; set; }
        //リードフレーム　幅　From
        public double? LeadFrameWidthFrom { get; set; }
        //リードフレーム　幅　To
        public double? LeadFrameWidthTo { get; set; }
        //リードフレーム　長　From
        public double? LeadFrameLengthFrom { get; set; }
        //リードフレーム　長　To
        public double? LeadFrameLengthTo { get; set; }
        //リードフレーム　厚　From
        public double? LeadFrameThicknessFrom { get; set; }
        //リードフレーム　厚　To
        public double? LeadFrameThicknessTo { get; set; }
    }

}