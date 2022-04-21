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
            //Eccezione lanciata se l'appuntamento è fissato per una data del passato
            try
            {
                ComparazioneDelleDate();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Mi dispiace ma " + e.ParamName + " ha detto " + e.Message);
            }

        }
        public void ComparazioneDelleDate()
        {
            if (dataEOraAppuntamento < dataEOraAttuale)
            {
                throw new ArgumentOutOfRangeException("dataEOraAppuntamento", "non puo essere una data del passato ");
            }
        }
     public DateTime cambioAppuntamnto()
        {
            DateTime cambioDellAppuntamento = DateTime.Parse(Console.ReadLine());
            this.dataEOraAppuntamento = cambioDellAppuntamento;
            try
            {
                ComparazioneDelleDate();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Mi dispiace ma " + e.ParamName + " ha detto " + e.Message);
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
