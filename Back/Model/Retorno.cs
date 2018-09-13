using System;

namespace PamonhaAPI.Model
{
    public class Retorno
    {
        public Retorno(int numeroDeVisitas)
        {
            this.NumeroDeVisitas = numeroDeVisitas;
        }

        public int NumeroDeVisitas { get; set; }
    }
}