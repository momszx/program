using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varázsige
{
    class Program
    {
        
        public class Varazsige //Az osztályunkat mindig a class Program és sttic void Main között hozzuk létre.
        {
            public string megnevezes;
            public hatasTipus tipus;
            public string leiras;
            public int ero;
        }

        public enum hatasTipus //az enumot is
        {
            ROBBANTO,
            KABITO
        }

        static List<Varazsige> VarazslatokBetoltese() //Olyan függvény, mely visszatérési értéke egy Varazsige lista, paraméter pedig nem kellett
        {
            List<Varazsige> visszaadottLista = new List<Varazsige>(); //A lista létrehozása

            Varazsige atmeneti = new Varazsige(); //new kell, mert osztályom van
            atmeneti.megnevezes = "Descendo";
            atmeneti.tipus = hatasTipus.ROBBANTO;
            atmeneti.leiras = "felrobbantja a megcélzott tárgyat";
            atmeneti.ero = 7;
            visszaadottLista.Add(atmeneti); // A létrehozott elemet beletöltjük a listába

            atmeneti = new Varazsige(); //Egy új Varazsige-t hozunk létre, hogy a memóriacímek ne ütközzenek. Osztály esetében fontos!
            atmeneti.megnevezes = "Deprimo";
            atmeneti.tipus = hatasTipus.ROBBANTO;
            atmeneti.leiras = "Lyukat robbant egy szilárd felületbe";
            atmeneti.ero = 8;
            visszaadottLista.Add(atmeneti);// A létrehozott elemet beletöltjük a listába

            atmeneti = new Varazsige(); //Egy új Varazsige-t hozunk létre, hogy a memóriacímek ne ütközzenek. Osztály esetében fontos!
            atmeneti.megnevezes = "Expulso";
            atmeneti.tipus = hatasTipus.ROBBANTO;
            atmeneti.leiras = "Ismeretlen";
            atmeneti.ero = 5;
            visszaadottLista.Add(atmeneti);// A létrehozott elemet beletöltjük a listába

            atmeneti = new Varazsige(); //Egy új Varazsige-t hozunk létre, hogy a memóriacímek ne ütközzenek. Osztály esetében fontos!
            atmeneti.megnevezes = "Stupor";
            atmeneti.tipus = hatasTipus.KABITO;
            atmeneti.leiras = "A célszemély néhány percre elájul";
            atmeneti.ero = 6;
            visszaadottLista.Add(atmeneti);// A létrehozott elemet beletöltjük a listába

            atmeneti = new Varazsige(); //Egy új Varazsige-t hozunk létre, hogy a memóriacímek ne ütközzenek. Osztály esetében fontos!
            atmeneti.megnevezes = "Petrificus totalus";
            atmeneti.tipus = hatasTipus.KABITO;
            atmeneti.leiras = "A célszemély néhány percre megdermed";
            atmeneti.ero = 3;
            visszaadottLista.Add(atmeneti);// A létrehozott elemet beletöltjük a listába

            return visszaadottLista; // A létrehozott listát vissza adjuk a hívó környezetnek.
            //Ha például a főprogram hívja, ő fogja megkapni ezt az új listát.
        }

        static int KabitoDarab(List<Varazsige> lista) //Olyan függvény, mely egy egész számmal tér vissza és paraméterben kap egy varázsige listát
        {
            int darab = 0; //Tároló, amibe azt fogom tárolni hogy mennyi kábító varázsigét találtunk
            for (int i = 0; i < lista.Count; i++) //bejárjuk egy ciklussal a paraméterben kapott listát (mert benne kell megkeresni, mennyi kábító van)
            {
                if (lista[i].tipus == hatasTipus.KABITO) //Ha az i-edik elem típus mezője (ami egy enum, vagy hatasTipus.KABITO vagy hatastipus.ROBBANTO lehet az értéke) kábító, akkor növelem a darabot 1-el
                {
                    darab++;
                }
            }

            return darab; //Visszaadjuk a hívó félnek a megszámolt darabot.
        }

        static Varazsige LegerosebbVarazslat(List<Varazsige> lista) //Olyan függvény, mely visszatérési értéke egy Varazsige. paraméterben egy olyan listát vár, amelyben varázsigéket tárolunk
        {
            Varazsige legerosebb = lista[0]; //Ő a tárolónk. Benne tároljuk a legerősebb varázsigét majd. Egyenlőre kijelöljük a legelsőt legerősebbnek
            for (int i = 0; i < lista.Count; i++) //Bejárjuk egy ciklussal a paraméterben kapott listát (mert benne kell megtalálni a legerősebb varázsigét)
            {
                if (lista[i].ero > legerosebb.ero) //Ha találunk erősebbet az eddigi kikiáltott legerősebbnél, akkor ő lesz mostantól a legerősebb, és őt hasonlítjuk a többi elemmel
                {
                    legerosebb = lista[i];
                }
            }

            return legerosebb; //Vissza adjuk a hívó környezetnek a megtalált legerősebb varázsigét
        }

        static int ErosVarazslatDarab(List<Varazsige> lista, int also, int felso) //Olyan függvény, mely visszatérési értéke egy egész szám, paraméterben pedig kap egy Varázsige listát, egy alsó és felső határszámot
        {
            int darab = 0; //Létrehozzuk a tárolót. Benne fogjuk letárolni azt, hogy mennyi darab olyan varázslat van, amelynél az erő az alsó és felső határ között van
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ero >= also && lista[i].ero <= felso) //Megengedem az egyenlőséget is most.
                {
                    darab++; //Ha az elemnek az erő értéke a két határ között van, akkor a darabot növelem 1-el
                }
            }

            return darab; //Vissza adjuk a hívó félnek a megszámolt darabot.
        }

        static void StatisztikaMegjelenitese(List<Varazsige> lista) //Olyan eljárás (void), mely paraméterben kap egy varazsige listát
        {
            //Megjelenítjük az adatokat a megírt függvények segítségével
            Console.WriteLine("Összesen {0} darab varázsige van a listában.", lista.Count);

            int kabitoDarabszam = KabitoDarab(lista); //A függvény visszatérési értékét lementjük egy változóba
            Console.WriteLine("Ebből összesen {0} darab káító varázsige", kabitoDarabszam);

            Varazsige legerosebb = LegerosebbVarazslat(lista); //Lementjük a függvény visszatérési értékét (ami egy varázsige)
            Console.WriteLine("A legerősebb varázsige: " + legerosebb.megnevezes); //Neki a mező értékét írjuk ki

            Console.WriteLine("Összesen {0} darab erősnek nevezhető varázsige van.", +ErosVarazslatDarab(lista, 8, 10)); //Nem muszáj a visszatérési értéket külön lementeni, felhasználhatjuk a kiírásban is.
        }

        static void Main(string[] args)
        {
            List<Varazsige> varazslatok = new List<Varazsige>(); //olyan listát hoztam létre, melybe varázslatokat tárolhatunk

            varazslatok = VarazslatokBetoltese(); //Belementettem a függvény visszatérési értékét, ami egy feeltöltött lista .
                                                  //List<Varazsige> varazslatok = VarazslatokBetoltese(); //Csinálhattam volna 1 lépésen is

            StatisztikaMegjelenitese(varazslatok); //Erről a listáról, amit már feltöltöttem megjelenítem a statisztikát.

            Console.ReadLine();
        }
    }
    }

