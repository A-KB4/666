
namespace Лаб_4____2__
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromBinary = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.gvComp = new System.Windows.Forms.DataGridView();
            this.bindSrcComp = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcComp)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.saveFileDialog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.tsSeparator1,
            this.btnDel,
            this.btnClear,
            this.tsSeparator2,
            this.btnSaveAsText,
            this.btnSaveAsBinary,
            this.btnOpenFromText,
            this.btnOpenFromBinary,
            this.btnExit});
            this.saveFileDialog.Location = new System.Drawing.Point(0, 0);
            this.saveFileDialog.Name = "saveFileDialog";
            this.saveFileDialog.Size = new System.Drawing.Size(800, 27);
            this.saveFileDialog.TabIndex = 0;
            this.saveFileDialog.Text = "toolStrip1";
            this.saveFileDialog.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.saveFileDialog_ItemClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::Лаб_4____2__.Properties.Resources.плюс;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 24);
            this.btnAdd.Text = "Додати запис про комп\'ютер";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::Лаб_4____2__.Properties.Resources.редагування;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 24);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::Лаб_4____2__.Properties.Resources.мінус;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(29, 24);
            this.btnDel.Text = "Видалити запис ";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = global::Лаб_4____2__.Properties.Resources.удаліть;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(29, 24);
            this.btnClear.Text = "Очистити дані ";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = global::Лаб_4____2__.Properties.Resources.дискета;
            this.btnSaveAsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(29, 24);
            this.btnSaveAsText.Text = "toolStripButton1";
            this.btnSaveAsText.Click += new System.EventHandler(this.saveFileDialog_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = global::Лаб_4____2__.Properties.Resources.дискета_2;
            this.btnSaveAsBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(29, 24);
            this.btnSaveAsBinary.Text = "toolStripButton2";
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromText.Image = global::Лаб_4____2__.Properties.Resources.папка;
            this.btnOpenFromText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(29, 24);
            this.btnOpenFromText.Text = "toolStripButton3";
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromBinary.Image = global::Лаб_4____2__.Properties.Resources.папка_2;
            this.btnOpenFromBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            this.btnOpenFromBinary.Size = new System.Drawing.Size(29, 24);
            this.btnOpenFromBinary.Text = "toolStripButton4";
            this.btnOpenFromBinary.Click += new System.EventHandler(this.btnOpenFromBinary_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::Лаб_4____2__.Properties.Resources.вихід;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 24);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvComp
            // 
            this.gvComp.AllowUserToAddRows = false;
            this.gvComp.AllowUserToDeleteRows = false;
            this.gvComp.AutoGenerateColumns = false;
            this.gvComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvComp.DataSource = this.bindSrcComp;
            this.gvComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvComp.Location = new System.Drawing.Point(0, 27);
            this.gvComp.Name = "gvComp";
            this.gvComp.ReadOnly = true;
            this.gvComp.RowHeadersWidth = 51;
            this.gvComp.RowTemplate.Height = 24;
            this.gvComp.Size = new System.Drawing.Size(800, 423);
            this.gvComp.TabIndex = 1;
            // 
            // bindSrcComp
            // 
            this.bindSrcComp.CurrentChanged += new System.EventHandler(this.bindSrcComp_CurrentChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvComp);
            this.Controls.Add(this.saveFileDialog);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота 4 ";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.saveFileDialog.ResumeLayout(false);
            this.saveFileDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip saveFileDialog;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.BindingSource bindSrcComp;
        private System.Windows.Forms.DataGridView gvComp;
        private System.Windows.Forms.ToolStripButton btnSaveAsText;
        private System.Windows.Forms.ToolStripButton btnSaveAsBinary;
        private System.Windows.Forms.ToolStripButton btnOpenFromText;
        private System.Windows.Forms.ToolStripButton btnOpenFromBinary;
    }
}