// See https://aka.ms/new-console-template for more information
using ListaAppuntamenti;
try
{
    Appuntamento dottore = new Appuntamento("Dott. Esposito", DateTime.Parse("22/04/2022"), "Napoli");
}catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("Mi dispiace ma " + e.ParamName + " ha detto " + e.Message);
}