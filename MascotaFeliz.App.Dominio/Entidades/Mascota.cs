using System;

namespace MascotaFeliz.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>  
    public class Mascota

    // Esta vaina esta mal, pero ya la vamos a arreglar :v
    {
        public int Id { get; set; }
        public float Temperatura {get;set;}
        public float Peso {get;set;}
        public int FrecuenciaRespiratoria {get;set;}
        public int FrecuenciaCardiaca {get;set;}
        public string EstadoDeAnimo {get;set;}
        public string Recomendaciones {get;set;}
        public Tipo TipoAnimal {get;set;}
        public Propietario Propietario {get;set;}
    }
}