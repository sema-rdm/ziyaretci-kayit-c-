# ziyaretci-kayit-c-
c# ile ziyaretçi kayit programı
![ziyaretçi-kayıt form ekranı](https://github.com/sema-rdm/ziyaretci-kayit-c-/blob/main/ziyaretci-img.png)
<br>
<br>
### proje içeriği <br>

adsoyad, ünvan, adres, telefon, ziyaret sebebi, giriş-çıkış saatlerine göre gelen ziyaretçileri kaydetme, güncelleme, arama, silme
ve verileri excele aktarma işlemi yapıyor. <br>
adsoyad, ünvan, adres bilgileri boş bırakılınca uyarı ikonu çıkar  bu alan boş bırakılamaz uyarısı verir ve kaydetme işlemi yapılmaz.<br>
adsoyad, ünvan textbox larına sayı girişi telefon textboxına harf girişi engellenir.<br>
telefon verisi 0 ile başlayıp 11 haneli kuralına uymazsa kaydetme işlemi yapılmaz.<br>
çıkış saati saat formatına göre kontrol edilir , giriş saati güncel saati gösterir.<br>
güncelleme butonuna basınca veriler textboxlara getirilir ve giriş saati durdurulur (timer.stop()).<br>
sil butonu ile seçilen satır silinir .<br>
adsoyad verisine göre arama işlemi yapılır.<br> 
yazdır butonu ile datagridviewdeki veriler excel sayfasına aktarılır.
