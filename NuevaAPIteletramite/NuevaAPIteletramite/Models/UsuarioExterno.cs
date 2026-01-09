namespace NuevaAPIteletramite.Models
{
    public class UsuarioExterno
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string? TelefonoFijo { get; set; }
        public string Correo { get; set; } = string.Empty;

        //control de acceso
        public bool DebeCambiarClave { get; set; } = true;
        public string TipoUsuario { get; set; } = "Externo";

        //Fechas
        public DateTime FechaNacimiento {  get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        //Seguridad(Bytes)
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];

        //los nombres que les asignamos aqui serán los mismos que estarán en la BD (Id, Cedula, etc)
    }
}
