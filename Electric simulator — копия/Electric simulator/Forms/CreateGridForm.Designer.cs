namespace Electric_simulator.Forms
{
    partial class CreateGridForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeObjectComboBox = new System.Windows.Forms.ComboBox();
            this.PowerElements = new System.Windows.Forms.TextBox();
            this.CreateElements = new System.Windows.Forms.Button();
            this.ShowElements = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberElement = new System.Windows.Forms.TextBox();
            this.TotalPower = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(316, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(467, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "потребление / выроботка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(99, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип объекта";
            // 
            // TypeObjectComboBox
            // 
            this.TypeObjectComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.TypeObjectComboBox.FormattingEnabled = true;
            this.TypeObjectComboBox.Location = new System.Drawing.Point(35, 83);
            this.TypeObjectComboBox.Name = "TypeObjectComboBox";
            this.TypeObjectComboBox.Size = new System.Drawing.Size(240, 33);
            this.TypeObjectComboBox.TabIndex = 5;
            this.TypeObjectComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeObject_SelectedIndexChanged);
            // 
            // PowerElements
            // 
            this.PowerElements.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PowerElements.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.PowerElements.Location = new System.Drawing.Point(541, 83);
            this.PowerElements.Name = "PowerElements";
            this.PowerElements.Size = new System.Drawing.Size(100, 33);
            this.PowerElements.TabIndex = 6;
            this.PowerElements.Text = "100";
            this.PowerElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PowerElements.TextChanged += new System.EventHandler(this.PowerElements_TextChanged);
            // 
            // CreateElements
            // 
            this.CreateElements.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CreateElements.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateElements.Location = new System.Drawing.Point(678, 249);
            this.CreateElements.Name = "CreateElements";
            this.CreateElements.Size = new System.Drawing.Size(173, 44);
            this.CreateElements.TabIndex = 7;
            this.CreateElements.Text = "Создать элемент";
            this.CreateElements.UseVisualStyleBackColor = false;
            this.CreateElements.Click += new System.EventHandler(this.CreateElements_Click);
            // 
            // ShowElements
            // 
            this.ShowElements.BackColor = System.Drawing.Color.PowderBlue;
            this.ShowElements.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ShowElements.Location = new System.Drawing.Point(35, 249);
            this.ShowElements.Name = "ShowElements";
            this.ShowElements.Size = new System.Drawing.Size(219, 44);
            this.ShowElements.TabIndex = 8;
            this.ShowElements.Text = "Посмотреть элементы";
            this.ShowElements.UseVisualStyleBackColor = false;
            this.ShowElements.Click += new System.EventHandler(this.ShowElements_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(763, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Итого";
            // 
            // NumberElement
            // 
            this.NumberElement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberElement.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.NumberElement.Location = new System.Drawing.Point(321, 83);
            this.NumberElement.Name = "NumberElement";
            this.NumberElement.Size = new System.Drawing.Size(100, 33);
            this.NumberElement.TabIndex = 13;
            this.NumberElement.Text = "1";
            this.NumberElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberElement.TextChanged += new System.EventHandler(this.NumberElement_TextChanged);
            // 
            // TotalPower
            // 
            this.TotalPower.AutoSize = true;
            this.TotalPower.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.TotalPower.Location = new System.Drawing.Point(763, 86);
            this.TotalPower.Name = "TotalPower";
            this.TotalPower.Size = new System.Drawing.Size(65, 25);
            this.TotalPower.TabIndex = 14;
            this.TotalPower.Text = "Итого";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(467, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Максимальная";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "TypeObjectComboBox";
            this.toolTip1.ToolTipTitle = "1234";
            // 
            // CreateGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 316);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalPower);
            this.Controls.Add(this.NumberElement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowElements);
            this.Controls.Add(this.CreateElements);
            this.Controls.Add(this.PowerElements);
            this.Controls.Add(this.TypeObjectComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateGridForm";
            this.Text = "CreateGrid";
            this.Load += new System.EventHandler(this.CreateGridForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeObjectComboBox;
        private System.Windows.Forms.TextBox PowerElements;
        private System.Windows.Forms.Button CreateElements;
        private System.Windows.Forms.Button ShowElements;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberElement;
        private System.Windows.Forms.Label TotalPower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}