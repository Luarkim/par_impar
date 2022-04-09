int numero;
string paridade;

Console.Write("digite um núumero: ");
numero = Convert.ToInt32(Console.ReadLine ());

paridade = (numero % 2) == 0 ? "par" : "ímpar";

Console.WriteLine($"{numero} é {paridade}");