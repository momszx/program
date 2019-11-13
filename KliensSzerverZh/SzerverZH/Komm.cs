using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace SzerverZH
{
    
    class Komm
    {
        static List<Poszt> poszts = new List<Poszt>() { new Poszt("Nevem Márk","Márk")};
        bool logged = false;
        string felhasznalo = string.Empty;
        TcpClient bejovo = null;
        StreamReader sr = null;
        StreamWriter sw = null;

        public Komm(TcpClient kliens)
        {
            bejovo = kliens;
            sr = new StreamReader(bejovo.GetStream(), Encoding.UTF8);
            sw = new StreamWriter(bejovo.GetStream(), Encoding.UTF8);
        }

        public void Komm_Indit()
        {
            Console.WriteLine("Felcsatlakozott egy kliens!");
            bool end = false;
            string keres = string.Empty;
            sw.WriteLine("Üdv a szerveren!( Ha elakadtál használd a help parancsot)");
            sw.Flush();
            string[] keresekparameterei;
            while (!end)
            {
                try
                {
                    keres = sr.ReadLine();
                    keresekparameterei = keres.Split('|');

                    switch (keresekparameterei[0])
                    {
                        case "Login":
                            if (keresekparameterei[1] == null && keresekparameterei[2] == null)
                            {
                                sw.WriteLine("ERR Hibás felhasználónév vagy jelszó");
                                sw.Flush();
                            }
                            else
                            {
                                logged = true;
                                felhasznalo = keresekparameterei[1];
                                sw.WriteLine("Sikeres bejentkezés.");
                                sw.Flush();
                            }
                            break;
                        case "Posztolás":
                            if (!logged)
                            {
                                sw.WriteLine("ERR Kérlek jelentkezbe.");
                                sw.Flush();
                            }
                            else
                            {
                                if (keresekparameterei[1] != null && keresekparameterei[2] != null)
                                {
                                    poszts.Add(new Poszt(keresekparameterei[1],felhasznalo));
                                    sw.WriteLine("Sikeres posztolás");
                                    sw.Flush();
                                }
                                else
                                {
                                    sw.WriteLine("Hibás posztolás");
                                    sw.Flush();
                                }
                            }
                            break;
                        case "Like":
                            if (!logged)
                            {
                                sw.WriteLine("ERR Kérlek jelentkezbe.");
                                sw.Flush();
                            }
                            else
                            {
                                if (keresekparameterei[1] != null)
                                {
                                    //poszts[keresekparameterei[1]
                                    sw.WriteLine("Sikeres posztolás");
                                    sw.Flush();
                                }
                                else
                                {
                                    sw.WriteLine("Hibás posztolás");
                                    sw.Flush();
                                }
                            }
                            break;
                        case "Dislike":
                            if (!logged)
                            {
                                sw.WriteLine("ERR Kérlek jelentkezbe.");
                                sw.Flush();
                            }
                            else
                            {

                            }
                            break;
                        case "Logout":
                            if (!logged)
                            {
                                sw.WriteLine("ERR Kérlek jelentkezbe.");
                                sw.Flush();
                            }
                            else
                            {
                                logged = false;
                                
                                sw.WriteLine("Sikeres Kijelentkezés"); 
                                sw.Flush();
                                end = true;

                            }
                            break;
                        case "GetPosztok":
                            if (!logged)
                            {
                                sw.WriteLine("ERR Kérlek jelentkezbe.");
                                sw.Flush();
                            }
                            else
                            {
                                for (int i = 0; i < poszts.Count; i++)
                                {
                                    sw.WriteLine("POSTOK|"+ poszts[i].PostId +"|" + poszts[i].Tulajdonos + "|" + poszts[i].Postszoveg + "|" + poszts[i].Like+"|"+poszts[i].Dislike);
                                    sw.Flush();
                                }
                            }
                            break;
                        case "Help":
                            sw.WriteLine("Login,Posztolás,Like,Dislike,Logout");
                            sw.Flush();
                            break;


                        default:
                            sw.WriteLine("Nincs ilyen szolgáltatás!");
                            break;
                    }

                    sw.Flush();
                }
                catch (Exception e)
                {
                    if (bejovo.Connected)
                    {
                        sw.WriteLine("ERR|{0}", e.Message);
                        sw.Flush();
                    }
                    else
                    {
                        end = true;
                    }
                }
            }
        }
    }
}