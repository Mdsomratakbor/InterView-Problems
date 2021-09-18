using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShip
{
    public partial class CargoShip : Form
    {
        public CargoShip()
        {
            InitializeComponent();
        }

        private void NewBoat_Click(object sender, EventArgs e)
        {
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargoShip));
            //this.loadSliderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadSliderPanel.BackgroundImage")));
            PanelShowBasedOnCondition(false, false, false, false);
            this.CurrentLoad.Visible = false;
            this.Capacity.Visible = false;
            this.Car.Value = 0;
            this.Truck.Value = 0;
            this.MotorCycle.Value = 0;
            this.TrainCar.Value = 0;
            this.motorCycleCount.Text = "0";
            this.truckCount.Text = "0";
            this.carCount.Text = "0";
            this.trainCarCount.Text = "0";
            AlertBox.BackColor = Color.Gray;
        }

        private void MotorCycle_Scroll(object sender, EventArgs e)
        {

           this.motorCycleCount.Text = this.MotorCycle.Value.ToString();
            PanelShowBasedOnCondition(true, false, false, false);
            this.motorCyclePanel.Location = new Point(118, 80);
            CurrentTotalLoad();
        }

        private void Truck_Scroll(object sender, EventArgs e)
        {
            this.truckCount.Text = this.Truck.Value.ToString();
            PanelShowBasedOnCondition(false, true, false, false);

            this.truckPanel.Location = new Point(118, 80);
            CurrentTotalLoad();
        }

        private void Car_Scroll(object sender, EventArgs e)
        {
            this.carCount.Text = this.Car.Value.ToString();
            PanelShowBasedOnCondition(false, false, true, false);
            this.carPanel.Location = new Point(118, 80);
            CurrentTotalLoad();
        }

        private void TrainCar_Scroll(object sender, EventArgs e)
        {

            this.trainCarCount.Text = this.TrainCar.Value.ToString();

            PanelShowBasedOnCondition(false, false, false, true);

            this.traincarPanel.Location = new Point(118, 80);
            CurrentTotalLoad();
        } 
        
        private void CurrentTotalLoad()
        {
            int capacity = 239, totalCurrentLoad=0;
            int motorCycleUnit = 0, truckUnit = 0, carUnit = 0, trainCar = 0;
            motorCycleUnit = Convert.ToInt32(this.motorCycleCount.Text);
            truckUnit = Convert.ToInt32(this.truckCount.Text);
            carUnit = Convert.ToInt32(this.carCount.Text);
            trainCar = Convert.ToInt32(this.trainCarCount.Text);
            totalCurrentLoad = (motorCycleUnit * 3) + (truckUnit * 11) + (carUnit*5)+ ( trainCar*17);
            if (capacity == totalCurrentLoad)
            {
                AlertBox.BackColor = Color.Green;
            }
            else if (totalCurrentLoad> capacity)
            {
                AlertBox.BackColor = Color.Red;
            }
            else
            {
                AlertBox.BackColor = Color.Gray;
            }
            Capacity.Visible = true;
            CurrentLoad.Visible = true;

            CurrentLoad.Text = $"CurrentLoad = {totalCurrentLoad}";
        }

        private void PanelShowBasedOnCondition(bool MPVisiblity, bool TPVisibility, bool CPVisibility, bool TCVisibility)
        {
            this.motorCyclePanel.Visible = MPVisiblity;
            this.truckPanel.Visible = TPVisibility;
            this.carPanel.Visible = CPVisibility;
            this.traincarPanel.Visible = TCVisibility;
        }


    }
}
