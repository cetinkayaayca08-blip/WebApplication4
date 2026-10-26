using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Musteri> Musteriler { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Başlangıç verilerini alt alta ve hatasız ekliyoruz
        modelBuilder.Entity<Musteri>().HasData(
            new Musteri { Id = 1, MusteriAdi = "Nur", MusteriSoyadi = "Kılıç", MusteriTelNo = "05390006040", MusteriEletisim = "gul@all.com", MusteriCinsiyet = "Kadın", MusteriAcikAdresi = "Ankara" },
            new Musteri { Id = 2, MusteriAdi = "Sevgi", MusteriSoyadi = "Helin", MusteriTelNo = "0539985459", MusteriEletisim = "elanur@all.com", MusteriCinsiyet = "Kadın", MusteriAcikAdresi = "İstanbul" },
            new Musteri { Id = 3, MusteriAdi = "Sevilay", MusteriSoyadi = "Kalaycı", MusteriTelNo = "0539888438", MusteriEletisim = "sevilay@all.com", MusteriCinsiyet = "Kadın", MusteriAcikAdresi = "Ankara" },
            new Musteri { Id = 4, MusteriAdi = "Ada", MusteriSoyadi = "Çetin", MusteriTelNo = "05391112273", MusteriEletisim = "sura@all.com", MusteriCinsiyet = "Kadın", MusteriAcikAdresi = "İzmir" },
            new Musteri { Id = 5, MusteriAdi = "Eren", MusteriSoyadi = "Kılıç", MusteriTelNo = "05392223364", MusteriEletisim = "ekin@all.com", MusteriCinsiyet = "Kadın", MusteriAcikAdresi = "Bursa" },
            new Musteri { Id = 6, MusteriAdi = "Fatmanur", MusteriSoyadi = "Çelik", MusteriTelNo = "05390004040", MusteriEletisim = "fatmanur@all.com", MusteriCinsiyet = "Kadın", MusteriAcikAdresi = "Zeytintepe" },
            new Musteri { Id = 7, MusteriAdi = "Ayda", MusteriSoyadi = "Çetinkaya", MusteriTelNo = "0539885459", MusteriEletisim = "ayda@all.com", MusteriCinsiyet = "Kadın", MusteriAcikAdresi = "Zonguldak" },
            new Musteri { Id = 8, MusteriAdi = "Ayça", MusteriSoyadi = "Çetinkaya", MusteriTelNo = "0539885538", MusteriEletisim = "ayca@all.com", MusteriCinsiyet = "Kadın", MusteriAcikAdresi = "Zonguldak" }
        );
    }
}