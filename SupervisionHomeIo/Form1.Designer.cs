namespace SupervisionHomeIo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.chambreH = new System.Windows.Forms.GroupBox();
            this.labelChbrH2Value = new System.Windows.Forms.Label();
            this.labelChbrH3Value = new System.Windows.Forms.Label();
            this.labelChbrH4Value = new System.Windows.Forms.Label();
            this.labelChbrH5Value = new System.Windows.Forms.Label();
            this.labelChbrH6Value = new System.Windows.Forms.Label();
            this.labelChbrH7Value = new System.Windows.Forms.Label();
            this.labelChbrH1Value = new System.Windows.Forms.Label();
            this.labelChbrH7 = new System.Windows.Forms.Label();
            this.labelChbrH6 = new System.Windows.Forms.Label();
            this.labelChbrH5 = new System.Windows.Forms.Label();
            this.labelChbrH4 = new System.Windows.Forms.Label();
            this.labelChbrH3 = new System.Windows.Forms.Label();
            this.labelChbrH2 = new System.Windows.Forms.Label();
            this.labelChbrH1 = new System.Windows.Forms.Label();
            this.chartTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.labelTemperature = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chambreH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(81, 536);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(47, 17);
            this.time.TabIndex = 25;
            this.time.Text = "Heure";
            this.time.Click += new System.EventHandler(this.label8_Click);
            // 
            // chambreH
            // 
            this.chambreH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chambreH.Controls.Add(this.labelChbrH2Value);
            this.chambreH.Controls.Add(this.labelChbrH3Value);
            this.chambreH.Controls.Add(this.labelChbrH4Value);
            this.chambreH.Controls.Add(this.labelChbrH5Value);
            this.chambreH.Controls.Add(this.labelChbrH6Value);
            this.chambreH.Controls.Add(this.labelChbrH7Value);
            this.chambreH.Controls.Add(this.labelChbrH1Value);
            this.chambreH.Controls.Add(this.labelChbrH7);
            this.chambreH.Controls.Add(this.labelChbrH6);
            this.chambreH.Controls.Add(this.labelChbrH5);
            this.chambreH.Controls.Add(this.labelChbrH4);
            this.chambreH.Controls.Add(this.labelChbrH3);
            this.chambreH.Controls.Add(this.labelChbrH2);
            this.chambreH.Controls.Add(this.labelChbrH1);
            this.chambreH.Cursor = System.Windows.Forms.Cursors.Default;
            this.chambreH.Location = new System.Drawing.Point(12, 12);
            this.chambreH.Name = "chambreH";
            this.chambreH.Size = new System.Drawing.Size(305, 500);
            this.chambreH.TabIndex = 26;
            this.chambreH.TabStop = false;
            this.chambreH.Text = "Chambre H";
            this.chambreH.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelChbrH2Value
            // 
            this.labelChbrH2Value.AutoSize = true;
            this.labelChbrH2Value.Location = new System.Drawing.Point(243, 65);
            this.labelChbrH2Value.Name = "labelChbrH2Value";
            this.labelChbrH2Value.Size = new System.Drawing.Size(49, 17);
            this.labelChbrH2Value.TabIndex = 13;
            this.labelChbrH2Value.Text = "Valeur";
            // 
            // labelChbrH3Value
            // 
            this.labelChbrH3Value.AutoSize = true;
            this.labelChbrH3Value.Location = new System.Drawing.Point(243, 103);
            this.labelChbrH3Value.Name = "labelChbrH3Value";
            this.labelChbrH3Value.Size = new System.Drawing.Size(49, 17);
            this.labelChbrH3Value.TabIndex = 12;
            this.labelChbrH3Value.Text = "Valeur";
            // 
            // labelChbrH4Value
            // 
            this.labelChbrH4Value.AutoSize = true;
            this.labelChbrH4Value.Location = new System.Drawing.Point(243, 143);
            this.labelChbrH4Value.Name = "labelChbrH4Value";
            this.labelChbrH4Value.Size = new System.Drawing.Size(49, 17);
            this.labelChbrH4Value.TabIndex = 11;
            this.labelChbrH4Value.Text = "Valeur";
            this.labelChbrH4Value.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelChbrH5Value
            // 
            this.labelChbrH5Value.AutoSize = true;
            this.labelChbrH5Value.Location = new System.Drawing.Point(243, 181);
            this.labelChbrH5Value.Name = "labelChbrH5Value";
            this.labelChbrH5Value.Size = new System.Drawing.Size(49, 17);
            this.labelChbrH5Value.TabIndex = 10;
            this.labelChbrH5Value.Text = "Valeur";
            // 
            // labelChbrH6Value
            // 
            this.labelChbrH6Value.AutoSize = true;
            this.labelChbrH6Value.Location = new System.Drawing.Point(243, 216);
            this.labelChbrH6Value.Name = "labelChbrH6Value";
            this.labelChbrH6Value.Size = new System.Drawing.Size(49, 17);
            this.labelChbrH6Value.TabIndex = 9;
            this.labelChbrH6Value.Text = "Valeur";
            // 
            // labelChbrH7Value
            // 
            this.labelChbrH7Value.AutoSize = true;
            this.labelChbrH7Value.Location = new System.Drawing.Point(243, 252);
            this.labelChbrH7Value.Name = "labelChbrH7Value";
            this.labelChbrH7Value.Size = new System.Drawing.Size(49, 17);
            this.labelChbrH7Value.TabIndex = 8;
            this.labelChbrH7Value.Text = "Valeur";
            this.labelChbrH7Value.Click += new System.EventHandler(this.labelChbrH7Value_Click);
            // 
            // labelChbrH1Value
            // 
            this.labelChbrH1Value.AutoSize = true;
            this.labelChbrH1Value.Location = new System.Drawing.Point(243, 29);
            this.labelChbrH1Value.Name = "labelChbrH1Value";
            this.labelChbrH1Value.Size = new System.Drawing.Size(49, 17);
            this.labelChbrH1Value.TabIndex = 7;
            this.labelChbrH1Value.Text = "Valeur";
            // 
            // labelChbrH7
            // 
            this.labelChbrH7.AutoSize = true;
            this.labelChbrH7.Location = new System.Drawing.Point(6, 252);
            this.labelChbrH7.Name = "labelChbrH7";
            this.labelChbrH7.Size = new System.Drawing.Size(191, 17);
            this.labelChbrH7.TabIndex = 6;
            this.labelChbrH7.Text = "Detecteur de porte ouverte 2";
            // 
            // labelChbrH6
            // 
            this.labelChbrH6.AutoSize = true;
            this.labelChbrH6.Location = new System.Drawing.Point(6, 216);
            this.labelChbrH6.Name = "labelChbrH6";
            this.labelChbrH6.Size = new System.Drawing.Size(191, 17);
            this.labelChbrH6.TabIndex = 5;
            this.labelChbrH6.Text = "Detecteur de porte ouverte 1";
            this.labelChbrH6.Click += new System.EventHandler(this.labelChbrH6_Click);
            // 
            // labelChbrH5
            // 
            this.labelChbrH5.AutoSize = true;
            this.labelChbrH5.Location = new System.Drawing.Point(6, 181);
            this.labelChbrH5.Name = "labelChbrH5";
            this.labelChbrH5.Size = new System.Drawing.Size(94, 17);
            this.labelChbrH5.TabIndex = 4;
            this.labelChbrH5.Text = "Interrupteur 2";
            // 
            // labelChbrH4
            // 
            this.labelChbrH4.AutoSize = true;
            this.labelChbrH4.Location = new System.Drawing.Point(6, 143);
            this.labelChbrH4.Name = "labelChbrH4";
            this.labelChbrH4.Size = new System.Drawing.Size(94, 17);
            this.labelChbrH4.TabIndex = 3;
            this.labelChbrH4.Text = "Interrupteur 1";
            // 
            // labelChbrH3
            // 
            this.labelChbrH3.AutoSize = true;
            this.labelChbrH3.Location = new System.Drawing.Point(6, 103);
            this.labelChbrH3.Name = "labelChbrH3";
            this.labelChbrH3.Size = new System.Drawing.Size(133, 17);
            this.labelChbrH3.TabIndex = 2;
            this.labelChbrH3.Text = "Detecteur de fumée";
            // 
            // labelChbrH2
            // 
            this.labelChbrH2.AutoSize = true;
            this.labelChbrH2.Location = new System.Drawing.Point(6, 65);
            this.labelChbrH2.Name = "labelChbrH2";
            this.labelChbrH2.Size = new System.Drawing.Size(155, 17);
            this.labelChbrH2.TabIndex = 1;
            this.labelChbrH2.Text = "Capteur de mouvement";
            // 
            // labelChbrH1
            // 
            this.labelChbrH1.AutoSize = true;
            this.labelChbrH1.Location = new System.Drawing.Point(6, 29);
            this.labelChbrH1.Name = "labelChbrH1";
            this.labelChbrH1.Size = new System.Drawing.Size(145, 17);
            this.labelChbrH1.TabIndex = 0;
            this.labelChbrH1.Text = "Capteur de luminosité";
            // 
            // chartTest
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTest.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTest.Legends.Add(legend3);
            this.chartTest.Location = new System.Drawing.Point(394, 32);
            this.chartTest.Name = "chartTest";
            this.chartTest.Size = new System.Drawing.Size(654, 398);
            this.chartTest.TabIndex = 14;
            this.chartTest.Text = "chart1";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(407, 476);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(150, 17);
            this.labelTemperature.TabIndex = 27;
            this.labelTemperature.Text = "Température : calcul...";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(673, 456);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 134);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 665);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.chartTest);
            this.Controls.Add(this.chambreH);
            this.Controls.Add(this.time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.chambreH.ResumeLayout(false);
            this.chambreH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.GroupBox chambreH;
        private System.Windows.Forms.Label labelChbrH5;
        private System.Windows.Forms.Label labelChbrH4;
        private System.Windows.Forms.Label labelChbrH3;
        private System.Windows.Forms.Label labelChbrH2;
        private System.Windows.Forms.Label labelChbrH1;
        private System.Windows.Forms.Label labelChbrH7;
        private System.Windows.Forms.Label labelChbrH6;
        private System.Windows.Forms.Label labelChbrH2Value;
        private System.Windows.Forms.Label labelChbrH3Value;
        private System.Windows.Forms.Label labelChbrH4Value;
        private System.Windows.Forms.Label labelChbrH5Value;
        private System.Windows.Forms.Label labelChbrH6Value;
        private System.Windows.Forms.Label labelChbrH7Value;
        private System.Windows.Forms.Label labelChbrH1Value;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.ListView listView1;
    }
}

