using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kim milyoner olmak yarışmasına hoşgeldiniz.\nBu yarışmada size 3 sorumuz olacak. 2 soruyu doğru cevaplarsanız yarışmayı kazanacaksınız.\nSize verilen 2 kategoriden birini seçerek yarışmaya başlayabilirsiniz.");
        Console.Write("Lütfen kategori seçiniz: \n1) Tarih\n2) Spor\n");

        string kategori = Console.ReadLine();  // Kullanıcıdan kategori seçimi alınır
        int point = 0;  // Doğru cevap sayısı

        if (kategori == "1")
        {
            Console.WriteLine("Tarih kategorisini seçtiniz.\nHazırsanız başlayalım!\n(y/n)");
            string basla = Console.ReadLine();
            if (basla == "y")
            {
                // Tarih kategorisindeki sorular
                point += AskQuestion("İstanbul'un Fethi hangi tarihte gerçekleşmiştir?", "A) 1299", "B) 1453", "C) 1517", "D) 1923", "b");
                point += AskQuestion("I. Dünya Savaşı hangi yıllar arasında gerçekleşmiştir?", "A) 1914-1918", "B) 1939-1945", "C) 1804-1815", "D) 1900-1905", "a");
                point += AskQuestion("Magna Carta (Büyük Özgürlükler Sözleşmesi) hangi ülkede imzalanmıştır?", "A) Fransa", "B) İngiltere", "C) Almanya", "D) İtalya", "b");
            }
            else
            {
                Console.WriteLine("Artık çok geç:)");
            }
        }
        else if (kategori == "2")
        {
            Console.WriteLine("Spor kategorisini seçtiniz.\nHazırsanız başlayalım!\n(y/n)");
            string basla = Console.ReadLine();
            if (basla == "y")
            {
                // Spor kategorisindeki sorular
                point += AskQuestion("2022 FIFA Dünya Kupası şampiyonu hangi ülke olmuştur?", "A) Fransa", "B) Arjantin", "C) Brezilya", "D) Almanya", "b");
                point += AskQuestion("Usain Bolt hangi spor dalında ünlüdür?", "A) Futbol", "B) Basketbol", "C) Atletizm", "D) Yüzme", "c");
                point += AskQuestion("NBA'de 2023 şampiyonu hangi takım olmuştur?", "A) Los Angeles Lakers", "B) Miami Heat", "C) Denver Nuggets", "D) Boston Celtics", "c");
            }
            else
            {
                Console.WriteLine("Artık çok geç:)");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz kategori seçimi.");
        }

        // Sonuçları yazdır
        if (point >= 2)
        {
            Console.WriteLine($"Tebrikler! Yarışmayı kazandınız! Doğru cevap sayınız: {point}");
        }
        else
        {
            Console.WriteLine($"Yarışmayı kaybettiniz. Doğru cevap sayınız: {point}");
        }
    }

    // Soru sorma ve cevabı kontrol etme fonksiyonu
    static int AskQuestion(string question, string optionA, string optionB, string optionC, string optionD, string correctAnswer)
    {
        Console.WriteLine($"{question}\n{optionA}\n{optionB}\n{optionC}\n{optionD}");
        string cevap = Console.ReadLine().ToLower();

        if (cevap == correctAnswer)
        {
            Console.WriteLine("Doğru cevap!");
            return 1;
        }
        else
        {
            Console.WriteLine("Yanlış cevap.");
            return 0;
        }
    }
}
