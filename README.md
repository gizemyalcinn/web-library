Proje Amacı: Bu proje, bir kütüphane sisteminde kitapların yönetilmesini sağlayan bir konsol
uygulaması olarak geliştirilmiştir. Uygulama, kullanıcıya yeni kitaplar ekleme, mevcut kitapları silme,
belirli kriterlere göre kitapları arama ve tüm kütüphane kitaplarını listeleme gibi temel işlevler sunar.
Bu tür bir proje, nesneye yönelik programlama, basit veri yapıları ve arama algoritmalarının
kullanılmasını amaçlamaktadır.
Proje ile kitapların verimli bir şekilde yönetilebileceği basit ve kullanıcı dostu bir konsol tabanlı
uygulama oluşturmak amaçlanmıştır. Proje, kullanıcıların bir kütüphanedeki kitapları kolayca ekleyip
silebilmesini, kitapları isme veya yazara göre arayabilmesini ve tüm kitapları listeleyebilmesini sağlar.
Bu sistem, özellikle küçük bir kütüphane veya bireysel bir kitap koleksiyonu yönetimi için ideal bir
prototip sunar.
Programlama Dili: Python, Java, C++ vb. nesneye yönelik programlamaya uygun diller
kullanabilirsiniz.

1. İsterler
Kullanılacak Veri Yapıları ve Algoritmalar
Nesneye Yönelik Programlama (OOP): Projede, nesneye yönelik programlama yapısının
kullanılması zorunludur. Kitap ve Kütüphane sınıfları ile sistemin verileri nesne olarak temsil edilir. Bu
yaklaşım, verilerin daha modüler ve yeniden kullanılabilir şekilde organize edilmesini sağlar.
Kitap Listesi (List Veri Yapısı): Kitaplar, Python’un liste veri yapısı (self.books listesi) kullanılarak
tutulacaktır. Her kitap, bir Kitap nesnesi olarak bu listeye eklenir. Bu yapı, kitap ekleme ve silme
işlemleri için uygulanacaktır.
Lineer Arama Algoritması: Kullanıcı isme veya yazara göre arama yaptığında, lineer arama
algoritması kullanılarak self.books listesi içinde bir döngü yardımıyla arama yapılacaktır (Farklı bir
algoritma da kullanılabilir. Basit olması açısından bu yapı önerilmiştir)
Sınıflar ve Fonksiyonlar
Proje iki ana sınıftan oluşur:
1. Kitap Sınıfı (Book Class): Kitapla ilgili bilgileri tutar. Her kitap, bir isim, yazar ve yayın yılı
bilgisine sahiptir. Bu bilgiler sınıfın özellikleri olarak saklanır.
Özellikler:

 name: Kitabın adı.
 author: Kitabın yazarı.
 year: Yayın yılı.

Metotlar:

 __str__: Kitabın bilgilerini yazdırmak için kullanılır.

2. Library Sınıfı: Kütüphane ile ilgili tüm işlemleri yönetir. Kütüphane sınıfı kitap ekleme, silme,
arama ve listeleme gibi işlevlere sahiptir.
Özellikler:

 books: Tüm kitapları içeren bir liste.

Metotlar:

 add_book: Yeni bir kitap ekler.
 remove_book: Mevcut bir kitabı adıyla bulup siler.
 search_by_name: İsme göre kitap arar.
 search_by_author: Yazara göre kitap arar.
 list_books: Tüm kitapları listeler.

Özellikler ve Kullanım Senaryoları
1. Kitap Ekleme: Kullanıcı, kitabın adını, yazarını ve yayın yılını girdikten sonra, add_book
fonksiyonu bu bilgileri bir Kitap nesnesine dönüştürerek listeye ekler.
2. Kitap Silme: Kullanıcı, kütüphaneden silmek istediği kitabın adını girer. remove_book
fonksiyonu, bu adı self.books listesi içinde arar ve eşleşen kitap bulunursa siler.

3. İsme Göre Arama: Kullanıcı, bir kitabın adını girerek kitap araması yapabilir. search_by_name
fonksiyonu, girilen ismi self.books listesi içinde arar ve sonuçları listeler. Aranan kitap veya
kitaplar bulunursa, kullanıcıya kitap detayları gösterilir.
4. Yazara Göre Arama: Kullanıcı, bir yazar adı girerek, o yazarın kitaplarını arayabilir.
search_by_author fonksiyonu, belirtilen yazarı self.books listesi içinde arar ve varsa kitap
detaylarını kullanıcıya sunar.
5. Tüm Kitapları Listeleme: Kullanıcı, kütüphanede mevcut tüm kitapları görmek istediğinde,
list_books fonksiyonu çağrılır. Bu fonksiyon, self.books listesindeki tüm kitapları sırayla
listeler ve her bir kitabın adı, yazarı ve yayın yılı gibi bilgileri gösterir.
Kullanıcı Arayüzü ve Konsol Menüsü
Kullanıcı, basit bir konsol menüsü aracılığıyla işlemlerini gerçekleştirebilir. Menü, kullanıcıya aşağıdaki
seçenekleri sunar:
 Kitap Ekle: Yeni bir kitap eklemek için.
 Kitap Sil: Mevcut bir kitabı silmek için.
 Kitap Ara (İsme Göre): Kitapları ismine göre aramak için.
 Kitap Ara (Yazara Göre): Kitapları yazara göre aramak için.
 Tüm Kitapları Listele: Kütüphanedeki tüm kitapları listelemek için.
 Çıkış: Uygulamadan çıkmak için.
Örnek Kullanım Senaryosu
1. Kitap Ekleyin: Kullanıcı yeni bir kitap eklemek ister. Konsoldan &quot;1&quot; seçeneğini seçer, ardından
kitabın adını, yazarını ve yayın yılını girer. Kitap, Kitap nesnesine dönüştürülerek Library
sınıfındaki books listesine eklenir ve kullanıcıya &quot;Başarıyla eklendi&quot; mesajı verilir.
2. Kitap Silin: Kullanıcı, kütüphanedeki bir kitabı silmek istediğinde &quot;2&quot; seçeneğini seçer.
Konsolda kitap adı istenir. Library sınıfı, bu adı books listesi içinde arar, eşleşen kitap
bulunursa listeden çıkarır ve &quot;Başarıyla silindi&quot; mesajı gösterir.
3. İsme Göre Arayın: Kullanıcı belirli bir kitabı ismine göre aramak istediğinde &quot;3&quot; seçeneğini
seçer. search_by_name fonksiyonu çalışarak liste içinde arama yapar, kitabı bulursa ekranda
detaylarını gösterir.
4. Yazara Göre Arayın: Kullanıcı bir yazara ait kitapları görmek istediğinde &quot;4&quot; seçeneğini seçer
ve yazar adı girer. search_by_author fonksiyonu bu adı books listesinde arar ve eşleşen
kitapları kullanıcıya gösterir.
5. Tüm Kitapları Listeleyin: Kullanıcı tüm kütüphane kitaplarını görmek istediğinde &quot;5&quot;
seçeneğini seçer. Tüm kitaplar ekranda detaylarıyla birlikte listelenir.
6. Çıkış: Kullanıcı uygulamayı kapatmak için "6" seçeneğini seçer.

