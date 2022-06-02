using System;
using IMC;
using Xunit;

public class TestesIMC
{
    [Fact]
    public void TestarCalculo()
    {
        var peso = 74M;
        var altura = 1.70M;

        var imc = Calculo.Calcular(peso, altura);

        Assert.Equal(25.61M, Math.Round(imc, 2));
    }

    [Fact]
    public void TestarClassificacao()
    {
        var imc = 25.61M;
        var classificacao = Calculo.Classificar(imc);

        Assert.Equal(Classificacao.Sobrepeso, classificacao);
    }
}
