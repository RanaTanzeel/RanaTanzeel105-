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
    public class DetailsModel : PageModel
    {
        private readonly Rana_Tanzeel.Data.Rana_TanzeelContext _context;

        public DetailsModel(Rana_Tanzeel.Data.Rana_TanzeelContext context)
        {
            _context = context;
        }

        public student student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            student = await _context.student.FirstOrDefaultAsync(m => m.ID == id);

            if (student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
