using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using yektaApi.Models;

namespace yektaApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProCategoriesApiController : ControllerBase
    {
        private readonly ApiContext _context;

        public ProCategoriesApiController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/ProCategoriesApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProCategory>>> GetProCategory()
        {
            return await _context.ProCategory.ToListAsync();
        }

        // GET: api/ProCategoriesApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProCategory>> GetProCategory(int id)
        {
            var proCategory = await _context.ProCategory.FindAsync(id);

            if (proCategory == null)
            {
                return NotFound();
            }

            return proCategory;
        }

        // PUT: api/ProCategoriesApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProCategory(int id, ProCategory proCategory)
        {
            if (id != proCategory.CPId)
            {
                return BadRequest();
            }

            _context.Entry(proCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProCategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProCategoriesApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProCategory>> PostProCategory(ProCategory proCategory)
        {
            _context.ProCategory.Add(proCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProCategory", new { id = proCategory.CPId }, proCategory);
        }

        // DELETE: api/ProCategoriesApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProCategory(int id)
        {
            var proCategory = await _context.ProCategory.FindAsync(id);
            if (proCategory == null)
            {
                return NotFound();
            }

            _context.ProCategory.Remove(proCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProCategoryExists(int id)
        {
            return _context.ProCategory.Any(e => e.CPId == id);
        }
    }
}
