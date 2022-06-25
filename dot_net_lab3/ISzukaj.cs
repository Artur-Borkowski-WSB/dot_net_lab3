using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace dot_net_lab3
{
    [ServiceContract]
    public interface ISzukaj
    {
        [OperationContract]
        Osoba PoNazwisku(string nazwisko);
    }
}
