Console.WriteLine("Fake Identity Generator");
Console.WriteLine("");
Console.Title = "Fake ID Gen";
ConsoleKeyInfo cki;

var rand = new Random();

Console.WriteLine("---------------------- LOG ----------------------");
string[] names = System.IO.File.ReadAllLines("names.txt");
Console.WriteLine("Generated name");

string[] surnames = System.IO.File.ReadAllLines("surnames.txt");
Console.WriteLine("Generated surname");

string[] jobs = System.IO.File.ReadAllLines("jobs.txt");
Console.WriteLine("Generated job");

int[] giorni = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
Console.WriteLine("Generated born day");

int[] mesi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
Console.WriteLine("Generated born month");

int[] expire = { 2023, 2024, 2025, 2026 };

string[] blood = { "0+", "0-", "A+", "A-", "B+", "B-", "AB+", "AB-" };
Console.WriteLine("Generated blood type");


int[] weight, height;
weight = new int[80];
height = new int[105];
for (int i = 0; i < 79; i++)
{
    weight[i] = i + 40;
}

Console.WriteLine("Generated weight");


for (int i = 0; i < 104; i++)
{
    height[i] = i + 95;
}
Console.WriteLine("Generated height");


int anni = 0;
int credit1 = 0;
int credit2 = 0;
int credit3 = 0;
int credit4 = 0;
int cvv = 0;

while (anni < 1950 || anni > 2010)
{
    anni = rand.Next(2010);
}
Console.WriteLine("Generated born year");

/* Credit card gen stuff
  while (credit1 < 5500 || credit1 > 4020)
{
    credit1 = rand.Next(9999);
}
while (credit2 < 9999 || credit1 > 1000)
{
    credit2 = rand.Next(9999);
}
while (credit3 < 9999 || credit1 > 1000)
{
    credit3 = rand.Next(9999);
}
while (credit4 < 9999 || credit1 > 1000)
{
    credit4 = rand.Next(9999);
}
while (cvv < 900 || cvv > 600)
{
    cvv = rand.Next(900);
} */

int numeroNome = rand.Next(18240);
int numeroCognome = rand.Next(1000);
string nomeRand = names[numeroNome];
string cognomeRand = names[numeroCognome];
Console.WriteLine("-------------------------------------------------");
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("");
Console.WriteLine("Name: " + nomeRand);
Console.WriteLine("Surname: " + cognomeRand);
Console.WriteLine("Born: " + giorni[rand.Next(29)] + "/" + mesi[rand.Next(13)] + "/" + anni);
Console.WriteLine("Work: " + jobs[rand.Next(1000)]);
Console.WriteLine("Height: " + height[rand.Next(105)] + " cm");
Console.WriteLine("Weight: " + weight[rand.Next(80)] + " cm");
Console.WriteLine("Blood Type:: " + blood[rand.Next(8)]);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Press the Escape (Esc) key to quit:");
do
{
    cki = Console.ReadKey();
 
} while (cki.Key != ConsoleKey.Escape);

/*
CREDIT CARD GENERATOR (not 100% working)
Console.WriteLine("-------------------------------------------------------------------------------------------");
Console.WriteLine("Credit card: " + credit1 + " " + credit2 + " " + credit3 + " " + credit4);
Console.WriteLine("CVV: " + cvv);
Console.WriteLine("Expire: " + mesi[rand.Next(13)] + "/" + expire[rand.Next(5)]); 
*/

