namespace FichadorPersonal.Model
{
    public class Registro
    {
        public DateTime FechaIngreso { get; set; } 
        public int Duracion { get; set; }
        //public List<Hora> Horas { get; set; }
        public bool EsFeriado { get; set; } = false;
        public decimal Ingresos { get; set; }

    }
}
