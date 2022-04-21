// See https://aka.ms/new-console-template for more information
using ListaAppuntamenti;


    Appuntamento dottore = new Appuntamento("Dott. Esposito", DateTime.Parse("12/04/2022"), "Napoli");

Console.WriteLine(dottore.GetNome());
Console.WriteLine(dottore.GetAppuntamento());
dottore.cambioAppuntamento();
Console.WriteLine(dottore.GetAppuntamento());

//chiediamo quanti appuntamenti vuole prendere l'utente
Console.WriteLine("Quanti appuntamenti vuoi prendere?");
int numeroAppuntamenti = int.Parse(Console.ReadLine());


List<Appuntamento> listaDiAppuntamenti = new List<Appuntamento>();
if (numeroAppuntamenti > 0)
{
    for (int i = 0; i < numeroAppuntamenti; i++)
{

    Console.WriteLine("inserisci l'appuntamento numero " + (i+1));
    Console.WriteLine("Inserisci il nome della persona con cui hai l'appuntamento: ");
    string? nomeAppuntamento = Console.ReadLine();
    
    DateTime dataAttuale = DateTime.Now;
    DateTime dataPerAppuntamento;
    do
    {
        Console.WriteLine("Inserisci la data dell'appuntamento: ");
        dataPerAppuntamento = DateTime.Parse(Console.ReadLine());
        
           
    } while (dataPerAppuntamento < dataAttuale);


    Console.WriteLine("Inserisci il luogo dell'appuntamento: ");
    string? luogoAppuntamento = Console.ReadLine();

    Console.Clear();

    listaDiAppuntamenti.Add(new Appuntamento(nomeAppuntamento, dataPerAppuntamento, luogoAppuntamento));

}
}
listaDiAppuntamenti.Add(dottore);

foreach(Appuntamento appuntamenti in listaDiAppuntamenti)
{
    Console.WriteLine(appuntamenti.ToString());
}
bool condizione = true;
while (condizione == true)
{
    Console.WriteLine("Vuoi modificare l'appuntamento? [si/no]");
string? risposta = Console.ReadLine();


    switch(risposta){
        case "si":
            Console.WriteLine("iNSERISCI IL NOME DELL'APPUNTAMENTO CHE VUOI MODIFICARE");
            string nomeAppuntamento = "";
            //inserisco eccezione per valore non corretto su console.Readline
            try
            {

                nomeAppuntamento = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("mi dispiace hai inserito un input non corretto");
                

            }
            /**************************BONUS****************************/

            int numberIndex = listaDiAppuntamenti.FindIndex(x => x.GetNome() == nomeAppuntamento); //PRENDO L'INDEX DELL'APPUNTAMENTO CONFRONTANDO IL NOME
            if(numberIndex == -1)
            {
                Console.WriteLine("mi dispiace ma il nome dell'appuntamento non esiste");
                condizione = false;
                break;
            }
            Console.WriteLine("NOME APPUNTAMENTO TROVATO! INSERISCI LA NUOVA DATA DA INSERIRE");
            listaDiAppuntamenti[numberIndex].cambioAppuntamento();
            Console.Clear();

            Console.WriteLine("Appuntamento aggiornato.\n Ecco la nuova lista: ");

            /* STAMPO LISTA AGGIORNATA FINALE*/
            foreach (Appuntamento appuntamenti in listaDiAppuntamenti)
            {
                Console.WriteLine(appuntamenti.ToString());
            }
            /*************************FINE*BONUS****************************/
            condizione = false;
            break;
           
        case "no":
            Console.WriteLine("Buona giornata!");
            condizione = false;
            break;
            //Caso in cui l'utente sbaglia input
        default:
            Console.Clear();
            Console.WriteLine("Scelta non valida.");
            break;
    }
}


