namespace _2FA_Zero.Classes
{
    public abstract class UsuarioBase
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        /// <summary TipoUsuario>
        /// Classifica o usuário em quatro tipos:
        ///     >> Usuário tipo Pessoa Física
        ///     >> Usuário tipo Pessoa Jurídica
        ///     >> Usuário tipo Auditoria
        ///     >> Usuário tipo Outros
        /// </summary>
        public string? TipoUsuario { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataInativacao{ get; set; }
        public DateTime DataAlteracao { get; set; }
        public List<Sistema>? Sistema { get; set; }
        public List<Modulo>? Modulo { get; set; }
        public List<Credencial>? Credenciais { get; set; }
        public bool EstadoAutenticacao { get; set; }
        public bool EstadoAutorizacao { get; set; }

    }
}
