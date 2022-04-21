// See https://aka.ms/new-console-template for more information
using ListaAppuntamenti;
Appuntamento dottore = new Appuntamento("Dott. Esposito", DateTime.Parse("12/04/2022"), "Napoli");

Console.WriteLine(dottore.GetNome());
Console.WriteLine(dottore.GetAppuntamento());
dottore.cambioAppuntamnto();
Console.WriteLine(dottore.GetAppuntamento());
