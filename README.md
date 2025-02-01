# 🏨 BookingRapidApi - Otel Listeleme Uygulaması


## 📌 Proje Açıklaması  
Bu proje, **RapidAPI** üzerinden **Booking API** kullanılarak geliştirilmiş bir **otel listeleme uygulamasıdır**.  
Kullanıcılar belirledikleri kriterlere göre otelleri filtreleyebilir ve en uygun seçenekleri listeleyebilirler.  

---

## 🔍 Kullanıcı Deneyimi  

**Kullanıcıdan alınan bilgiler:**  
✅ 🗺️ **Şehir** → Filtrelemek istedikleri destinasyon  
✅ 📅 **Giriş Tarihi** → Konaklama başlangıç tarihi  
✅ 📅 **Çıkış Tarihi** → Konaklama bitiş tarihi  
✅ 👤 **Yetişkin Sayısı**  
✅ 🧒 **Çocuk Sayısı**  

💡 **Listeleme sonucunda kullanıcının erişebileceği bilgiler:**  
🏠 **Otel Adı**  
⭐ **Otel Puanı**  
👥 **Kaç kişi tarafından değerlendirildiği**  

---

## 🚀 Kullanılan Teknolojiler  

🔹 **ASP.NET Core (6.0)** ile geliştirildi  
🔹 **Tek katmanlı mimari** kullanıldı  
🔹 **Booking API'nin iki farklı endpoint'i** entegre edildi  

📌 **Search Hotel Destination Endpoint:**  
Kullanıcının girdiği şehir adına karşılık gelen **şehir ID’si** elde edildi.  

📌 **Search Hotels Endpoint:**  
Şehir ID’si ve diğer filtreleme kriterleri kullanılarak **uygun oteller listelendi**.  

📦 **ViewModel Kullanımı:**  
API’den gelen JSON verilerini işlemek için **ViewModel yapıları** oluşturuldu.  

---
![screencapture-localhost-7152-Booking-Home-2025-01-30-00_10_56](https://github.com/user-attachments/assets/cb0c70e8-d3a8-46a0-9e68-c1672c87d67b)
![screencapture-localhost-7152-Booking-BookingHotelSearch-2025-01-30-00_11_45](https://github.com/user-attachments/assets/5d00caab-46d5-4f08-b9aa-83405841d351)


