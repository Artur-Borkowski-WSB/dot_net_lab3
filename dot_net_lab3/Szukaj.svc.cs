using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace dot_net_lab3
{
    [DataContract]
    public class Szukaj : ISzukaj
    {
        public Osoba PoNazwisku(string nazwisko)
        {
            List<Osoba> osoby = new List<Osoba>
            {
                new Osoba("Adam", "Nowak", "Gdańsk"),
                new Osoba("Jan", "Kowalski", "Warszawa"),
                new Osoba("Anna", "Kowalska", "Warszawa"),
                new Osoba("Eustachy", "Lis", "Gdynia"),
                new Osoba("Piotr", "Piotrowski", "Kraków")
            };
            Osoba znaleziona = osoby.Find(item => item.nazwisko == nazwisko);
            return znaleziona;
        }
    }
}
