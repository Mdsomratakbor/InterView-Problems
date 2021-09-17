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
            this.truckPanel.Visible = false;
            this.traincarPanel.Visible = false;
            this.carPanel.Visible = false;
            this.motorCyclePanel.Visible = false;
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
        }

        private void MotorCycle_Scroll(object sender, EventArgs e)
        {

           this.motorCycleCount.Text = this.MotorCycle.Value.ToString();
            
          
    
            this.truckPanel.Visible = false;
            this.traincarPanel.Visible = false;
            this.carPanel.Visible = false;
            
            this.motorCyclePanel.Visible = true;
            this.motorCyclePanel.Location = new Point(118, 80);
        }

        private void Truck_Scroll(object sender, EventArgs e)
        {
            this.truckCount.Text = this.Truck.Value.ToString();

            this.motorCyclePanel.Visible = false;
            this.traincarPanel.Visible = false;
            this.carPanel.Visible = false;
            this.truckPanel.Visible = true;
            this.truckPanel.Location = new Point(118, 80);
        }

        private void Car_Scroll(object sender, EventArgs e)
        {
            this.carCount.Text = this.Car.Value.ToString();

            this.motorCyclePanel.Visible = false;
            this.truckPanel.Visible = false;
            this.traincarPanel.Visible = false;
            this.carPanel.Visible = true;
            this.carPanel.Location = new Point(118, 80);
        }

        private void TrainCar_Scroll(object sender, EventArgs e)
        {

            this.trainCarCount.Text = this.TrainCar.Value.ToString();

            this.motorCyclePanel.Visible = false;
            this.truckPanel.Visible = false;
            this.carPanel.Visible = false;
            this.traincarPanel.Visible = true;
            this.traincarPanel.Location = new Point(118, 80);
        }      
    }
}
