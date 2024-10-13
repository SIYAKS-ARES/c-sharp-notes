using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

void printHangman(int wrong)
{
    if (wrong == 0)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine("    |");
        Console.WriteLine("    |");
        Console.WriteLine("    |");
        Console.WriteLine("   ===");
    }
    else if (wrong == 1)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine("O   |");
        Console.WriteLine("    |");
        Console.WriteLine("    |");
        Console.WriteLine("   ===");
    }
    else if (wrong == 2)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine("O   |");
        Console.WriteLine("|   |");
        Console.WriteLine("    |");
        Console.WriteLine("   ===");
    }
    else if (wrong == 3)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O  |");
        Console.WriteLine("/|  |");
        Console.WriteLine("    |");
        Console.WriteLine("   ===");
    }
    else if (wrong == 4)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O  |");
        Console.WriteLine("/|\\ |");
        Console.WriteLine("    |");
        Console.WriteLine("   ===");
    }
    else if (wrong == 5)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O  |");
        Console.WriteLine("/|\\ |");
        Console.WriteLine("/   |");
        Console.WriteLine("   ===");
    }
    else if (wrong == 6)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O   |");
        Console.WriteLine("/|\\  |");
        Console.WriteLine("/ \\  |");
        Console.WriteLine("    ===");
    }
}

int printWord(List<char> guessedLetters, String randomWord)
{
    int counter = 0;
    int rightLetters = 0;
    Console.Write("\r\n");
    foreach (char c in randomWord)
    {
        if (guessedLetters.Contains(c))
        {
            Console.Write(c + " ");
            rightLetters += 1;
        }
        else
        {
            Console.Write("  ");
        }
        counter += 1;
    }
    //Console.Write("\r\n");
    return rightLetters;
}

void printLines(String randomWord)
{
    Console.Write("\r");
    foreach (char c in randomWord)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("\u0305 ");
    }
}

Console.WriteLine("Welcome to hangman cities of Turkey edition :)");
Console.WriteLine("-----------------------------------------");

Random random = new Random();
List<string> wordDictionary = new List<string> {
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"
            };
int index = random.Next(wordDictionary.Count);
String randomWord = wordDictionary[index];

foreach (char x in randomWord)
{
    Console.Write("_ ");
}

int lengthOfWordToGuess = randomWord.Length;
int amountOfTimesWrong = 0;
List<char> currentLettersGuessed = new List<char>();
int currentLettersRight = 0;

while (amountOfTimesWrong != 6 && currentLettersRight != lengthOfWordToGuess)
{
    Console.Write("\nLetters guessed so far: ");
    foreach (char letter in currentLettersGuessed)
    {
        Console.Write(letter + " ");
    }

    Console.Write("\nGuess a letter: ");
    char letterGuessed = Console.ReadLine()[0];

    if (currentLettersGuessed.Contains(letterGuessed))
    {
        Console.Write("\r\n You have already guessed this letter");
        printHangman(amountOfTimesWrong);
        currentLettersRight = printWord(currentLettersGuessed, randomWord);
        printLines(randomWord);
    }
    else
    {

        bool right = false;
        for (int i = 0; i < randomWord.Length; i++) { if (letterGuessed == randomWord[i]) { right = true; } }


        if (right)
        {
            printHangman(amountOfTimesWrong);

            currentLettersGuessed.Add(letterGuessed);
            currentLettersRight = printWord(currentLettersGuessed, randomWord);
            Console.Write("\r\n");
            printLines(randomWord);
        }

        else
        {
            amountOfTimesWrong += 1;
            currentLettersGuessed.Add(letterGuessed);

            printHangman(amountOfTimesWrong);

            currentLettersRight = printWord(currentLettersGuessed, randomWord);
            Console.Write("\r\n");
            printLines(randomWord);
        }
    }
}
Console.WriteLine("\r\nGame is over! Thank you for playing!");
Console.WriteLine("The City was:" + randomWord);
