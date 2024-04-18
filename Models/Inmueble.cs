namespace InmueblesApi.Models
{
    public class Inmueble
    {
        public int Id { get; set; }
        public string? Tipo { get; set; } // Permite valores nulos
        public int CantidadHabitaciones { get; set; }
        public string? Direccion { get; set; } // Permite valores nulos
        public decimal Precio { get; set; }
    }
}
