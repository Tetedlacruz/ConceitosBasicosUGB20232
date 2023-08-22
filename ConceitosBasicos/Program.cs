using ConceitosBasicos;

int num1 = 20;
int num2 = 11;
double num3 = 1.76;
int result;
double res;

Somador soma;
soma = new Somador();
result = soma.Soma(num1, num2);
Console.WriteLine($"A soma dos números {num1} + {num2} é {result}");

res = Conversor.MetrosMilimetros(num3);
Console.WriteLine("A medida " +num3+ " metros correspondente a " +res+ " milimetros");