﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebERP.Data;

namespace WebERP.ViewComponents
{
    public class StateViewComponent:ViewComponent
    {
        private ApplicationDbContext _context;

        public StateViewComponent(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.States.ToListAsync());
        }
    }   
}
