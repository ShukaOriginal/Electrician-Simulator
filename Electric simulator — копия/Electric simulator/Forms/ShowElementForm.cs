using Electric_simulator.Data;
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

        public ElementsModel data = new ElementsModel();

        private void ShowElementForm_Load(object sender, EventArgs e)
        {
            var sort = new SortCreatedElementModel() { data = data };
            sort.SortingCreatedElements();
            //var List = data.CreatedElements;{data.CreatedElements[i].i;d}
            //label3.Text = data.CreatedElements.Count.ToString();
            var mem = "";
            idLabel.Text = "";
            for (int i = 0; i < data.CreatedElements.Count; i++)
            {
                mem = idLabel.Text;
                idLabel.Text = mem + data.CreatedElements[i].id + "\n";
            }
            mem = "";
            nameLabel.Text = "";
            for (int i = 0; i < data.CreatedElements.Count; i++)
            {
                mem = nameLabel.Text;
                nameLabel.Text = mem + data.CreatedElements[i].name + "\n";
            }
            mem = "";
            MaxProductionLabel.Text = "";
            for (int i = 0; i < data.CreatedElements.Count; i++)
            {
                mem = MaxProductionLabel.Text;
                MaxProductionLabel.Text = mem + data.CreatedElements[i].MaxProduction + "\n";
            }
            mem = "";
            ProductionLabel.Text = "";
            for (int i = 0; i < data.CreatedElements.Count; i++)
            {
                mem = ProductionLabel.Text;
                ProductionLabel.Text = mem + data.CreatedElements[i].Production + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
