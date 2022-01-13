using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rana_Tanzeel.Data;
using Rana_Tanzeel.Models;

namespace Rana_Tanzeel
{
    public class IndexModel : PageModel
    {
        private readonly Rana_Tanzeel.Data.Rana_TanzeelContext _context;

        public IndexModel(Rana_Tanzeel.Data.Rana_TanzeelContext context)
        {
            _context = context;
        }

        public IList<student> student { get;set; }

        public async Task OnGetAsync()
        {
            student = await _context.student.ToListAsync();
        }
    }
}
