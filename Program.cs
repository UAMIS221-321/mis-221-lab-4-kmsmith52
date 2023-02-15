// See https://aka.ms/new-console-template for more information
class Lab4 {
    public static void Main(string[] args) {
        string choice;
        System.Console.WriteLine("Type 1 for full triangle, type 2 for partial triangle, and type 3 to exit");
        choice = Console.ReadLine();

        if (choice != "1" && choice != "2" && choice != "3") {
            while (choice != "1" && choice != "2" && choice != "3") {
                System.Console.WriteLine("Please enter one of the three options mentioned above.");
                choice = Console.ReadLine();
            } 
        }
        
        if(choice == "1") {
            Lab4.GetFull();
        }
        else if (choice == "2") {
            Lab4.GetPartial();
        }
        else if (choice != "3") {
            System.Console.WriteLine("Thank you for using this program!");
        }
    }
    
    
    static void GetFull() {
        Random rnd = new Random();
        int number = rnd.Next(3, 10);
        for (int i = 0; i <= number; i++) {
            for (int j = 0; j < i; j++) {
                System.Console.Write("O");
            }
            System.Console.WriteLine();
        }
    }

    static void GetPartial() {
        Random rnd = new Random();
        int number = rnd.Next(3, 10);
        for (int i = 0; i <= number; i++) {
            for (int j = 0; j < i; j++) {
                Random rand = new Random();
                int num = rand.Next(2);
                if (num == 0) {
                    System.Console.Write("O");
                }
                else {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
}

