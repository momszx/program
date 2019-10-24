using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06_BookshopDLL;

namespace _07_Bookshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            User Ede = new User(1, "Troll Ede", "p4ssw0rd", "ede.troll@uni-eszterhazy.com");
            Address a = new Address("3633", "Balassagyarmat", "fdgfdgfd");
            Ede.SendHTMLEmail("Üzenet trágya", "<html><head></head><body><h1>Hello "+Ede.Name+ "!</h1>Ezt üzenem neked!</body></html>");
        }
    }
}
