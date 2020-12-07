
namespace WpfApp2
{
    partial class Form3
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
            System.Windows.Forms.Label id_SkladLabel;
            System.Windows.Forms.Label optovay_cenaLabel;
            System.Windows.Forms.Label roznih_cenaLabel;
            System.Windows.Forms.Label ostatok_skladLabel;
            System.Windows.Forms.Label id_TovarLabel;
            System.Windows.Forms.Label id_KategoriaLabel;
            System.Windows.Forms.Label prihod_skladLabel;
            System.Windows.Forms.Label id_TipdocumentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.magazDataSet = new WpfApp2.MagazDataSet();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new WpfApp2.MagazDataSetTableAdapters.SkladTableAdapter();
            this.tableAdapterManager = new WpfApp2.MagazDataSetTableAdapters.TableAdapterManager();
            this.skladBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_SkladTextBox = new System.Windows.Forms.TextBox();
            this.optovay_cenaTextBox = new System.Windows.Forms.TextBox();
            this.roznih_cenaTextBox = new System.Windows.Forms.TextBox();
            this.ostatok_skladTextBox = new System.Windows.Forms.TextBox();
            this.id_TovarTextBox = new System.Windows.Forms.TextBox();
            this.id_KategoriaTextBox = new System.Windows.Forms.TextBox();
            this.prihod_skladTextBox = new System.Windows.Forms.TextBox();
            this.id_TipdocumentTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.skladBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_SkladLabel = new System.Windows.Forms.Label();
            optovay_cenaLabel = new System.Windows.Forms.Label();
            roznih_cenaLabel = new System.Windows.Forms.Label();
            ostatok_skladLabel = new System.Windows.Forms.Label();
            id_TovarLabel = new System.Windows.Forms.Label();
            id_KategoriaLabel = new System.Windows.Forms.Label();
            prihod_skladLabel = new System.Windows.Forms.Label();
            id_TipdocumentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.magazDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).BeginInit();
            this.skladBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // magazDataSet
            // 
            this.magazDataSet.DataSetName = "MagazDataSet";
            this.magazDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.magazDataSet;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckTableAdapter = null;
            this.tableAdapterManager.DomTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KategoriaTableAdapter = null;
            this.tableAdapterManager.MagazTableAdapter = null;
            this.tableAdapterManager.NakladnayaTableAdapter = null;
            this.tableAdapterManager.OrganizateTableAdapter = null;
            this.tableAdapterManager.OtchetTableAdapter = null;
            this.tableAdapterManager.PostavhikTableAdapter = null;
            this.tableAdapterManager.RaionTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.TipDocumentovTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WpfApp2.MagazDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // skladBindingNavigator
            // 
            this.skladBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.skladBindingNavigator.BindingSource = this.skladBindingSource;
            this.skladBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.skladBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.skladBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.skladBindingNavigatorSaveItem});
            this.skladBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.skladBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.skladBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.skladBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.skladBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.skladBindingNavigator.Name = "skladBindingNavigator";
            this.skladBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.skladBindingNavigator.Size = new System.Drawing.Size(382, 25);
            this.skladBindingNavigator.TabIndex = 0;
            this.skladBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // id_SkladLabel
            // 
            id_SkladLabel.AutoSize = true;
            id_SkladLabel.Location = new System.Drawing.Point(32, 82);
            id_SkladLabel.Name = "id_SkladLabel";
            id_SkladLabel.Size = new System.Drawing.Size(48, 13);
            id_SkladLabel.TabIndex = 1;
            id_SkladLabel.Text = "id Sklad:";
            // 
            // id_SkladTextBox
            // 
            this.id_SkladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_Sklad", true));
            this.id_SkladTextBox.Location = new System.Drawing.Point(121, 79);
            this.id_SkladTextBox.Name = "id_SkladTextBox";
            this.id_SkladTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_SkladTextBox.TabIndex = 2;
            // 
            // optovay_cenaLabel
            // 
            optovay_cenaLabel.AutoSize = true;
            optovay_cenaLabel.Location = new System.Drawing.Point(32, 108);
            optovay_cenaLabel.Name = "optovay_cenaLabel";
            optovay_cenaLabel.Size = new System.Drawing.Size(77, 13);
            optovay_cenaLabel.TabIndex = 3;
            optovay_cenaLabel.Text = "Optovay cena:";
            // 
            // optovay_cenaTextBox
            // 
            this.optovay_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Optovay_cena", true));
            this.optovay_cenaTextBox.Location = new System.Drawing.Point(121, 105);
            this.optovay_cenaTextBox.Name = "optovay_cenaTextBox";
            this.optovay_cenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.optovay_cenaTextBox.TabIndex = 4;
            // 
            // roznih_cenaLabel
            // 
            roznih_cenaLabel.AutoSize = true;
            roznih_cenaLabel.Location = new System.Drawing.Point(32, 134);
            roznih_cenaLabel.Name = "roznih_cenaLabel";
            roznih_cenaLabel.Size = new System.Drawing.Size(70, 13);
            roznih_cenaLabel.TabIndex = 5;
            roznih_cenaLabel.Text = "Roznih cena:";
            // 
            // roznih_cenaTextBox
            // 
            this.roznih_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Roznih_cena", true));
            this.roznih_cenaTextBox.Location = new System.Drawing.Point(121, 131);
            this.roznih_cenaTextBox.Name = "roznih_cenaTextBox";
            this.roznih_cenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.roznih_cenaTextBox.TabIndex = 6;
            // 
            // ostatok_skladLabel
            // 
            ostatok_skladLabel.AutoSize = true;
            ostatok_skladLabel.Location = new System.Drawing.Point(32, 160);
            ostatok_skladLabel.Name = "ostatok_skladLabel";
            ostatok_skladLabel.Size = new System.Drawing.Size(75, 13);
            ostatok_skladLabel.TabIndex = 7;
            ostatok_skladLabel.Text = "Ostatok sklad:";
            // 
            // ostatok_skladTextBox
            // 
            this.ostatok_skladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Ostatok_sklad", true));
            this.ostatok_skladTextBox.Location = new System.Drawing.Point(121, 157);
            this.ostatok_skladTextBox.Name = "ostatok_skladTextBox";
            this.ostatok_skladTextBox.Size = new System.Drawing.Size(100, 20);
            this.ostatok_skladTextBox.TabIndex = 8;
            // 
            // id_TovarLabel
            // 
            id_TovarLabel.AutoSize = true;
            id_TovarLabel.Location = new System.Drawing.Point(32, 186);
            id_TovarLabel.Name = "id_TovarLabel";
            id_TovarLabel.Size = new System.Drawing.Size(49, 13);
            id_TovarLabel.TabIndex = 9;
            id_TovarLabel.Text = "id Tovar:";
            // 
            // id_TovarTextBox
            // 
            this.id_TovarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_Tovar", true));
            this.id_TovarTextBox.Location = new System.Drawing.Point(121, 183);
            this.id_TovarTextBox.Name = "id_TovarTextBox";
            this.id_TovarTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_TovarTextBox.TabIndex = 10;
            // 
            // id_KategoriaLabel
            // 
            id_KategoriaLabel.AutoSize = true;
            id_KategoriaLabel.Location = new System.Drawing.Point(32, 212);
            id_KategoriaLabel.Name = "id_KategoriaLabel";
            id_KategoriaLabel.Size = new System.Drawing.Size(66, 13);
            id_KategoriaLabel.TabIndex = 11;
            id_KategoriaLabel.Text = "id Kategoria:";
            // 
            // id_KategoriaTextBox
            // 
            this.id_KategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_Kategoria", true));
            this.id_KategoriaTextBox.Location = new System.Drawing.Point(121, 209);
            this.id_KategoriaTextBox.Name = "id_KategoriaTextBox";
            this.id_KategoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_KategoriaTextBox.TabIndex = 12;
            // 
            // prihod_skladLabel
            // 
            prihod_skladLabel.AutoSize = true;
            prihod_skladLabel.Location = new System.Drawing.Point(32, 238);
            prihod_skladLabel.Name = "prihod_skladLabel";
            prihod_skladLabel.Size = new System.Drawing.Size(68, 13);
            prihod_skladLabel.TabIndex = 13;
            prihod_skladLabel.Text = "Prihod sklad:";
            // 
            // prihod_skladTextBox
            // 
            this.prihod_skladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Prihod_sklad", true));
            this.prihod_skladTextBox.Location = new System.Drawing.Point(121, 235);
            this.prihod_skladTextBox.Name = "prihod_skladTextBox";
            this.prihod_skladTextBox.Size = new System.Drawing.Size(100, 20);
            this.prihod_skladTextBox.TabIndex = 14;
            // 
            // id_TipdocumentLabel
            // 
            id_TipdocumentLabel.AutoSize = true;
            id_TipdocumentLabel.Location = new System.Drawing.Point(32, 264);
            id_TipdocumentLabel.Name = "id_TipdocumentLabel";
            id_TipdocumentLabel.Size = new System.Drawing.Size(83, 13);
            id_TipdocumentLabel.TabIndex = 15;
            id_TipdocumentLabel.Text = "id Tipdocument:";
            // 
            // id_TipdocumentTextBox
            // 
            this.id_TipdocumentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_Tipdocument", true));
            this.id_TipdocumentTextBox.Location = new System.Drawing.Point(121, 261);
            this.id_TipdocumentTextBox.Name = "id_TipdocumentTextBox";
            this.id_TipdocumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_TipdocumentTextBox.TabIndex = 16;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // skladBindingNavigatorSaveItem
            // 
            this.skladBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skladBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("skladBindingNavigatorSaveItem.Image")));
            this.skladBindingNavigatorSaveItem.Name = "skladBindingNavigatorSaveItem";
            this.skladBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.skladBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.skladBindingNavigatorSaveItem.Click += new System.EventHandler(this.skladBindingNavigatorSaveItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 323);
            this.Controls.Add(id_SkladLabel);
            this.Controls.Add(this.id_SkladTextBox);
            this.Controls.Add(optovay_cenaLabel);
            this.Controls.Add(this.optovay_cenaTextBox);
            this.Controls.Add(roznih_cenaLabel);
            this.Controls.Add(this.roznih_cenaTextBox);
            this.Controls.Add(ostatok_skladLabel);
            this.Controls.Add(this.ostatok_skladTextBox);
            this.Controls.Add(id_TovarLabel);
            this.Controls.Add(this.id_TovarTextBox);
            this.Controls.Add(id_KategoriaLabel);
            this.Controls.Add(this.id_KategoriaTextBox);
            this.Controls.Add(prihod_skladLabel);
            this.Controls.Add(this.prihod_skladTextBox);
            this.Controls.Add(id_TipdocumentLabel);
            this.Controls.Add(this.id_TipdocumentTextBox);
            this.Controls.Add(this.skladBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).EndInit();
            this.skladBindingNavigator.ResumeLayout(false);
            this.skladBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagazDataSet magazDataSet;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private MagazDataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private MagazDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator skladBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton skladBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_SkladTextBox;
        private System.Windows.Forms.TextBox optovay_cenaTextBox;
        private System.Windows.Forms.TextBox roznih_cenaTextBox;
        private System.Windows.Forms.TextBox ostatok_skladTextBox;
        private System.Windows.Forms.TextBox id_TovarTextBox;
        private System.Windows.Forms.TextBox id_KategoriaTextBox;
        private System.Windows.Forms.TextBox prihod_skladTextBox;
        private System.Windows.Forms.TextBox id_TipdocumentTextBox;
    }
}