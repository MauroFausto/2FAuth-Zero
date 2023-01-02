namespace _2FA_Zero.Classes
{
    public class Credencial
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Privilegio> Privilegios { get; set; }
    }
}
