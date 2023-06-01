Console.WriteLine("Welcome to yet another interactive story game.");
Console.WriteLine();
Thread.Sleep(1000);
Console.WriteLine("Type 'yes' to proceed and 'no' to end");

string[] names = {"Ham", "Lettuce", "Ketchup", "Sandwich", "Cornstarch", "Hatter", "Moustache", "dapperman", "dripper", "drizzler"};
Random generator = new Random(); //Ger dig ett random namn efter du har sagt "yes" som är 2 av dessa ord.

int firstName = 1;
int lastName = 1;

string yesno = Console.ReadLine(); //variabeln för dörren man ska välja
string loweryesno = yesno.ToLower(); //för att transformera alla bokstäver man skriver till små bokstäver
if (loweryesno == "yes") 
{   
    int r = generator.Next(9);
    firstName = r;
    int r2 = generator.Next(9);
    lastName = r2;

    Console.WriteLine($"Great! Your name will from now on be Mr. {names[firstName]} {names[lastName]}. Hope you like it, because you are stuck with it now.");
    Console.WriteLine("...");

    Hello:
        string thehat = ""; //skapar en tom variabel som ska fyllas upp efter frågan varje gång
        Thread.Sleep(1500);
        Console.WriteLine($"You wake up in your room. But it is not your room. You look around and find strange tophats on the floor. One red and one blue. You wonder what they are for and then decide to put one on, wich one do you pick? 'red hat' or 'blue hat'");
        thehat = Console.ReadLine();
        string lowerthehat = thehat.ToLower();
        if (lowerthehat == "red hat")
        {
            Thread.Sleep(1000);
            Console.WriteLine("You put the red hat on. You looked in the mirror and saw a increadebly dapper looking man, your jaw dropped as you have never looked this good before. Behind you on the bed there now seemed to be two suits. A 'blue suit' or 'red suit'");
            string thesuit = Console.ReadLine();
            string lowerthesuit = thesuit.ToLower();
            if (lowerthesuit == "red suit")
            {
                Thread.Sleep(1000);
                Console.WriteLine("The red suit. What a great choise you thought. You put it on and instantly felt good about your choise. Very very stylish indeed. Type 'acknowledge dapper'");
                string dapper = Console.ReadLine();
                string lowerdapper = dapper.ToLower();
                if (lowerdapper == "acknowledge dapper")
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"You acknowledge how dapper you look. And indeed you do, Mr. {names[firstName]} {names[lastName]}, all dressed up in red. You wake up from the dream you were having. THE END");
                    Console.ReadLine();
                }
            }

            else if (lowerthesuit == "blue suit")
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("You put the blue suit on. You looked in the mirror and did not see you wearing it, strange?. you turned around to pick up the other suit. Instantly you flung out of bed. You were back in the room and could make the choise of blue hat and red hat again.");
                    Thread.Sleep(2000);
                    goto Hello;
                }
        }

        else if (lowerthehat == "blue hat")
            {
                Thread.Sleep(1000);
                Console.WriteLine("You put the blue hat on. You looked in the mirror and did not see it, strange?. you turned around and picked up the red hat. Instantly you flung out of bed. You were back in the room and could make the choise of blue hat and red hat again.");
                Thread.Sleep(2000);
                goto Hello;
            }




    
}

if (loweryesno == "no")
{
    Console.WriteLine("Closing in...");
    Thread.Sleep(1000);
    Console.WriteLine("5..");
    Thread.Sleep(1000);
    Console.WriteLine("4..");
    Thread.Sleep(1000);
    Console.WriteLine("3..");
    Thread.Sleep(1000);
    Console.WriteLine("2..");
    Thread.Sleep(1000);
    Console.WriteLine("1..");
    Thread.Sleep(1000);
    Console.WriteLine("Closing.");
    Thread.Sleep(1000);
}