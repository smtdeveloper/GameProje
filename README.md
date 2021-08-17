# GameProje

<h2> C# - Angular </h2>

Yazılım Geliştirici Yetiştirme Kampı (C#) 5. Gün 5. Ödev

Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz.

Gereksinimler
Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

Satışlarda kampanya entegrasyonunu simule ediniz.

N - Katmanlı Mimari
Her katmanda; soyut classları tutuğum bir Abstract klasörü ve somut classları tuttuğum Concrete klasörü bulunmaktadır. Araştırmalarımdan yola çıkarak bu katmanlarımın her birini class library ile oluşturdum ve DataAccess katmanımı Entities katmanı ile, Business katmanımı DataAccess katmanı ile, UI Katmanımı Business katmanı ile ilişkilendirdim. Bunları niye yaptığım aşağıda daha ayrıntılı bir şekilde anlatmaya çalıştım.
Entities Katmanı
Bu katmanda proje boyunca kullanacağımız ana classlarımızı belirliyoruz yani gerçek nesnelerimizi belirlediğimiz yer burası. Bunun dışında IEntity interface'i oluşturdum. Bu interface bütün gerçek nesnelerimin referansını tutuyor.
Gerçek Sınıflarım (Concrete Class)
Player.cs
Person.cs
Game.cs
Soyut Sınıflarım (Abstract Class)
IEntity.cs
Business Katmanı
Bu katmanda iş yüklerimizi yazıyoruz. Öncelikle şunu söylemeliyim bu katman Data Access tarafından projeye çekilmiş olan verileri alarak işleyecek olan katmandır. Biz uygulamalarımızda Data Access katmanını direk olarak kullanmayız. Araya Business katmanını koyarak bizim yerimize Business’ın yapmasını sağlarız. Kullanıcıdan gelen veriler öncelikle Business katmanına gider oradan işlenerek Data Access katmanına aktarılır. Yukarıda neden business katmanını DataAccess katmanı ile ilişkilendirdiğimi daha iyi anlamışınızdır.
Gerçek Sınıflarım (Concrete Class)
GameManager.cs
PlayerManager.cs - Bu classımda kişilik kontrolü yapıyorum eğer o kontrolden geçerse DataAccess katmanındaki işlemlerini gerçekleştiriyorum.
SteamPlatformManager.cs
WinterSalesManager.cs
PersonCheckManager.cs
Soyut Sınıflarım (Abstract Class)
IGameService.cs
IPlatformService.cs
ISalesService.cs
IPlayerService.cs
IPersonCheckService.cs
DataAccess Katmanı
Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir. Bu katmanda bu işlemlerden başka herhangi bir işlem yapılmamaktadır.
Gerçek Sınıflarım (Concrete Class)
DatabaseLoggerManager.cs
FileLoggerManager.cs
Soyut Sınıflarım (Abstract Class)
ILoggerService
UI (Sunum Katmanı)
Bu katman kullanıcı ile etkileşimin yapıldığı katmandır. Ben Console uygulaması yaptığım için adına Console koydum fakat bu Windows Form uygulamasıda olabilir veya bir Web projesi olabilirdi.
Gerçek Sınıflarım (Concrete Class)
Program.cs
