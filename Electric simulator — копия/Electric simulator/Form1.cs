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
        public TimeModel SimulationTimeModel = new TimeModel();
        public SimulationModel Simulation = new SimulationModel();

        public MainForm()
        {
            InitializeComponent();
        }

        private void RealTimeTick_Tick(object sender, EventArgs e)
        {
            SimulationTimeModel.SimulationTick();
            if (TimeModel.NewTick)
            {
                Timelabel.Text = TimeModel.TimeInSimulation.ToString(@"hh\:mm");
            }
            TimeSpeedlabel.Text = "X" + TimeModel.TimeSpeed.ToString();
        }

        private void TimeSpeedX1_Click(object sender, EventArgs e)
        {
            TimeModel.TimeSpeed = 1;
        }

        private void TimeSpeedX2_Click(object sender, EventArgs e)
        {
            TimeModel.TimeSpeed = 2;
        }

        private void TimeSpeedX5_Click(object sender, EventArgs e)
        {
            TimeModel.TimeSpeed = 5;
        }

        private void SimulationPause_Click(object sender, EventArgs e)
        {
            TimeModel.TimeSpeed = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            using (var CreateGrid = new CreateGridForm())
            {
                CreateGrid.ShowDialog();
            }
            var sort = new SortCreatedElementModel() ;
            sort.SortingCreatedElements();
        }

        private void ShowElements_Click(object sender, EventArgs e)
        {
            var ShowElementForm = new ShowElementForm();
            ShowElementForm.Show();
        }
    }
}
