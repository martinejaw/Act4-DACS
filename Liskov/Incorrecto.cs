
using System;

namespace Act4_DACS.Liskov.Incorrecto{

    //"you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification"

public abstract class Auto  {  
    public double combustible {get;set;} 
    public abstract void cargarCombustible(int litros);  
} 

public class AutoElectrico: Auto{  

    // Aqui estamos aplicando mal el principio de substitucion, ya que 
    public override void cargarCombustible(int litros){
        throw new Exception("Este auto no carga nafta papa");
    }
   
}  
public class AutoCombustion: Auto{  
    public override void cargarCombustible(int litros){
        combustible += litros;
    }
}

}
