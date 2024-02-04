// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string message1 = "Krediler";
int term = 12;
double amount = 100000.5;

bool isAuthenticated = false;


// variables ---> camelCase




// ************ conditions ************


if (isAuthenticated)
{
    Console.WriteLine("Buton --> Hoşgeldiniz...");
}
else
{
    Console.WriteLine("Lütfen giriş yapınız..");
}



// ************ arrays ************

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", };
string[] loans2 = new string[5];
loans2[0] = "Kredi1";

string[] loans3 = new string[]
{
    "kredi1",
    "Kredi2"
};

                                    // increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}











Console.WriteLine("Kod bitti");






