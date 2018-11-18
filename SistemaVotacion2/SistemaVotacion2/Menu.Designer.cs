namespace SistemaVotacion2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            System.Windows.Forms.Label codFacLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaCreaLabel;
            System.Windows.Forms.Label descripcion_Label;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bd_unaulavotaDataSet = new SistemaVotacion2.bd_unaulavotaDataSet();
            this.facultadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultadTableAdapter = new SistemaVotacion2.bd_unaulavotaDataSetTableAdapters.facultadTableAdapter();
            this.tableAdapterManager = new SistemaVotacion2.bd_unaulavotaDataSetTableAdapters.TableAdapterManager();
            this.facultadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.facultadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codFacTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcion_TextBox = new System.Windows.Forms.TextBox();
            this.facultadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codFacLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaCreaLabel = new System.Windows.Forms.Label();
            descripcion_Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_unaulavotaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadBindingNavigator)).BeginInit();
            this.facultadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.facultadBindingNavigator);
            this.tabPage1.Controls.Add(this.facultadDataGridView);
            this.tabPage1.Controls.Add(codFacLabel);
            this.tabPage1.Controls.Add(this.codFacTextBox);
            this.tabPage1.Controls.Add(nombreLabel);
            this.tabPage1.Controls.Add(this.nombreTextBox);
            this.tabPage1.Controls.Add(fechaCreaLabel);
            this.tabPage1.Controls.Add(this.fechaCreaDateTimePicker);
            this.tabPage1.Controls.Add(descripcion_Label);
            this.tabPage1.Controls.Add(this.descripcion_TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(237, 93);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bd_unaulavotaDataSet
            // 
            this.bd_unaulavotaDataSet.DataSetName = "bd_unaulavotaDataSet";
            this.bd_unaulavotaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultadBindingSource
            // 
            this.facultadBindingSource.DataMember = "facultad";
            this.facultadBindingSource.DataSource = this.bd_unaulavotaDataSet;
            // 
            // facultadTableAdapter
            // 
            this.facultadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.candidatoTableAdapter = null;
            this.tableAdapterManager.facultadTableAdapter = this.facultadTableAdapter;
            this.tableAdapterManager.pro_acadTableAdapter = null;
            this.tableAdapterManager.resultadoTableAdapter = null;
            this.tableAdapterManager.rolTableAdapter = null;
            this.tableAdapterManager.targetonTableAdapter = null;
            this.tableAdapterManager.tipoConsejoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaVotacion2.bd_unaulavotaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.votanteTableAdapter = null;
            // 
            // facultadBindingNavigator
            // 
            this.facultadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facultadBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.facultadBindingNavigator.BindingSource = this.facultadBindingSource;
            this.facultadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facultadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facultadBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.facultadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.facultadBindingNavigatorSaveItem});
            this.facultadBindingNavigator.Location = new System.Drawing.Point(98, 64);
            this.facultadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facultadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facultadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facultadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facultadBindingNavigator.Name = "facultadBindingNavigator";
            this.facultadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facultadBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.facultadBindingNavigator.TabIndex = 1;
            this.facultadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // facultadBindingNavigatorSaveItem
            // 
            this.facultadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facultadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facultadBindingNavigatorSaveItem.Image")));
            this.facultadBindingNavigatorSaveItem.Name = "facultadBindingNavigatorSaveItem";
            this.facultadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.facultadBindingNavigatorSaveItem.Text = "Guardar datos";
            this.facultadBindingNavigatorSaveItem.Click += new System.EventHandler(this.facultadBindingNavigatorSaveItem_Click);
            // 
            // codFacLabel
            // 
            codFacLabel.AutoSize = true;
            codFacLabel.Location = new System.Drawing.Point(116, 189);
            codFacLabel.Name = "codFacLabel";
            codFacLabel.Size = new System.Drawing.Size(49, 13);
            codFacLabel.TabIndex = 0;
            codFacLabel.Text = "cod Fac:";
            // 
            // codFacTextBox
            // 
            this.codFacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadBindingSource, "codFac", true));
            this.codFacTextBox.Location = new System.Drawing.Point(191, 186);
            this.codFacTextBox.Name = "codFacTextBox";
            this.codFacTextBox.Size = new System.Drawing.Size(200, 20);
            this.codFacTextBox.TabIndex = 1;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(116, 215);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(191, 212);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // fechaCreaLabel
            // 
            fechaCreaLabel.AutoSize = true;
            fechaCreaLabel.Location = new System.Drawing.Point(116, 242);
            fechaCreaLabel.Name = "fechaCreaLabel";
            fechaCreaLabel.Size = new System.Drawing.Size(65, 13);
            fechaCreaLabel.TabIndex = 4;
            fechaCreaLabel.Text = "Fecha Crea:";
            // 
            // fechaCreaDateTimePicker
            // 
            this.fechaCreaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facultadBindingSource, "FechaCrea", true));
            this.fechaCreaDateTimePicker.Location = new System.Drawing.Point(191, 238);
            this.fechaCreaDateTimePicker.Name = "fechaCreaDateTimePicker";
            this.fechaCreaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaCreaDateTimePicker.TabIndex = 5;
            // 
            // descripcion_Label
            // 
            descripcion_Label.AutoSize = true;
            descripcion_Label.Location = new System.Drawing.Point(116, 267);
            descripcion_Label.Name = "descripcion_Label";
            descripcion_Label.Size = new System.Drawing.Size(69, 13);
            descripcion_Label.TabIndex = 6;
            descripcion_Label.Text = "Descripcion :";
            // 
            // descripcion_TextBox
            // 
            this.descripcion_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadBindingSource, "Descripcion ", true));
            this.descripcion_TextBox.Location = new System.Drawing.Point(191, 264);
            this.descripcion_TextBox.Name = "descripcion_TextBox";
            this.descripcion_TextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcion_TextBox.TabIndex = 7;
            // 
            // facultadDataGridView
            // 
            this.facultadDataGridView.AutoGenerateColumns = false;
            this.facultadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.facultadDataGridView.DataSource = this.facultadBindingSource;
            this.facultadDataGridView.Location = new System.Drawing.Point(615, 169);
            this.facultadDataGridView.Name = "facultadDataGridView";
            this.facultadDataGridView.Size = new System.Drawing.Size(444, 225);
            this.facultadDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codFac";
            this.dataGridViewTextBoxColumn1.HeaderText = "codFac";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaCrea";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaCrea";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion ";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_unaulavotaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadBindingNavigator)).EndInit();
            this.facultadBindingNavigator.ResumeLayout(false);
            this.facultadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultadDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private bd_unaulavotaDataSet bd_unaulavotaDataSet;
        private System.Windows.Forms.BindingSource facultadBindingSource;
        private bd_unaulavotaDataSetTableAdapters.facultadTableAdapter facultadTableAdapter;
        private bd_unaulavotaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facultadBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton facultadBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView facultadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox codFacTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreaDateTimePicker;
        private System.Windows.Forms.TextBox descripcion_TextBox;
    }
}