using System;

namespace Act4_DACS.RU.Incorrecto
{
    public class Rectangulo
    {
        public double Alto { get; set; }
        public double Ancho { get; set; }

        public double TotalArea(Rectangulo[] rectangulos)
        {
            double area = 0;  
            foreach (Rectangulo rect in rectangulos){
                area += rect.Alto * rect.Ancho;      
            }
            return area; 
        }
    }
}