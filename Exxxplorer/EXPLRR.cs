using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace Exxxplorer
{
    public partial class Explrr : Form
    {
        public Explrr()
        {
            InitializeComponent();
        }
        Stack<string> StackOfDirs = new Stack<string>();
        private void Explrr_Load(object sender, EventArgs e)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drivers)
                DRIVERS_OF_COMP.Rows.Add(drive);
            DRIVERS_OF_COMP.ClearSelection();
            DRIVERS_OF_COMP.SelectionChanged += new System.EventHandler(this.DRIVERS_OF_COMP_SelectionChanged);
        }
        private void UpdateData(string Directry)
        {
            if (StackOfDirs.Count <= 1) StepBack.Enabled = false;
            else StepBack.Enabled = true;
            try { Directory.SetCurrentDirectory(Directry); }
            catch
            {
                CurrentPick.Text = StackOfDirs.Pop();
                MessageBox.Show("Отказано в доступе, т.к. я (разработчик) инвалид (на самом деле хз как получить доступ к папке такой)");
                return;
            }
            DataOfDir.Rows.Clear();
            var directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
            DirectoryInfo dir;
            foreach (string str in directories)
            {
                int n = DataOfDir.Rows.Add();
                DataOfDir.Rows[n].Cells[0].Value = NameFileOrDir(str);
                DataOfDir.Rows[n].Cells[1].Value = "Папка с файлами";
                dir = new DirectoryInfo(str);
                try { DataOfDir.Rows[n].Cells[2].Value = DirSize(dir); }
                catch { DataOfDir.Rows[n].Cells[2].Value = "Отказано в доступе"; continue; }
                DataOfDir.Rows[n].Cells[2].Value = Math.Round(double.Parse(DataOfDir.Rows[n].Cells[2].Value.ToString()) / 1048576, 2);
                DataOfDir.Rows[n].Cells[2].Value += " мб";
            }
            var files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string str in files)
            {
                int n = DataOfDir.Rows.Add();
                FileInfo file = new FileInfo(NameFileOrDir(str));
                DataOfDir.Rows[n].Cells[0].Value = file.Name;
                DataOfDir.Rows[n].Cells[1].Value = ExtensionLogicName(file.Extension);
                DataOfDir.Rows[n].Cells[2].Value = Math.Round((double)file.Length / 1048576, 2);
            }
        }
        private void DRIVERS_OF_COMP_SelectionChanged(object sender, EventArgs e)
        {
            StackOfDirs.Clear();
            StackOfDirs.Push(DRIVERS_OF_COMP.CurrentRow.Cells[0].Value.ToString());
            CurrentPick.Text = DRIVERS_OF_COMP.CurrentRow.Cells[0].Value.ToString();
            UpdateData(CurrentPick.Text);
        }
        public long DirSize(DirectoryInfo dir)
        {
            try
            {
                long Size = 0;
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo fi in files)
                {
                    Size += fi.Length;
                }
                DirectoryInfo[] dis = dir.GetDirectories();
                foreach (DirectoryInfo dInf in dis)
                {
                    Size += DirSize(dInf);
                }
                return Size;
            }
            catch { throw new Exception(); }
        }
        private static string NameFileOrDir(string str)
        {
            string result = null;
            int i = str.Length - 1;
            while (str[i--] != (char)92) ;
            i += 2;
            for (int q = i; q < str.Length; q++)
                result += str[q];
            return result;
        }
        private string ExtensionLogicName(string str)
        {
            switch (str)
            {
                case ".docx":
                    return "Документ Microsoft Word";
                case ".txt":
                    return "Текстовый документ";
                case ".png":
                case ".jpg":
                case ".ico":
                case ".gif":
                case ".tif":
                    return "Картиночка";
                default:
                    return "Extension";
            }
        }

        private void StepBack_Click(object sender, EventArgs e)
        {
            CurrentPick.Text = StackOfDirs.Pop();
            UpdateData(CurrentPick.Text);
        }

        private void DataOfDir_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StackOfDirs.Push(CurrentPick.Text);
            CurrentPick.Text += DataOfDir.CurrentRow.Cells[0].Value.ToString() + ((char)92).ToString();
            UpdateData(CurrentPick.Text);
        }

        private void CurrentPick_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.F10 != e.KeyCode) return;
            if (!Directory.Exists(CurrentPick.Text))
            {
                MessageBox.Show("Такого пути нет, лашара, ГЫГЫГЫГЫГЫГЫГыыыыыыыыыыыыыыыыыыыыыыыыыыыы");
                return;
            }
            UpdateData(CurrentPick.Text);
        }

        private void EXTNSION_SEARCH_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.F10 != e.KeyCode || DataOfDir.RowCount == 0) return;
            for(int i = 0; i < DataOfDir.RowCount; i++)
            {
                FileInfo file = new FileInfo(NameFileOrDir(CurrentPick.Text + DataOfDir.Rows[i].Cells[0].Value.ToString()));
                if (file.Extension != EXTNSION_SEARCH.Text) DataOfDir.Rows[i].Visible = false;
            }
        }
    }
}