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
Appuntamento.ReferenceEquals(listaDiAppuntamenti, new List<Appuntamento>());


