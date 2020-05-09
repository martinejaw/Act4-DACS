
using System;

namespace Act4_DACS.SI.Incorrecto{

    interface IVehiculo  {  
        void subirPasajero();
        void conducir();
        void volar();
    } 

    public class Automovil: IVehiculo{
        public void volar(){
            throw new Exception("Los automoviles no vuelan papa");
        }
        public void conducir(){
            // hacer algo para conducir
        }

        public void subirPasajero()
        {
            //hacer algo para subir pasajero
        }
    }
    public class Avion: IVehiculo{  
        public void conducir(){
            throw new Exception("Los aviones no se conducen papa");
        }

        public void volar(){
            // hacer algo para volar
        }
        public void subirPasajero()
        {
            //hacer algo para subir pasajero
        }
    } 

}  



