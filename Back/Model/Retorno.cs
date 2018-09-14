using System;

namespace PamonhaAPI.Model
{
    public class Retorno
    {
        public Retorno(int numeroDeVisitas, string ambiente)
        {
            this.NumeroDeVisitas = numeroDeVisitas;
            this.Ambiente = ambiente;
        }

        public int NumeroDeVisitas { get; set; }
        public string Ambiente { get; set; }
    }
}