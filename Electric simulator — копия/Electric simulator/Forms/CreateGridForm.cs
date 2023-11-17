using Electric_simulator.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_simulator.Forms
{
    public partial class CreateGridForm : Form
    {


        private PropertiesObject selectedItem;

        private ElementsModel data = new ElementsModel(); // { get; set; }  = new ElementsModel();

        public CreateGridForm()
        {
            InitializeComponent();
        }

        private void TypeObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = (PropertiesObject)TypeObjectComboBox.SelectedItem;

            PowerElements.Text = selectedItem.StandartPower.ToString();
            //MessageBox.Show($"type: {selectedItem.MaxProduction}");
        }

        private void CreateGridForm_Load(object sender, EventArgs e)
        {
            TypeObjectComboBox.Items.AddRange(data.StandartElements.ToArray());
            TypeObjectComboBox.DisplayMember = "Name";
            TypeObjectComboBox.SelectedItem = data.StandartElements[0];

        }

        private void PowerElements_TextChanged(object sender, EventArgs e)
        {
            if (PowerElements.Text != "")
            {
                if (int.Parse(PowerElements.Text) >= selectedItem.MaxConsumption && selectedItem.MaxProduction == 0)
                {
                    //MessageBox.Show("Что-то создаёт коритические ошибки");
                    PowerElements.Text = selectedItem.MaxConsumption.ToString();
                }
                if (int.Parse(PowerElements.Text) >= selectedItem.MaxProduction && selectedItem.MaxConsumption == 0)
                {
                    PowerElements.Text = selectedItem.MaxProduction.ToString();
                }
                var total = int.Parse(PowerElements.Text) * int.Parse(NumberElement.Text);
                TotalPower.Text = total.ToString();
            }
        }

        private void NumberElement_TextChanged(object sender, EventArgs e)
        {
            if (NumberElement.Text == "" || NumberElement.Text == "0")
            {
                NumberElement.Text = "1";
            }
            var total = int.Parse(PowerElements.Text) * int.Parse(NumberElement.Text);
            TotalPower.Text = total.ToString();
        }

        private void CreateElements_Click(object sender, EventArgs e)
        {

            data.AddElement(selectedItem.Generator, int.Parse(NumberElement.Text), selectedItem.name,
                selectedItem.type, int.Parse(PowerElements.Text), selectedItem.GrowthRate);

        }

        private void ShowElements_Click(object sender, EventArgs e)
        {
            var ShowElementForm = new ShowElementForm() { data = data };
            ShowElementForm.Show();
        }
    }
}
