using System;

namespace Fazenda
{
    public class Fruta
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
        public float Calorias()
        {
            return CaloriasGrama * Peso;
        }
        public override String ToString()
        {
            return Nome +
                " possui a cor " + Cor +
                " e um total de " + Calorias() + "calorias";
            value
        }
    }
}
