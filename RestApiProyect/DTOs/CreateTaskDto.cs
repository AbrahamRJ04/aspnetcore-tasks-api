namespace RestApiProyect.DTOs
{
    public class CreateTaskDto
    {
        public string Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
