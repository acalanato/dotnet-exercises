using System;

namespace Fazenda
{
    internal class Fruta
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int Peso { get; set; }
        public float CaloriasGrama { get; set; }

        public Fruta(string nomeFruta, string corFruta, int pesoFruta, float calGrama)
        {
            Nome = nomeFruta;
            Cor = corFruta;
            Peso = pesoFruta;
            CaloriasGrama = calGrama;
        }
    }
}
