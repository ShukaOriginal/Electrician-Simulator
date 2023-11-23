namespace Electric_simulator.Forms
{
    partial class ShowElementForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.MaxProductionLabel = new System.Windows.Forms.Label();
            this.ProductionLabel = new System.Windows.Forms.Label();
            this.Lfble3 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RealTimeTick2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(195, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(394, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Макс. выроботка";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(116, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(258, 454);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MaxProductionLabel
            // 
            this.MaxProductionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.MaxProductionLabel.Location = new System.Drawing.Point(380, 93);
            this.MaxProductionLabel.Name = "MaxProductionLabel";
            this.MaxProductionLabel.Size = new System.Drawing.Size(199, 454);
            this.MaxProductionLabel.TabIndex = 5;
            this.MaxProductionLabel.Text = "MaxProduction";
            this.MaxProductionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductionLabel
            // 
            this.ProductionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ProductionLabel.Location = new System.Drawing.Point(601, 93);
            this.ProductionLabel.Name = "ProductionLabel";
            this.ProductionLabel.Size = new System.Drawing.Size(144, 454);
            this.ProductionLabel.TabIndex = 7;
            this.ProductionLabel.Text = "Production";
            this.ProductionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lfble3
            // 
            this.Lfble3.AutoSize = true;
            this.Lfble3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lfble3.Location = new System.Drawing.Point(617, 35);
            this.Lfble3.Name = "Lfble3";
            this.Lfble3.Size = new System.Drawing.Size(109, 25);
            this.Lfble3.TabIndex = 6;
            this.Lfble3.Text = "Выроботка";
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(34, 93);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(33, 454);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "id ";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "id";
            // 
            // RealTimeTick2
            // 
            this.RealTimeTick2.Enabled = true;
            this.RealTimeTick2.Tick += new System.EventHandler(this.RealTimeTick2_Tick);
            // 
            // ShowElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 598);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductionLabel);
            this.Controls.Add(this.Lfble3);
            this.Controls.Add(this.MaxProductionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShowElementForm";
            this.Text = "ShowElementForm";
            this.Load += new System.EventHandler(this.ShowElementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label MaxProductionLabel;
        private System.Windows.Forms.Label ProductionLabel;
        private System.Windows.Forms.Label Lfble3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer RealTimeTick2;
    }
}