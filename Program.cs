// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Primeiro.Entities;
using Primeiro.Entities.Enums;

//Entrada de Dados
List<Contribuinte> Contribuinte = new List<Contribuinte>();

Console.Write("Enter the number of tax payers: ");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++) {
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or Company (i/c)? ");
    char a = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (a == 'i' || a == 'I') {
        Console.Write("Health expenditures: ");
        double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Contribuinte.Add(new Fisico(name, income, health));
    }
    else {
        Console.Write("Employers: ");
        int employers = int.Parse(Console.ReadLine());
        Contribuinte.Add(new Juridica(name, income, employers));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
double sum = 0.0;
foreach (Contribuinte contribuinte in Contribuinte) {
    double imposto = contribuinte.Imposto();
    Console.WriteLine(contribuinte.Name + ": $ " + contribuinte.Imposto().ToString("F2", CultureInfo.InvariantCulture));
    sum += imposto;
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));