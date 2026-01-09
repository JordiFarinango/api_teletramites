namespace NuevaAPIteletramite.Models
{
    public class UsuarioInterno
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = string.Empty;

        public string Apellidos { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        //correos

        public string EmailPersonal { get; set; } = string.Empty;
        public string EmailInstitucional { get; set; } = string.Empty;

        public string DireccionDomicilio { get; set; } = string.Empty;

        public string TipoUsuario { get; set; } = "Interno";

        //datos laborales
        public string Area { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string TituloProfesional { get; set; } = string.Empty;
        public string CodigoTituloScyt { get; set; } = string.Empty;

        //control
        public bool DebeCambiarClave { get; set; } = true;

        //fechas
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro {  get; set; } = DateTime.UtcNow;

        //Seguridad
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];



    }
}
