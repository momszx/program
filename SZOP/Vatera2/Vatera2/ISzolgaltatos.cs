using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatera2
{
    public interface ISzolgaltatos
    {
        string Bejelentkezes(string fnev, string jelszo);

        string Licit(int id, int ar);

        string Logout();

        List<string> Szolgaltatasok();

        string TermekHozzaAd(int termekAr,string termekNev);

        List<Termékek> Osszestermek();

        string Peldanykero();
    }
}
