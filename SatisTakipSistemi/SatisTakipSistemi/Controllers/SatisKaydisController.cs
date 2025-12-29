using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SatisTakipSistemi.Data;
using SatisTakipSistemi.Models;

namespace SatisTakipSistemi.Controllers
{
    public class SatisKaydisController : Controller
    {
        private readonly SatisTakipSistemiContext _context;

        public SatisKaydisController(SatisTakipSistemiContext context)
        {
            _context = context;
        }

        // GET: SatisKaydis
        public async Task<IActionResult> Index()
        {
            return View(await _context.SatisKaydi.ToListAsync());
        }

        // GET: SatisKaydis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var satisKaydi = await _context.SatisKaydi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (satisKaydi == null)
            {
                return NotFound();
            }

            return View(satisKaydi);
        }

        // GET: SatisKaydis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SatisKaydis/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirmaAdi,SorumluSatisci,FirmaMail,FirmaTelefon,Durum,Notlar,Tarih")] SatisKaydi satisKaydi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(satisKaydi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(satisKaydi);
        }

        // GET: SatisKaydis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var satisKaydi = await _context.SatisKaydi.FindAsync(id);
            if (satisKaydi == null)
            {
                return NotFound();
            }
            return View(satisKaydi);
        }

        // POST: SatisKaydis/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirmaAdi,SorumluSatisci,FirmaMail,FirmaTelefon,Durum,Notlar,Tarih")] SatisKaydi satisKaydi)
        {
            if (id != satisKaydi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(satisKaydi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SatisKaydiExists(satisKaydi.Id))
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
            return View(satisKaydi);
        }

        // GET: SatisKaydis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var satisKaydi = await _context.SatisKaydi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (satisKaydi == null)
            {
                return NotFound();
            }

            return View(satisKaydi);
        }

        // POST: SatisKaydis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var satisKaydi = await _context.SatisKaydi.FindAsync(id);
            if (satisKaydi != null)
            {
                _context.SatisKaydi.Remove(satisKaydi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // --- YENİ EKLENEN ÖZELLİK: HÜCRE GÜNCELLEME ---
        [HttpPost]
        public async Task<IActionResult> HucreGuncelle(int id, string kolon, string deger)
        {
            var kayit = await _context.SatisKaydi.FindAsync(id);
            if (kayit == null)
            {
                return Json(new { success = false, message = "Kayıt bulunamadı." });
            }

            // Hangi kolonu değiştirmek istiyorsak ona göre işlem yap
            switch (kolon)
            {
                case "FirmaAdi":
                    kayit.FirmaAdi = deger;
                    break;
                case "FirmaTelefon":
                    kayit.FirmaTelefon = deger;
                    break;
                case "FirmaMail":
                    kayit.FirmaMail = deger;
                    break;
                case "SorumluSatisci":
                    kayit.SorumluSatisci = deger;
                    break;
            }

            await _context.SaveChangesAsync();
            return Json(new { success = true });
        }
        // ---------------------------------------------

        private bool SatisKaydiExists(int id)
        {
            return _context.SatisKaydi.Any(e => e.Id == id);
        }
    }
}