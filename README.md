# PolyMorpihsm
Proje Özeti
Bu proje, C# dilinde geometrik şekillerin alan hesaplamasını gerçekleştiren bir konsol uygulamasıdır. Uygulama, BaseGeometrikSekil adında bir temel sınıf ve ondan türeyen Kare, Dikdortgen ve DikUcgen (Dik Üçgen) sınıflarını içermektedir. Proje, polimorfizm prensibini kullanarak her bir geometrik şeklin alanını hesaplamaktadır.

Sınıflar
BaseGeometrikSekil

Özellikler:
Width: Şeklin genişliği.
Height: Şeklin yüksekliği.
Metotlar:
CalculateArea(): Alanı hesaplamak için soyut bir metot. Türetilen sınıflarda (Kare, Dikdortgen, DikUcgen) farklı şekilde uygulanır.
Kare (BaseGeometrikSekil'den Kalıtım Alır)

Metotlar:
CalculateArea(): Alanı genişlik * yükseklik ile hesaplar.
Dikdortgen (BaseGeometrikSekil'den Kalıtım Alır)

Metotlar:
CalculateArea(): Alanı genişlik * yükseklik ile hesaplar.
DikUcgen (BaseGeometrikSekil'den Kalıtım Alır)

Metotlar:
CalculateArea(): Alanı (genişlik * yükseklik) / 2 ile hesaplar.
Çalıştırma Adımları
Projeyi C# destekleyen bir IDE'de (örneğin Visual Studio veya Visual Studio Code) açın.
Projeyi derleyin ve çalıştırın.
Program, her bir geometrik şekil için bir nesne oluşturur, değerleri atar ve alan hesaplama metotlarını çağırarak sonuçları konsola yazdırır.
