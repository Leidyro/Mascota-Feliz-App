using System;

namespace MascotaFeliz.App.Dominio
{
    public class Visita
    {
        public Visita(int id, DateTime fecha)
        {
            Id = id;
            DateTime Fecha = new DateTime(2021,10,21);
        }

        public int Id { get; set; }
        public DateTime Fecha {get; set;}

    }
}