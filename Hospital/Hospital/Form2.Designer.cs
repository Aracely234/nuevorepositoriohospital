﻿
namespace Hospital
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
            this.PDistancia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNoPseudoalatorio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumaNumeroGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbXo = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PDistancia
            // 
            this.PDistancia.Location = new System.Drawing.Point(155, 349);
            this.PDistancia.Name = "PDistancia";
            this.PDistancia.Size = new System.Drawing.Size(109, 40);
            this.PDistancia.TabIndex = 60;
            this.PDistancia.Text = "Prueba Distancia";
            this.PDistancia.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 59;
            this.button1.Text = "Prueba Promedios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Distribución normal:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "Promedio de los numeros pseodoaleatorios:";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label8.Location = new System.Drawing.Point(42, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Generador de Numeros Pseodoalarorios";
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(168, 181);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(108, 20);
            this.tbn.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label5.Location = new System.Drawing.Point(29, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Numeros a generar:";
            // 
            // btnNoPseudoalatorio
            // 
            this.btnNoPseudoalatorio.Location = new System.Drawing.Point(202, 139);
            this.btnNoPseudoalatorio.Name = "btnNoPseudoalatorio";
            this.btnNoPseudoalatorio.Size = new System.Drawing.Size(75, 23);
            this.btnNoPseudoalatorio.TabIndex = 49;
            this.btnNoPseudoalatorio.Text = "Generar";
            this.btnNoPseudoalatorio.UseVisualStyleBackColor = true;
            this.btnNoPseudoalatorio.Click += new System.EventHandler(this.btnNoPseudoalatorio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNumero,
            this.ColumaNumeroGenerado});
            this.dataGridView1.Location = new System.Drawing.Point(347, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(253, 449);
            this.dataGridView1.TabIndex = 48;
            // 
            // ColumnaNumero
            // 
            this.ColumnaNumero.HeaderText = "No.";
            this.ColumnaNumero.Name = "ColumnaNumero";
            // 
            // ColumaNumeroGenerado
            // 
            this.ColumaNumeroGenerado.HeaderText = "Numero Pseudoalatorio";
            this.ColumaNumeroGenerado.Name = "ColumaNumeroGenerado";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(73, 136);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(108, 20);
            this.tbM.TabIndex = 47;
            // 
            // tbXo
            // 
            this.tbXo.Location = new System.Drawing.Point(73, 110);
            this.tbXo.Name = "tbXo";
            this.tbXo.Size = new System.Drawing.Size(108, 20);
            this.tbXo.TabIndex = 46;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(73, 84);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(108, 20);
            this.tbC.TabIndex = 45;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(73, 58);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(108, 20);
            this.tbA.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Xo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "c:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "a:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 61;
            this.button2.Text = "Hospital";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PDistancia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNoPseudoalatorio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.tbXo);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PDistancia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNoPseudoalatorio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumaNumeroGenerado;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbXo;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}