/* Practical W2 - C# Console Application
 * Jack Alexander
 * 29/09/2026
*/

Main(args);
void Main(String[] args) {

  int option;

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
}