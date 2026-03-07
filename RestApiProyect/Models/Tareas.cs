namespace RestApiProyect.Models
{
    public class Tareas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? Descripcion { get; set; }
        public bool Estatus { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
