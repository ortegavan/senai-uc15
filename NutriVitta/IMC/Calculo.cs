using System;

namespace IMC
{
	public static class Calculo
	{
		public static decimal Calcular(decimal peso, decimal altura)
        {
			return peso / (altura * altura);
        }

		public static Classificacao Classificar(decimal imc)
        {
			Classificacao classificacao;

			if (imc < 18.5M)
            {
				classificacao = Classificacao.AbaixoDoPeso;
            }
			else if (imc >= 18.5M && imc < 24.9M)
            {
				classificacao = Classificacao.PesoNormal;
            }
			else if (imc >= 25M && imc < 29.9M)
            {
				classificacao = Classificacao.Sobrepeso;
            }
			else if (imc >= 30M && imc < 34.9M)
			{
				classificacao = Classificacao.ObesidadeGrauI;
			}
			else if (imc >= 35M && imc < 39.9M)
			{
				classificacao = Classificacao.ObesidadeGrauII;
			}
			else
			{
				classificacao = Classificacao.ObesidadeGrauIII;
			}

			return classificacao;
		}
	}
}

