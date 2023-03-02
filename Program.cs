class Program {
    static void Main(string[] args) {
        Console.Write ("secret number :");
        int a = int.Parse(Console.ReadLine());
       
        Console.Write ("agent:");
        string b = (Console.ReadLine());
        
        if(a <= 999999 && a >= 0) {
            int hth = a / 100000 % 10;
            int tth = a / 10000 % 10;
            int th = a / 1000 % 10;
            int hun = a / 100 % 10;
            int ten = a / 10 % 10;
            int num = a / 10;
        
         if(b == "CIA") {
            if(th >= 6 && th != 8 && ten != 1 && ten != 3 && ten != 5 && num % 3 == 0) {
                Console.WriteLine("True");
            }
            else {
                 Console.WriteLine("False");
            }
         }
         if(b == "FBI") {
            if(hth >= 4 && hth <= 7 && tth % 2 != 0 && hun % 2 == 0 && hun != 6) {
                Console.WriteLine("True");
            }
            else {
                 Console.WriteLine("False");
            }
         }if(b == "NSA") {
            if(hun % 3 == 0 && hun %2 != 0 && num % 30 == 0 && num == 7 || ten == 7 || hun == 7 || 
            th == 7 || tth == 7 || hth == 7) {
                Console.WriteLine("True");
            }
            else {
                 Console.WriteLine("False");
            }
         }
    }else {
                 Console.WriteLine("False");

                 
            }
}
}