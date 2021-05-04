    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace proyecto 
    {
        public class Animales
        {
            public string TipoDeAnimal {get; set;}
            public string Sexo {get; set;}
            public string Nombre {get; set;}
            public string Edad {get; set;}

            public void TAnimal() 
            {
                Console.WriteLine ("Cual es el tipo del animal");
            }
            public void TipoDeSexo() 
            {
                Console.WriteLine("¿Cual es el sexo?");
            }
            public void TipoNombre()
            {
                Console.WriteLine("¿Cual es el nombre?");
            }
        }
    }