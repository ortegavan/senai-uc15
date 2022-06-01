Console.Write("Informe seu peso (em kg): ");
decimal peso = decimal.Parse(Console.ReadLine());

Console.Write("Informe sua altura (em m): ");
decimal altura = decimal.Parse(Console.ReadLine());

Console.WriteLine();

var imc = IMC.Calculo.Calcular(peso, altura);
var classificacao = IMC.Calculo.Classificar(imc);

Console.WriteLine($"Seu IMC é {imc.ToString("N2")} e a classificação é {classificacao}");