using System;

namespace Act4_DACS.ID.Incorrecto{
    public class Persona {
        private String Nombre{get; set;}
    }

        public interface IPersistence {
            public void save(object obj);
    }

    public class MySql{
        public void savePersona(object obj){
            Console.WriteLine("Guardado excelentemente bien...");
        }
    }

    public class ServicioPersona {
        private IPersistence persistencia{get; set;}
        public void savePersona(Persona persona) {
            MySql mysql = new MySql();
		    mysql.savePersona(persona);
	    }
    }
}