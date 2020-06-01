namespace Laboratorio08
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RecExistentesButton = new System.Windows.Forms.Button();
            this.RestauranteExistenteButton = new System.Windows.Forms.Button();
            this.TiendasExistentesButton = new System.Windows.Forms.Button();
            this.CinesRich = new System.Windows.Forms.RichTextBox();
            this.RecRich = new System.Windows.Forms.RichTextBox();
            this.RestRich = new System.Windows.Forms.RichTextBox();
            this.TiendasRich = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CinesExistentesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.RecExistentesButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.RestauranteExistenteButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TiendasExistentesButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CinesRich, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RecRich, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.RestRich, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TiendasRich, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CinesExistentesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RecExistentesButton
            // 
            this.RecExistentesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RecExistentesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecExistentesButton.Location = new System.Drawing.Point(603, 3);
            this.RecExistentesButton.Name = "RecExistentesButton";
            this.RecExistentesButton.Size = new System.Drawing.Size(194, 106);
            this.RecExistentesButton.TabIndex = 14;
            this.RecExistentesButton.Text = "CENTROS RECREACIONALES EXISTENTES";
            this.RecExistentesButton.UseVisualStyleBackColor = false;
            this.RecExistentesButton.Click += new System.EventHandler(this.RecExistentesButton_Click);
            // 
            // RestauranteExistenteButton
            // 
            this.RestauranteExistenteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RestauranteExistenteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestauranteExistenteButton.Location = new System.Drawing.Point(403, 3);
            this.RestauranteExistenteButton.Name = "RestauranteExistenteButton";
            this.RestauranteExistenteButton.Size = new System.Drawing.Size(194, 106);
            this.RestauranteExistenteButton.TabIndex = 13;
            this.RestauranteExistenteButton.Text = "RESTAURANTES EXISTENTES";
            this.RestauranteExistenteButton.UseVisualStyleBackColor = false;
            this.RestauranteExistenteButton.Click += new System.EventHandler(this.RestauranteExistenteButton_Click);
            // 
            // TiendasExistentesButton
            // 
            this.TiendasExistentesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TiendasExistentesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TiendasExistentesButton.Location = new System.Drawing.Point(3, 3);
            this.TiendasExistentesButton.Name = "TiendasExistentesButton";
            this.TiendasExistentesButton.Size = new System.Drawing.Size(194, 106);
            this.TiendasExistentesButton.TabIndex = 12;
            this.TiendasExistentesButton.Text = "TIENDAS EXISTENTES";
            this.TiendasExistentesButton.UseVisualStyleBackColor = false;
            this.TiendasExistentesButton.Click += new System.EventHandler(this.TiendasExistentesButton_Click);
            // 
            // CinesRich
            // 
            this.CinesRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CinesRich.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinesRich.Location = new System.Drawing.Point(203, 115);
            this.CinesRich.Name = "CinesRich";
            this.CinesRich.ReadOnly = true;
            this.CinesRich.Size = new System.Drawing.Size(194, 219);
            this.CinesRich.TabIndex = 9;
            this.CinesRich.Text = "";
            // 
            // RecRich
            // 
            this.RecRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecRich.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecRich.Location = new System.Drawing.Point(603, 115);
            this.RecRich.Name = "RecRich";
            this.RecRich.ReadOnly = true;
            this.RecRich.Size = new System.Drawing.Size(194, 219);
            this.RecRich.TabIndex = 7;
            this.RecRich.Text = "";
            // 
            // RestRich
            // 
            this.RestRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestRich.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestRich.Location = new System.Drawing.Point(403, 115);
            this.RestRich.Name = "RestRich";
            this.RestRich.ReadOnly = true;
            this.RestRich.Size = new System.Drawing.Size(194, 219);
            this.RestRich.TabIndex = 6;
            this.RestRich.Text = "";
            // 
            // TiendasRich
            // 
            this.TiendasRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TiendasRich.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiendasRich.Location = new System.Drawing.Point(3, 115);
            this.TiendasRich.Name = "TiendasRich";
            this.TiendasRich.ReadOnly = true;
            this.TiendasRich.Size = new System.Drawing.Size(194, 219);
            this.TiendasRich.TabIndex = 4;
            this.TiendasRich.Text = "";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(203, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 107);
            this.button1.TabIndex = 8;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CinesExistentesButton
            // 
            this.CinesExistentesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CinesExistentesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CinesExistentesButton.Location = new System.Drawing.Point(203, 3);
            this.CinesExistentesButton.Name = "CinesExistentesButton";
            this.CinesExistentesButton.Size = new System.Drawing.Size(194, 106);
            this.CinesExistentesButton.TabIndex = 10;
            this.CinesExistentesButton.Text = "CINES EXISTENTES";
            this.CinesExistentesButton.UseVisualStyleBackColor = false;
            this.CinesExistentesButton.Click += new System.EventHandler(this.CinesExistentesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(403, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 113);
            this.label2.TabIndex = 11;
            this.label2.Text = "PRESIONE EL BOTON DE LOS LOCALES QUE DESEE VER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox RecRich;
        private System.Windows.Forms.RichTextBox RestRich;
        private System.Windows.Forms.RichTextBox TiendasRich;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox CinesRich;
        private System.Windows.Forms.Button CinesExistentesButton;
        private System.Windows.Forms.Button TiendasExistentesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RecExistentesButton;
        private System.Windows.Forms.Button RestauranteExistenteButton;
    }
}