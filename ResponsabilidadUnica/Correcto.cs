using System;

public class Rectangulo{  
    public double Alto {get;set;}  
    public double Ancho {get;set; }  
}  

public class CalculadorArea {  
    public static double TotalArea(Rectangulo[] rectangulos)  {  
        double area = 0;  
        foreach (Rectangulo rect in rectangulos){
            area += rect.Alto * rect.Ancho;      
        }
        return area; 
    }  
} 
/*
class Program
{
    static void Main(string[] args)
    {
        Rectangulo rect1 = new Rectangulo();
        rect1.Alto = 2;
        rect1.Ancho = 4;

        Console.WriteLine(CalculadorArea.TotalArea(rect1));

    }
}*/