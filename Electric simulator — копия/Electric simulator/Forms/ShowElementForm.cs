using Electric_simulator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_simulator.Forms
{
    public partial class ShowElementForm : Form
    {
        public ShowElementForm()
        {
            InitializeComponent();
        }

        private void ShowElementForm_Load(object sender, EventArgs e)
        {
            //var List = data.CreatedElements;{data.CreatedElements[i].i;d}
            //label3.Text = data.CreatedElements.Count.ToString();
            refreash();
        }

        private void refreash()
        {
            var mem = "";
            idLabel.Text = "";
            for (int i = 0; i < ElementsModel.CreatedElements.Count; i++)
            {
                mem = idLabel.Text;
                idLabel.Text = mem + ElementsModel.CreatedElements[i].id + "\n";
            }
            mem = "";
            nameLabel.Text = "";
            for (int i = 0; i < ElementsModel.CreatedElements.Count; i++)
            {
                mem = nameLabel.Text;
                nameLabel.Text = mem + ElementsModel.CreatedElements[i].name + "\n";
            }
            mem = "";
            MaxProductionLabel.Text = "";
            for (int i = 0; i < ElementsModel.CreatedElements.Count; i++)
            {
                mem = MaxProductionLabel.Text;
                MaxProductionLabel.Text = mem + ElementsModel.CreatedElements[i].maxProduction + "\n";
            }
            mem = "";
            ProductionLabel.Text = "";
            for (int i = 0; i < ElementsModel.CreatedElements.Count; i++)
            {
                mem = ProductionLabel.Text;
                ProductionLabel.Text = mem + ElementsModel.CreatedElements[i].production + "\n";
            }
        }

        private void RealTimeTick2_Tick(object sender, EventArgs e)
        {
            if (TimeModel.NewTick)
            {
                refreash();
            }
        }
    }
}
