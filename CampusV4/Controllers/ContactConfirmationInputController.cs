﻿using System;
using System.Collections.Generic;
using System.Linq;
using C1.Web.Mvc;
using C1.Web.Mvc.Serialization;
using System.Data;
using System.Web;
using System.Web.Mvc;
using CampusV4.Models;

// This code was generated by C1 Scaffolder.

namespace CampusV4.Controllers
{
    public class ContactConfirmationInputController : Controller
    {

        public ActionResult ContactConfirmationInput(string Inquiry)
        {
            ContactConfirmationInputViewModel model = new ContactConfirmationInputViewModel();
            GetCombDataList(ref model);
            GetContactConfirmationDataList(ref model);
            model.ConfirmationCheck = true;
            model.ConfirmedCheck = true;
            //製番
            model.Seiban = "0000003655A";
            return View(model);
        }

        public ActionResult Regist()
        {
            ContactConfirmationInputViewModel model = new ContactConfirmationInputViewModel();
            GetCombDataList(ref model);
            GetContactConfirmationDataList(ref model);
            model.ContactConfirmationList.Add(new ContactConfirmationListData("","",DateTime.Parse("2024/04/29"), "入力内容追加", "佐藤　一郎", DateTime.Parse("2024/04/30")));

            return View("ContactConfirmationInput",model);
        }

        public ActionResult SendMail(ContactConfirmationInputViewModel model)
        {
            GetCombDataList(ref model);
            GetContactConfirmationDataList(ref model);
            return View(model);
        }

        //リストボックス値取得
        private void GetCombDataList(ref ContactConfirmationInputViewModel model)
        {

            // 入力者情報を取得
            var EmployeeData = new List<EmployeeData>();
            EmployeeData.Add(new EmployeeData("　", ""));
            EmployeeData.Add(new EmployeeData("USR00001", "佐藤　一郎"));
            EmployeeData.Add(new EmployeeData("USR00002", "佐藤　次郎"));
            EmployeeData.Add(new EmployeeData("USR00003", "佐藤　三郎"));
            EmployeeData.Add(new EmployeeData("USR00004", "佐藤　四朗"));
            EmployeeData.Add(new EmployeeData("USR00005", "佐藤　五郎"));
            model.InputManDataList = EmployeeData;

            // 確認者情報を取得
            var EmployeeData1 = new List<EmployeeData>();
            EmployeeData1.Add(new EmployeeData("　", ""));
            EmployeeData1.Add(new EmployeeData("USR00001", "佐藤　一郎"));
            EmployeeData1.Add(new EmployeeData("USR00002", "佐藤　次郎"));
            EmployeeData1.Add(new EmployeeData("USR00003", "佐藤　三郎"));
            EmployeeData1.Add(new EmployeeData("USR00004", "佐藤　四朗"));
            EmployeeData1.Add(new EmployeeData("USR00005", "佐藤　五郎"));
            model.ConfirmerDataList = EmployeeData1;
        }

        private void GetContactConfirmationDataList(ref ContactConfirmationInputViewModel model)
        {
            List<ContactConfirmationListData> DataList = new List<ContactConfirmationListData>();
            DataList.Add(new ContactConfirmationListData("Upper Main Cavity","",DateTime.Parse("2024/01/01"), "入力内容1", "佐藤　一郎", DateTime.Parse("2024/01/02")));
            DataList.Add(new ContactConfirmationListData("Lower Main Cavity", "", DateTime.Parse("2024/02/27"), "入力内容2", "佐藤　次郎", DateTime.Parse("2024/02/28")));
            DataList.Add(new ContactConfirmationListData("", "テスト検索項目", DateTime.Parse("2024/03/30"), "入力内容3", "佐藤　三郎", DateTime.Parse("2024/03/31")));

            model.ContactConfirmationList = DataList;
        }
    }
}