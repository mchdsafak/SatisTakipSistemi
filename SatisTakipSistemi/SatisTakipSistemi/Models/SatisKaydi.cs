namespace SatisTakipSistemi.Models
{
    public class SatisKaydi
    {
        public int Id { get; set; } 

        public string FirmaAdi { get; set; } // potansiyel müşteri firma adı, bu bir crm uygulaması

        public string SorumluSatisci { get; set; } // ilgilenen satış personeli

        public string FirmaMail { get; set; } // iletişim sağlaman e-posta adresi 

        public string FirmaTelefon { get; set; } // iletişim sağlanan telefon numarası

        public string Durum { get; set; } //süreç(ulaşıldı, dönüş bekleniyor vs.)

        public string Notlar { get; set; } //  satışçının notu

        public DateTime Tarih { get; set; }
        public SatisKaydi()
        {
            Tarih = DateTime.Now;
        }
    }
}