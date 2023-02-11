using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorMasyStali
{
    public partial class Form1 : Form
    {
        decimal masaMetalu = 0M;
        decimal cenaMetalu = 0M;

        public Form1()
        {
            InitializeComponent();
            wwwButton.MouseEnter += new EventHandler(wwwButton_MouseEnter);
            wwwButton.MouseLeave += new EventHandler(wwwButton_MouseLeave);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.Write("event sie zdarrzyl" + comboBox1.SelectedItem);
            if (comboBox1.SelectedItem.ToString() == "Stal")
            {
                masaMetalu = 7.85M;
                cenaMetalu = Properties.Settings.Default.cenaStali;
                cenaTextBox.Text = cenaMetalu.ToString();
                Debug.Write(masaMetalu);
            }
            if (comboBox1.SelectedItem.ToString() == "Inox")
            {
                masaMetalu = 8M;
                cenaMetalu = Properties.Settings.Default.cenaInox;
                cenaTextBox.Text = cenaMetalu.ToString();
                Debug.Write(masaMetalu);
            }
            if (comboBox1.SelectedItem.ToString() == "Aluminium")
            {
                masaMetalu = 2.7M;
                cenaMetalu = Properties.Settings.Default.cenaAluminium;
                cenaTextBox.Text = cenaMetalu.ToString();
                Debug.Write(masaMetalu);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            decimal cenaDoZapisania;
            string WartoscOknaCeny = cenaTextBox.Text.Replace(".", ",");
            if (comboBox1.SelectedItem.ToString() == "Stal")
            {
                if (Decimal.TryParse(WartoscOknaCeny, out cenaDoZapisania) && cenaDoZapisania > 0)
                {

                    Properties.Settings.Default.cenaStali = cenaDoZapisania;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Błędna wartość ceny", "Błąd");
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Inox")
            {
                if (Decimal.TryParse(WartoscOknaCeny, out cenaDoZapisania) && cenaDoZapisania > 0)
                {

                    Properties.Settings.Default.cenaInox = cenaDoZapisania;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Błędna wartość ceny", "Błąd");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Aluminium")
            {
                if (Decimal.TryParse(WartoscOknaCeny, out cenaDoZapisania) && cenaDoZapisania > 0)
                {

                    Properties.Settings.Default.cenaAluminium = cenaDoZapisania;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Błędna wartość ceny", "Błąd");
                }
            }
        }
        /// <summary>
        /// Przelicz Blachę Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void przeliczButton_Click_1(object sender, EventArgs e)
        {

            int x = 0;
            int y = 0;
            decimal z = 0M;
            decimal xm2 = 0;
            decimal ym2 = 0;
            bool wszystkoGraX = false;
            bool wszystkoGraY = false;
            bool wszystkoGraZ = false;
            string gruboscBlachyDoZmiany = gruboscBlachy.Text.Replace(".", ",");

            if (Int32.TryParse(wartosc1.Text, out x) && x > 0)
            {
                xm2 = (decimal)x / 1000;
                wszystkoGraX = true;



            }
            else
            {
                MessageBox.Show("Błędna wartość Szerokości", "Błąd");
            }
            if (Int32.TryParse(wartosc2.Text, out y) && y > 0)
            {
                ym2 = (decimal)y / 1000;
                wszystkoGraY = true;
            }
            else
            {
                MessageBox.Show("Błędna wartość Długości", "Błąd");
            }
            if (Decimal.TryParse(gruboscBlachyDoZmiany, out z) && z > 0)
            {

                wszystkoGraZ = true;
            }
            else
            {
                MessageBox.Show("Błędna wartość Grubości", "Błąd");
            }



            if (wszystkoGraX && wszystkoGraY && wszystkoGraZ && masaMetalu > 0M)
            {
                decimal MasaArkusza = (decimal)xm2 * ym2 * z * masaMetalu;
                wynikLabel.Text = MasaArkusza.ToString("0.00") + "kg";
                wynikLabel.ForeColor = Color.Orange;
                decimal CenaArkusza = MasaArkusza * cenaMetalu;
                wynikCenyArkusza.Text = CenaArkusza.ToString("0.00") + "zł";
                wynikCenyArkusza.ForeColor = Color.Orange;

            }
            if (masaMetalu <= 0M) { MessageBox.Show("Podaj Materiał", "Błąd"); }

        }
        /// <summary>
        /// Przelicz Profil Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrzeliczProfil_Click(object sender, EventArgs e)
        {


            int x = 0;
            decimal y = 0;
            int a = 0;
            decimal z = 0M;
            decimal xm2 = 0;
            decimal ym2 = 0;
            decimal am2 = 0;
            
            string gruboscBlachyDoZmiany = GruboscSciankiProfilaText.Text.Replace(".", ",");
            string dlugoscProfilaPoZmianie = DlugoscProfilaText.Text.Replace(".", ",");
            if (Int32.TryParse(SzerokoscProfilaText.Text, out x) && x > 0)
            {
                xm2 = (decimal)x / 1000;
                



            }
            else
            {
                MessageBox.Show("Błędna wartość Szerokości", "Błąd");
                return;
            }
            if (Int32.TryParse(WysokoscProfilaText.Text, out a) && a > 0)
            {
                am2 = (decimal)a / 1000;

            }
            else
            {
                MessageBox.Show("Błędna wartość Wysokości", "Błąd");
                return;
            }

            if (Decimal.TryParse(dlugoscProfilaPoZmianie, out y) && y > 0)
            {
                // ym2 = (decimal)y / 1000;
                ym2 = y;
                
            }
            else
            {
                MessageBox.Show("Błędna wartość Długości", "Błąd");
                return;
            }
            if (Decimal.TryParse(gruboscBlachyDoZmiany, out z) && z > 0)
            {

                
            }
            else
            {
                MessageBox.Show("Błędna wartość Grubości", "Błąd");
                return;
            }

            if (masaMetalu <= 0M) {
                MessageBox.Show("Podaj Materiał", "Błąd");
                return;
            }


            decimal odjeteGrubosci = (z * 2 * 3.14M) / 1000;
            decimal obwodProfila = (xm2 + am2) * 2;
            obwodProfila -= odjeteGrubosci;
            decimal MasaArkusza = (decimal)obwodProfila * ym2 * z * masaMetalu;
            MasaProfilaLabel.Text = MasaArkusza.ToString("0.00") + "kg";
            MasaProfilaLabel.ForeColor = Color.Orange;
                decimal CenaArkusza = MasaArkusza * cenaMetalu;
                CenaProfilaText.Text = CenaArkusza.ToString("0.00") + "zł";
                CenaProfilaText.ForeColor = Color.Orange;

            
            

        }

        /// <summary>
        /// Przelicz Rurę event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrzeliczRure_Click(object sender, EventArgs e)
        {
            int x = 0;
            decimal y = 0;
            int a = 0;
            decimal z = 0M;
            decimal xm2 = 0;
            decimal ym2 = 0;
            

            string gruboscRuryDoZmiany = GruboscSciankiRuraText.Text.Replace(".", ",");
            string dlugoscRuryPoZmianie = DlugoscRuryText.Text.Replace(".", ",");
            string srednicaRuryPoZmianie = SrednicaText.Text.Replace(".", ",");
            if (Int32.TryParse(srednicaRuryPoZmianie, out x) && x > 0)
            {
                xm2 = (decimal)x / 1000;




            }
            else
            {
                MessageBox.Show("Błędna wartość Średnicy", "Błąd");
                return;
            }
          

            if (Decimal.TryParse(dlugoscRuryPoZmianie, out y) && y > 0)
            {
                // ym2 = (decimal)y / 1000;
                ym2 = y;

            }
            else
            {
                MessageBox.Show("Błędna wartość Długości", "Błąd");
                return;
            }
            if (Decimal.TryParse(gruboscRuryDoZmiany, out z) && z > 0)
            {


            }
            else
            {
                MessageBox.Show("Błędna wartość Grubości", "Błąd");
                return;
            }

            if (masaMetalu <= 0M)
            {
                MessageBox.Show("Podaj Materiał", "Błąd");
                return;
            }


            xm2 -= (z / 1000);
            decimal obwodKola = (xm2 / 2) * 3.14M * 2M;


            decimal MasaArkusza = (decimal)obwodKola * ym2 * z * masaMetalu;
            MasaRury.Text = MasaArkusza.ToString("0.00") + "kg";
            MasaRury.ForeColor = Color.Orange;
            decimal CenaArkusza = MasaArkusza * cenaMetalu;
            CenaRury.Text = CenaArkusza.ToString("0.00") + "zł";
            CenaRury.ForeColor = Color.Orange;




        }
        /// <summary>
        /// Przelicz Preta Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrzeliczPreta_Click(object sender, EventArgs e)
        {
            decimal x = 0;
            decimal y = 0;
            
            
            decimal xm2 = 0;
            decimal ym2 = 0;


            
            string dlugoscPretaPoZmianie = DlugoscPretaText.Text.Replace(".", ",");
            string srednicaPretaPoZmianie = SrednicaPretaText.Text.Replace(".", ",");
            if (Decimal.TryParse(srednicaPretaPoZmianie, out x) && x > 0)
            {
                xm2 = x / 10;




            }
            else
            {
                MessageBox.Show("Błędna wartość Średnicy", "Błąd");
                return;
            }


            if (Decimal.TryParse(dlugoscPretaPoZmianie, out y) && y > 0)
            {
                 ym2 = (decimal)y * 100;
                //ym2 = y;

            }
            else
            {
                MessageBox.Show("Błędna wartość Długości", "Błąd");
                return;
            }
        

            if (masaMetalu <= 0M)
            {
                MessageBox.Show("Podaj Materiał", "Błąd");
                return;
            }

            decimal promienDoKwadratu =(decimal) Math.Pow((double)xm2 / 2, 2);
            
            decimal poleKola = (decimal) Math.PI * promienDoKwadratu;
            Debug.Write("promien do kwadratu ="+promienDoKwadratu);
            Debug.Write("Pole koła =" +poleKola);

            decimal MasaArkusza = poleKola * ym2 * masaMetalu;
            MasaArkusza /= 1000;
            MasaPreta.Text = MasaArkusza.ToString("0.00") + "kg";
            MasaPreta.ForeColor = Color.Orange;
            decimal CenaArkusza = MasaArkusza * cenaMetalu;
            CenaPreta.Text = CenaArkusza.ToString("0.00") + "zł";
            CenaPreta.ForeColor = Color.Orange;
        }
        /// <summary>
        /// Przelicz Katownik Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrzeliczKontownik_Click(object sender, EventArgs e)
        {
            int x = 0;
            decimal y = 0;
            int a = 0;
            decimal z = 0M;
            decimal xm2 = 0;
            decimal ym2 = 0;
            decimal am2 = 0;

            string gruboscSciankiKontownikaDoZmiany = GroboscSciankiKontonikaText.Text.Replace(".", ",");
            string dlugoscKontownikaPoZmianie = DlugoscKontownikaText.Text.Replace(".", ",");
            if (Int32.TryParse(SzerokoscKontownikaText.Text, out x) && x > 0)
            {
                xm2 = (decimal)x / 1000;




            }
            else
            {
                MessageBox.Show("Błędna wartość Szerokości", "Błąd");
                return;
            }
            if (Int32.TryParse(WysokoscKontownikaText.Text, out a) && a > 0)
            {
                am2 = (decimal)a / 1000;

            }
            else
            {
                MessageBox.Show("Błędna wartość Wysokości", "Błąd");
                return;
            }

            if (Decimal.TryParse(dlugoscKontownikaPoZmianie, out y) && y > 0)
            {
                // ym2 = (decimal)y / 1000;
                ym2 = y;

            }
            else
            {
                MessageBox.Show("Błędna wartość Długości", "Błąd");
                return;
            }
            if (Decimal.TryParse(gruboscSciankiKontownikaDoZmiany, out z) && z > 0)
            {


            }
            else
            {
                MessageBox.Show("Błędna wartość Grubości", "Błąd");
                return;
            }

            if (masaMetalu <= 0M)
            {
                MessageBox.Show("Podaj Materiał", "Błąd");
                return;
            }


            decimal odjeteGrubosci = ((z * 2 * 3.14M) / 4) / 1000;
            decimal obwodProfila = xm2 + am2;
            obwodProfila -= odjeteGrubosci;



            decimal MasaArkusza = (decimal)obwodProfila * ym2 * z * masaMetalu;
            MasaKontownika.Text = MasaArkusza.ToString("0.00") + "kg";
            MasaKontownika.ForeColor = Color.Orange;
            decimal CenaArkusza = MasaArkusza * cenaMetalu;
            CenaKontownika.Text = CenaArkusza.ToString("0.00") + "zł";
            CenaKontownika.ForeColor = Color.Orange;
        }
        /// <summary>
        /// Dzialanie Klawisza ENTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TablsControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(TablsControl.SelectedTab == TablsControl.TabPages["BlachaPage"])
                {
                    przeliczButton.PerformClick();
                }
                if (TablsControl.SelectedTab == TablsControl.TabPages["ProfilPage"])
                {
                    PrzeliczProfil.PerformClick();
                }
                if (TablsControl.SelectedTab == TablsControl.TabPages["RuraPage"])
                {
                    PrzeliczRure.PerformClick();
                }
                if (TablsControl.SelectedTab == TablsControl.TabPages["PrętPage"])
                {
                    PrzeliczPreta.PerformClick();
                }
                if (TablsControl.SelectedTab == TablsControl.TabPages["Kątownik"])
                {
                    PrzeliczKontownik.PerformClick();
                }
            }
        }
        void wwwButton_MouseLeave(object sender, EventArgs e)
        {
            this.wwwButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.LOGO_programu));
        }


        void wwwButton_MouseEnter(object sender, EventArgs e)
        {
            this.wwwButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.LOGO_programu_on_hover));
        }

        private void wwwButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hokto.net");
        }
    }
    
    
}
