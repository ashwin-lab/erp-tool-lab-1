﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Identity;
using WebERP.Data;
using WebERP.Models;
using System.IO;

namespace WebERP.Controllers
{
    public class ArticalController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext dbContext;

        public ArticalController(
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.dbContext = context;
        }

        [HttpGet]
        public IActionResult Artical_Master()
        {
            return View(dbContext.Artical_Master.ToList());
        }
        [HttpGet]
        public IActionResult AddArtical(int ID, string Type)
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SAVEArtical(Artical_Master objArtical)
        {
            if (ModelState.IsValid)
            {
                objArtical.INS_DATE = DateTime.Now;
                objArtical.INS_UID = userManager.GetUserName(HttpContext.User);
                dbContext.Artical_Master.Add(objArtical);
                var result = await dbContext.SaveChangesAsync();
                return RedirectToAction("Artical_Master");
            }
            else
            {
                return View("Artical_Master");
            }
        }
        [HttpGet]
        public IActionResult EditArtical(int id)
        {
            return View(dbContext.Artical_Master.Find(id));
        }

        [HttpPost]
        public IActionResult EditArtical(Artical_Master objArtical)
        {
            objArtical.UDT_DATE = DateTime.Now;
            objArtical.UDT_UID = userManager.GetUserName(HttpContext.User);
            dbContext.Artical_Master.Update(objArtical);
            dbContext.SaveChanges();
            return RedirectToAction("Artical_Master");

        }
        [HttpGet]
        public IActionResult DeleteArtical(int ID)
        {
            var data = dbContext.Artical_Master.Find(ID);
            dbContext.Artical_Master.Remove(data);
            dbContext.SaveChanges();
            return RedirectToAction("Artical_Master");
        }
        [HttpGet]
        public IActionResult Excel()
        {
            var ComData = dbContext.Artical_Master;

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("List-Articals");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "NAME";
                worksheet.Cell(currentRow, 2).Value = "Brand Code";
                worksheet.Cell(currentRow, 3).Value = "INSERT DATE";
                worksheet.Cell(currentRow, 4).Value = "INSERT UID";
                worksheet.Cell(currentRow, 5).Value = "UPDATE DATE";
                worksheet.Cell(currentRow, 6).Value = "UPDATE UID";

                foreach (var Data in ComData)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = Data.NAME;
                    worksheet.Cell(currentRow, 2).Value = Data.BRAND_CODE;
                    worksheet.Cell(currentRow, 3).Value = Data.INS_DATE;
                    worksheet.Cell(currentRow, 4).Value = Data.INS_UID;
                    worksheet.Cell(currentRow, 5).Value = Data.UDT_DATE;
                    worksheet.Cell(currentRow, 6).Value = Data.UDT_UID;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Aticals.xlsx");
                }
            }
        }
    }
}