using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCriarCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100,MinimumLength =3, ErrorMessage ="O nome do jogo deve conter entre 3 e 100 caracter")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100,MinimumLength =1,ErrorMessage ="Onome deve conter entre 1 e 100 caracter")]
        public string Produtora { get; set; }

        [Required]
        [Range(1,1000,ErrorMessage="O preco de veser no mínimo 1R$ real e no máximo 1000R$")]
        public double Preco { get; set; }

    }
}
