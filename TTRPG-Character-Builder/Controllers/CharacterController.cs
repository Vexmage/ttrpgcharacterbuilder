using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TTRPG_Character_Builder.Data;
using TTRPG_Character_Builder.Models;



namespace TTRPG_Character_Builder.Controllers
{
    public class CharacterController : Controller
    {
        // Dependency injection of the database context
        private readonly ApplicationDbContext _context;

        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Character/Create
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var characters = await _context.Characters.ToListAsync();
            return View("List", characters);
        }


        // POST: Character/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Race,Class,Strength,Dexterity,Intelligence,Wisdom,Constitution,Charisma,Biography")] Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Add(character);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redirect to the list or detail view
            }
            return View(character);
        }

        // Other actions like Edit, Details, Delete, etc. will be added later.
    }
}
