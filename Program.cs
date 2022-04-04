using DIO.TesteTec.Classes;

Console.WriteLine("Digite uma nova pessoa iniciando por");
Console.WriteLine("Nome:");
var nomePessoa = Console.ReadLine();
Console.WriteLine("Dia:");
var ddPessoa = Int32.Parse(Console.ReadLine());
Console.WriteLine("Mes:");
var mmPessoa = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ano:");
var aaaaPessoa = Int32.Parse(Console.ReadLine());
Console.WriteLine("Altura:");
var altPessoa = Int32.Parse(Console.ReadLine());
Pessoa novaPessoa = new Pessoa(nomePessoa,ddPessoa,mmPessoa,aaaaPessoa,altPessoa);
System.Console.WriteLine(novaPessoa );