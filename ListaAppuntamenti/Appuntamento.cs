using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamento
    {
        private string? nome;
        public DateTime dataEOraAttuale = DateTime.Now;
        public DateTime dataEOraAppuntamento;
        public string? localitaAppuntamento;

        public Appuntamento(string nome, DateTime dataEOraAppuntamento, string localitaAppuntamento)
        {
            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
            this.dataEOraAppuntamento = dataEOraAppuntamento;

            if (dataEOraAppuntamento < dataEOraAttuale)
            {
                throw new ArgumentOutOfRangeException("dataEOraAppuntamento", "non puo essere una data del passato ");
            }
        }
     public DateTime cambioAppuntamnto()
        {
            DateTime cambioDellAppuntamento = DateTime.Parse(Console.ReadLine());
            this.dataEOraAppuntamento = cambioDellAppuntamento;
            if (dataEOraAppuntamento < dataEOraAttuale)
            {
                throw new ArgumentOutOfRangeException("dataEOraAppuntamento", "Non puo essere una data del passato ");
            }
            return dataEOraAppuntamento;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetLocalitaAppuntamento()
        {
            return localitaAppuntamento;
        }
    }
}
