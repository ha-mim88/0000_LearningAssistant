using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using web.Data;
using web.Entities;

namespace web.Pages.Admin.MySkillBoard
{
    public class DetailsModel : PageModel
    {
        private readonly web.Data.ApplicationDbContext _context;

        public DetailsModel(web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Skill Skill { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skill.FirstOrDefaultAsync(m => m.Id == id);

            if (skill is not null)
            {
                Skill = skill;

                return Page();
            }

            return NotFound();
        }
    }
}
