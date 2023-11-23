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

            PowerElements.Text = selectedItem.standartPower.ToString();
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
                if (int.Parse(PowerElements.Text) >= selectedItem.maxConsumption && selectedItem.maxProduction == 0)
                {
                    //MessageBox.Show("Что-то создаёт коритические ошибки");
                    PowerElements.Text = selectedItem.maxConsumption.ToString();
                }
                if (int.Parse(PowerElements.Text) >= selectedItem.maxProduction && selectedItem.maxConsumption == 0)
                {
                    PowerElements.Text = selectedItem.maxProduction.ToString();
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

            data.AddElement( selectedItem.generator, int.Parse(NumberElement.Text), selectedItem.name,
                selectedItem.type, int.Parse(PowerElements.Text), selectedItem.growthRate,
                selectedItem.consumptionRate, selectedItem.intervalRefreashTime);

        }

        private void ShowElements_Click(object sender, EventArgs e)
        {
            var sort = new SortCreatedElementModel();
            sort.SortingCreatedElements();
            var ShowElementForm = new ShowElementForm();
            ShowElementForm.Show();
        }
    }
}
