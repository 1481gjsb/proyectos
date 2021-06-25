namespace win.proyecto
{
    partial class Formant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formant));
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label idLabel;
            this.mantenimientoBL_manteniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoBL_manteniBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenimientoBL_manteniBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_manteniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_manteniBindingNavigator)).BeginInit();
            this.mantenimientoBL_manteniBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mantenimientoBL_manteniBindingSource
            // 
            this.mantenimientoBL_manteniBindingSource.DataSource = typeof(BL.proyecto.mantenimientoBL.manteni);
            // 
            // mantenimientoBL_manteniBindingNavigator
            // 
            this.mantenimientoBL_manteniBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mantenimientoBL_manteniBindingNavigator.BindingSource = this.mantenimientoBL_manteniBindingSource;
            this.mantenimientoBL_manteniBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mantenimientoBL_manteniBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mantenimientoBL_manteniBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mantenimientoBL_manteniBindingNavigatorSaveItem});
            this.mantenimientoBL_manteniBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mantenimientoBL_manteniBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mantenimientoBL_manteniBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mantenimientoBL_manteniBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mantenimientoBL_manteniBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mantenimientoBL_manteniBindingNavigator.Name = "mantenimientoBL_manteniBindingNavigator";
            this.mantenimientoBL_manteniBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mantenimientoBL_manteniBindingNavigator.Size = new System.Drawing.Size(592, 25);
            this.mantenimientoBL_manteniBindingNavigator.TabIndex = 0;
            this.mantenimientoBL_manteniBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mantenimientoBL_manteniBindingNavigatorSaveItem
            // 
            this.mantenimientoBL_manteniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mantenimientoBL_manteniBindingNavigatorSaveItem.Enabled = false;
            this.mantenimientoBL_manteniBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoBL_manteniBindingNavigatorSaveItem.Image")));
            this.mantenimientoBL_manteniBindingNavigatorSaveItem.Name = "mantenimientoBL_manteniBindingNavigatorSaveItem";
            this.mantenimientoBL_manteniBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mantenimientoBL_manteniBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(146, 225);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(39, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "activo:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mantenimientoBL_manteniBindingSource, "activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(216, 220);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new System.Drawing.Point(146, 139);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(32, 13);
            areaLabel.TabIndex = 3;
            areaLabel.Text = "Area:";
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_manteniBindingSource, "Area", true));
            this.areaTextBox.Location = new System.Drawing.Point(216, 136);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(192, 20);
            this.areaTextBox.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(146, 96);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_manteniBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(216, 93);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(192, 20);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(146, 182);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 7;
            horaLabel.Text = "Hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_manteniBindingSource, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(216, 179);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(192, 20);
            this.horaTextBox.TabIndex = 8;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(146, 55);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 9;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBL_manteniBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(216, 52);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(192, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // Formant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 345);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.mantenimientoBL_manteniBindingNavigator);
            this.Name = "Formant";
            this.Text = "Formant";
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_manteniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBL_manteniBindingNavigator)).EndInit();
            this.mantenimientoBL_manteniBindingNavigator.ResumeLayout(false);
            this.mantenimientoBL_manteniBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mantenimientoBL_manteniBindingSource;
        private System.Windows.Forms.BindingNavigator mantenimientoBL_manteniBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mantenimientoBL_manteniBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}