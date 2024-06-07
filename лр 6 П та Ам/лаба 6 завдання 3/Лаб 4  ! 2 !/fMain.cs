using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Лаб_3___2__;

namespace Лаб_4____2__
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvComp.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва комп'ютера";
            gvComp.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "os";
            column.Name = "операційна система";
            gvComp.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Virob";
            column.Name = "Виробник";
            gvComp.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Proc";
            column.Name = "процесор";
            gvComp.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Bios";
            column.Name = "версія біос";
            gvComp.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OperMemory";
            column.Name = "обсяг операційної пам'яті";
            column.Width = 80;
            gvComp.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Inch";
            column.Name = "дюйми";
            column.Width = 60;
            gvComp.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Overclocking";
            column.Name = "розгін процесора";
            column.Width = 60;
            gvComp.Columns.Add(column);

            bindSrcComp.Add(new Desktop("Вася266", "Крокодил", "Казах Абрамович", 123, 123, 123, true, false));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Comp comp = new Desktop();  // Або Laptop в залежності від потреби

            fComp ft = new fComp(comp);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcComp.Add(comp);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Comp comp = (Comp)bindSrcComp.List[bindSrcComp.Position];

            fComp ft = new fComp(comp);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcComp.List[bindSrcComp.Position] = comp;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcComp.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблюцю ? \n \nВсі данні будуть втрачені ", "Очищення данних ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcComp.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttomSize = 9 * btnAdd.Width + 3 * tsSeparator1.Width;
            btnExit.Margin = new Padding(Width - buttomSize, 0, 0, 0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void bindSrcComp_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void saveFileDialog_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void saveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);

                try
                {
                    foreach (Comp comp in bindSrcComp.List)
                    {
                        sw.Write(comp.Name + "\t" + comp.os + "\t" +
                        comp.Virob + "\t" + comp.Proc + "\t" +
                        comp.Bios + "\t" + comp.OperMemory + "\t" +
                        comp.Inch + "\t" + comp.Overclocking + "\t\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Сталась помилка: \n{0}", ex.Message),
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void fMain_Load_1(object sender, EventArgs e)
        {
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файли даних (*.towns)|*.towns | All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter bw = new BinaryWriter(saveFileDialog.OpenFile()))
                {
                    try
                    {
                        foreach (Comp comp in bindSrcComp.List)
                        {
                            bw.Write(comp.Name);
                            bw.Write(comp.os);
                            bw.Write(comp.Virob);
                            bw.Write(comp.Proc);
                            bw.Write(comp.Bios);
                            bw.Write(comp.OperMemory);
                            bw.Write(comp.Inch);
                            bw.Write(comp.Overclocking);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            StreamReader sr = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                    string s;

                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] splits = s.Split('\t');
                        Comp comp = new Desktop(splits[0], splits[1], splits[2],  // Або Laptop в залежності від потреби
                            int.Parse(splits[3]), double.Parse(splits[4]), double.Parse(splits[5]),
                            bool.Parse(splits[6]), bool.Parse(splits[7]));
                        bindSrcComp.Add(comp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Файли даних (*.towns)|*.towns|Усі файли (*.*)|*.*";

            openFileDialog.Title = "Прочитати дані у бінарному форматі";

            openFileDialog.InitialDirectory = Application.StartupPath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcComp.Clear();

                using (BinaryReader br = new BinaryReader(openFileDialog.OpenFile()))
                {
                    try
                    {
                        while (br.BaseStream.Position < br.BaseStream.Length)
                        {
                            Comp comp = new Desktop();  // Або Laptop в залежності від потреби

                            for (int i = 1; i <= 8; i++)
                            {
                                switch (i)
                                {
                                    case 1:
                                        comp.Name = br.ReadString();
                                        break;
                                    case 2:
                                        comp.os = br.ReadString();
                                        break;
                                    case 3:
                                        comp.Virob = br.ReadString();
                                        break;
                                    case 4:
                                        comp.Proc = br.ReadInt32();
                                        break;
                                    case 5:
                                        comp.Bios = br.ReadDouble();
                                        break;
                                    case 6:
                                        comp.OperMemory = br.ReadDouble();
                                        break;
                                    case 7:
                                        comp.Inch = br.ReadBoolean();
                                        break;
                                    case 8:
                                        comp.Overclocking = br.ReadBoolean();
                                        break;
                                }
                            }

                            bindSrcComp.Add(comp);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
