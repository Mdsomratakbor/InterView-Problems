using System.Drawing;

namespace CargoShip
{
    partial class CargoShip
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargoShip));
            this.NewBoat = new System.Windows.Forms.Button();
            this.loadSliderPanel = new System.Windows.Forms.Panel();
            this.AlertBox = new System.Windows.Forms.Panel();
            this.CurrentLoad = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.Label();
            this.traincarPanel = new System.Windows.Forms.Panel();
            this.truckPanel = new System.Windows.Forms.Panel();
            this.carPanel = new System.Windows.Forms.Panel();
            this.motorCyclePanel = new System.Windows.Forms.Panel();
            this.MotorCycle = new System.Windows.Forms.TrackBar();
            this.motorCycleLable = new System.Windows.Forms.Label();
            this.Truck = new System.Windows.Forms.TrackBar();
            this.truckLabel = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.TrackBar();
            this.carLable = new System.Windows.Forms.Label();
            this.TrainCar = new System.Windows.Forms.TrackBar();
            this.traincarLable = new System.Windows.Forms.Label();
            this.motorCycleCount = new System.Windows.Forms.Label();
            this.truckCount = new System.Windows.Forms.Label();
            this.carCount = new System.Windows.Forms.Label();
            this.trainCarCount = new System.Windows.Forms.Label();
            this.loadSliderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotorCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Truck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainCar)).BeginInit();
            this.SuspendLayout();
            // 
            // NewBoat
            // 
            this.NewBoat.Location = new System.Drawing.Point(46, 531);
            this.NewBoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewBoat.Name = "NewBoat";
            this.NewBoat.Size = new System.Drawing.Size(108, 37);
            this.NewBoat.TabIndex = 0;
            this.NewBoat.Text = "New Boat";
            this.NewBoat.UseVisualStyleBackColor = true;
            this.NewBoat.Click += new System.EventHandler(this.NewBoat_Click);
            // 
            // loadSliderPanel
            // 
            this.loadSliderPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadSliderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadSliderPanel.BackgroundImage")));
            this.loadSliderPanel.Controls.Add(this.AlertBox);
            this.loadSliderPanel.Controls.Add(this.CurrentLoad);
            this.loadSliderPanel.Controls.Add(this.Capacity);
            this.loadSliderPanel.Controls.Add(this.traincarPanel);
            this.loadSliderPanel.Controls.Add(this.truckPanel);
            this.loadSliderPanel.Controls.Add(this.carPanel);
            this.loadSliderPanel.Controls.Add(this.motorCyclePanel);
            this.loadSliderPanel.Location = new System.Drawing.Point(218, 15);
            this.loadSliderPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.loadSliderPanel.Name = "loadSliderPanel";
            this.loadSliderPanel.Size = new System.Drawing.Size(591, 282);
            this.loadSliderPanel.TabIndex = 1;
            // 
            // AlertBox
            // 
            this.AlertBox.BackColor = System.Drawing.Color.Gray;
            this.AlertBox.Location = new System.Drawing.Point(521, 0);
            this.AlertBox.Name = "AlertBox";
            this.AlertBox.Size = new System.Drawing.Size(70, 35);
            this.AlertBox.TabIndex = 14;
            // 
            // CurrentLoad
            // 
            this.CurrentLoad.AutoSize = true;
            this.CurrentLoad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CurrentLoad.ForeColor = System.Drawing.Color.White;
            this.CurrentLoad.Location = new System.Drawing.Point(275, 213);
            this.CurrentLoad.Name = "CurrentLoad";
            this.CurrentLoad.Size = new System.Drawing.Size(156, 28);
            this.CurrentLoad.TabIndex = 5;
            this.CurrentLoad.Text = "CurrentLoad=88";
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Capacity.ForeColor = System.Drawing.Color.White;
            this.Capacity.Location = new System.Drawing.Point(135, 213);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(134, 28);
            this.Capacity.TabIndex = 4;
            this.Capacity.Text = "Capacity=239";
            // 
            // traincarPanel
            // 
            this.traincarPanel.BackColor = System.Drawing.Color.Green;
            this.traincarPanel.Location = new System.Drawing.Point(651, 32);
            this.traincarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.traincarPanel.Name = "traincarPanel";
            this.traincarPanel.Size = new System.Drawing.Size(167, 119);
            this.traincarPanel.TabIndex = 3;
            this.traincarPanel.Visible = false;
            // 
            // truckPanel
            // 
            this.truckPanel.BackColor = System.Drawing.Color.LightSalmon;
            this.truckPanel.Location = new System.Drawing.Point(306, 32);
            this.truckPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.truckPanel.Name = "truckPanel";
            this.truckPanel.Size = new System.Drawing.Size(167, 119);
            this.truckPanel.TabIndex = 1;
            this.truckPanel.Visible = false;
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.carPanel.Location = new System.Drawing.Point(479, 32);
            this.carPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(167, 119);
            this.carPanel.TabIndex = 2;
            this.carPanel.Visible = false;
            // 
            // motorCyclePanel
            // 
            this.motorCyclePanel.BackColor = System.Drawing.Color.Gold;
            this.motorCyclePanel.Location = new System.Drawing.Point(135, 32);
            this.motorCyclePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.motorCyclePanel.Name = "motorCyclePanel";
            this.motorCyclePanel.Size = new System.Drawing.Size(167, 119);
            this.motorCyclePanel.TabIndex = 0;
            this.motorCyclePanel.Visible = false;
            // 
            // MotorCycle
            // 
            this.MotorCycle.AccessibleDescription = "";
            this.MotorCycle.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.MotorCycle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MotorCycle.LargeChange = 1;
            this.MotorCycle.Location = new System.Drawing.Point(205, 376);
            this.MotorCycle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MotorCycle.Name = "MotorCycle";
            this.MotorCycle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MotorCycle.RightToLeftLayout = true;
            this.MotorCycle.Size = new System.Drawing.Size(269, 45);
            this.MotorCycle.TabIndex = 1;
            this.MotorCycle.Scroll += new System.EventHandler(this.MotorCycle_Scroll);
            // 
            // motorCycleLable
            // 
            this.motorCycleLable.AutoSize = true;
            this.motorCycleLable.Location = new System.Drawing.Point(244, 405);
            this.motorCycleLable.Name = "motorCycleLable";
            this.motorCycleLable.Size = new System.Drawing.Size(194, 28);
            this.motorCycleLable.TabIndex = 3;
            this.motorCycleLable.Text = "Motor Cycle (3 units)";
            // 
            // Truck
            // 
            this.Truck.AccessibleDescription = "";
            this.Truck.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.Truck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Truck.LargeChange = 1;
            this.Truck.Location = new System.Drawing.Point(507, 376);
            this.Truck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Truck.Name = "Truck";
            this.Truck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Truck.Size = new System.Drawing.Size(251, 45);
            this.Truck.TabIndex = 1;
            this.Truck.Scroll += new System.EventHandler(this.Truck_Scroll);
            // 
            // truckLabel
            // 
            this.truckLabel.AutoSize = true;
            this.truckLabel.Location = new System.Drawing.Point(541, 405);
            this.truckLabel.Name = "truckLabel";
            this.truckLabel.Size = new System.Drawing.Size(151, 28);
            this.truckLabel.TabIndex = 5;
            this.truckLabel.Text = "Trucks (11 units)";
            // 
            // Car
            // 
            this.Car.AccessibleDescription = "";
            this.Car.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.Car.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Car.LargeChange = 1;
            this.Car.Location = new System.Drawing.Point(205, 457);
            this.Car.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Car.Name = "Car";
            this.Car.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Car.Size = new System.Drawing.Size(269, 45);
            this.Car.TabIndex = 1;
            this.Car.Scroll += new System.EventHandler(this.Car_Scroll);
            // 
            // carLable
            // 
            this.carLable.AutoSize = true;
            this.carLable.Location = new System.Drawing.Point(255, 487);
            this.carLable.Name = "carLable";
            this.carLable.Size = new System.Drawing.Size(124, 28);
            this.carLable.TabIndex = 7;
            this.carLable.Text = "Cars (5 units)";
            // 
            // TrainCar
            // 
            this.TrainCar.AccessibleDescription = "";
            this.TrainCar.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.TrainCar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TrainCar.LargeChange = 1;
            this.TrainCar.Location = new System.Drawing.Point(507, 457);
            this.TrainCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrainCar.Name = "TrainCar";
            this.TrainCar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrainCar.Size = new System.Drawing.Size(251, 45);
            this.TrainCar.TabIndex = 1;
            this.TrainCar.Scroll += new System.EventHandler(this.TrainCar_Scroll);
            // 
            // traincarLable
            // 
            this.traincarLable.AutoSize = true;
            this.traincarLable.Location = new System.Drawing.Point(552, 487);
            this.traincarLable.Name = "traincarLable";
            this.traincarLable.Size = new System.Drawing.Size(173, 28);
            this.traincarLable.TabIndex = 9;
            this.traincarLable.Text = "Train Car (17 units)";
            // 
            // motorCycleCount
            // 
            this.motorCycleCount.AutoSize = true;
            this.motorCycleCount.Location = new System.Drawing.Point(218, 344);
            this.motorCycleCount.Name = "motorCycleCount";
            this.motorCycleCount.Size = new System.Drawing.Size(23, 28);
            this.motorCycleCount.TabIndex = 10;
            this.motorCycleCount.Text = "0";
            // 
            // truckCount
            // 
            this.truckCount.AutoSize = true;
            this.truckCount.Location = new System.Drawing.Point(518, 344);
            this.truckCount.Name = "truckCount";
            this.truckCount.Size = new System.Drawing.Size(23, 28);
            this.truckCount.TabIndex = 11;
            this.truckCount.Text = "0";
            // 
            // carCount
            // 
            this.carCount.AutoSize = true;
            this.carCount.Location = new System.Drawing.Point(218, 425);
            this.carCount.Name = "carCount";
            this.carCount.Size = new System.Drawing.Size(23, 28);
            this.carCount.TabIndex = 12;
            this.carCount.Text = "0";
            // 
            // trainCarCount
            // 
            this.trainCarCount.AutoSize = true;
            this.trainCarCount.Location = new System.Drawing.Point(518, 425);
            this.trainCarCount.Name = "trainCarCount";
            this.trainCarCount.Size = new System.Drawing.Size(23, 28);
            this.trainCarCount.TabIndex = 13;
            this.trainCarCount.Text = "0";
            // 
            // CargoShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 612);
            this.Controls.Add(this.trainCarCount);
            this.Controls.Add(this.carCount);
            this.Controls.Add(this.truckCount);
            this.Controls.Add(this.motorCycleCount);
            this.Controls.Add(this.traincarLable);
            this.Controls.Add(this.TrainCar);
            this.Controls.Add(this.carLable);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.truckLabel);
            this.Controls.Add(this.Truck);
            this.Controls.Add(this.motorCycleLable);
            this.Controls.Add(this.MotorCycle);
            this.Controls.Add(this.loadSliderPanel);
            this.Controls.Add(this.NewBoat);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CargoShip";
            this.Text = "Fill the Boat";
            this.loadSliderPanel.ResumeLayout(false);
            this.loadSliderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotorCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Truck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewBoat;
        private System.Windows.Forms.Panel loadSliderPanel;
        private System.Windows.Forms.TrackBar MotorCycle;
        private System.Windows.Forms.TrackBar Truck;
        private System.Windows.Forms.TrackBar Car;
        private System.Windows.Forms.TrackBar TrainCar;
        private System.Windows.Forms.Label truckLabel;
        private System.Windows.Forms.Label motorCycleLable;
        private System.Windows.Forms.Label carLable;
        private System.Windows.Forms.Label traincarLable;
        private System.Windows.Forms.Panel motorCyclePanel;
        private System.Windows.Forms.Panel truckPanel;
        private System.Windows.Forms.Panel traincarPanel;
        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Label motorCycleCount;
        private System.Windows.Forms.Label truckCount;
        private System.Windows.Forms.Label carCount;
        private System.Windows.Forms.Label trainCarCount;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.Label CurrentLoad;
        private System.Windows.Forms.Panel AlertBox;
    }
}

