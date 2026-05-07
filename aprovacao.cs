using System.ComponentModel;


Console.WriteLine("=== Calculadora Escolar ===");
Console.Write("Digite a primeira nota:");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write(" Digite a segunda nota:" );
double nota2 = Convert.ToDouble(Console.ReadLine());

double soma = nota1 + nota2;
Console.WriteLine($"Soma das notas:" { soma});

double media = soma / 2;

Console.WriteLine($"Média: {media}");
if (media >= 7)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}


