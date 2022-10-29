int[] randomDizi = new int[10];               // integer tipinde 10 adetlik bir dizi oluşturalım
int randomDeger;                             // oluşturacağımız random sayıları ilk olarak nu değişkene yazacağız
Random random = new Random();               // random nesnesi oluşturarak bunu kullanacağız
for (int i = 0; i < randomDizi.Length; i++)
{
    randomDeger=random.Next(100);
    randomDizi[i] = randomDeger;                // oluşturulan random değerleri dizi içine atıyoruz
    Console.WriteLine($"[{randomDizi[i]}]");  // dizimizi yazdırıyoruz
}

Array.Sort(randomDizi);
foreach (int yazdir in randomDizi)
    Console.Write($"[{yazdir}],");
