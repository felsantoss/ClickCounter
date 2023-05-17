namespace Counter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.lbl_label = new System.Windows.Forms.Label();
            this.light_mode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dark_mode = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.Yellow;
            this.button.Location = new System.Drawing.Point(160, 206);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(136, 33);
            this.button.TabIndex = 0;
            this.button.Text = "Clique Aqui!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // lbl_label
            // 
            this.lbl_label.AutoSize = true;
            this.lbl_label.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_label.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_label.Location = new System.Drawing.Point(218, 138);
            this.lbl_label.Name = "lbl_label";
            this.lbl_label.Size = new System.Drawing.Size(25, 28);
            this.lbl_label.TabIndex = 1;
            this.lbl_label.Text = "0";
            // 
            // light_mode
            // 
            this.light_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.light_mode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.light_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.light_mode.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light_mode.ForeColor = System.Drawing.Color.Yellow;
            this.light_mode.Location = new System.Drawing.Point(53, 392);
            this.light_mode.Name = "light_mode";
            this.light_mode.Size = new System.Drawing.Size(35, 33);
            this.light_mode.TabIndex = 4;
            this.light_mode.Text = "☀";
            this.light_mode.UseVisualStyleBackColor = true;
            this.light_mode.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(364, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dark_mode
            // 
            this.dark_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dark_mode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dark_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dark_mode.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dark_mode.ForeColor = System.Drawing.Color.White;
            this.dark_mode.Location = new System.Drawing.Point(12, 392);
            this.dark_mode.Name = "dark_mode";
            this.dark_mode.Size = new System.Drawing.Size(35, 33);
            this.dark_mode.TabIndex = 6;
            this.dark_mode.Text = "🌙";
            this.dark_mode.UseVisualStyleBackColor = true;
            this.dark_mode.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Yellow;
            this.labelTime.Location = new System.Drawing.Point(88, 275);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 23);
            this.labelTime.TabIndex = 7;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Yellow;
            this.labelTitle.Location = new System.Drawing.Point(68, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(313, 23);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Quantos cliques em 10 segundos?";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.Color.Yellow;
            this.buttonRestart.Location = new System.Drawing.Point(176, 392);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(102, 33);
            this.buttonRestart.TabIndex = 9;
            this.buttonRestart.Text = "Reiniciar";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dark_mode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.light_mode);
            this.Controls.Add(this.lbl_label);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label lbl_label;
        private System.Windows.Forms.Button light_mode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dark_mode;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonRestart;
    }
}

