using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public Carro(string modelo, string marca, int ano, string cor)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Cor = cor;
        }


    }
}
