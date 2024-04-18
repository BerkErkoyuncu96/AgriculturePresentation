using AgriculturePresentation.Models;
using ClosedXML.Excel;
using DataAccessLayer.Contexts;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace AgriculturePresentation.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        string GuidKey = Guid.NewGuid().ToString();
        public IActionResult staticReport()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workbook = excelPackage.Workbook.Worksheets.Add("Dosya1");

            workbook.Cells[1, 1].Value = "Ürün Adı";
            workbook.Cells[1,2].Value = "Ürün Kategorisi";
            workbook.Cells[1, 3].Value = "Stok Miktarı";

            workbook.Cells[2, 1].Value = "Mercimek";
            workbook.Cells[2, 2].Value = "Bakliyat";
            workbook.Cells[2, 3].Value = "1000 Ton";

            workbook.Cells[3, 1].Value = "Bulgur";
            workbook.Cells[3, 2].Value = "Bakliyat";
            workbook.Cells[3, 3].Value = "1500 Ton";

            workbook.Cells[4, 1].Value = "Karpuz";
            workbook.Cells[4, 2].Value = "Meyve ve Sebze";
            workbook.Cells[4, 3].Value = "3 Ton";

            workbook.Cells[5, 1].Value = "Maydonoz";
            workbook.Cells[5, 2].Value = "Meyve ve Sebze";
            workbook.Cells[5, 3].Value = "5 Ton";
            
            workbook.Cells[6, 1].Value = "Peynir";
            workbook.Cells[6, 2].Value = "Kahvaltı";
            workbook.Cells[6, 3].Value = "10 Ton";

            workbook.Cells[7, 1].Value = "Buğday";
            workbook.Cells[7, 2].Value = "Bakliyat";
            workbook.Cells[7, 3].Value = "300 Ton";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",GuidKey+".xlsx");
        }

        public List<ContactModel> contactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using( var context = new AgricultureContext())
            {
                contactModels = context.Contacts.Select(x => new ContactModel
                {
                    contactId = x.ContactId,
                    contactName = x.Name,
                    contactMail = x.Mail,
                    contactMessage = x.Message,
                    contactDate = x.Date
                }).ToList();
            }

            return contactModels;
        }
        public IActionResult contactReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1,1).Value = "Mesaj ID";
                workSheet.Cell(1,2).Value = "Mesaj Gönderen";
                workSheet.Cell(1,3).Value = "Mesaj Mail";
                workSheet.Cell(1,4).Value = "Mesaj İçeriği";
                workSheet.Cell(1,5).Value = "Mesaj Tarihi";

                int contactRowCount = 2;

                foreach(var item in contactList())
                {
                    workSheet.Cell(contactRowCount,1).Value = item.contactId;
                    workSheet.Cell(contactRowCount,2).Value = item.contactName;
                    workSheet.Cell(contactRowCount,3).Value = item.contactMail;
                    workSheet.Cell(contactRowCount,4).Value = item.contactMessage;
                    workSheet.Cell(contactRowCount,5).Value = item.contactDate;

                    contactRowCount++;
                }

                using (var strem = new MemoryStream())
                {
                    workbook.SaveAs(strem);
                    var content = strem.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", GuidKey + ".xlsx");
                }
            }
        }

        public List<AnnouncementModel> announcementList()
        {
            List<AnnouncementModel> announcementModels = new List<AnnouncementModel>();
            using (var context = new AgricultureContext())
            {
                announcementModels = context.Announcements.Select(x => new AnnouncementModel
                {
                    announcementId = x.AnnouncementId,
                    announcementTitle = x.Title,
                    announcementDescripton = x.Description,
                    announcementDate = x.Date,
                    announcementBool = x.Status
                }).ToList();
            }
            return announcementModels;
        }

        public IActionResult announcementReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1, 1).Value = "Duyuru ID";
                workSheet.Cell(1, 2).Value = "Duyuru Başlığı";
                workSheet.Cell(1, 3).Value = "Duyuru Açıklaması";
                workSheet.Cell(1, 4).Value = "Duyuru Tarihi";
                workSheet.Cell(1, 5).Value = "Duyuru Durumu";

                int contactRowCount = 2;

                foreach (var item in announcementList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.announcementId;
                    workSheet.Cell(contactRowCount, 2).Value = item.announcementTitle;
                    workSheet.Cell(contactRowCount, 3).Value = item.announcementDescripton;
                    workSheet.Cell(contactRowCount, 4).Value = item.announcementDate;
                    workSheet.Cell(contactRowCount, 5).Value = item.announcementBool;

                    contactRowCount++;
                }

                using (var strem = new MemoryStream())
                {
                    workbook.SaveAs(strem);
                    var content = strem.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", GuidKey+".xlsx");
                }
            }
        }
    }
}
