using Newtonsoft.Json;

namespace FomeBateuApp.Dto
{
    public class UsuariosEndereco
    {        
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public int UsuarioId { get; set; }
        public bool Principal { get; set; }
        public string Bairro { get; set; }

        [JsonIgnore]
        public Usuarios Usuario { get; set; }
    }
}
