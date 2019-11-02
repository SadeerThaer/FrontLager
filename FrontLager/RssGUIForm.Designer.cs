namespace FrontLager
{
    partial class RssGUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.knappGetData = new System.Windows.Forms.Button();
            this.printData = new System.Windows.Forms.Label();
            this.CBFrekvens = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TxtRssUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TBKategori = new System.Windows.Forms.TextBox();
            this.BtnAddKategori = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.podLista = new System.Windows.Forms.ListView();
            this.namnPod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avsnittNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.podFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.podKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.LKategori = new System.Windows.Forms.Label();
            this.LWKategori = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // knappGetData
            // 
            this.knappGetData.Location = new System.Drawing.Point(798, 345);
            this.knappGetData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.knappGetData.Name = "knappGetData";
            this.knappGetData.Size = new System.Drawing.Size(112, 35);
            this.knappGetData.TabIndex = 0;
            this.knappGetData.Text = "Hämta";
            this.knappGetData.UseVisualStyleBackColor = true;
            this.knappGetData.Click += new System.EventHandler(this.KnappGetData_Click);
            // 
            // printData
            // 
            this.printData.AutoSize = true;
            this.printData.Location = new System.Drawing.Point(675, 346);
            this.printData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printData.Name = "printData";
            this.printData.Size = new System.Drawing.Size(51, 20);
            this.printData.TabIndex = 2;
            this.printData.Text = "label1";
            // 
            // CBFrekvens
            // 
            this.CBFrekvens.FormattingEnabled = true;
            this.CBFrekvens.Items.AddRange(new object[] {
            "Var 5:e minut",
            "Var 10:e minut",
            "Var 15:e minut"});
            this.CBFrekvens.Location = new System.Drawing.Point(234, 346);
            this.CBFrekvens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBFrekvens.Name = "CBFrekvens";
            this.CBFrekvens.Size = new System.Drawing.Size(180, 28);
            this.CBFrekvens.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(424, 348);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // TxtRssUrl
            // 
            this.TxtRssUrl.Location = new System.Drawing.Point(18, 348);
            this.TxtRssUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRssUrl.Name = "TxtRssUrl";
            this.TxtRssUrl.Size = new System.Drawing.Size(205, 26);
            this.TxtRssUrl.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ny";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 388);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Spara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 389);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TBKategori
            // 
            this.TBKategori.Location = new System.Drawing.Point(676, 246);
            this.TBKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBKategori.Name = "TBKategori";
            this.TBKategori.Size = new System.Drawing.Size(354, 26);
            this.TBKategori.TabIndex = 12;
            // 
            // BtnAddKategori
            // 
            this.BtnAddKategori.Location = new System.Drawing.Point(676, 286);
            this.BtnAddKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddKategori.Name = "BtnAddKategori";
            this.BtnAddKategori.Size = new System.Drawing.Size(112, 35);
            this.BtnAddKategori.TabIndex = 13;
            this.BtnAddKategori.Text = "Ny";
            this.BtnAddKategori.UseVisualStyleBackColor = true;
            this.BtnAddKategori.Click += new System.EventHandler(this.BtnAddKategori_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(798, 286);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 14;
            this.button5.Text = "Spara";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(920, 286);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 35);
            this.button6.TabIndex = 15;
            this.button6.Text = "Ta bort";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Url";
            // 
            // podLista
            // 
            this.podLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namnPod,
            this.avsnittNummer,
            this.podFrekvens,
            this.podKategori});
            this.podLista.HideSelection = false;
            this.podLista.Location = new System.Drawing.Point(22, 18);
            this.podLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.podLista.Name = "podLista";
            this.podLista.Size = new System.Drawing.Size(582, 286);
            this.podLista.TabIndex = 17;
            this.podLista.UseCompatibleStateImageBehavior = false;
            this.podLista.View = System.Windows.Forms.View.Details;
            // 
            // namnPod
            // 
            this.namnPod.Text = "Namn";
            this.namnPod.Width = 101;
            // 
            // avsnittNummer
            // 
            this.avsnittNummer.Text = "Avsnitt";
            this.avsnittNummer.Width = 95;
            // 
            // podFrekvens
            // 
            this.podFrekvens.Text = "Frekvens";
            this.podFrekvens.Width = 93;
            // 
            // podKategori
            // 
            this.podKategori.Text = "Kategorier";
            this.podKategori.Width = 97;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(28, 474);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(576, 213);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(646, 474);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 213);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Frekvens";
            // 
            // LKategori
            // 
            this.LKategori.AutoSize = true;
            this.LKategori.Location = new System.Drawing.Point(672, 18);
            this.LKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LKategori.Name = "LKategori";
            this.LKategori.Size = new System.Drawing.Size(82, 20);
            this.LKategori.TabIndex = 22;
            this.LKategori.Text = "Kategorier";
            // 
            // LWKategori
            // 
            this.LWKategori.FormattingEnabled = true;
            this.LWKategori.ItemHeight = 20;
            this.LWKategori.Location = new System.Drawing.Point(679, 48);
            this.LWKategori.Name = "LWKategori";
            this.LWKategori.Size = new System.Drawing.Size(351, 184);
            this.LWKategori.TabIndex = 23;
            // 
            // RssGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 708);
            this.Controls.Add(this.LWKategori);
            this.Controls.Add(this.LKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.podLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnAddKategori);
            this.Controls.Add(this.TBKategori);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtRssUrl);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CBFrekvens);
            this.Controls.Add(this.printData);
            this.Controls.Add(this.knappGetData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RssGUIForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button knappGetData;
        private System.Windows.Forms.Label printData;
        private System.Windows.Forms.ComboBox CBFrekvens;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox TxtRssUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TBKategori;
        private System.Windows.Forms.Button BtnAddKategori;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView podLista;
        private System.Windows.Forms.ColumnHeader avsnittNummer;
        private System.Windows.Forms.ColumnHeader namnPod;
        private System.Windows.Forms.ColumnHeader podFrekvens;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader podKategori;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LKategori;
        private System.Windows.Forms.ListBox LWKategori;
    }
}

