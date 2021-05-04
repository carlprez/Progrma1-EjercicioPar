    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace proyecto
    {
      public class Perro : Animales
      {
          public string Raza {get; set;}
          public string Perrarina {get; set;}

          public void QueRazaEs()
          {
              Console.WriteLine("¿Que raza es su perro?");   
          }
          public void TipoDePerrarina() 
          {
              Console.WriteLine("¿Que tipo de perrarina utiliza?");
          }
      }  
    }