using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace dot_net_lab3
{
    [DataContract]
    public class Osoba
    {
        [DataMember]
        public string imie, nazwisko, adres;
        public Osoba(string imie, string nazwisko, string adres)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
        }
    }
}