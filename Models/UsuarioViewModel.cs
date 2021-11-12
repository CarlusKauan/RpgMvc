namespace RpgMvc.Models
{
    public class UsuarioViewModel
    {
        //Propriedades da classe.
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordString { get; set; }
        public byte[] Foto { get; set; }
    }
}