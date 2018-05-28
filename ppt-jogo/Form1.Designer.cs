namespace ppt_jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_papel1 = new System.Windows.Forms.PictureBox();
            this.pb_tesoura1 = new System.Windows.Forms.PictureBox();
            this.pb_pedra1 = new System.Windows.Forms.PictureBox();
            this.rb_pedra = new System.Windows.Forms.RadioButton();
            this.rb_tesoura = new System.Windows.Forms.RadioButton();
            this.rb_papel = new System.Windows.Forms.RadioButton();
            this.pb_pedra2 = new System.Windows.Forms.PictureBox();
            this.pb_tesoura2 = new System.Windows.Forms.PictureBox();
            this.pb_papel2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_vitorias = new System.Windows.Forms.Label();
            this.lb_derrotas = new System.Windows.Forms.Label();
            this.lb_empates = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_papel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tesoura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pedra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pedra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tesoura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_papel2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_papel1
            // 
            this.pb_papel1.Image = ((System.Drawing.Image)(resources.GetObject("pb_papel1.Image")));
            this.pb_papel1.Location = new System.Drawing.Point(324, 12);
            this.pb_papel1.Name = "pb_papel1";
            this.pb_papel1.Size = new System.Drawing.Size(150, 150);
            this.pb_papel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_papel1.TabIndex = 0;
            this.pb_papel1.TabStop = false;
            // 
            // pb_tesoura1
            // 
            this.pb_tesoura1.Image = global::ppt_jogo.Properties.Resources.tesoura;
            this.pb_tesoura1.Location = new System.Drawing.Point(168, 12);
            this.pb_tesoura1.Name = "pb_tesoura1";
            this.pb_tesoura1.Size = new System.Drawing.Size(150, 150);
            this.pb_tesoura1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_tesoura1.TabIndex = 1;
            this.pb_tesoura1.TabStop = false;
            // 
            // pb_pedra1
            // 
            this.pb_pedra1.Image = global::ppt_jogo.Properties.Resources.pedra;
            this.pb_pedra1.Location = new System.Drawing.Point(12, 12);
            this.pb_pedra1.Name = "pb_pedra1";
            this.pb_pedra1.Size = new System.Drawing.Size(150, 150);
            this.pb_pedra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pedra1.TabIndex = 2;
            this.pb_pedra1.TabStop = false;
            // 
            // rb_pedra
            // 
            this.rb_pedra.AutoSize = true;
            this.rb_pedra.Location = new System.Drawing.Point(79, 168);
            this.rb_pedra.Name = "rb_pedra";
            this.rb_pedra.Size = new System.Drawing.Size(14, 13);
            this.rb_pedra.TabIndex = 3;
            this.rb_pedra.TabStop = true;
            this.rb_pedra.UseVisualStyleBackColor = true;
            // 
            // rb_tesoura
            // 
            this.rb_tesoura.AutoSize = true;
            this.rb_tesoura.Location = new System.Drawing.Point(237, 168);
            this.rb_tesoura.Name = "rb_tesoura";
            this.rb_tesoura.Size = new System.Drawing.Size(14, 13);
            this.rb_tesoura.TabIndex = 4;
            this.rb_tesoura.TabStop = true;
            this.rb_tesoura.UseVisualStyleBackColor = true;
            // 
            // rb_papel
            // 
            this.rb_papel.AutoSize = true;
            this.rb_papel.Location = new System.Drawing.Point(391, 168);
            this.rb_papel.Name = "rb_papel";
            this.rb_papel.Size = new System.Drawing.Size(14, 13);
            this.rb_papel.TabIndex = 5;
            this.rb_papel.TabStop = true;
            this.rb_papel.UseVisualStyleBackColor = true;
            // 
            // pb_pedra2
            // 
            this.pb_pedra2.Image = global::ppt_jogo.Properties.Resources.pedra;
            this.pb_pedra2.Location = new System.Drawing.Point(12, 399);
            this.pb_pedra2.Name = "pb_pedra2";
            this.pb_pedra2.Size = new System.Drawing.Size(150, 150);
            this.pb_pedra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pedra2.TabIndex = 8;
            this.pb_pedra2.TabStop = false;
            this.pb_pedra2.Visible = false;
            // 
            // pb_tesoura2
            // 
            this.pb_tesoura2.Image = global::ppt_jogo.Properties.Resources.tesoura;
            this.pb_tesoura2.Location = new System.Drawing.Point(168, 399);
            this.pb_tesoura2.Name = "pb_tesoura2";
            this.pb_tesoura2.Size = new System.Drawing.Size(150, 150);
            this.pb_tesoura2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_tesoura2.TabIndex = 7;
            this.pb_tesoura2.TabStop = false;
            this.pb_tesoura2.Visible = false;
            // 
            // pb_papel2
            // 
            this.pb_papel2.Image = ((System.Drawing.Image)(resources.GetObject("pb_papel2.Image")));
            this.pb_papel2.Location = new System.Drawing.Point(324, 399);
            this.pb_papel2.Name = "pb_papel2";
            this.pb_papel2.Size = new System.Drawing.Size(150, 150);
            this.pb_papel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_papel2.TabIndex = 6;
            this.pb_papel2.TabStop = false;
            this.pb_papel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Jogar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.Location = new System.Drawing.Point(203, 300);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 20);
            this.lb_resultado.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vitórias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Derrotas";
            // 
            // lb_vitorias
            // 
            this.lb_vitorias.AutoSize = true;
            this.lb_vitorias.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vitorias.Location = new System.Drawing.Point(439, 232);
            this.lb_vitorias.Name = "lb_vitorias";
            this.lb_vitorias.Size = new System.Drawing.Size(20, 20);
            this.lb_vitorias.TabIndex = 14;
            this.lb_vitorias.Text = "0";
            // 
            // lb_derrotas
            // 
            this.lb_derrotas.AutoSize = true;
            this.lb_derrotas.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_derrotas.Location = new System.Drawing.Point(439, 268);
            this.lb_derrotas.Name = "lb_derrotas";
            this.lb_derrotas.Size = new System.Drawing.Size(20, 20);
            this.lb_derrotas.TabIndex = 15;
            this.lb_derrotas.Text = "0";
            // 
            // lb_empates
            // 
            this.lb_empates.AutoSize = true;
            this.lb_empates.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empates.Location = new System.Drawing.Point(439, 300);
            this.lb_empates.Name = "lb_empates";
            this.lb_empates.Size = new System.Drawing.Size(20, 20);
            this.lb_empates.TabIndex = 17;
            this.lb_empates.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Empates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.lb_empates);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_derrotas);
            this.Controls.Add(this.lb_vitorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_pedra2);
            this.Controls.Add(this.pb_tesoura2);
            this.Controls.Add(this.pb_papel2);
            this.Controls.Add(this.rb_papel);
            this.Controls.Add(this.rb_tesoura);
            this.Controls.Add(this.rb_pedra);
            this.Controls.Add(this.pb_pedra1);
            this.Controls.Add(this.pb_tesoura1);
            this.Controls.Add(this.pb_papel1);
            this.Name = "Form1";
            this.Text = "Pedra, papel e tesoura";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_papel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tesoura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pedra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pedra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tesoura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_papel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_papel1;
        private System.Windows.Forms.PictureBox pb_tesoura1;
        private System.Windows.Forms.PictureBox pb_pedra1;
        private System.Windows.Forms.RadioButton rb_pedra;
        private System.Windows.Forms.RadioButton rb_tesoura;
        private System.Windows.Forms.RadioButton rb_papel;
        private System.Windows.Forms.PictureBox pb_pedra2;
        private System.Windows.Forms.PictureBox pb_tesoura2;
        private System.Windows.Forms.PictureBox pb_papel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_vitorias;
        private System.Windows.Forms.Label lb_derrotas;
        private System.Windows.Forms.Label lb_empates;
        private System.Windows.Forms.Label label5;
    }
}

