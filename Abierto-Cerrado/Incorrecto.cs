
using System;

namespace Act4_DACS.AC.Incorrecto{
public class Rectangulo{  
   public double Alto {get;set;}  
   public double Ancho {get;set; }  
}  
public class Circulo{  
   public double Radio {get;set;}  
}  
public class CalculadorArea  {  

    // Este metodo esta mal porque cada vez que agregue una figura tendre que modificar el codigo agregando un if para calcular un area distinta
    // Esto significa que no es cerrada a la modificacion

    public double AreaTotal(object[] objs)  {  
        double area = 0;  
        foreach (object obj in objs){
            if(obj is Rectangulo)  {
                Rectangulo rectangulo = (Rectangulo)obj;
                area += rectangulo.Alto * rectangulo.Ancho;  
            }  
            else  {  
                Circulo circulo = (Circulo)obj;  
                area += circulo.Radio * circulo.Radio * Math.PI;  
            }  
        }

      return area;  
    }  
}  
}