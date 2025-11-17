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
        /// <summary>
        /// The Entity Framework Core database context for accessing application data.
        /// </summary>
        private readonly web.Data.ApplicationDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModel"/> class.
        /// </summary>
        /// <param name="context">
        /// The <see cref="ApplicationDbContext"/> instance injected by the framework,
        /// used for database operations.
        /// </param>
        public IndexModel(web.Data.ApplicationDbContext context)
        {
            // Assign the injected database context to the private field.
            _context = context;
        }

        public IList<Skill> Skill { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Skill = await _context.Skill.ToListAsync();
        }
    }
}
