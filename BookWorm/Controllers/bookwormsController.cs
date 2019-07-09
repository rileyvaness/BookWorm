using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookWorm.Models;

namespace BookWorm.Controllers
{
    public class bookwormsController : Controller
    {
        private readonly BookWormContext _context;

        public bookwormsController(BookWormContext context)
        {
            _context = context;
        }

        // GET: bookworms
        public async Task<IActionResult> Index(string bookGenre, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.bookworm
                                            orderby m.Genre
                                            select m.Genre;

            var book = from m in _context.bookworm
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                book = book.Where(s => s.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(bookGenre))
            {
                book = book.Where(x => x.Genre == bookGenre);
            }

            var movieGenreVM = new BookGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Books = await book.ToListAsync()
            };

            return View(movieGenreVM);
        }
        // GET: bookworms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookworm = await _context.bookworm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookworm == null)
            {
                return NotFound();
            }

            return View(bookworm);
        }

        // GET: bookworms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: bookworms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,Genre,QuickSummary,Thoughts")] bookworm bookworm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookworm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookworm);
        }

        // GET: bookworms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookworm = await _context.bookworm.FindAsync(id);
            if (bookworm == null)
            {
                return NotFound();
            }
            return View(bookworm);
        }

        // POST: bookworms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,Genre,QuickSummary,Thoughts")] bookworm bookworm)
        {
            if (id != bookworm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookworm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!bookwormExists(bookworm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bookworm);
        }

        // GET: bookworms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookworm = await _context.bookworm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookworm == null)
            {
                return NotFound();
            }

            return View(bookworm);
        }

        // POST: bookworms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookworm = await _context.bookworm.FindAsync(id);
            _context.bookworm.Remove(bookworm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool bookwormExists(int id)
        {
            return _context.bookworm.Any(e => e.Id == id);
        }
    }
}
