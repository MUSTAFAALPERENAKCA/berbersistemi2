# ✂️ BerberShop — Berber & Kuaför Yönetim Sistemi

ASP.NET Core MVC ile geliştirilmiş, berber ve kuaför işletmeleri için kapsamlı bir yönetim platformu.

## ✨ Özellikler

- **Randevu Yönetimi** — Randevu oluşturma, düzenleme, iptal ve takvim görünümü
- **Müşteri Yönetimi** — Müşteri profilleri ve ziyaret geçmişi
- **Personel & Kuaför Yönetimi** — Kuaför ve asistan hesapları, yetenek/uzmanlık alanları
- **Departman / Şube Yönetimi** — Çoklu şube desteği
- **Çalışma Programı** — Haftalık uygunluk takvimi ve vardiya yönetimi
- **Kimlik Doğrulama** — ASP.NET Core Identity ile güvenli giriş, kayıt ve rol tabanlı yetkilendirme

## 🛠️ Tech Stack

| Katman | Teknoloji |
|--------|-----------|
| Framework | ASP.NET Core MVC (.NET 8) |
| ORM | Entity Framework Core |
| Veritabanı | SQL Server / LocalDB |
| Auth | ASP.NET Core Identity |
| Frontend | Razor Views · Bootstrap 5 |

## 📂 Proje Yapısı

```
BerberShop/
├── Controllers/
│   ├── AccountController.cs      # Kimlik doğrulama
│   ├── AppointmentController.cs  # Randevu yönetimi
│   ├── CustomerController.cs     # Müşteri yönetimi
│   ├── StylistController.cs      # Kuaför yönetimi
│   ├── DepartmentController.cs   # Departman yönetimi
│   └── ScheduleController.cs     # Çalışma programı
├── Models/                       # Domain modelleri
├── Views/                        # Razor şablonları
├── Data/                         # DbContext
└── Migrations/                   # EF Core migration'ları
```

## ⚡ Kurulum

**Gereksinimler:** .NET 8 SDK · SQL Server veya LocalDB

```bash
git clone https://github.com/MUSTAFAALPERENAKCA/berbersistemi2
cd berbersistemi2

# Veritabanını oluştur
dotnet ef database update

# Çalıştır
dotnet run
```

Tarayıcıda `https://localhost:5001` adresini açın.

## 📄 Lisans

MIT
