using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceUtils;
using ClassLib;


namespace _21._01.ver2
{
    public partial class MainWindow : Form
    {
        Train train = new Train("Сапсан");
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DataGridUtils.InitGridForArr(dataGrid, 50, false, true, true, false, false);
            

        }

        private void addCarriage_btn_Click(object sender, EventArgs e)
        {   try
            {
                int carriageNumber = int.Parse(carrNumber_txt.Text);
                int passNumber = int.Parse(passNum_txt.Text);
                int luggAmount = int.Parse(luggAmount_txt.Text);
                int comfort = int.Parse(comfortLvl_txt.Text);
                if (comfort > 0 && comfort < 5)
                {
                    switch (comfort)
                    {
                        case 1:
                            EconomCarriage economCarriage = new EconomCarriage(carriageNumber, passNumber, luggAmount, comfort);
                            train.CarriagesConnected.Add(economCarriage);
                            break;
                        case 2:
                            MiddleCarriage middleCarriage = new MiddleCarriage(carriageNumber, passNumber, luggAmount, comfort);
                            train.CarriagesConnected.Add(middleCarriage);
                            break;
                        case 3:
                            ExpensiveCarriage expensiveCarriage = new ExpensiveCarriage(carriageNumber, passNumber, luggAmount, comfort);
                            train.CarriagesConnected.Add(expensiveCarriage);
                            break;
                        case 4:
                            LuxuryCarriage luxuryCarriage = new LuxuryCarriage(carriageNumber, passNumber, luggAmount, comfort);
                            train.CarriagesConnected.Add(luxuryCarriage);
                            break;
                    }
                    DataGridUtils.CarriageListToGrid(dataGrid, train.CarriagesConnected);
                    carrNumber_txt.Clear();
                    passNum_txt.Clear();
                    luggAmount_txt.Clear();
                    comfortLvl_txt.Clear();
                }
                else
                {
                    Messages.ShowError("Неправильно задан уровень комфорта!");
                }
            }
            catch(Exception ex)
            {
                Messages.ShowError("Проверьте правильность вводимых данных!");
            }
            
        }

        private void getAppropiateCarriages_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int minPassengers = int.Parse(minPassDiapason_txt.Text);
                int maxPassengers = int.Parse(maxPassDiapason_txt.Text);
                DataGridUtils.CarriageListToGrid(dataGrid, train.FindAppropiateCarriages(minPassengers, maxPassengers));
                minPassDiapason_txt.Clear();
                maxPassDiapason_txt.Clear();
            }
            catch(Exception ex)
            {
                Messages.ShowError("Проверьте правильность вводимых данных!");
            }
        }

        private void deleteCarriage_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int carriageNumber = int.Parse(numCarriageToDelete_txt.Text);
                train.DisconnectCarriage(carriageNumber);
                DataGridUtils.CarriageListToGrid(dataGrid, train.CarriagesConnected);
                numCarriageToDelete_txt.Clear();
            }
            catch(Exception ex)
            {
                Messages.ShowError("Проверьте правильность вводимых данных!");
            }
        }

        private void getPassNum_btn_Click(object sender, EventArgs e)
        {
            getPassengerNumber_lbl.Text = train.GetPassNumber().ToString();
        }

        private void getLuggAmount_btn_Click(object sender, EventArgs e)
        {
            getLuggAmount_lbl.Text = train.GetLuggAmount().ToString();
        }

        private void sortCarriages_btn_Click(object sender, EventArgs e)
        {
            train.ComfortSort();
            DataGridUtils.CarriageListToGrid(dataGrid, train.CarriagesConnected);
        }

        private void showCarriageList_btn_Click(object sender, EventArgs e)
        {
            DataGridUtils.CarriageListToGrid(dataGrid, train.CarriagesConnected);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
