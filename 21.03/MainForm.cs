using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib.TASK3;
using InterfaceUtils;

namespace _21._03
{
    public partial class MainForm : Form
    {
        List<IMusicInstrument> musicInstruments;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            musicInstruments = new List<IMusicInstrument>();
        }

        private void dataGridView_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateGuitar_btn_Click(object sender, EventArgs e)
        {
            string name = inputName_txt.Text;
            int price = int.Parse(inputPrice_txt.Text);
            string color = inputColor_txt.Text;
            int possibleLoudness = int.Parse(inputPossibleLoudness_txt.Text);
            IMusicInstrument guitar = new ElectroGuitar(name, price, color, possibleLoudness);
            musicInstruments.Add(guitar);
            DataGridUtils.GuitarToGrid(dataGridView_dgv, musicInstruments);
        }
    }
}
