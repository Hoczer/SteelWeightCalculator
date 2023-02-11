namespace KalkulatorMasyStali
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TablsControl = new System.Windows.Forms.TabControl();
            this.BlachaPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.wynikCenyArkusza = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wynikLabel = new System.Windows.Forms.Label();
            this.przeliczButton = new System.Windows.Forms.Button();
            this.gruboscBlachy = new System.Windows.Forms.TextBox();
            this.wartosc2 = new System.Windows.Forms.TextBox();
            this.wartosc1 = new System.Windows.Forms.TextBox();
            this.ProfilPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.WysokoscProfilaText = new System.Windows.Forms.TextBox();
            this.CenaProfilaText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MasaProfilaLabel = new System.Windows.Forms.Label();
            this.PrzeliczProfil = new System.Windows.Forms.Button();
            this.GruboscSciankiProfilaText = new System.Windows.Forms.TextBox();
            this.DlugoscProfilaText = new System.Windows.Forms.TextBox();
            this.SzerokoscProfilaText = new System.Windows.Forms.TextBox();
            this.RuraPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.CenaRury = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.MasaRury = new System.Windows.Forms.Label();
            this.PrzeliczRure = new System.Windows.Forms.Button();
            this.GruboscSciankiRuraText = new System.Windows.Forms.TextBox();
            this.DlugoscRuryText = new System.Windows.Forms.TextBox();
            this.SrednicaText = new System.Windows.Forms.TextBox();
            this.PrętPage = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.CenaPreta = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.MasaPreta = new System.Windows.Forms.Label();
            this.PrzeliczPreta = new System.Windows.Forms.Button();
            this.DlugoscPretaText = new System.Windows.Forms.TextBox();
            this.SrednicaPretaText = new System.Windows.Forms.TextBox();
            this.Kątownik = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.WysokoscKontownikaText = new System.Windows.Forms.TextBox();
            this.CenaKontownika = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.MasaKontownika = new System.Windows.Forms.Label();
            this.PrzeliczKontownik = new System.Windows.Forms.Button();
            this.GroboscSciankiKontonikaText = new System.Windows.Forms.TextBox();
            this.DlugoscKontownikaText = new System.Windows.Forms.TextBox();
            this.SzerokoscKontownikaText = new System.Windows.Forms.TextBox();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.cenaLabel = new System.Windows.Forms.Label();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wwwButton = new System.Windows.Forms.Button();
            this.TablsControl.SuspendLayout();
            this.BlachaPage.SuspendLayout();
            this.ProfilPage.SuspendLayout();
            this.RuraPage.SuspendLayout();
            this.PrętPage.SuspendLayout();
            this.Kątownik.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablsControl
            // 
            this.TablsControl.Controls.Add(this.BlachaPage);
            this.TablsControl.Controls.Add(this.ProfilPage);
            this.TablsControl.Controls.Add(this.RuraPage);
            this.TablsControl.Controls.Add(this.PrętPage);
            this.TablsControl.Controls.Add(this.Kątownik);
            this.TablsControl.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TablsControl.Location = new System.Drawing.Point(12, 12);
            this.TablsControl.Name = "TablsControl";
            this.TablsControl.SelectedIndex = 0;
            this.TablsControl.Size = new System.Drawing.Size(452, 330);
            this.TablsControl.TabIndex = 0;
            this.TablsControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TablsControl_KeyDown);
            // 
            // BlachaPage
            // 
            this.BlachaPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BlachaPage.Controls.Add(this.label7);
            this.BlachaPage.Controls.Add(this.wynikCenyArkusza);
            this.BlachaPage.Controls.Add(this.label3);
            this.BlachaPage.Controls.Add(this.label2);
            this.BlachaPage.Controls.Add(this.label1);
            this.BlachaPage.Controls.Add(this.wynikLabel);
            this.BlachaPage.Controls.Add(this.przeliczButton);
            this.BlachaPage.Controls.Add(this.gruboscBlachy);
            this.BlachaPage.Controls.Add(this.wartosc2);
            this.BlachaPage.Controls.Add(this.wartosc1);
            this.BlachaPage.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlachaPage.Location = new System.Drawing.Point(4, 24);
            this.BlachaPage.Name = "BlachaPage";
            this.BlachaPage.Padding = new System.Windows.Forms.Padding(3);
            this.BlachaPage.Size = new System.Drawing.Size(444, 302);
            this.BlachaPage.TabIndex = 0;
            this.BlachaPage.Text = "Blacha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(6, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 33);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cena arkusza:";
            // 
            // wynikCenyArkusza
            // 
            this.wynikCenyArkusza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wynikCenyArkusza.AutoSize = true;
            this.wynikCenyArkusza.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.wynikCenyArkusza.ForeColor = System.Drawing.Color.White;
            this.wynikCenyArkusza.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wynikCenyArkusza.Location = new System.Drawing.Point(214, 201);
            this.wynikCenyArkusza.Name = "wynikCenyArkusza";
            this.wynikCenyArkusza.Size = new System.Drawing.Size(63, 41);
            this.wynikCenyArkusza.TabIndex = 31;
            this.wynikCenyArkusza.Text = "0zł";
            this.wynikCenyArkusza.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(75, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Grubość mm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(75, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Długość mm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Szerokość mm :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wynikLabel
            // 
            this.wynikLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.wynikLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.wynikLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wynikLabel.Location = new System.Drawing.Point(52, 122);
            this.wynikLabel.Name = "wynikLabel";
            this.wynikLabel.Size = new System.Drawing.Size(161, 38);
            this.wynikLabel.TabIndex = 20;
            this.wynikLabel.Text = "Masa";
            this.wynikLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // przeliczButton
            // 
            this.przeliczButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przeliczButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.przeliczButton.Location = new System.Drawing.Point(246, 128);
            this.przeliczButton.Name = "przeliczButton";
            this.przeliczButton.Size = new System.Drawing.Size(99, 27);
            this.przeliczButton.TabIndex = 19;
            this.przeliczButton.Text = "Przelicz";
            this.przeliczButton.UseVisualStyleBackColor = true;
            this.przeliczButton.Click += new System.EventHandler(this.przeliczButton_Click_1);
            // 
            // gruboscBlachy
            // 
            this.gruboscBlachy.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gruboscBlachy.Location = new System.Drawing.Point(246, 78);
            this.gruboscBlachy.Name = "gruboscBlachy";
            this.gruboscBlachy.Size = new System.Drawing.Size(82, 23);
            this.gruboscBlachy.TabIndex = 18;
            // 
            // wartosc2
            // 
            this.wartosc2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wartosc2.Location = new System.Drawing.Point(246, 49);
            this.wartosc2.Name = "wartosc2";
            this.wartosc2.Size = new System.Drawing.Size(132, 23);
            this.wartosc2.TabIndex = 17;
            // 
            // wartosc1
            // 
            this.wartosc1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wartosc1.Location = new System.Drawing.Point(246, 20);
            this.wartosc1.Name = "wartosc1";
            this.wartosc1.Size = new System.Drawing.Size(132, 23);
            this.wartosc1.TabIndex = 16;
            // 
            // ProfilPage
            // 
            this.ProfilPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProfilPage.Controls.Add(this.label6);
            this.ProfilPage.Controls.Add(this.label13);
            this.ProfilPage.Controls.Add(this.WysokoscProfilaText);
            this.ProfilPage.Controls.Add(this.CenaProfilaText);
            this.ProfilPage.Controls.Add(this.label9);
            this.ProfilPage.Controls.Add(this.label10);
            this.ProfilPage.Controls.Add(this.label11);
            this.ProfilPage.Controls.Add(this.MasaProfilaLabel);
            this.ProfilPage.Controls.Add(this.PrzeliczProfil);
            this.ProfilPage.Controls.Add(this.GruboscSciankiProfilaText);
            this.ProfilPage.Controls.Add(this.DlugoscProfilaText);
            this.ProfilPage.Controls.Add(this.SzerokoscProfilaText);
            this.ProfilPage.Location = new System.Drawing.Point(4, 24);
            this.ProfilPage.Name = "ProfilPage";
            this.ProfilPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProfilPage.Size = new System.Drawing.Size(444, 302);
            this.ProfilPage.TabIndex = 1;
            this.ProfilPage.Text = "Profil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 33);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cena profila:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(81, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 15);
            this.label13.TabIndex = 47;
            this.label13.Text = "Wysokość mm :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WysokoscProfilaText
            // 
            this.WysokoscProfilaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WysokoscProfilaText.Location = new System.Drawing.Point(253, 44);
            this.WysokoscProfilaText.Name = "WysokoscProfilaText";
            this.WysokoscProfilaText.Size = new System.Drawing.Size(132, 23);
            this.WysokoscProfilaText.TabIndex = 33;
            // 
            // CenaProfilaText
            // 
            this.CenaProfilaText.AutoSize = true;
            this.CenaProfilaText.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.CenaProfilaText.ForeColor = System.Drawing.Color.White;
            this.CenaProfilaText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CenaProfilaText.Location = new System.Drawing.Point(194, 211);
            this.CenaProfilaText.Name = "CenaProfilaText";
            this.CenaProfilaText.Size = new System.Drawing.Size(63, 41);
            this.CenaProfilaText.TabIndex = 45;
            this.CenaProfilaText.Text = "0zł";
            this.CenaProfilaText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(81, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Grubość ścianki mm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(81, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Długość m :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(81, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Szerokość mm :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MasaProfilaLabel
            // 
            this.MasaProfilaLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.MasaProfilaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MasaProfilaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasaProfilaLabel.Location = new System.Drawing.Point(54, 150);
            this.MasaProfilaLabel.Name = "MasaProfilaLabel";
            this.MasaProfilaLabel.Size = new System.Drawing.Size(161, 38);
            this.MasaProfilaLabel.TabIndex = 36;
            this.MasaProfilaLabel.Text = "Masa";
            this.MasaProfilaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrzeliczProfil
            // 
            this.PrzeliczProfil.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzeliczProfil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrzeliczProfil.Location = new System.Drawing.Point(248, 156);
            this.PrzeliczProfil.Name = "PrzeliczProfil";
            this.PrzeliczProfil.Size = new System.Drawing.Size(99, 27);
            this.PrzeliczProfil.TabIndex = 36;
            this.PrzeliczProfil.Text = "Przelicz";
            this.PrzeliczProfil.UseVisualStyleBackColor = true;
            this.PrzeliczProfil.Click += new System.EventHandler(this.PrzeliczProfil_Click);
            // 
            // GruboscSciankiProfilaText
            // 
            this.GruboscSciankiProfilaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GruboscSciankiProfilaText.Location = new System.Drawing.Point(253, 105);
            this.GruboscSciankiProfilaText.Name = "GruboscSciankiProfilaText";
            this.GruboscSciankiProfilaText.Size = new System.Drawing.Size(82, 23);
            this.GruboscSciankiProfilaText.TabIndex = 35;
            // 
            // DlugoscProfilaText
            // 
            this.DlugoscProfilaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DlugoscProfilaText.Location = new System.Drawing.Point(253, 72);
            this.DlugoscProfilaText.Name = "DlugoscProfilaText";
            this.DlugoscProfilaText.Size = new System.Drawing.Size(132, 23);
            this.DlugoscProfilaText.TabIndex = 34;
            // 
            // SzerokoscProfilaText
            // 
            this.SzerokoscProfilaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzerokoscProfilaText.Location = new System.Drawing.Point(253, 15);
            this.SzerokoscProfilaText.Name = "SzerokoscProfilaText";
            this.SzerokoscProfilaText.Size = new System.Drawing.Size(132, 23);
            this.SzerokoscProfilaText.TabIndex = 32;
            // 
            // RuraPage
            // 
            this.RuraPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RuraPage.Controls.Add(this.label8);
            this.RuraPage.Controls.Add(this.CenaRury);
            this.RuraPage.Controls.Add(this.label14);
            this.RuraPage.Controls.Add(this.label15);
            this.RuraPage.Controls.Add(this.label16);
            this.RuraPage.Controls.Add(this.MasaRury);
            this.RuraPage.Controls.Add(this.PrzeliczRure);
            this.RuraPage.Controls.Add(this.GruboscSciankiRuraText);
            this.RuraPage.Controls.Add(this.DlugoscRuryText);
            this.RuraPage.Controls.Add(this.SrednicaText);
            this.RuraPage.Location = new System.Drawing.Point(4, 24);
            this.RuraPage.Name = "RuraPage";
            this.RuraPage.Size = new System.Drawing.Size(444, 302);
            this.RuraPage.TabIndex = 2;
            this.RuraPage.Text = "Rura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(52, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 33);
            this.label8.TabIndex = 42;
            this.label8.Text = "Cena rury:";
            // 
            // CenaRury
            // 
            this.CenaRury.AutoSize = true;
            this.CenaRury.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.CenaRury.ForeColor = System.Drawing.Color.White;
            this.CenaRury.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CenaRury.Location = new System.Drawing.Point(211, 207);
            this.CenaRury.Name = "CenaRury";
            this.CenaRury.Size = new System.Drawing.Size(63, 41);
            this.CenaRury.TabIndex = 41;
            this.CenaRury.Text = "0zł";
            this.CenaRury.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(93, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 15);
            this.label14.TabIndex = 40;
            this.label14.Text = "Grubość ścianki mm :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(93, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "Długość m :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(93, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 15);
            this.label16.TabIndex = 38;
            this.label16.Text = "Średnica mm :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MasaRury
            // 
            this.MasaRury.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.MasaRury.ForeColor = System.Drawing.SystemColors.Control;
            this.MasaRury.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasaRury.Location = new System.Drawing.Point(70, 126);
            this.MasaRury.Name = "MasaRury";
            this.MasaRury.Size = new System.Drawing.Size(161, 38);
            this.MasaRury.TabIndex = 37;
            this.MasaRury.Text = "Masa";
            this.MasaRury.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrzeliczRure
            // 
            this.PrzeliczRure.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzeliczRure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrzeliczRure.Location = new System.Drawing.Point(264, 132);
            this.PrzeliczRure.Name = "PrzeliczRure";
            this.PrzeliczRure.Size = new System.Drawing.Size(99, 27);
            this.PrzeliczRure.TabIndex = 36;
            this.PrzeliczRure.Text = "Przelicz";
            this.PrzeliczRure.UseVisualStyleBackColor = true;
            this.PrzeliczRure.Click += new System.EventHandler(this.PrzeliczRure_Click);
            // 
            // GruboscSciankiRuraText
            // 
            this.GruboscSciankiRuraText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GruboscSciankiRuraText.Location = new System.Drawing.Point(264, 82);
            this.GruboscSciankiRuraText.Name = "GruboscSciankiRuraText";
            this.GruboscSciankiRuraText.Size = new System.Drawing.Size(82, 23);
            this.GruboscSciankiRuraText.TabIndex = 35;
            // 
            // DlugoscRuryText
            // 
            this.DlugoscRuryText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DlugoscRuryText.Location = new System.Drawing.Point(264, 53);
            this.DlugoscRuryText.Name = "DlugoscRuryText";
            this.DlugoscRuryText.Size = new System.Drawing.Size(132, 23);
            this.DlugoscRuryText.TabIndex = 34;
            // 
            // SrednicaText
            // 
            this.SrednicaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SrednicaText.Location = new System.Drawing.Point(264, 24);
            this.SrednicaText.Name = "SrednicaText";
            this.SrednicaText.Size = new System.Drawing.Size(132, 23);
            this.SrednicaText.TabIndex = 33;
            // 
            // PrętPage
            // 
            this.PrętPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrętPage.Controls.Add(this.label12);
            this.PrętPage.Controls.Add(this.CenaPreta);
            this.PrętPage.Controls.Add(this.label18);
            this.PrętPage.Controls.Add(this.label19);
            this.PrętPage.Controls.Add(this.MasaPreta);
            this.PrętPage.Controls.Add(this.PrzeliczPreta);
            this.PrętPage.Controls.Add(this.DlugoscPretaText);
            this.PrętPage.Controls.Add(this.SrednicaPretaText);
            this.PrętPage.Location = new System.Drawing.Point(4, 24);
            this.PrętPage.Name = "PrętPage";
            this.PrętPage.Size = new System.Drawing.Size(444, 302);
            this.PrętPage.TabIndex = 3;
            this.PrętPage.Text = "Pręt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(36, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 33);
            this.label12.TabIndex = 50;
            this.label12.Text = "Cena pręta:";
            // 
            // CenaPreta
            // 
            this.CenaPreta.AutoSize = true;
            this.CenaPreta.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.CenaPreta.ForeColor = System.Drawing.Color.White;
            this.CenaPreta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CenaPreta.Location = new System.Drawing.Point(208, 220);
            this.CenaPreta.Name = "CenaPreta";
            this.CenaPreta.Size = new System.Drawing.Size(63, 41);
            this.CenaPreta.TabIndex = 49;
            this.CenaPreta.Text = "0zł";
            this.CenaPreta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(105, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 15);
            this.label18.TabIndex = 48;
            this.label18.Text = "Długość m :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(105, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 15);
            this.label19.TabIndex = 47;
            this.label19.Text = "Średnica mm :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MasaPreta
            // 
            this.MasaPreta.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.MasaPreta.ForeColor = System.Drawing.SystemColors.Control;
            this.MasaPreta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasaPreta.Location = new System.Drawing.Point(82, 141);
            this.MasaPreta.Name = "MasaPreta";
            this.MasaPreta.Size = new System.Drawing.Size(161, 38);
            this.MasaPreta.TabIndex = 46;
            this.MasaPreta.Text = "Masa";
            this.MasaPreta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrzeliczPreta
            // 
            this.PrzeliczPreta.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzeliczPreta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrzeliczPreta.Location = new System.Drawing.Point(276, 147);
            this.PrzeliczPreta.Name = "PrzeliczPreta";
            this.PrzeliczPreta.Size = new System.Drawing.Size(99, 27);
            this.PrzeliczPreta.TabIndex = 45;
            this.PrzeliczPreta.Text = "Przelicz";
            this.PrzeliczPreta.UseVisualStyleBackColor = true;
            this.PrzeliczPreta.Click += new System.EventHandler(this.PrzeliczPreta_Click);
            // 
            // DlugoscPretaText
            // 
            this.DlugoscPretaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DlugoscPretaText.Location = new System.Drawing.Point(276, 68);
            this.DlugoscPretaText.Name = "DlugoscPretaText";
            this.DlugoscPretaText.Size = new System.Drawing.Size(132, 23);
            this.DlugoscPretaText.TabIndex = 44;
            // 
            // SrednicaPretaText
            // 
            this.SrednicaPretaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SrednicaPretaText.Location = new System.Drawing.Point(276, 39);
            this.SrednicaPretaText.Name = "SrednicaPretaText";
            this.SrednicaPretaText.Size = new System.Drawing.Size(132, 23);
            this.SrednicaPretaText.TabIndex = 43;
            // 
            // Kątownik
            // 
            this.Kątownik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Kątownik.Controls.Add(this.label17);
            this.Kątownik.Controls.Add(this.label20);
            this.Kątownik.Controls.Add(this.WysokoscKontownikaText);
            this.Kątownik.Controls.Add(this.CenaKontownika);
            this.Kątownik.Controls.Add(this.label22);
            this.Kątownik.Controls.Add(this.label23);
            this.Kątownik.Controls.Add(this.label24);
            this.Kątownik.Controls.Add(this.MasaKontownika);
            this.Kątownik.Controls.Add(this.PrzeliczKontownik);
            this.Kątownik.Controls.Add(this.GroboscSciankiKontonikaText);
            this.Kątownik.Controls.Add(this.DlugoscKontownikaText);
            this.Kątownik.Controls.Add(this.SzerokoscKontownikaText);
            this.Kątownik.Location = new System.Drawing.Point(4, 24);
            this.Kątownik.Name = "Kątownik";
            this.Kątownik.Size = new System.Drawing.Size(444, 302);
            this.Kątownik.TabIndex = 4;
            this.Kątownik.Text = "Kątownik";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(28, 220);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(236, 33);
            this.label17.TabIndex = 60;
            this.label17.Text = "Cena kątownika:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(103, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 15);
            this.label20.TabIndex = 59;
            this.label20.Text = "Wysokość mm :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WysokoscKontownikaText
            // 
            this.WysokoscKontownikaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WysokoscKontownikaText.Location = new System.Drawing.Point(275, 47);
            this.WysokoscKontownikaText.Name = "WysokoscKontownikaText";
            this.WysokoscKontownikaText.Size = new System.Drawing.Size(132, 23);
            this.WysokoscKontownikaText.TabIndex = 50;
            // 
            // CenaKontownika
            // 
            this.CenaKontownika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenaKontownika.AutoSize = true;
            this.CenaKontownika.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.CenaKontownika.ForeColor = System.Drawing.Color.White;
            this.CenaKontownika.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CenaKontownika.Location = new System.Drawing.Point(268, 214);
            this.CenaKontownika.Name = "CenaKontownika";
            this.CenaKontownika.Size = new System.Drawing.Size(63, 41);
            this.CenaKontownika.TabIndex = 58;
            this.CenaKontownika.Text = "0zł";
            this.CenaKontownika.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(103, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(137, 15);
            this.label22.TabIndex = 57;
            this.label22.Text = "Grubość ścianki mm :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(103, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 15);
            this.label23.TabIndex = 56;
            this.label23.Text = "Długość m :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.ForeColor = System.Drawing.SystemColors.Control;
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(103, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 15);
            this.label24.TabIndex = 55;
            this.label24.Text = "Szerokość mm :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MasaKontownika
            // 
            this.MasaKontownika.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.MasaKontownika.ForeColor = System.Drawing.SystemColors.Control;
            this.MasaKontownika.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasaKontownika.Location = new System.Drawing.Point(76, 153);
            this.MasaKontownika.Name = "MasaKontownika";
            this.MasaKontownika.Size = new System.Drawing.Size(161, 38);
            this.MasaKontownika.TabIndex = 53;
            this.MasaKontownika.Text = "Masa";
            this.MasaKontownika.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrzeliczKontownik
            // 
            this.PrzeliczKontownik.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzeliczKontownik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrzeliczKontownik.Location = new System.Drawing.Point(270, 159);
            this.PrzeliczKontownik.Name = "PrzeliczKontownik";
            this.PrzeliczKontownik.Size = new System.Drawing.Size(99, 27);
            this.PrzeliczKontownik.TabIndex = 54;
            this.PrzeliczKontownik.Text = "Przelicz";
            this.PrzeliczKontownik.UseVisualStyleBackColor = true;
            this.PrzeliczKontownik.Click += new System.EventHandler(this.PrzeliczKontownik_Click);
            // 
            // GroboscSciankiKontonikaText
            // 
            this.GroboscSciankiKontonikaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroboscSciankiKontonikaText.Location = new System.Drawing.Point(275, 108);
            this.GroboscSciankiKontonikaText.Name = "GroboscSciankiKontonikaText";
            this.GroboscSciankiKontonikaText.Size = new System.Drawing.Size(82, 23);
            this.GroboscSciankiKontonikaText.TabIndex = 52;
            // 
            // DlugoscKontownikaText
            // 
            this.DlugoscKontownikaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DlugoscKontownikaText.Location = new System.Drawing.Point(275, 75);
            this.DlugoscKontownikaText.Name = "DlugoscKontownikaText";
            this.DlugoscKontownikaText.Size = new System.Drawing.Size(132, 23);
            this.DlugoscKontownikaText.TabIndex = 51;
            // 
            // SzerokoscKontownikaText
            // 
            this.SzerokoscKontownikaText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzerokoscKontownikaText.Location = new System.Drawing.Point(275, 18);
            this.SzerokoscKontownikaText.Name = "SzerokoscKontownikaText";
            this.SzerokoscKontownikaText.Size = new System.Drawing.Size(132, 23);
            this.SzerokoscKontownikaText.TabIndex = 49;
            // 
            // zapiszButton
            // 
            this.zapiszButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapiszButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zapiszButton.Location = new System.Drawing.Point(387, 370);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(75, 23);
            this.zapiszButton.TabIndex = 30;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
            // 
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cenaLabel.ForeColor = System.Drawing.Color.White;
            this.cenaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cenaLabel.Location = new System.Drawing.Point(228, 372);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(91, 18);
            this.cenaLabel.TabIndex = 29;
            this.cenaLabel.Text = "Cena za kg:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cenaTextBox.Location = new System.Drawing.Point(326, 370);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(54, 23);
            this.cenaTextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(18, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Materiał :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Stal",
            "Inox",
            "Aluminium"});
            this.comboBox1.Location = new System.Drawing.Point(100, 370);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(240, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Program by Bartosz Orzechowski";
            // 
            // wwwButton
            // 
            this.wwwButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wwwButton.BackgroundImage")));
            this.wwwButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wwwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wwwButton.Location = new System.Drawing.Point(21, 420);
            this.wwwButton.Name = "wwwButton";
            this.wwwButton.Size = new System.Drawing.Size(143, 25);
            this.wwwButton.TabIndex = 31;
            this.wwwButton.UseVisualStyleBackColor = true;
            this.wwwButton.Click += new System.EventHandler(this.wwwButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(476, 477);
            this.Controls.Add(this.wwwButton);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cenaLabel);
            this.Controls.Add(this.TablsControl);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kalkulator Masy Stali";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TablsControl.ResumeLayout(false);
            this.BlachaPage.ResumeLayout(false);
            this.BlachaPage.PerformLayout();
            this.ProfilPage.ResumeLayout(false);
            this.ProfilPage.PerformLayout();
            this.RuraPage.ResumeLayout(false);
            this.RuraPage.PerformLayout();
            this.PrętPage.ResumeLayout(false);
            this.PrętPage.PerformLayout();
            this.Kątownik.ResumeLayout(false);
            this.Kątownik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TablsControl;
        private System.Windows.Forms.TabPage BlachaPage;
        private System.Windows.Forms.TabPage ProfilPage;
        private System.Windows.Forms.Label wynikCenyArkusza;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label wynikLabel;
        private System.Windows.Forms.Button przeliczButton;
        private System.Windows.Forms.TextBox gruboscBlachy;
        private System.Windows.Forms.TextBox wartosc2;
        private System.Windows.Forms.TextBox wartosc1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WysokoscProfilaText;
        private System.Windows.Forms.Label CenaProfilaText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MasaProfilaLabel;
        private System.Windows.Forms.Button PrzeliczProfil;
        private System.Windows.Forms.TextBox GruboscSciankiProfilaText;
        private System.Windows.Forms.TextBox DlugoscProfilaText;
        private System.Windows.Forms.TextBox SzerokoscProfilaText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage RuraPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CenaRury;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label MasaRury;
        private System.Windows.Forms.Button PrzeliczRure;
        private System.Windows.Forms.TextBox GruboscSciankiRuraText;
        private System.Windows.Forms.TextBox DlugoscRuryText;
        private System.Windows.Forms.TextBox SrednicaText;
        private System.Windows.Forms.TabPage PrętPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label CenaPreta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label MasaPreta;
        private System.Windows.Forms.Button PrzeliczPreta;
        private System.Windows.Forms.TextBox DlugoscPretaText;
        private System.Windows.Forms.TextBox SrednicaPretaText;
        private System.Windows.Forms.TabPage Kątownik;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox WysokoscKontownikaText;
        private System.Windows.Forms.Label CenaKontownika;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label MasaKontownika;
        private System.Windows.Forms.Button PrzeliczKontownik;
        private System.Windows.Forms.TextBox GroboscSciankiKontonikaText;
        private System.Windows.Forms.TextBox DlugoscKontownikaText;
        private System.Windows.Forms.TextBox SzerokoscKontownikaText;
        private System.Windows.Forms.Button wwwButton;
    }
}

