int pessoas, adultostotal, adultoalcool, adultonaoalcool, criancas;
double acompanhamentos, cerveja, carne, agua, refrigerante;

Console.WriteLine("--- Churrascão da galera ---");

Console.Write("Quantos adultos não consomem álcool? ");
adultonaoalcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantos adultos consomem bebidas alcoólicas? ");
adultoalcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantas crianças estarão presentes nesse churrasco? ");
criancas = Convert.ToInt32(Console.ReadLine());

adultostotal = adultoalcool + adultonaoalcool;
pessoas = adultostotal + criancas;

if (adultostotal > 1)
{
carne = 0.4 * adultostotal + 0.2 * criancas;
acompanhamentos = 0.2 * adultostotal + 0.2 * criancas;
cerveja = adultoalcool * 2;
agua = 0.4 * pessoas;
refrigerante = 0.5 * pessoas;

Console.WriteLine("");

Console.WriteLine($"O total de carne será {carne}kg");
Console.WriteLine($"O total de cerveja será {cerveja}L");
Console.WriteLine($"O total de água será {agua}L");
Console.WriteLine($"o total de acompanhamentos será de {acompanhamentos}kg");
Console.WriteLine($"O total de refrigerante será de {refrigerante}L");
}

else 
{
Console.WriteLine("Não é possível fazer um churrasco sem o acompanhamento de um adulto responsável!");
return;
}