using System.Security.Cryptography;

namespace TestDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void fuerza()
    {
        double masa = 2.6;
        double aceleracion = 3.5; 
        double result = 9.1;

        double ExpectedResult = Physics.fuerza(masa,aceleracion);

        Assert.Equal(ExpectedResult, result);

    }
    [Fact]
    public void trabajo ()
    {
        double fuerza = 4.1;
        double distancia = 3.2;
        double ExpectedResult = 13.12;

        double result = Physics.trabajo(fuerza, distancia);

        Assert.Equal(ExpectedResult, result);
    }

    [Fact]
    public void energia_cinetica()
    {
        // Given
        var masa = 3.5;
        var velocidad = 5.5;
        // When
        var ExpectedResult = 52.9375;
        // Then
        var result = Physics.energia_cinetica(masa,velocidad);
        Assert.Equal(ExpectedResult, result);

    }
}