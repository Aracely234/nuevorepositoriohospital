
namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tbnC = new System.Windows.Forms.TextBox();
            this.tbnB = new System.Windows.Forms.TextBox();
            this.tbnA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataserviciosofrece = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCOSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalServicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapersonas = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicioxpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.TextBox();
            this.txCostoOpera = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txingresototal = new System.Windows.Forms.TextBox();
            this.labelresultado = new System.Windows.Forms.Label();
            this.buDecision = new System.Windows.Forms.Button();
            this.btquitar2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataserviciosofrece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(6, 315);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 248);
            this.dataGridView2.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "i";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ri";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Pacientes";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbnC
            // 
            this.tbnC.Location = new System.Drawing.Point(353, 96);
            this.tbnC.Name = "tbnC";
            this.tbnC.Size = new System.Drawing.Size(52, 20);
            this.tbnC.TabIndex = 45;
            // 
            // tbnB
            // 
            this.tbnB.Location = new System.Drawing.Point(353, 74);
            this.tbnB.Name = "tbnB";
            this.tbnB.Size = new System.Drawing.Size(52, 20);
            this.tbnB.TabIndex = 44;
            // 
            // tbnA
            // 
            this.tbnA.Location = new System.Drawing.Point(353, 52);
            this.tbnA.Name = "tbnA";
            this.tbnA.Size = new System.Drawing.Size(52, 20);
            this.tbnA.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "a:";
            // 
            // dataserviciosofrece
            // 
            this.dataserviciosofrece.BackgroundColor = System.Drawing.Color.White;
            this.dataserviciosofrece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataserviciosofrece.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn4,
            this.CLI,
            this.CLS,
            this.Sigla,
            this.CCOSTO,
            this.TotalServicios,
            this.Ingresos});
            this.dataserviciosofrece.Location = new System.Drawing.Point(606, 12);
            this.dataserviciosofrece.Name = "dataserviciosofrece";
            this.dataserviciosofrece.Size = new System.Drawing.Size(666, 283);
            this.dataserviciosofrece.TabIndex = 58;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Servicios";
            this.Column5.Name = "Column5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // CLI
            // 
            this.CLI.HeaderText = "Limite Inferior";
            this.CLI.Name = "CLI";
            // 
            // CLS
            // 
            this.CLS.HeaderText = "Limite Superior";
            this.CLS.Name = "CLS";
            // 
            // Sigla
            // 
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.Name = "Sigla";
            // 
            // CCOSTO
            // 
            this.CCOSTO.HeaderText = "Costo";
            this.CCOSTO.Name = "CCOSTO";
            // 
            // TotalServicios
            // 
            this.TotalServicios.HeaderText = "Total Servicios";
            this.TotalServicios.Name = "TotalServicios";
            // 
            // Ingresos
            // 
            this.Ingresos.HeaderText = "Ingresos";
            this.Ingresos.Name = "Ingresos";
            // 
            // datapersonas
            // 
            this.datapersonas.BackgroundColor = System.Drawing.Color.White;
            this.datapersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datapersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column2,
            this.Servicioxpaciente,
            this.CostoPersona});
            this.datapersonas.Location = new System.Drawing.Point(831, 347);
            this.datapersonas.Name = "datapersonas";
            this.datapersonas.Size = new System.Drawing.Size(441, 248);
            this.datapersonas.TabIndex = 59;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "No.Personas";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero Pseudoalatorio";
            this.Column2.Name = "Column2";
            // 
            // Servicioxpaciente
            // 
            this.Servicioxpaciente.HeaderText = "Servicio";
            this.Servicioxpaciente.Name = "Servicioxpaciente";
            // 
            // CostoPersona
            // 
            this.CostoPersona.HeaderText = "Costo";
            this.CostoPersona.Name = "CostoPersona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ingresos Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Punto de cambio:";
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(416, 19);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(78, 20);
            this.pc.TabIndex = 46;
            // 
            // txCostoOpera
            // 
            this.txCostoOpera.Location = new System.Drawing.Point(420, 130);
            this.txCostoOpera.Name = "txCostoOpera";
            this.txCostoOpera.Size = new System.Drawing.Size(117, 20);
            this.txCostoOpera.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Costo de Operacion:";
            // 
            // txingresototal
            // 
            this.txingresototal.Location = new System.Drawing.Point(420, 156);
            this.txingresototal.Name = "txingresototal";
            this.txingresototal.Size = new System.Drawing.Size(100, 20);
            this.txingresototal.TabIndex = 63;
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.Location = new System.Drawing.Point(301, 216);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(0, 13);
            this.labelresultado.TabIndex = 64;
            // 
            // buDecision
            // 
            this.buDecision.Location = new System.Drawing.Point(312, 226);
            this.buDecision.Name = "buDecision";
            this.buDecision.Size = new System.Drawing.Size(75, 23);
            this.buDecision.TabIndex = 65;
            this.buDecision.Text = "Desicion";
            this.buDecision.UseVisualStyleBackColor = true;
            this.buDecision.Click += new System.EventHandler(this.buDecision_Click);
            // 
            // btquitar2
            // 
            this.btquitar2.Location = new System.Drawing.Point(313, 268);
            this.btquitar2.Name = "btquitar2";
            this.btquitar2.Size = new System.Drawing.Size(119, 23);
            this.btquitar2.TabIndex = 67;
            this.btquitar2.Text = "Quitar dos filas";
            this.btquitar2.UseVisualStyleBackColor = true;
            this.btquitar2.Click += new System.EventHandler(this.btquitar2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 629);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btquitar2);
            this.Controls.Add(this.buDecision);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.txingresototal);
            this.Controls.Add(this.txCostoOpera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datapersonas);
            this.Controls.Add(this.dataserviciosofrece);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.tbnC);
            this.Controls.Add(this.tbnB);
            this.Controls.Add(this.tbnA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataserviciosofrece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbnC;
        private System.Windows.Forms.TextBox tbnB;
        private System.Windows.Forms.TextBox tbnA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataserviciosofrece;
        private System.Windows.Forms.DataGridView datapersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCOSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingresos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicioxpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pc;
        private System.Windows.Forms.TextBox txCostoOpera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txingresototal;
        private System.Windows.Forms.Label labelresultado;
        private System.Windows.Forms.Button buDecision;
        private System.Windows.Forms.Button btquitar2;
        private System.Windows.Forms.Label label8;
    }
}

