using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusterilerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MusterilerController(AppDbContext context)
        {
            _context = context;
        }

        // 1. Tüm Müşterileri Listeleme
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Musteri>>> GetMusteriler()
        {
            return await _context.Musteriler.ToListAsync();
        }

        // 2. Müşteri ID ile Sorgulama
        [HttpGet("id/{id}")]
        public async Task<ActionResult<Musteri>> GetMusteriById(int id)
        {
            var musteri = await _context.Musteriler.FindAsync(id);
            if (musteri == null) return NotFound("Müşteri bulunamadı.");
            return musteri;
        }

        // 3. Müşteri Adı ile Sorgulama
        [HttpGet("ad/{ad}")]
        public async Task<ActionResult<IEnumerable<Musteri>>> GetMusteriByAd(string ad)
        {
            return await _context.Musteriler
                .Where(m => m.MusteriAdi != null && m.MusteriAdi.ToLower().Contains(ad.ToLower()))
                .ToListAsync();
        }

        // 4. Müşteri Telefon Numarası ile Sorgulama
        [HttpGet("telefon/{telefon}")]
        public async Task<ActionResult<IEnumerable<Musteri>>> GetMusteriByTelefon(string telefon)
        {
            return await _context.Musteriler
                .Where(m => m.MusteriTelNo != null && m.MusteriTelNo.Contains(telefon))
                .ToListAsync();
        }

        // 5. Insert (Müşteri Ekleme)
        [HttpPost]
        public async Task<ActionResult<Musteri>> PostMusteri(Musteri musteri)
        {
            _context.Musteriler.Add(musteri);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMusteriById), new { id = musteri.Id }, musteri);
        }

        // 6. Update (Müşteri Güncelleme)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusteri(int id, Musteri musteri)
        {
            if (id != musteri.Id) return BadRequest("ID eşleşmiyor.");

            _context.Entry(musteri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Musteriler.Any(e => e.Id == id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // 7. Delete (Müşteri Silme)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusteri(int id)
        {
            var musteri = await _context.Musteriler.FindAsync(id);
            if (musteri == null) return NotFound("Müşteri bulunamadı.");

            _context.Musteriler.Remove(musteri);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}