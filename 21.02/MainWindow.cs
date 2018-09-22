using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace _21._02
{
    
    public partial class MainWindow : Form
    {
        House house;
        AdvancedHouse advancedHouse;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void createHouse1_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int houseNum = int.Parse(inputHouseNum1_txt.Text);
                int flatsNum = int.Parse(inputFlatNum1_lbl.Text);
                int yearOfBuild = int.Parse(inputYearOfBuild1_txt.Text);
                if (yearOfBuild > 1600 && yearOfBuild < 2019)
                {
                    house = new House(houseNum, flatsNum, yearOfBuild);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                InterfaceUtils.Messages.ShowError("Проверьте корректность введенных данных");
            }

        }

        private void createHouse2_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int houseNum = int.Parse(inputHouseNum2_txt.Text);
                int flatsNum = int.Parse(inputFlatNum2_txt.Text);
                int yearOfBuild = int.Parse(inputYearOfBuild2_txt.Text);
                string location = inputLoc_txt.Text;
                bool convertedLoc;
                if ((yearOfBuild > 1600 && yearOfBuild < 2019) && (location == "центр" || location == "окраина"))
                {
                    if (location == "центр")
                    {
                        convertedLoc = true;
                    }
                    else
                    {
                        convertedLoc = false;
                    }
                    advancedHouse = new AdvancedHouse(houseNum, flatsNum, yearOfBuild, convertedLoc);

                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                InterfaceUtils.Messages.ShowError("Проверьте корректность введенных данных");
            }
        }

        private void calculateQ1_btn_Click(object sender, EventArgs e)
        {
            try
            {
                house.CalculateQuality();
                outoutInfo1_lbl.Text = house.OutputInfo();
            }
            catch
            {
                InterfaceUtils.Messages.ShowError("Проверьте корректность введенных данных");
            }
        }

        private void calculateQ2_btn_Click(object sender, EventArgs e)
        {
            try
            {
                advancedHouse.CalculateQuality();
                outputInfo2_txt.Text = advancedHouse.OutputInfo();
            }
            catch
            {
                InterfaceUtils.Messages.ShowError("Проверьте корректность введенных данных");
            }

        }

    }

}
