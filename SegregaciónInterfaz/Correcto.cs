
using System;

namespace Act4_DACS.SI.Correcto{
    interface IVehiculo  {  
        void subirPasajero();
    }

    interface IVuela  {  
        void volar();
    } 
    interface IConduce {
        void conducir();
    }
    public class Automovil: IVehiculo,IConduce{
        public void conducir(){
            // hacer algo para conducir
        }
        public void subirPasajero()
        {
            //hacer algo para subir pasajero
        }
    }
    public class Avion: IVehiculo,IVuela{  
        public void volar(){
            // hacer algo para volar
        }
        public void subirPasajero()
        {
            //hacer algo para subir pasajero
        }
    } 

}  



