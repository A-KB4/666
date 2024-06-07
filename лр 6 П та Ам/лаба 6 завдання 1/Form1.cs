    using System;
    using System.Windows.Forms;

    namespace GeometryVolumeCalculator
    {
        public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
            }

            private void btnCalculate_Click(object sender, EventArgs e)
            {
                try
                {
                    double a = double.Parse(txtPyramidBase.Text);
                    double h = double.Parse(txtPyramidHeight.Text);
                    double r = double.Parse(txtSphereRadius.Text);

                    Pyramid pyramid = new Pyramid(a, h);
                    Sphere sphere = new Sphere(r);

                    lblPyramidVolume.Text = "Pyramid Volume: " + pyramid.GetVolume();
                    lblSphereVolume.Text = "Sphere Volume: " + sphere.GetVolume();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

