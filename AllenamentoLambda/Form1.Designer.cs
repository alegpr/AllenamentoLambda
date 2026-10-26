namespace AllenamentoLambda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvVideogiochi = new ListView();
            chTitolo = new ColumnHeader();
            chGenere = new ColumnHeader();
            chOreDiGioco = new ColumnHeader();
            chPrezzo = new ColumnHeader();
            chDataUscita = new ColumnHeader();
            chVoto = new ColumnHeader();
            btTitolo = new Button();
            btPrezzo = new Button();
            btOreGioco = new Button();
            btDataUscita = new Button();
            groupBox1 = new GroupBox();
            rbDecrescente = new RadioButton();
            rbCrescente = new RadioButton();
            groupBox2 = new GroupBox();
            btTrovaTitolo = new Button();
            btTrovaDataUscita = new Button();
            btTrovaOreGioco = new Button();
            btTrovaPerzzo = new Button();
            rbMeno = new RadioButton();
            rbPiu = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lvVideogiochi
            // 
            lvVideogiochi.Columns.AddRange(new ColumnHeader[] { chTitolo, chGenere, chOreDiGioco, chPrezzo, chDataUscita, chVoto });
            lvVideogiochi.FullRowSelect = true;
            lvVideogiochi.GridLines = true;
            lvVideogiochi.Location = new Point(17, 20);
            lvVideogiochi.Margin = new Padding(4, 5, 4, 5);
            lvVideogiochi.MultiSelect = false;
            lvVideogiochi.Name = "lvVideogiochi";
            lvVideogiochi.Size = new Size(834, 366);
            lvVideogiochi.TabIndex = 0;
            lvVideogiochi.UseCompatibleStateImageBehavior = false;
            lvVideogiochi.View = View.Details;
            lvVideogiochi.VirtualMode = true;
            lvVideogiochi.RetrieveVirtualItem += listView1_RetrieveVirtualItem;
            // 
            // chTitolo
            // 
            chTitolo.Text = "Titolo";
            chTitolo.Width = 120;
            // 
            // chGenere
            // 
            chGenere.Text = "Genere";
            chGenere.Width = 120;
            // 
            // chOreDiGioco
            // 
            chOreDiGioco.Text = "Ore Di Gioco";
            chOreDiGioco.Width = 90;
            // 
            // chPrezzo
            // 
            chPrezzo.Text = "Prezzo";
            // 
            // chDataUscita
            // 
            chDataUscita.Text = "DataUscita";
            chDataUscita.Width = 90;
            // 
            // chVoto
            // 
            chVoto.Text = "Voto";
            // 
            // btTitolo
            // 
            btTitolo.Location = new Point(6, 100);
            btTitolo.Name = "btTitolo";
            btTitolo.Size = new Size(141, 34);
            btTitolo.TabIndex = 1;
            btTitolo.Text = "Titolo";
            btTitolo.UseVisualStyleBackColor = true;
            btTitolo.Click += btTitolo_Click;
            // 
            // btPrezzo
            // 
            btPrezzo.Location = new Point(6, 180);
            btPrezzo.Name = "btPrezzo";
            btPrezzo.Size = new Size(141, 34);
            btPrezzo.TabIndex = 2;
            btPrezzo.Text = "Prezzo";
            btPrezzo.UseVisualStyleBackColor = true;
            btPrezzo.Click += btPrezzo_Click;
            // 
            // btOreGioco
            // 
            btOreGioco.Location = new Point(6, 140);
            btOreGioco.Name = "btOreGioco";
            btOreGioco.Size = new Size(141, 34);
            btOreGioco.TabIndex = 3;
            btOreGioco.Text = "Ore di Gioco";
            btOreGioco.UseVisualStyleBackColor = true;
            btOreGioco.Click += btOreGioco_Click;
            // 
            // btDataUscita
            // 
            btDataUscita.Location = new Point(6, 220);
            btDataUscita.Name = "btDataUscita";
            btDataUscita.Size = new Size(141, 34);
            btDataUscita.TabIndex = 4;
            btDataUscita.Text = "Data di Uscita";
            btDataUscita.UseVisualStyleBackColor = true;
            btDataUscita.Click += btDataUscita_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDecrescente);
            groupBox1.Controls.Add(rbCrescente);
            groupBox1.Controls.Add(btTitolo);
            groupBox1.Controls.Add(btDataUscita);
            groupBox1.Controls.Add(btOreGioco);
            groupBox1.Controls.Add(btPrezzo);
            groupBox1.Location = new Point(17, 394);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(158, 280);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordina Per";
            // 
            // rbDecrescente
            // 
            rbDecrescente.AutoSize = true;
            rbDecrescente.Location = new Point(6, 65);
            rbDecrescente.Name = "rbDecrescente";
            rbDecrescente.Size = new Size(132, 29);
            rbDecrescente.TabIndex = 6;
            rbDecrescente.Text = "Decrescente";
            rbDecrescente.UseVisualStyleBackColor = true;
            // 
            // rbCrescente
            // 
            rbCrescente.AutoSize = true;
            rbCrescente.Checked = true;
            rbCrescente.Location = new Point(6, 30);
            rbCrescente.Name = "rbCrescente";
            rbCrescente.Size = new Size(113, 29);
            rbCrescente.TabIndex = 5;
            rbCrescente.TabStop = true;
            rbCrescente.Text = "Crescente";
            rbCrescente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btTrovaTitolo);
            groupBox2.Controls.Add(btTrovaDataUscita);
            groupBox2.Controls.Add(btTrovaOreGioco);
            groupBox2.Controls.Add(btTrovaPerzzo);
            groupBox2.Controls.Add(rbMeno);
            groupBox2.Controls.Add(rbPiu);
            groupBox2.Location = new Point(181, 394);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 280);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trova";
            // 
            // btTrovaTitolo
            // 
            btTrovaTitolo.Location = new Point(6, 100);
            btTrovaTitolo.Name = "btTrovaTitolo";
            btTrovaTitolo.Size = new Size(141, 34);
            btTrovaTitolo.TabIndex = 5;
            btTrovaTitolo.Text = "Titolo";
            btTrovaTitolo.UseVisualStyleBackColor = true;
            btTrovaTitolo.Click += btTrovaTitolo_Click;
            // 
            // btTrovaDataUscita
            // 
            btTrovaDataUscita.Location = new Point(6, 220);
            btTrovaDataUscita.Name = "btTrovaDataUscita";
            btTrovaDataUscita.Size = new Size(141, 34);
            btTrovaDataUscita.TabIndex = 8;
            btTrovaDataUscita.Text = "Data di Uscita";
            btTrovaDataUscita.UseVisualStyleBackColor = true;
            // 
            // btTrovaOreGioco
            // 
            btTrovaOreGioco.Location = new Point(6, 140);
            btTrovaOreGioco.Name = "btTrovaOreGioco";
            btTrovaOreGioco.Size = new Size(141, 34);
            btTrovaOreGioco.TabIndex = 7;
            btTrovaOreGioco.Text = "Ore di Gioco";
            btTrovaOreGioco.UseVisualStyleBackColor = true;
            btTrovaOreGioco.Click += btTrovaOreGioco_Click;
            // 
            // btTrovaPerzzo
            // 
            btTrovaPerzzo.Location = new Point(6, 180);
            btTrovaPerzzo.Name = "btTrovaPerzzo";
            btTrovaPerzzo.Size = new Size(141, 34);
            btTrovaPerzzo.TabIndex = 6;
            btTrovaPerzzo.Text = "Prezzo";
            btTrovaPerzzo.UseVisualStyleBackColor = true;
            // 
            // rbMeno
            // 
            rbMeno.AutoSize = true;
            rbMeno.Location = new Point(6, 65);
            rbMeno.Name = "rbMeno";
            rbMeno.Size = new Size(83, 29);
            rbMeno.TabIndex = 1;
            rbMeno.Text = "Meno";
            rbMeno.UseVisualStyleBackColor = true;
            // 
            // rbPiu
            // 
            rbPiu.AutoSize = true;
            rbPiu.Checked = true;
            rbPiu.Location = new Point(6, 30);
            rbPiu.Name = "rbPiu";
            rbPiu.Size = new Size(61, 29);
            rbPiu.TabIndex = 0;
            rbPiu.TabStop = true;
            rbPiu.Text = "Più";
            rbPiu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lvVideogiochi);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvVideogiochi;
        private ColumnHeader chTitolo;
        private ColumnHeader chGenere;
        private ColumnHeader chOreDiGioco;
        private ColumnHeader chPrezzo;
        private ColumnHeader chDataUscita;
        private ColumnHeader chVoto;
        private Button btTitolo;
        private Button btPrezzo;
        private Button btOreGioco;
        private Button btDataUscita;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbPiu;
        private RadioButton rbMeno;
        private RadioButton rbDecrescente;
        private RadioButton rbCrescente;
        private Button btTrovaTitolo;
        private Button btTrovaDataUscita;
        private Button btTrovaOreGioco;
        private Button btTrovaPerzzo;
    }
}
