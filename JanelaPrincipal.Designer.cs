namespace Pista_em_uso
{
    partial class JanelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.labelRumoPista = new System.Windows.Forms.Label();
            this.labelDirecaoVento = new System.Windows.Forms.Label();
            this.labelDeclinacaoMagnetica = new System.Windows.Forms.Label();
            this.textBoxRumoPista = new System.Windows.Forms.TextBox();
            this.textBoxDirecaoVento = new System.Windows.Forms.TextBox();
            this.textBoxDeclinacaoMagnetica = new System.Windows.Forms.TextBox();
            this.labelSentidoDeclinacao = new System.Windows.Forms.Label();
            this.radioButtonOeste = new System.Windows.Forms.RadioButton();
            this.radioButtonLeste = new System.Windows.Forms.RadioButton();
            this.groupBoxConfiguracoes = new System.Windows.Forms.GroupBox();
            this.labelTransparencia = new System.Windows.Forms.Label();
            this.trackBarTransparencia = new System.Windows.Forms.TrackBar();
            this.checkBoxSempreVisivel = new System.Windows.Forms.CheckBox();
            this.labelResultadoPistaEmUso = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.checkBoxCronometro = new System.Windows.Forms.CheckBox();
            this.labelCronometro = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxConfiguracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparencia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRumoPista
            // 
            this.labelRumoPista.AutoSize = true;
            this.labelRumoPista.Location = new System.Drawing.Point(12, 9);
            this.labelRumoPista.Name = "labelRumoPista";
            this.labelRumoPista.Size = new System.Drawing.Size(78, 13);
            this.labelRumoPista.TabIndex = 0;
            this.labelRumoPista.Text = "Rumo da pista:";
            // 
            // labelDirecaoVento
            // 
            this.labelDirecaoVento.AutoSize = true;
            this.labelDirecaoVento.Location = new System.Drawing.Point(12, 35);
            this.labelDirecaoVento.Name = "labelDirecaoVento";
            this.labelDirecaoVento.Size = new System.Drawing.Size(92, 13);
            this.labelDirecaoVento.TabIndex = 1;
            this.labelDirecaoVento.Text = "Direção do vento:";
            // 
            // labelDeclinacaoMagnetica
            // 
            this.labelDeclinacaoMagnetica.AutoSize = true;
            this.labelDeclinacaoMagnetica.Location = new System.Drawing.Point(12, 61);
            this.labelDeclinacaoMagnetica.Name = "labelDeclinacaoMagnetica";
            this.labelDeclinacaoMagnetica.Size = new System.Drawing.Size(110, 13);
            this.labelDeclinacaoMagnetica.TabIndex = 2;
            this.labelDeclinacaoMagnetica.Text = "Declinação magética:";
            // 
            // textBoxRumoPista
            // 
            this.textBoxRumoPista.Location = new System.Drawing.Point(128, 6);
            this.textBoxRumoPista.Name = "textBoxRumoPista";
            this.textBoxRumoPista.Size = new System.Drawing.Size(44, 20);
            this.textBoxRumoPista.TabIndex = 3;
            this.textBoxRumoPista.TextChanged += new System.EventHandler(this.textBoxRumoPista_TextChanged);
            // 
            // textBoxDirecaoVento
            // 
            this.textBoxDirecaoVento.Location = new System.Drawing.Point(128, 32);
            this.textBoxDirecaoVento.Name = "textBoxDirecaoVento";
            this.textBoxDirecaoVento.Size = new System.Drawing.Size(44, 20);
            this.textBoxDirecaoVento.TabIndex = 4;
            this.textBoxDirecaoVento.TextChanged += new System.EventHandler(this.textBoxDirecaoVento_TextChanged);
            // 
            // textBoxDeclinacaoMagnetica
            // 
            this.textBoxDeclinacaoMagnetica.Location = new System.Drawing.Point(128, 58);
            this.textBoxDeclinacaoMagnetica.Name = "textBoxDeclinacaoMagnetica";
            this.textBoxDeclinacaoMagnetica.Size = new System.Drawing.Size(44, 20);
            this.textBoxDeclinacaoMagnetica.TabIndex = 5;
            this.textBoxDeclinacaoMagnetica.TextChanged += new System.EventHandler(this.textBoxDeclinacaoMagnetica_TextChanged);
            // 
            // labelSentidoDeclinacao
            // 
            this.labelSentidoDeclinacao.AutoSize = true;
            this.labelSentidoDeclinacao.Location = new System.Drawing.Point(12, 87);
            this.labelSentidoDeclinacao.Name = "labelSentidoDeclinacao";
            this.labelSentidoDeclinacao.Size = new System.Drawing.Size(116, 13);
            this.labelSentidoDeclinacao.TabIndex = 6;
            this.labelSentidoDeclinacao.Text = "Sentido da declinação:";
            // 
            // radioButtonOeste
            // 
            this.radioButtonOeste.AutoSize = true;
            this.radioButtonOeste.Checked = true;
            this.radioButtonOeste.Location = new System.Drawing.Point(15, 104);
            this.radioButtonOeste.Name = "radioButtonOeste";
            this.radioButtonOeste.Size = new System.Drawing.Size(73, 17);
            this.radioButtonOeste.TabIndex = 7;
            this.radioButtonOeste.TabStop = true;
            this.radioButtonOeste.Text = "Oeste (W)";
            this.radioButtonOeste.UseVisualStyleBackColor = true;
            this.radioButtonOeste.CheckedChanged += new System.EventHandler(this.radioButtonOeste_CheckedChanged);
            // 
            // radioButtonLeste
            // 
            this.radioButtonLeste.AutoSize = true;
            this.radioButtonLeste.Location = new System.Drawing.Point(105, 104);
            this.radioButtonLeste.Name = "radioButtonLeste";
            this.radioButtonLeste.Size = new System.Drawing.Size(67, 17);
            this.radioButtonLeste.TabIndex = 8;
            this.radioButtonLeste.Text = "Leste (E)";
            this.radioButtonLeste.UseVisualStyleBackColor = true;
            this.radioButtonLeste.CheckedChanged += new System.EventHandler(this.radioButtonLeste_CheckedChanged);
            // 
            // groupBoxConfiguracoes
            // 
            this.groupBoxConfiguracoes.Controls.Add(this.labelTransparencia);
            this.groupBoxConfiguracoes.Controls.Add(this.trackBarTransparencia);
            this.groupBoxConfiguracoes.Controls.Add(this.checkBoxSempreVisivel);
            this.groupBoxConfiguracoes.Location = new System.Drawing.Point(12, 127);
            this.groupBoxConfiguracoes.Name = "groupBoxConfiguracoes";
            this.groupBoxConfiguracoes.Size = new System.Drawing.Size(160, 100);
            this.groupBoxConfiguracoes.TabIndex = 9;
            this.groupBoxConfiguracoes.TabStop = false;
            this.groupBoxConfiguracoes.Text = "Configurações";
            // 
            // labelTransparencia
            // 
            this.labelTransparencia.AutoSize = true;
            this.labelTransparencia.Location = new System.Drawing.Point(41, 76);
            this.labelTransparencia.Name = "labelTransparencia";
            this.labelTransparencia.Size = new System.Drawing.Size(75, 13);
            this.labelTransparencia.TabIndex = 2;
            this.labelTransparencia.Text = "Transparência";
            // 
            // trackBarTransparencia
            // 
            this.trackBarTransparencia.Location = new System.Drawing.Point(7, 44);
            this.trackBarTransparencia.Maximum = 100;
            this.trackBarTransparencia.Minimum = 50;
            this.trackBarTransparencia.Name = "trackBarTransparencia";
            this.trackBarTransparencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarTransparencia.Size = new System.Drawing.Size(147, 45);
            this.trackBarTransparencia.TabIndex = 1;
            this.trackBarTransparencia.TickFrequency = 25;
            this.trackBarTransparencia.Value = 100;
            this.trackBarTransparencia.Scroll += new System.EventHandler(this.trackBarTransparencia_Scroll);
            // 
            // checkBoxSempreVisivel
            // 
            this.checkBoxSempreVisivel.AutoSize = true;
            this.checkBoxSempreVisivel.Location = new System.Drawing.Point(7, 20);
            this.checkBoxSempreVisivel.Name = "checkBoxSempreVisivel";
            this.checkBoxSempreVisivel.Size = new System.Drawing.Size(96, 17);
            this.checkBoxSempreVisivel.TabIndex = 0;
            this.checkBoxSempreVisivel.Text = "Sempre visível";
            this.checkBoxSempreVisivel.UseVisualStyleBackColor = true;
            this.checkBoxSempreVisivel.CheckedChanged += new System.EventHandler(this.checkBoxSempreVisivel_CheckedChanged);
            // 
            // labelResultadoPistaEmUso
            // 
            this.labelResultadoPistaEmUso.AutoSize = true;
            this.labelResultadoPistaEmUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoPistaEmUso.Location = new System.Drawing.Point(12, 284);
            this.labelResultadoPistaEmUso.Name = "labelResultadoPistaEmUso";
            this.labelResultadoPistaEmUso.Size = new System.Drawing.Size(162, 16);
            this.labelResultadoPistaEmUso.TabIndex = 11;
            this.labelResultadoPistaEmUso.Text = "Pista em uso: 00 ou 00";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(12, 258);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(160, 23);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular pista em uso";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // checkBoxCronometro
            // 
            this.checkBoxCronometro.AutoSize = true;
            this.checkBoxCronometro.Location = new System.Drawing.Point(12, 234);
            this.checkBoxCronometro.Name = "checkBoxCronometro";
            this.checkBoxCronometro.Size = new System.Drawing.Size(80, 17);
            this.checkBoxCronometro.TabIndex = 12;
            this.checkBoxCronometro.Text = "Cronômetro";
            this.checkBoxCronometro.UseVisualStyleBackColor = true;
            this.checkBoxCronometro.CheckedChanged += new System.EventHandler(this.checkBoxCronometro_CheckedChanged);
            // 
            // labelCronometro
            // 
            this.labelCronometro.AutoSize = true;
            this.labelCronometro.Location = new System.Drawing.Point(138, 235);
            this.labelCronometro.Name = "labelCronometro";
            this.labelCronometro.Size = new System.Drawing.Size(34, 13);
            this.labelCronometro.TabIndex = 13;
            this.labelCronometro.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 306);
            this.Controls.Add(this.labelCronometro);
            this.Controls.Add(this.checkBoxCronometro);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelResultadoPistaEmUso);
            this.Controls.Add(this.groupBoxConfiguracoes);
            this.Controls.Add(this.radioButtonLeste);
            this.Controls.Add(this.radioButtonOeste);
            this.Controls.Add(this.labelSentidoDeclinacao);
            this.Controls.Add(this.textBoxDeclinacaoMagnetica);
            this.Controls.Add(this.textBoxDirecaoVento);
            this.Controls.Add(this.textBoxRumoPista);
            this.Controls.Add(this.labelDeclinacaoMagnetica);
            this.Controls.Add(this.labelDirecaoVento);
            this.Controls.Add(this.labelRumoPista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaPrincipal";
            this.Text = "Pista em uso";
            this.groupBoxConfiguracoes.ResumeLayout(false);
            this.groupBoxConfiguracoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransparencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRumoPista;
        private System.Windows.Forms.Label labelDirecaoVento;
        private System.Windows.Forms.Label labelDeclinacaoMagnetica;
        private System.Windows.Forms.TextBox textBoxRumoPista;
        private System.Windows.Forms.TextBox textBoxDirecaoVento;
        private System.Windows.Forms.TextBox textBoxDeclinacaoMagnetica;
        private System.Windows.Forms.Label labelSentidoDeclinacao;
        private System.Windows.Forms.RadioButton radioButtonOeste;
        private System.Windows.Forms.RadioButton radioButtonLeste;
        private System.Windows.Forms.GroupBox groupBoxConfiguracoes;
        private System.Windows.Forms.Label labelTransparencia;
        private System.Windows.Forms.TrackBar trackBarTransparencia;
        private System.Windows.Forms.CheckBox checkBoxSempreVisivel;
        private System.Windows.Forms.Label labelResultadoPistaEmUso;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.CheckBox checkBoxCronometro;
        private System.Windows.Forms.Label labelCronometro;
        private System.Windows.Forms.Timer timer1;
    }
}

