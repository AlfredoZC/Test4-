using System.Diagnostics;
using TestDemo;

Console.WriteLine("Hello, World!");

bool checker = true;

while(checker){

    Console.WriteLine("Que desea calcular?\n");
    Console.WriteLine("1.- Fuerza dado masa y aceleracion\n");
    Console.WriteLine("2.- Calcular el \"trabajo\" dado la fuerza y distancia\n");
    Console.WriteLine("3.- Calcular la energia cinetica dado la masa y velocidad\n");
    Console.WriteLine("\n");
    Console.WriteLine("Ingrese su opcion del 1 - 3 : ");
    int result =  int.Parse(Console.ReadLine());


    if(result == 1){
        bool iterador1 = true;
        while(iterador1){
            Console.WriteLine("Vamos a calcular la Fuerza!");
            Console.WriteLine("Ingrese la masa:");
            double masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la aceleracion: ");
            double aceleracion = double.Parse(Console.ReadLine());  
            
            double resultF = Physics.fuerza(masa,aceleracion);
            Console.WriteLine($"El resultado es:{resultF}\n");
            Console.WriteLine("Quieres calcular la fuerza nuevamente?\n");
            Console.WriteLine("1.- SI           2.-NO");
            int checker1 = int.Parse(Console.ReadLine());
            if(checker1 == 1){
                continue;
            }else{
                iterador1 = false;
            }
        }
        


    }else if( result == 2){

        bool iterador2 = true;
        while(iterador2){
            Console.WriteLine("Vamos a calcular el trabajo!");
            Console.WriteLine("Ingrese la fuerza:");
            double fuerza = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la distancia: ");
            double distancia = double.Parse(Console.ReadLine());  
            
            double resultF = Physics.trabajo(fuerza,distancia);
            Console.WriteLine($"El trabajo es:{resultF}\n");
            Console.WriteLine("Quieres calcular el trabajo nuevamente?");
            Console.WriteLine("1.- SI           2.-NO");
            int checker1 = int.Parse(Console.ReadLine());
            if(checker1 == 1){
                continue;
            }else{
                iterador2 = false;
            }
        }

    }else if ( result == 3){

        bool iterador3 = true;
        while(iterador3){
            Console.WriteLine("Vamos a calcular la energia cinetica!");
            Console.WriteLine("Ingrese la masa:");
            double masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad: ");
            double velocidad = double.Parse(Console.ReadLine());  
            
            double resultF = Physics.energia_cinetica(masa,velocidad);
            Console.WriteLine($"La energia cinetica es:{resultF}\n");
            Console.WriteLine("Quieres calcular el trabajo nuevamente?");
            Console.WriteLine("1.- SI           2.-NO");
            int checker1 = int.Parse(Console.ReadLine());
            if(checker1 == 1){
                continue;
            }else{
                iterador3 = false;
            }
        }
    }
   
Console.WriteLine("Desea seguir usando la calculadora fisica?");
Console.WriteLine("1.- SI                   2.- NO");
int finisher = int.Parse(Console.ReadLine());  

    if (finisher == 1){
        continue;
    } else{
        Console.WriteLine("Gracias por usar la Calculadora fisica");
        checker = false;
    }

}