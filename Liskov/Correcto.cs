
using System;

namespace Act4_DACS.Liskov.Correcto{

    //"you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification"

public abstract class Figura  {  
    public abstract double Area();  
} 

public class Rectangulo: Figura{  
     public double Alto {get;set;}  
     public double Ancho {get;set; }  

    public override double Area(){
        return Alto*Ancho;
    }
   
}  
public class Circulo: Figura{  
    public double Radio {get;set;}  

    public override double Area(){
        return Radio * Radio * Math.PI;
    }
}  
public class CalculadorArea  {  

    // Aqui aplicamos el principio de sustitucion, ya que en el array de figuras nunca contiene un objeto instanciado desde figura, ya que es una clase
    // abstracta, lo que nos llegan son implementaciones concretas de la clase, por ejemplo, rectangulo o circulo.
    public static double AreaTotal(Figura[] arrFiguras)  {  
        double area = 0;  
        foreach(var figura in arrFiguras)  {  
         area += figura.Area();  
        }    
      return area;  
    }  
}

class Program
{
    static void Main(string[] args)
    {
        Rectangulo rect1 = new Rectangulo();
        rect1.Alto = 2;
        rect1.Ancho = 4;

        Circulo circulo = new Circulo();
        circulo.Radio = 1;

        Figura[] figuras = new Figura[2]{rect1, circulo};

        Console.WriteLine(CalculadorArea.AreaTotal(figuras));

    }
}

}
