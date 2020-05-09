using System;

namespace Act4_DACS.ID.Correcto{
    public class Persona {
        private String Nombre{get; set;}
    }

    public interface IPersistence {
        public void save(object obj);
    }

    public class MySql : IPersistence
    {
        public void save(object obj){
            Console.WriteLine("Todo bien...");
        }
    }

    public class ServicioPersona {
        private IPersistence persistencia{get; set;}
        public void savePersona(Persona persona) {
            persistencia.save(persona);
	    }
    }
}