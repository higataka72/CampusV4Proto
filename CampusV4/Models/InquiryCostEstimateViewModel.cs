using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class InquiryCostEstimateViewModel
    {
        public List<InquiryCostEstimateData> InquiryCostEstimateDataList { get; set; }
        public List<EstimateReplyData> EstimateReplyDataList { get; set; }
        public List<MailManagerData> MailManagerDataList { get; set; }

        // 分類記号マスタより
        public List<InguiryCostEstimate_ClassificationData> ClassificationDataList { get; set; }
        // 品種コードマスタより
        public List<HinshuData> HinsyuDataList { get; set; }

        public string selectPartsClass { get; set; }
        public string selectPartsName { get; set; }
        // 分類記号
        public string ClassificationSymbol { get; set; }
        // 品名
        public string Hinmei { get; set; }

        // メール送信履歴用
        public DateTime? SendDateFrom { get; set; }
        public DateTime? SendDateTo { get; set; }
        public string selectFactoryCode { get; set; }
        public string selectFactoryName { get; set; }
        public List<MailSendHistoryData> MailSendHistoryDataList { get; set; }
        public List<MailCategoryData> MailCategoryDataList { get; set; }
    }

    public class InquiryCostEstimateData
    {
        public string Col_1 { get; set; }
        public string Col_1_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public Boolean? Col_4_1 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }
        public int Col_8 { get; set; }
        public string Col_9 { get; set; }
        public string Col_10 { get; set; }
        public string Col_11 { get; set; }
        public string Col_12 { get; set; }
        public string Col_12_1 { get; set; }
        public string Col_12_2 { get; set; }
        public string Col_13 { get; set; }

        public InquiryCostEstimateData(string _col_1, string _col_1_1, string _col_2, string _col_3,
                                       string _col_4, Boolean? _col_4_1, string _col_5, string _col_6,
                                       string _col_7, int _col_8, string _col_9, string _col_10,
                                       string _col_11, string _col_12, string _col_12_1, string _col_12_2, string _col_13)
        {
            Col_1 = _col_1;
            Col_1_1 = _col_1_1;
            Col_2 = _col_2;
            Col_3 = _col_3;
            Col_4 = _col_4;
            Col_4_1 = _col_4_1;
            Col_5 = _col_5;
            Col_6 = _col_6;
            Col_7 = _col_7;
            Col_8 = _col_8;
            Col_9 = _col_9;
            Col_10 = _col_10;
            Col_11 = _col_11;
            Col_12 = _col_12;
            Col_12_1 = _col_12_1;
            Col_12_2 = _col_12_2;
            Col_13 = _col_13;
        }
    }


    public class AssemblableReferenceData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }
        public string Col_8 { get; set; }
        public string Col_9 { get; set; }
        public string Col_10 { get; set; }

    }

    public class EstimateReplyData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }
        public string Col_8 { get; set; }
        public string Col_8_1 { get; set; }
        public string Col_9 { get; set; }
        public string Col_10 { get; set; }
        public string Col_11 { get; set; }
        public string Col_12 { get; set; }
        public string Col_13 { get; set; }
        public string Col_13_1 { get; set; }
        public string Col_13_2 { get; set; }
        public string Col_13_3 { get; set; }
        public bool Col_14 { get; set; }
        public int Col_15 { get; set; }
        public bool Col_16 { get; set; }

        public EstimateReplyData(string _col_1, string _col_2, string _col_3,
                                 string _col_4, string _col_5, string _col_6,
                                 string _col_7, string _col_8, string _col_8_1, string _col_9,
                                 string _col_10, string _col_11, string _col_12,
                                 string _col_13, string _col_13_1, string _col_13_2, string _col_13_3,
                                 bool _col_14, int _col_15, bool _col_16)
        {
            Col_1 = _col_1;
            Col_2 = _col_2;
            Col_3 = _col_3;
            Col_4 = _col_4;
            Col_5 = _col_5;
            Col_6 = _col_6;
            Col_7 = _col_7;
            Col_8 = _col_8;
            Col_8_1 = _col_8_1;
            Col_9 = _col_9;
            Col_10 = _col_10;
            Col_11 = _col_11;
            Col_12 = _col_12;
            Col_13 = _col_13;
            Col_13_1 = _col_13_1;
            Col_13_2 = _col_13_2;
            Col_13_3 = _col_13_3;
            Col_14 = _col_14;
            Col_15 = _col_15;
            Col_16 = _col_16;
        }
    }

    public class DrawingNumberData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
    }
    public class EstimateReference
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }

        public EstimateReference(string _col_1, string _col_2)
        {
            Col_1 = _col_1;
            Col_2 = _col_2;
        }
    }
    public class EstimateSecurityData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
    }

    public class InstallmentPaymentData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }

        public bool Col_6 { get; set; }

        public InstallmentPaymentData(string _col_1, string _col_2, string _col_3,
                                      string _col_4, string _col_5)
        {
            Col_1 = _col_1;
            Col_2 = _col_2;
            Col_3 = _col_3;
            Col_4 = _col_4;
            Col_5 = _col_5;
        }
    }

    public class MailManagerData
    {
        public bool Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }

        public MailManagerData(string _col_2, string _col_3, string _col_4,
                               string _col_5, string _col_6, string _col_7)
        {
            Col_1 = true;
            Col_2 = _col_2;
            Col_3 = _col_3;
            Col_4 = _col_4;
            Col_5 = _col_5;
            Col_6 = _col_6;
            Col_7 = _col_7;
        }
    }

    public class MailCategoryData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }

        public MailCategoryData(string _col_1, string _col_2)
        {
            Col_1 = _col_1;
            Col_2 = _col_2;
        }
    }


    public class MailSendHistoryData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }
        public string Col_8 { get; set; }
        public string Col_9 { get; set; }
        public string Col_10 { get; set; }

        public MailSendHistoryData(string _col_1, string _col_2, string _col_3, string _col_4, string _col_5,
                                    string _col_6, string _col_7, string _col_8, string _col_9, string _col_10)
        {
            Col_1 = _col_1;
            Col_2 = _col_2;
            Col_3 = _col_3;
            Col_4 = _col_4;
            Col_5 = _col_5;
            Col_6 = _col_6;
            Col_7 = _col_7;
            Col_8 = _col_8;
            Col_9 = _col_9;
            Col_10 = _col_10;
        }
    }

    public class InguiryCostEstimate_ClassificationData
    {

        public string ClassificationCode { get; set; }
        public string ClassificationSymbolName { get; set; }

        public InguiryCostEstimate_ClassificationData(string _ClassificationCode, string _ClassificationSymbolName)
        {
            ClassificationCode = _ClassificationCode;
            ClassificationSymbolName = _ClassificationSymbolName;
        }
    }
}