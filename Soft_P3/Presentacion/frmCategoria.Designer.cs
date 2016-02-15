namespace Soft_P3.Presentacion
{
    partial class frmCategoria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(235, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 315);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Categorias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(13, 150);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 28);
            this.textBox1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID Categoria";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bell MT", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(57, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 42);
            this.label12.TabIndex = 33;
            this.label12.Text = "Categorias";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(165, 94);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "Buscar:";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold);
            this.textBox12.Location = new System.Drawing.Point(470, 88);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(220, 30);
            this.textBox12.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Cedula",
            "RNC"});
            this.comboBox1.Location = new System.Drawing.Point(255, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 32);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.Text = "Descripcion";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aqua;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(700, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 36);
            this.button5.TabIndex = 42;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(700, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 36);
            this.button4.TabIndex = 41;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(700, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 36);
            this.button3.TabIndex = 40;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(700, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 36);
            this.button2.TabIndex = 39;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Descripcion";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox9.Location = new System.Drawing.Point(13, 266);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(215, 34);
            this.textBox9.TabIndex = 37;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(855, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Name = "frmCategoria";
            this.Text = "Mantenimiento Categoria";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
    }
}