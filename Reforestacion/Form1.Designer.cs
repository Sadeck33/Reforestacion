
namespace Reforestacion
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
            this.lblmuni = new System.Windows.Forms.Label();
            this.txtmuni = new System.Windows.Forms.TextBox();
            this.lblarbol = new System.Windows.Forms.Label();
            this.txtarbol = new System.Windows.Forms.TextBox();
            this.lblcanti = new System.Windows.Forms.Label();
            this.txtcanti = new System.Windows.Forms.TextBox();
            this.btnconsul = new System.Windows.Forms.Button();
            this.btnactu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clarbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcanti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnac = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdonar = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmuni
            // 
            this.lblmuni.AutoSize = true;
            this.lblmuni.Location = new System.Drawing.Point(44, 102);
            this.lblmuni.Name = "lblmuni";
            this.lblmuni.Size = new System.Drawing.Size(52, 13);
            this.lblmuni.TabIndex = 0;
            this.lblmuni.Text = "Municipio";
            // 
            // txtmuni
            // 
            this.txtmuni.Location = new System.Drawing.Point(103, 99);
            this.txtmuni.Name = "txtmuni";
            this.txtmuni.Size = new System.Drawing.Size(100, 20);
            this.txtmuni.TabIndex = 1;
            // 
            // lblarbol
            // 
            this.lblarbol.AutoSize = true;
            this.lblarbol.Location = new System.Drawing.Point(47, 188);
            this.lblarbol.Name = "lblarbol";
            this.lblarbol.Size = new System.Drawing.Size(31, 13);
            this.lblarbol.TabIndex = 2;
            this.lblarbol.Text = "Arbol";
            // 
            // txtarbol
            // 
            this.txtarbol.Location = new System.Drawing.Point(103, 185);
            this.txtarbol.Name = "txtarbol";
            this.txtarbol.Size = new System.Drawing.Size(100, 20);
            this.txtarbol.TabIndex = 3;
            // 
            // lblcanti
            // 
            this.lblcanti.AutoSize = true;
            this.lblcanti.Location = new System.Drawing.Point(47, 266);
            this.lblcanti.Name = "lblcanti";
            this.lblcanti.Size = new System.Drawing.Size(49, 13);
            this.lblcanti.TabIndex = 4;
            this.lblcanti.Text = "Cantidad";
            // 
            // txtcanti
            // 
            this.txtcanti.Location = new System.Drawing.Point(103, 266);
            this.txtcanti.Name = "txtcanti";
            this.txtcanti.Size = new System.Drawing.Size(100, 20);
            this.txtcanti.TabIndex = 5;
            // 
            // btnconsul
            // 
            this.btnconsul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnconsul.Location = new System.Drawing.Point(260, 69);
            this.btnconsul.Name = "btnconsul";
            this.btnconsul.Size = new System.Drawing.Size(75, 23);
            this.btnconsul.TabIndex = 6;
            this.btnconsul.Text = "Consultar";
            this.btnconsul.UseVisualStyleBackColor = false;
            this.btnconsul.Click += new System.EventHandler(this.btnconsul_Click);
            // 
            // btnactu
            // 
            this.btnactu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnactu.Location = new System.Drawing.Point(260, 124);
            this.btnactu.Name = "btnactu";
            this.btnactu.Size = new System.Drawing.Size(75, 23);
            this.btnactu.TabIndex = 7;
            this.btnactu.Text = "Agregar";
            this.btnactu.UseVisualStyleBackColor = false;
            this.btnactu.Click += new System.EventHandler(this.btnactu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clid,
            this.clmuni,
            this.clarbol,
            this.clcanti});
            this.dataGridView1.Location = new System.Drawing.Point(351, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 234);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clid
            // 
            this.clid.DataPropertyName = "id";
            this.clid.HeaderText = "ID";
            this.clid.Name = "clid";
            this.clid.ReadOnly = true;
            // 
            // clmuni
            // 
            this.clmuni.DataPropertyName = "nombre_mpio";
            this.clmuni.HeaderText = "Municipio";
            this.clmuni.Name = "clmuni";
            this.clmuni.ReadOnly = true;
            // 
            // clarbol
            // 
            this.clarbol.DataPropertyName = "nombre_arbol";
            this.clarbol.HeaderText = "Arbol";
            this.clarbol.Name = "clarbol";
            this.clarbol.ReadOnly = true;
            // 
            // clcanti
            // 
            this.clcanti.DataPropertyName = "cantidad";
            this.clcanti.HeaderText = "Cantidad";
            this.clcanti.Name = "clcanti";
            this.clcanti.ReadOnly = true;
            // 
            // txtbusca
            // 
            this.txtbusca.Location = new System.Drawing.Point(455, 26);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(155, 20);
            this.txtbusca.TabIndex = 10;
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por municipio:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(47, 26);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(103, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 13;
            // 
            // btnac
            // 
            this.btnac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnac.Location = new System.Drawing.Point(260, 183);
            this.btnac.Name = "btnac";
            this.btnac.Size = new System.Drawing.Size(75, 23);
            this.btnac.TabIndex = 14;
            this.btnac.Text = "Actualizar";
            this.btnac.UseVisualStyleBackColor = false;
            this.btnac.Click += new System.EventHandler(this.btnac_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnborrar.Location = new System.Drawing.Point(260, 241);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 15;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(224, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Donar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Arboles a donar";
            // 
            // txtdonar
            // 
            this.txtdonar.Location = new System.Drawing.Point(103, 370);
            this.txtdonar.Name = "txtdonar";
            this.txtdonar.Size = new System.Drawing.Size(100, 20);
            this.txtdonar.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(710, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Buscar por arbol:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtdonar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnac);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnactu);
            this.Controls.Add(this.btnconsul);
            this.Controls.Add(this.txtcanti);
            this.Controls.Add(this.lblcanti);
            this.Controls.Add(this.txtarbol);
            this.Controls.Add(this.lblarbol);
            this.Controls.Add(this.txtmuni);
            this.Controls.Add(this.lblmuni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Control de donación";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmuni;
        private System.Windows.Forms.TextBox txtmuni;
        private System.Windows.Forms.Label lblarbol;
        private System.Windows.Forms.TextBox txtarbol;
        private System.Windows.Forms.Label lblcanti;
        private System.Windows.Forms.TextBox txtcanti;
        private System.Windows.Forms.Button btnconsul;
        private System.Windows.Forms.Button btnactu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clarbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcanti;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnac;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdonar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

