namespace GeometryVolumeCalculator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPyramidBase;
        private System.Windows.Forms.TextBox txtPyramidHeight;
        private System.Windows.Forms.TextBox txtSphereRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPyramidVolume;
        private System.Windows.Forms.Label lblSphereVolume;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPyramidBase = new System.Windows.Forms.TextBox();
            this.txtPyramidHeight = new System.Windows.Forms.TextBox();
            this.txtSphereRadius = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPyramidVolume = new System.Windows.Forms.Label();
            this.lblSphereVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtPyramidBase
            this.txtPyramidBase.Location = new System.Drawing.Point(150, 10);
            this.txtPyramidBase.Name = "txtPyramidBase";
            this.txtPyramidBase.Size = new System.Drawing.Size(100, 20);
            this.txtPyramidBase.TabIndex = 0;

            // txtPyramidHeight
            this.txtPyramidHeight.Location = new System.Drawing.Point(150, 40);
            this.txtPyramidHeight.Name = "txtPyramidHeight";
            this.txtPyramidHeight.Size = new System.Drawing.Size(100, 20);
            this.txtPyramidHeight.TabIndex = 1;

            // txtSphereRadius
            this.txtSphereRadius.Location = new System.Drawing.Point(150, 70);
            this.txtSphereRadius.Name = "txtSphereRadius";
            this.txtSphereRadius.Size = new System.Drawing.Size(100, 20);
            this.txtSphereRadius.TabIndex = 2;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(150, 100);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblPyramidVolume
            this.lblPyramidVolume.AutoSize = true;
            this.lblPyramidVolume.Location = new System.Drawing.Point(150, 130);
            this.lblPyramidVolume.Name = "lblPyramidVolume";
            this.lblPyramidVolume.Size = new System.Drawing.Size(85, 13);
            this.lblPyramidVolume.TabIndex = 4;
            this.lblPyramidVolume.Text = "Pyramid Volume:";

            // lblSphereVolume
            this.lblSphereVolume.AutoSize = true;
            this.lblSphereVolume.Location = new System.Drawing.Point(150, 160);
            this.lblSphereVolume.Name = "lblSphereVolume";
            this.lblSphereVolume.Size = new System.Drawing.Size(79, 13);
            this.lblSphereVolume.TabIndex = 5;
            this.lblSphereVolume.Text = "Sphere Volume:";

            // MainForm
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPyramidVolume);
            this.Controls.Add(this.lblSphereVolume);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSphereRadius);
            this.Controls.Add(this.txtPyramidHeight);
            this.Controls.Add(this.txtPyramidBase);
            this.Name = "MainForm";
            this.Text = "Volume Calculator";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }   
    }
}
