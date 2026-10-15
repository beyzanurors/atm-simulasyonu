# C# Konsol Tabanlı ATM Simülasyonu

Bu proje, C# programlama dili ile geliştirilmiş; kullanıcıların temel bankacılık işlemlerini (bakiye sorgulama, para yatırma ve çekme) güvenli bir döngü içerisinde yapmasını sağlayan konsol tabanlı bir ATM simülasyonudur.

## Öne Çıkan Özellikler
- **Güvenli Girdi Kontrolü (`decimal.TryParse`):** Kullanıcı yanlışlıkla harf veya geçersiz bir karakter girdiğinde programın çökmesi engellenir.
- **Hata Yönetimi:** Hesaptaki bakiyeden fazla para çekilmeye çalışıldığında veya negatif/sıfır tutarlar girildiğinde uyarı mekanizmaları çalışır.
- **Para Birimi Formatı (`:C2`):** Bakiyeler ve tutarlar profesyonel bir şekilde para birimi formatında ekrana yazdırılır.
- **Döngü Yapısı (`while` ve `switch-case`):** Kullanıcı çıkış yap (`4`) seçeneğini seçene kadar menü aktif kalır.

## Kullanılan Teknolojiler
- **C# (.NET)**
- **Nesne Yönelimli / Yapısal Temel Programlama Prensipleri**

## Nasıl Çalıştırılır?
1. Bilgisayarınızda Visual Studio veya .NET SDK yüklü olduğundan emin olun.
2. Projeyi IDE içerisinde açın veya `Program.cs` dosyasını derleyin.
3. Terminalde/Konsolda projeyi çalıştırarak menüden seçim yapmaya başlayın:
   ```bash
   dotnet run
