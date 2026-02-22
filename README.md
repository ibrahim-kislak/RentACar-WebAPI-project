Rent A Car Web API Project
Bu proje, modern bir araç kiralama sisteminin backend altyapısını oluşturmak amacıyla geliştirilmiş, katmanlı mimariye (N-Tier Architecture) sahip bir .NET uygulamasıdır.

📌Proje Hakkında : 

Uygulama; araçların, müşterilerin ve kiralama siparişlerinin yönetimini sağlamak için temel CRUD (Oluşturma, Okuma, Güncelleme, Silme) operasyonlarını sunar. Kodun sürdürülebilirliği ve tekrar kullanılabilirliği için Generic Repository ve Service desenleri merkezi bir rol oynamaktadır.

##🛠️ Teknolojik Altyapı:

Framework: .NET 8.0 (API) ve .NET Framework 4.7.2 (Core Katmanlar).

ORM: Entity Framework 6.

Veritabanı: MS SQL Server.

API Dokümantasyonu: Swagger UI.

Mimari: Katmanlı Mimari (Entity, DataAccess, Business, Presentation).

📂 Mimari Yapı ve Katmanlar:

Proje, sorumlulukların net bir şekilde ayrılması prensibiyle 4 ana katman üzerine inşa edilmiştir:

Entity Layer (RentACarProject.EntityLayer): Projede kullanılan temel veri modellerini (Car, Customer, Order) içerir. Nesne ilişkileri (Navigation Properties) bu katmanda tanımlanmıştır.

Data Access Layer (RentACarProject.DataAccessLayer): Veritabanı ile doğrudan iletişim kuran katmandır. RentContext üzerinden GenericRepository yapısını kullanarak veritabanı işlemlerini standartlaştırır.

Business Layer (RentACarProject.BusinessLayer): İş mantığının ve kontrollerin yapıldığı katmandır. Örneğin, müşteri kaydedilirken gerekli alanların doluluk kontrolü burada yapılır.

Presentation Layer (RentACar.PresentationLayer): Dış dünyanın sistemle etkileşime geçtiği Web API katmanıdır. Program.cs içerisinde servislerin bağımlılıkları (Dependency Injection) yönetilir.

⚙️ Nasıl Çalışır?:

Veritabanı Bağlantısı: Uygulama, appsettings.json dosyasındaki bağlantı dizesini kullanarak SQL Server'a erişir.

İşlem Akışı: Kullanıcı bir API isteği gönderdiğinde (örneğin araç listeleme), istek CarController'a düşer. Controller, ilgili servisi (CarManager) çağırır, servis ise veri erişim katmanı üzerinden veritabanından bilgiyi getirir.

Generic Yapı: Tüm modüller (Araç, Müşteri, Sipariş) aynı temel CRUD metotlarını paylaştığı için yeni bir özellik eklemek oldukça hızlıdır.

🚀 Kullanım:

SQL Server üzerinde RentACarProjectDb adında bir veritabanı oluşturun veya projenin migration dosyalarını çalıştırın.

RentACar.PresentationLayer projesini başlangıç projesi yaparak uygulamayı başlatın.

Tarayıcıda açılan Swagger UI arayüzü üzerinden API uç noktalarını test etmeye başlayabilirsiniz.

Geliştirme Notu: Projenin sonraki aşamalarında FluentValidation ile doğrulama kuralları ve JWT ile yetkilendirme mekanizmaları eklenecektir.
