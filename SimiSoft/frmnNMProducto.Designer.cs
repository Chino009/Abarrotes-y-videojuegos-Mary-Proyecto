
namespace SimiSoft
{
    partial class frmNMProducto
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
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.lblMarca = new DevExpress.XtraEditors.LabelControl();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.lblPrecio = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.lblUnidad = new DevExpress.XtraEditors.LabelControl();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtUnidad = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBandera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(21, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(21, 283);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(33, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(21, 239);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(30, 13);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(21, 193);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(33, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(21, 146);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Location = new System.Drawing.Point(21, 101);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(74, 13);
            this.lblUnidad.TabIndex = 10;
            this.lblUnidad.Text = "Unidad Medida:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(21, 59);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(322, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(231, 146);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(108, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 143);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.MaxLength = 50;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(108, 232);
            this.txtStock.Name = "txtStock";
            this.txtStock.Properties.MaxLength = 4;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 5;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(108, 186);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.MaxLength = 7;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.EditValueChanged += new System.EventHandler(this.txtPrecio_EditValueChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(108, 280);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.MaxLength = 100;
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(108, 98);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Properties.MaxLength = 50;
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(108, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 150;
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // lblBandera
            // 
            this.lblBandera.AutoSize = true;
            this.lblBandera.Location = new System.Drawing.Point(333, 261);
            this.lblBandera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBandera.Name = "lblBandera";
            this.lblBandera.Size = new System.Drawing.Size(0, 13);
            this.lblBandera.TabIndex = 14;
            // 
            // frmNMProducto
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 322);
            this.Controls.Add(this.lblBandera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblId);
            this.IconOptions.Image = global::SimiSoft.Properties.Resources.icons8_nachos_16;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNMProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmnNMProducto";
            this.Load += new System.EventHandler(this.frmnNMProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.LabelControl lblMarca;
        private DevExpress.XtraEditors.LabelControl lblStock;
        private DevExpress.XtraEditors.LabelControl lblPrecio;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.LabelControl lblUnidad;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.TextEdit txtUnidad;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBandera;
    }
}