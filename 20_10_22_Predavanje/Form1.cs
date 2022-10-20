using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_10_22_Predavanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateTax_Click(object sender, EventArgs e)
        {
            double cijena = 79.95;
            double poreznaStopa = 0.06;


            IzracunPoreza(cijena, poreznaStopa);
            IzracunPoreza(cijena);


        }

        public void IzracunPoreza(double cijena, double poreznaStopa = 0.06)
        {

            double porez = cijena * poreznaStopa;
            lblCalculationRez.Text += String.Format("\n {0} poreza na {1} iznosi {2:C}.", poreznaStopa, cijena, porez);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int[] brojeviNiz = { 9, 5, 3, 77, 34, 65, 12, 3, 92, 4 }; //znači ako ćeš odmah napuniti niz, ne treba ono new int[]

            Suma(5); //mogu se spremiti i u varijablu pa pozvati varijablu, ali varijabla mora biti vrste koja se poziva kao parametar
            Suma(5, 12, 2);
            Suma(5, 12, 2, 92, 154);
            Suma(brojeviNiz);


        }
        public void Suma(params int[] parametri)
        {
            int suma = 0;
            foreach (int par in parametri)
            {
                suma += par;
            }
            lblCalculationRez2.Text += String.Format("\n Suma iznosi {0}", suma);
        }

        private void btnGiftCard_Click(object sender, EventArgs e)
        {
            double iznos = 1250.75;
            GiftCard(iznos);
            GiftCard();

        }
        public void GiftCard(double iznos = 500)
        {
            lblGiftCardReturn.Text += String.Format("\nIznos na vašoj poklon kartici je {0:C}", iznos);
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            Movie("Batman", 195);
            Movie("James Bond");
        }
        public void Movie(string ime, int trajanje = 90)
        {
            lblMovieResult.Text += String.Format("\nNaziv filma: {0} --- trajanje {1} minuta", ime, trajanje);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Multiply(5, 2);
            Multiply(5);
            Multiply(7.13, 4);
            Multiply(7.13);
            Multiply("Ana", 1);
            Multiply("Ana");
        }

        public void Multiply(int a, int b = 3)
        {
            lblMultiplyReturn.Text += String.Format("\nDobiveni parametri: {0} i {1}, izlaz: {2}", a, b, a * b);
        }
        public void Multiply(double a, int b = 3)
        {
            lblMultiplyReturn.Text += String.Format("\nDobiveni parametri: {0} i {1}, izlaz: {2}", a, b, a * b);
        }
        public void Multiply(string a, int b = 3)
        {
            string c = "";
            for (int i = 0; i < b; i++)
            {
                c += a;
            }
            lblMultiplyReturn.Text += String.Format("\nDobiveni parametri: {0} i {1}, izlaz: {2}", a, b, c);
        }

        private void btnNumberSwitch_Click(object sender, EventArgs e)
        {
           
            if (txtUserInput.Text == "")
            { MessageBox.Show("Unesite dvoznamenkasti broj"); 
            
            }


            int userInputNumber;
            

            
            Zamjena(out userInputNumber);
            
        }

        private void btnStringSwitch_Click(object sender, EventArgs e)
        {
            string userInputText;

            if (txtUserInput.Text == "")
            
                MessageBox.Show("Unesite neki tekst");

                Zamjena(out userInputText);
        }

        public void Zamjena(out int number)
        {
            number = Convert.ToInt32(txtUserInput.Text);
            
            string numberSwitch = "";
            char[] wordChars = number.ToString().ToCharArray();

            for (int i = number.ToString().Length - 1; i >= 0; i--)
            {
                numberSwitch += number.ToString()[i];                                      
            }
          
            lblSwitchReturn.Text += String.Format("\nBroj: {0} -- Zamjena: {1}", number, numberSwitch);
        }

        public void Zamjena(out string word)
        {
            word = txtUserInput.Text;
            string wordSwitch = "";
            char[] wordChars = word.ToCharArray();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                wordSwitch += wordChars[i];
            }

            //string wordSwitch = word.Substring(word.Length -1, 0);
            
            lblSwitchReturn.Text += String.Format("\nTekst: {0} -- Zamjena: {1}", word, wordSwitch);

        }

        
    }
}
