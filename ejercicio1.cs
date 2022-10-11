using System;

public class ejercicio1 {
    static void main () {
        int a = 4, b = 5, c = 12; 
        int resul = Suma(a,b,c);
        
        Console.WriteLine(resul);

        Coche miCoche = new Coche();
        int mostrar = miCoche.AddDoor(3);
        Console.WriteLine("El numero de puertas es: {0}", mostrar);
    }
    
    static int Suma (int a, int b, int c){
        return a + b + c;
    }
}

abstract class Coche {
    static int AddDoor(int doors){
        return doors + 1;
    }
}