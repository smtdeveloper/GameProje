# GameProje

<h2> C# - Angular </h2>

Yazılım Geliştirici Yetiştirme Kampı (C#) 5. Gün 5. Ödev

Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz.

# Gereksinimler

1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

2.Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

4.Satışlarda kampanya entegrasyonunu simule ediniz.

# N - Katmanlı Mimari

Her katmanda; soyut classları tutuğum bir Abstract klasörü ve somut classları tuttuğum Concrete klasörü bulunmaktadır. Araştırmalarımdan yola çıkarak bu katmanlarımın her birini class library ile oluşturdum ve DataAccess katmanımı Entities katmanı ile, Business katmanımı DataAccess katmanı ile, UI Katmanımı Business katmanı ile ilişkilendirdim. Bunları niye yaptığım aşağıda daha ayrıntılı bir şekilde anlatmaya çalıştım.

# Entities Katmanı

Bu katmanda proje boyunca kullanacağımız ana classlarımızı belirliyoruz yani gerçek nesnelerimizi belirlediğimiz yer burası. Bunun dışında IEntity interface'i oluşturdum. Bu interface bütün gerçek nesnelerimin referansını tutuyor. <br>
<br>
