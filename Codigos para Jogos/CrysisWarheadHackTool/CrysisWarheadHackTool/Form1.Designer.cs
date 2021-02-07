namespace CrysisWarheadHackTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VidaCheck = new MetroFramework.Controls.MetroCheckBox();
            this.MunicaoCheck = new MetroFramework.Controls.MetroCheckBox();
            this.InimigosCheck = new MetroFramework.Controls.MetroCheckBox();
            this.SemLimiteCheck = new MetroFramework.Controls.MetroCheckBox();
            this.EnergiaCheck = new MetroFramework.Controls.MetroCheckBox();
            this.VisaoCheck = new MetroFramework.Controls.MetroCheckBox();
            this.VelocidadeCheck = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TextoBase = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ImortalCheck = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // VidaCheck
            // 
            this.VidaCheck.AutoSize = true;
            this.VidaCheck.CustomBackground = false;
            this.VidaCheck.CustomForeColor = false;
            this.VidaCheck.FontSize = MetroFramework.MetroLinkSize.Small;
            this.VidaCheck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.VidaCheck.Location = new System.Drawing.Point(52, 94);
            this.VidaCheck.Name = "VidaCheck";
            this.VidaCheck.Size = new System.Drawing.Size(138, 15);
            this.VidaCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.VidaCheck.StyleManager = null;
            this.VidaCheck.TabIndex = 7;
            this.VidaCheck.Text = "Vida Regenera Rapido";
            this.VidaCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VidaCheck.UseStyleColors = false;
            this.VidaCheck.UseVisualStyleBackColor = true;
            // 
            // MunicaoCheck
            // 
            this.MunicaoCheck.AutoSize = true;
            this.MunicaoCheck.CustomBackground = false;
            this.MunicaoCheck.CustomForeColor = false;
            this.MunicaoCheck.FontSize = MetroFramework.MetroLinkSize.Small;
            this.MunicaoCheck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.MunicaoCheck.Location = new System.Drawing.Point(52, 125);
            this.MunicaoCheck.Name = "MunicaoCheck";
            this.MunicaoCheck.Size = new System.Drawing.Size(110, 15);
            this.MunicaoCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.MunicaoCheck.StyleManager = null;
            this.MunicaoCheck.TabIndex = 8;
            this.MunicaoCheck.Text = "Municao Infinita";
            this.MunicaoCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MunicaoCheck.UseStyleColors = false;
            this.MunicaoCheck.UseVisualStyleBackColor = true;
            // 
            // InimigosCheck
            // 
            this.InimigosCheck.AutoSize = true;
            this.InimigosCheck.CustomBackground = false;
            this.InimigosCheck.CustomForeColor = false;
            this.InimigosCheck.FontSize = MetroFramework.MetroLinkSize.Small;
            this.InimigosCheck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.InimigosCheck.Location = new System.Drawing.Point(52, 156);
            this.InimigosCheck.Name = "InimigosCheck";
            this.InimigosCheck.Size = new System.Drawing.Size(136, 15);
            this.InimigosCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.InimigosCheck.StyleManager = null;
            this.InimigosCheck.TabIndex = 9;
            this.InimigosCheck.Text = "Inimigos nao Atacam";
            this.InimigosCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InimigosCheck.UseStyleColors = false;
            this.InimigosCheck.UseVisualStyleBackColor = true;
            // 
            // SemLimiteCheck
            // 
            this.SemLimiteCheck.AutoSize = true;
            this.SemLimiteCheck.CustomBackground = false;
            this.SemLimiteCheck.CustomForeColor = false;
            this.SemLimiteCheck.FontSize = MetroFramework.MetroLinkSize.Small;
            this.SemLimiteCheck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.SemLimiteCheck.Location = new System.Drawing.Point(52, 187);
            this.SemLimiteCheck.Name = "SemLimiteCheck";
            this.SemLimiteCheck.Size = new System.Drawing.Size(135, 15);
            this.SemLimiteCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.SemLimiteCheck.StyleManager = null;
            this.SemLimiteCheck.TabIndex = 10;
            this.SemLimiteCheck.Text = "Sem Limite de Armas";
            this.SemLimiteCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SemLimiteCheck.UseStyleColors = false;
            this.SemLimiteCheck.UseVisualStyleBackColor = true;
            // 
            // EnergiaCheck
            // 
            this.EnergiaCheck.AutoSize = true;
            this.EnergiaCheck.CustomBackground = false;
            this.EnergiaCheck.CustomForeColor = false;
            this.EnergiaCheck.FontSize = MetroFramework.MetroLinkSize.Small;
            this.EnergiaCheck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.EnergiaCheck.Location = new System.Drawing.Point(52, 218);
            this.EnergiaCheck.Name = "EnergiaCheck";
            this.EnergiaCheck.Size = new System.Drawing.Size(125, 15);
            this.EnergiaCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.EnergiaCheck.StyleManager = null;
            this.EnergiaCheck.TabIndex = 11;
            this.EnergiaCheck.Text = "Energia Suit Infinita";
            this.EnergiaCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EnergiaCheck.UseStyleColors = false;
            this.EnergiaCheck.UseVisualStyleBackColor = true;
            // 
            // VisaoCheck
            // 
            this.VisaoCheck.AutoSize = true;
            this.VisaoCheck.CustomBackground = false;
            this.VisaoCheck.CustomForeColor = false;
            this.VisaoCheck.FontSize = MetroFramework.MetroLinkSize.Small;
            this.VisaoCheck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.VisaoCheck.Location = new System.Drawing.Point(52, 249);
            this.VisaoCheck.Name = "VisaoCheck";
            this.VisaoCheck.Size = new System.Drawing.Size(138, 15);
            this.VisaoCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.VisaoCheck.StyleManager = null;
            this.VisaoCheck.TabIndex = 12;
            this.VisaoCheck.Text = "Visao Noturna Infinita";
            this.VisaoCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VisaoCheck.UseStyleColors = false;
            this.VisaoCheck.UseVisualStyleBackColor = true;
            // 
            // VelocidadeCheck
            // 
            this.VelocidadeCheck.AutoSize = true;
            this.VelocidadeCheck.CustomBackground = false;
            this.VelocidadeCheck.CustomForeColor = false;
            this.VelocidadeCheck.FontSize = MetroFramework.MetroLinkSize.Small;
            this.VelocidadeCheck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.VelocidadeCheck.Location = new System.Drawing.Point(52, 280);
            this.VelocidadeCheck.Name = "VelocidadeCheck";
            this.VelocidadeCheck.Size = new System.Drawing.Size(113, 15);
            this.VelocidadeCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.VelocidadeCheck.StyleManager = null;
            this.VelocidadeCheck.TabIndex = 13;
            this.VelocidadeCheck.Text = "Super Velocidade";
            this.VelocidadeCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VelocidadeCheck.UseStyleColors = false;
            this.VelocidadeCheck.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(77, 446);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(176, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Copyrights 2020 - EdUaRdO";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(52, 382);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(224, 26);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Aplicar Alteracoes";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(52, 414);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(224, 17);
            this.progressBar1.TabIndex = 16;
            // 
            // TextoBase
            // 
            this.TextoBase.Location = new System.Drawing.Point(389, 37);
            this.TextoBase.Multiline = true;
            this.TextoBase.Name = "TextoBase";
            this.TextoBase.Size = new System.Drawing.Size(292, 54);
            this.TextoBase.TabIndex = 17;
            this.TextoBase.Text = resources.GetString("TextoBase.Text");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 97);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 54);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 157);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(292, 54);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(389, 217);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(292, 54);
            this.textBox4.TabIndex = 20;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(52, 318);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(109, 26);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Text = "Criar Backup";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = false;
            this.metroButton3.Location = new System.Drawing.Point(52, 350);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(224, 26);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton3.StyleManager = null;
            this.metroButton3.TabIndex = 22;
            this.metroButton3.Text = "Apagar backup anterior";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ImortalCheck
            // 
            this.ImortalCheck.AutoSize = true;
            this.ImortalCheck.CustomBackground = false;
            this.ImortalCheck.CustomForeColor = false;
            this.ImortalCheck.FontSize = MetroFramework.MetroLinkSize.Small;
            this.ImortalCheck.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.ImortalCheck.Location = new System.Drawing.Point(52, 63);
            this.ImortalCheck.Name = "ImortalCheck";
            this.ImortalCheck.Size = new System.Drawing.Size(61, 15);
            this.ImortalCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.ImortalCheck.StyleManager = null;
            this.ImortalCheck.TabIndex = 23;
            this.ImortalCheck.Text = "Imortal";
            this.ImortalCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ImortalCheck.UseStyleColors = false;
            this.ImortalCheck.UseVisualStyleBackColor = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = false;
            this.metroButton4.Location = new System.Drawing.Point(167, 318);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(109, 26);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton4.StyleManager = null;
            this.metroButton4.TabIndex = 24;
            this.metroButton4.Text = "Restaurar Backup";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 490);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.ImortalCheck);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextoBase);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.VelocidadeCheck);
            this.Controls.Add(this.VisaoCheck);
            this.Controls.Add(this.EnergiaCheck);
            this.Controls.Add(this.SemLimiteCheck);
            this.Controls.Add(this.InimigosCheck);
            this.Controls.Add(this.MunicaoCheck);
            this.Controls.Add(this.VidaCheck);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(332, 490);
            this.MinimumSize = new System.Drawing.Size(332, 490);
            this.Name = "Form1";
            this.Text = "Crysis Warhead Hack";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox VidaCheck;
        private MetroFramework.Controls.MetroCheckBox MunicaoCheck;
        private MetroFramework.Controls.MetroCheckBox InimigosCheck;
        private MetroFramework.Controls.MetroCheckBox SemLimiteCheck;
        private MetroFramework.Controls.MetroCheckBox EnergiaCheck;
        private MetroFramework.Controls.MetroCheckBox VisaoCheck;
        private MetroFramework.Controls.MetroCheckBox VelocidadeCheck;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox TextoBase;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroCheckBox ImortalCheck;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.Timer timer2;
    }
}

