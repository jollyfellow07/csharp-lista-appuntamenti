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
                cambioAppuntamento();
            }

        }

        /********METODI*******/
        public void ComparazioneDelleDate()
        {
            if (dataEOraAppuntamento < dataEOraAttuale)
            {
                throw new ArgumentOutOfRangeException("dataEOraAppuntamento", "non puo essere una data del passato ");
            }
        }
     public DateTime cambioAppuntamento()
        {
            do
            {
                Console.Write("Inserisci la nuova data per l'appuntamento: ");
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

            } while (dataEOraAppuntamento < dataEOraAttuale);
            return dataEOraAppuntamento;
        }
        public override string ToString()
        {
            string rappresentazioneInStringa = "";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            rappresentazioneInStringa += "\n**************Appuntamento***************\n";
            rappresentazioneInStringa += "Il nome dell'appuntamento è: " + GetNome() + "\n";
            rappresentazioneInStringa += "l'appuntamento è fissato per il giorno: " + GetAppuntamento() + "\n";
            rappresentazioneInStringa += "Il luogo dell'appuntamento è: " + GetLuogo() + "\n";
            rappresentazioneInStringa += "**************************************" + "\n";
            return rappresentazioneInStringa;
        }


        /*GETTER AND SETTER*/
        public DateTime GetAppuntamento()
        {
            
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
        public string GetLuogo()
        {
            return localitaAppuntamento;
        }
    }
}
