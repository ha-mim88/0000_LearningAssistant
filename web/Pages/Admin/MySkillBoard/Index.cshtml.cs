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
    public class IndexModel : PageModel
    {
        private readonly web.Data.ApplicationDbContext _context;

        public IndexModel(web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Skill> Skill { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Skill = await _context.Skill.ToListAsync();
        }
    }
}
