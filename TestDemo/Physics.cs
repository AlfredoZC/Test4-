namespace TestDemo;

public static class Physics
{
    public static double fuerza(double num1, double num2){
        return num1 * num2;
    }

    public static double trabajo( double fuerza, double distancia){
        return fuerza * distancia;
    }

    public static double energia_cinetica (double masa, double velocidad){
        double result = 0.5 * masa * velocidad * velocidad;
        return result;
    }
}
