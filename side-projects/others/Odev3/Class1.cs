Soruların her birine C# kodlarıyla çözüm sağlayalım. Her kod bloğunda algoritma adımlarını ve açıklamaları belirterek ilerleyeceğiz.

1. Diziyi Sıralama ve İkili Arama ile Sayı Kontrolü

Açıklama:

	•	Kullanıcıdan bir dizi alıp sıralayacağız, ardından bir sayı alıp ikili arama algoritması ile dizide olup olmadığını kontrol edeceğiz.

using System;

class Program
{
    static void Main()
    {
        // Giriş: Kullanıcıdan diziyi alıyoruz
        Console.WriteLine("Dizi eleman sayısını girin:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Dizi elemanını girin [{i + 1}/{n}]:");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Dizi sıralanıyor
        Array.Sort(array);
        Console.WriteLine("Sıralanmış dizi: " + string.Join(", ", array));

        // Kontrol: Kullanıcıdan bir sayı alıp dizide olup olmadığını kontrol edeceğiz
        Console.WriteLine("Dizide aramak istediğiniz sayıyı girin:");
        int target = int.Parse(Console.ReadLine());

        // İkili arama işlemi
        bool found = BinarySearch(array, target, 0, array.Length - 1);
        Console.WriteLine(found ? "Sayı dizide bulundu." : "Sayı dizide yok.");
    }

    // İkili Arama Fonksiyonu
    static bool BinarySearch(int[] array, int target, int low, int high)
    {
        if (low > high) return false;

        int mid = (low + high) / 2;

        if (array[mid] == target) return true;
        else if (array[mid] > target) return BinarySearch(array, target, low, mid - 1);
        else return BinarySearch(array, target, mid + 1, high);
    }
}

2. Pozitif Tam Sayıların Ortalaması ve Medyanı

Açıklama:

	•	Kullanıcı pozitif sayılar girecek, 0 girildiğinde ortalama ve medyan hesaplanacak.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        
        // Giriş: Sayıları alıyoruz
        while (true)
        {
            Console.WriteLine("Bir pozitif sayı girin (Bitirmek için 0):");
            int num = int.Parse(Console.ReadLine());
            if (num == 0) break;
            numbers.Add(num);
            sum += num;
        }

        // Çıkış: Ortalama hesaplanıyor
        double average = (double)sum / numbers.Count;
        Console.WriteLine("Ortalama: " + average);

        // Medyan hesaplanıyor
        numbers.Sort();
        double median;
        int mid = numbers.Count / 2;
        if (numbers.Count % 2 == 0)
            median = (numbers[mid - 1] + numbers[mid]) / 2.0;
        else
            median = numbers[mid];
        Console.WriteLine("Medyan: " + median);
    }
}

3. Ardışık Sayı Gruplarını Tespit Etme

Açıklama:

	•	Ardışık sayı gruplarını bulmak için kullanıcıdan bir dizi alıyoruz ve grupları listeliyoruz.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Giriş: Kullanıcıdan sayılar alınıyor
        while (true)
        {
            Console.WriteLine("Bir sayı girin (Bitirmek için 0):");
            int num = int.Parse(Console.ReadLine());
            if (num == 0) break;
            numbers.Add(num);
        }

        numbers.Sort();
        Console.WriteLine("Sıralı dizi: " + string.Join(", ", numbers));

        // Ardışık grupları bulma
        FindConsecutiveGroups(numbers);
    }

    static void FindConsecutiveGroups(List<int> numbers)
    {
        int start = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1)
            {
                Console.WriteLine($"{start}-{numbers[i - 1]}");
                start = numbers[i];
            }
        }
        Console.WriteLine($"{start}-{numbers[numbers.Count - 1]}");
    }
}

4. İfade Çözümleyici (İşlem Önceliğine Göre)

Açıklama:

	•	Matematiksel ifadeleri çözümlemek için işlem önceliği kurallarına göre çözüm adımlarını ve sonucu göstereceğiz.

using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.WriteLine("Matematiksel ifadeyi girin:");
        string expression = Console.ReadLine();

        // Çözüm sürecini gösterme
        Console.WriteLine("Çözüm Süreci:");
        EvaluateExpression(expression);
    }

    static void EvaluateExpression(string expression)
    {
        // DataTable sınıfını kullanarak işlem çözümlemesi
        DataTable table = new DataTable();
        table.Columns.Add("expression", typeof(string), expression);
        DataRow row = table.NewRow();
        table.Rows.Add(row);

        // Çıktı: İşlemin sonucu
        Console.WriteLine($"Sonuç: {table.Compute(expression, string.Empty)}");
    }
}

Bu şekilde, her soru için ayrı bir C# kodu ve açıklamaları sunarak çözümü tamamlıyoruz. Devamındaki sorulara yönelik çözümleme veya özel bir sorunun detaylandırılması için yardım gerekirse ekleyebilirim.xw