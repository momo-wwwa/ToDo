﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using todo.Models;

namespace ToDo.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly ItemContext _context;

        public IndexModel(ItemContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
