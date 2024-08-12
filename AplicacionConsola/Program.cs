using Humanizer;
string nombre = "Jhonatan";
string apellido = "Toro";
int sueldo = 10350000;

Console.Clear();
Console.WriteLine($"Nombre: {nombre} {apellido}");
Console.WriteLine($"");
Console.WriteLine($"Sueldo: {sueldo:C2}");
Console.WriteLine($"Es decir, ganas {sueldo.ToWords()} pesos Colombianos");