/* Practical W2 - C# Console Application
 * Jack Alexander
 * 29/09/2026
*/

using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

Main(args);
void Main(String[] args) {

    Decrypt();
    //Encrypt();
    // TaskFive();

    /* int option;

           do {
               PrintMenu();
               option = InputOption();
               GetMessage(option);
           }
           while (option != 0);
       }

       void PrintMenu() { 

       Console.WriteLine("Please enter a valid option from below:\n");
       Console.WriteLine("1. Hello in French");
       Console.WriteLine("2. Hello in Spanish");
       Console.WriteLine("3. Hello in German");
       Console.WriteLine("4. Hello in Italian");
       Console.WriteLine("0. Exit Application\n");

       }

   int InputOption() {

       try
       {
           int option = Convert.ToInt32(Console.ReadLine());
           return option;
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
           return -1; // Return an invalid option to indicate an error
       }
   }

   String GetMessage(int option) {
       switch (option)
       {
           case 1:
               Console.WriteLine("\nBonjour\n");
               return "Bonjour";
           case 2:
               Console.WriteLine("\nHola\n");
               return "Hola";
           case 3:
               Console.WriteLine("\nHallo\n");
               return "Hallo";
           case 4:
               Console.WriteLine("\nCiao\n");
               return "Ciao";
           case 0:
               Console.WriteLine("\nGoodbye"); 
               return "Goodbye";
           default:
               Console.WriteLine("\nPlease enter a valid option.\n");
               return "Invalid option";
       }

    */
    void TaskFive() {

        Console.WriteLine("Please enter a string:");
        String str = Console.ReadLine();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string result = textInfo.ToTitleCase(str.ToLower());
        Console.WriteLine(result);
        int wordCount = str.Split(' ').Length;
        Console.WriteLine("The sentence you inputted is: {0}", str);
        Console.WriteLine("Number of words = {0}", wordCount);

    }

    void Encrypt() {

        Console.Write("Please enter a string: ");
        String encrypt = Console.ReadLine();
        Console.Write("\nPlease enter number of rotations: ");
        int rotations = Convert.ToInt32(Console.ReadLine());
        string encrypted = "";

        foreach (char c in encrypt)
        {
            encrypted += (char)(c + rotations);
        }

        Console.WriteLine("\nThe sentence you inputted is: {0}", encrypt);
        Console.WriteLine("\nThe encrypted sentence is now: {0}", encrypted);
    }

    void Decrypt(){

        Console.Write("Please enter a string to decrypt: ");
        String decrypt = Console.ReadLine();
        Console.Write("\nPlease enter number of rotations: ");
        int rotations = Convert.ToInt32(Console.ReadLine());
        string decrypted = "";

        foreach (char decryptCharacter in decrypt)
        {
            decrypted += (char)(decryptCharacter - rotations);
        }

        Console.WriteLine("\nThe sentence you inputted is: {0}", decrypt);
        Console.WriteLine("\nThe decrypted sentence is now: {0}", decrypted);

    }

    void MenuSystem() {

        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Encrypt");
        Console.WriteLine("2. Decrypt");
        Console.WriteLine("0. Exit Application\n");

    }

   /* int InputOption()
    {

        try
        {
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return -1; // Return an invalid option to indicate an error

    */
        }