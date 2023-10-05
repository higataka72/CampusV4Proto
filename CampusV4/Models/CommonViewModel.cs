using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace CampusV4.Models
{
    public class CommonViewModel
    {
        public List<SupplierData> SupplierDataList { get; set; }
    }

    public class MasterData
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public MasterData()
        {
        }
        public MasterData(string _Code, string _Name)
        {
            Code = _Code;
            Name = _Name;
        }
    }

    public class InquiryHistoryData
    {
        public string InquiryNum { get; set; }
        public string Hinmei { get; set; }
        public double? Amount { get; set; }

        public InquiryHistoryData()
        {
        }
        public InquiryHistoryData(string _InquiryNum, string _Hinmei, double _Amount = 0)
        {
            InquiryNum = _InquiryNum;
            Hinmei = _Hinmei;
            Amount = _Amount;
        }
    }

    public class SupplierData
    {
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string DepartmentName { get; set; }
        public string Email { get; set; }

        public SupplierData()
        {
        }
        public SupplierData(string _SupplierCode, string _SupplierName, string _DepartmentName, string _Email)
        {
            SupplierCode = _SupplierCode;
            SupplierName = _SupplierName;
            DepartmentName = _DepartmentName;
            Email = _Email;
        }
    }
    public class MailAddressData
    {
        public string PartnerPersonCode { get; set; }
        public string PartnerPersonName { get; set; }
        public string Email { get; set; }

        public MailAddressData()
        {
        }
        public MailAddressData(string _PartnerPersonCode, string _PartnerPersonName, string _Email)
        {
            PartnerPersonCode = _PartnerPersonCode;
            PartnerPersonName = _PartnerPersonName;
            Email = _Email;
        }
    }

    public class PartsData
    {
        public Boolean RowCheck { get; set; }
        public double? RowNumber { get; set; }
        public string PartsCategory { get; set; }
        public string PartsName { get; set; }
        public string DrawingNumber { get; set; }
        public string PartsModel { get; set; }
        public double? IriSu { get; set; }
        public double? Kosu { get; set; }

        public PartsData()
        {
        }
        public PartsData(Boolean _RowCheck, double? _RowNumber, string _PartsCategory, 
                         string _PartsName, string _DrawingNumber, string _PartsModel, double? _IriSu, double? _Kosu)
        {
            RowCheck = _RowCheck;
            RowNumber = _RowNumber;
            PartsCategory = _PartsCategory;
            PartsName = _PartsName;
            DrawingNumber = _DrawingNumber;
            PartsModel = _PartsModel;
            IriSu = _IriSu;
            Kosu = _Kosu;
        }
    }


}