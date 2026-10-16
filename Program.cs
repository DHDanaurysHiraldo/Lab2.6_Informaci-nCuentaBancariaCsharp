
using static System.Runtime.InteropServices.JavaScript.JSType;

//Crear una aplicación de consola que solicite:
//-- Nombre del cliente
//-- Número de cuenta
//-- Tipo de cuenta
//-- Saldo actual
Console.Clear();

string nombreCliente, tipoCuenta;
int numeroCuenta;
double saldo;

Console.WriteLine("=========================================");
Console.WriteLine("APP - INFORMACIÓN DE UNA CUENTA BANCARIA");
Console.WriteLine("=========================================");

Console.Write("Ingrese el Nombre del Cliente: ");
nombreCliente = Console.ReadLine();

Console.Write("Ingrese su Número de Cuenta de 5 digitos: ");
numeroCuenta = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el Tipo de Cuenta (Ahorros / Corriente): ");
tipoCuenta = Console.ReadLine();

Console.Write("Ingrese el Saldo actual: ");
saldo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("=======================");
Console.WriteLine("  INFORMACIÓN CUENTA  ");
Console.WriteLine("=======================");

Console.WriteLine($"Cliente: {nombreCliente}");
Console.WriteLine($"Cuenta: {numeroCuenta}");
Console.WriteLine($"Tipo: {tipoCuenta}");
Console.WriteLine($"Saldo: {saldo}");

