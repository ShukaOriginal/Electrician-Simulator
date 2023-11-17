using Electric_simulator.Forms;
using Electric_simulator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_simulator
{
    public partial class MainForm : Form
    {
        public TimeModel SimulationTime = new TimeModel();
        public SimulationModel Simulation = new SimulationModel();

        public MainForm()
        {
            InitializeComponent();
        }

        private void RealTimeTick_Tick(object sender, EventArgs e)
        {
            SimulationTime.SimulationTick();
        }

        private void TimeSpeedX1_Click(object sender, EventArgs e)
        {
            SimulationTime.TimeSpeed = 1;
        }

        private void TimeSpeedX2_Click(object sender, EventArgs e)
        {
            SimulationTime.TimeSpeed = 2;
        }

        private void TimeSpeedX5_Click(object sender, EventArgs e)
        {
            SimulationTime.TimeSpeed = 5;
        }
        private void SimulationPause_Click(object sender, EventArgs e)
        {
            SimulationTime.TimeSpeed = 0;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            using (var CreateGrid = new CreateGridForm())
            {
                CreateGrid.ShowDialog();
            }
        }

        
    }
}
