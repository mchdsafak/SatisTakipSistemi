SATIS TAKIP SISTEMI

Bu çalışma, kurumsal satış süreçlerinin yönetilmesi amacıyla geliştirilmiş bir web uygulamasıdır. Müşteri görüşmelerinin kaydedilmesi, güncellenmesi ve durum takibinin yapılmasına olanak tanır.

Teknik Mimari

Framework: ASP.NET Core 8.0/9.0 MVC

ORM: Entity Framework Core

Veritabanı: SQLite


Arayüz: Bootstrap, jQuery ve AJAX 



Fonksiyonel Özellikler


Dinamik Veri Güncelleme: Liste ekranında bulunan 'editable-cell' özelliği sayesinde, hücrelere odaklanarak veriler anlık olarak güncellenebilmektedir.




Görsel Durum Yönetimi: Satışların "Teklif", "Onaylandı" veya "Olumsuz" gibi durumları, CSS sınıfları yardımıyla farklı renklerde badge'ler ile gösterilmektedir.


Otomatik Migrasyon: Veritabanı şeması, kod tarafındaki değişikliklere göre uygulama çalışma zamanında otomatik olarak güncellenir.

Kurulum Notları Projeyi yerel ortamınızda çalıştırmak için .NET SDK'nın yüklü olması yeterlidir. dotnet run komutu verildiğinde, SQLite veritabanı dosyası proje dizininde otomatik olarak oluşturulacaktır.
