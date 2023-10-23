﻿namespace rede_social.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string nomeCompleto { get; set; }

        public string fotoPerfil { get; set; }
        public DateTime dataNascimento { get; set; }
        public string genero { get; set; }
        public string biografia { get; set; }
        public string senha { get; set; }
        public string email { get; set; }

    }
}

