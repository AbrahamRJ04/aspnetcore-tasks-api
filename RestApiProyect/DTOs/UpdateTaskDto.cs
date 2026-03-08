namespace RestApiProyect.DTOs
{
    public class UpdateTaskDto
    {
        public string Titulo { get; set; }
        public string? Descripcion { get; set; }
        public bool Estatus { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
