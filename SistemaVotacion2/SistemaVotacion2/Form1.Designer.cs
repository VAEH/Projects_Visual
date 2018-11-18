namespace SistemaVotacion2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.bd_unaulavotaDataSet = new SistemaVotacion2.bd_unaulavotaDataSet();
            this.candidatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatoTableAdapter = new SistemaVotacion2.bd_unaulavotaDataSetTableAdapters.candidatoTableAdapter();
            this.tableAdapterManager = new SistemaVotacion2.bd_unaulavotaDataSetTableAdapters.TableAdapterManager();
            this.pro_acadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pro_acadTableAdapter = new SistemaVotacion2.bd_unaulavotaDataSetTableAdapters.pro_acadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bd_unaulavotaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_acadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bd_unaulavotaDataSet
            // 
            this.bd_unaulavotaDataSet.DataSetName = "bd_unaulavotaDataSet";
            this.bd_unaulavotaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatoBindingSource
            // 
            this.candidatoBindingSource.DataMember = "candidato";
            this.candidatoBindingSource.DataSource = this.bd_unaulavotaDataSet;
            // 
            // candidatoTableAdapter
            // 
            this.candidatoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.candidatoTableAdapter = this.candidatoTableAdapter;
            this.tableAdapterManager.facultadTableAdapter = null;
            this.tableAdapterManager.pro_acadTableAdapter = this.pro_acadTableAdapter;
            this.tableAdapterManager.resultadoTableAdapter = null;
            this.tableAdapterManager.rolTableAdapter = null;
            this.tableAdapterManager.targetonTableAdapter = null;
            this.tableAdapterManager.tipoConsejoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaVotacion2.bd_unaulavotaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.votanteTableAdapter = null;
            // 
            // pro_acadBindingSource
            // 
            this.pro_acadBindingSource.DataMember = "pro_acad";
            this.pro_acadBindingSource.DataSource = this.bd_unaulavotaDataSet;
            // 
            // pro_acadTableAdapter
            // 
            this.pro_acadTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 354);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_unaulavotaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_acadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private bd_unaulavotaDataSet bd_unaulavotaDataSet;
        private System.Windows.Forms.BindingSource candidatoBindingSource;
        private bd_unaulavotaDataSetTableAdapters.candidatoTableAdapter candidatoTableAdapter;
        private bd_unaulavotaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bd_unaulavotaDataSetTableAdapters.pro_acadTableAdapter pro_acadTableAdapter;
        private System.Windows.Forms.BindingSource pro_acadBindingSource;
    }
}

