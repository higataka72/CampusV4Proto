using System;
using System.Collections.Generic;
using System.Linq;
using CampusV4.Models;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CampusV4.Controllers
{
    public class CommonController : Controller
    {
        [HttpPost]
        public JsonResult GetMasterData(string name)
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<MasterData>();
            dataList.Add(new MasterData("11111", "あああああ"));
            dataList.Add(new MasterData("22222", "いいいいい"));
            dataList.Add(new MasterData("33333", "ううううう"));
            dataList.Add(new MasterData("44444", "えええええ"));
            dataList.Add(new MasterData("55555", "おおおおお"));
            dataList.Add(new MasterData("66666", "かかかかか"));
            dataList.Add(new MasterData("77777", "ききききき"));
            dataList.Add(new MasterData("88888", "くくくくく"));
            dataList.Add(new MasterData("99999", "けけけけけ"));

            string resultJson = "";

            if (!string.IsNullOrEmpty(name)) {
                resultJson = sz.Serialize(dataList.Where(m => m.Name.Contains(name)).ToList());
            } else
            {
                resultJson = sz.Serialize(dataList);
            }
            
            return Json(resultJson);
        }

        [HttpPost]
        public JsonResult GetInquiryHistoryData(string name)
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<InquiryHistoryData>();
            dataList.Add(new InquiryHistoryData("ZX-A001", "金型A図枠組み", 150000));
            dataList.Add(new InquiryHistoryData("ZX-A001", "金型特殊加工A", 550000));
            dataList.Add(new InquiryHistoryData("ZX-B001", "金型B図枠組み", 220000));

            string resultJson = "";

            if (!string.IsNullOrEmpty(name))
            {
                resultJson = sz.Serialize(dataList.Where(m => m.Hinmei.Contains(name)).ToList());
            }
            else
            {
                resultJson = sz.Serialize(dataList);
            }

            return Json(resultJson);
        }
        [HttpPost]
        public JsonResult GetSupplierData(string name)
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<SupplierData>();
            dataList.Add(new SupplierData("11111", "ユーザ１", "部署１", "user1@abc.co.jp"));
            dataList.Add(new SupplierData("22222", "ユーザ２", "部署２", "user2@abc.co.jp"));
            dataList.Add(new SupplierData("33333", "ユーザ３", "部署３", "user3@abc.co.jp"));

            string resultJson = "";

            if (!string.IsNullOrEmpty(name))
            {
                resultJson = sz.Serialize(dataList.Where(m => m.SupplierName.Contains(name)).ToList());
            }
            else
            {
                resultJson = sz.Serialize(dataList);
            }

            return Json(resultJson);
        }
        [HttpPost]
        public JsonResult GetMailAddressData(string name)
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<MailAddressData>();
            dataList.Add(new MailAddressData("100001", "佐藤　一郎", "user1@abc.co.jp"));
            dataList.Add(new MailAddressData("100002", "佐藤　二郎", "user2@abc.co.jp"));
            dataList.Add(new MailAddressData("100003", "佐藤　三郎", "user3@abc.co.jp"));

            string resultJson = "";

            if (!string.IsNullOrEmpty(name))
            {
                resultJson = sz.Serialize(dataList.Where(m => m.PartnerPersonName.Contains(name)).ToList());
            }
            else
            {
                resultJson = sz.Serialize(dataList);
            }

            return Json(resultJson);
        }
        [HttpPost]
        public JsonResult GetPartsData(string name)
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<PartsData>();
            dataList.Add(new PartsData(false, 1, "半導体部品", "金型A","A12345","M-A10",2,2));
            dataList.Add(new PartsData(false, 2, "半導体部品", "金型B", "A12346", "M-B10", 5, 5));
            dataList.Add(new PartsData(false, 3, "半導体部品", "金型C", "A12347", "M-C10", 10, 10));

            string resultJson = "";

            if (!string.IsNullOrEmpty(name))
            {
                resultJson = sz.Serialize(dataList.Where(m => m.PartsCategory.Contains(name)).ToList());
            }
            else
            {
                resultJson = sz.Serialize(dataList);
            }

            return Json(resultJson);
        }

    }
}