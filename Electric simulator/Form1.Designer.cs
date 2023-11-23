namespace Electric_simulator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RealTimeTick = new System.Windows.Forms.Timer(this.components);
            this.TimeSpeedX1 = new System.Windows.Forms.Button();
            this.TimeSpeedX2 = new System.Windows.Forms.Button();
            this.TimeSpeedX5 = new System.Windows.Forms.Button();
            this.SimulationPause = new System.Windows.Forms.Button();
            this.Timelabel = new System.Windows.Forms.Label();
            this.TimeSpeedlabel = new System.Windows.Forms.Label();
            this.ShowElements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RealTimeTick
            // 
            this.RealTimeTick.Enabled = true;
            this.RealTimeTick.Tick += new System.EventHandler(this.RealTimeTick_Tick);
            // 
            // TimeSpeedX1
            // 
            this.TimeSpeedX1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeSpeedX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeSpeedX1.Location = new System.Drawing.Point(1121, 12);
            this.TimeSpeedX1.Name = "TimeSpeedX1";
            this.TimeSpeedX1.Size = new System.Drawing.Size(43, 34);
            this.TimeSpeedX1.TabIndex = 0;
            this.TimeSpeedX1.Text = "X1";
            this.TimeSpeedX1.UseMnemonic = false;
            this.TimeSpeedX1.UseVisualStyleBackColor = false;
            this.TimeSpeedX1.Click += new System.EventHandler(this.TimeSpeedX1_Click);
            // 
            // TimeSpeedX2
            // 
            this.TimeSpeedX2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeSpeedX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeSpeedX2.Location = new System.Drawing.Point(1170, 12);
            this.TimeSpeedX2.Name = "TimeSpeedX2";
            this.TimeSpeedX2.Size = new System.Drawing.Size(43, 34);
            this.TimeSpeedX2.TabIndex = 1;
            this.TimeSpeedX2.Text = "X2";
            this.TimeSpeedX2.UseMnemonic = false;
            this.TimeSpeedX2.UseVisualStyleBackColor = false;
            this.TimeSpeedX2.Click += new System.EventHandler(this.TimeSpeedX2_Click);
            // 
            // TimeSpeedX5
            // 
            this.TimeSpeedX5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeSpeedX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeSpeedX5.Location = new System.Drawing.Point(1219, 12);
            this.TimeSpeedX5.Name = "TimeSpeedX5";
            this.TimeSpeedX5.Size = new System.Drawing.Size(43, 34);
            this.TimeSpeedX5.TabIndex = 2;
            this.TimeSpeedX5.Text = "X5";
            this.TimeSpeedX5.UseMnemonic = false;
            this.TimeSpeedX5.UseVisualStyleBackColor = false;
            this.TimeSpeedX5.Click += new System.EventHandler(this.TimeSpeedX5_Click);
            // 
            // SimulationPause
            // 
            this.SimulationPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SimulationPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimulationPause.Location = new System.Drawing.Point(1072, 12);
            this.SimulationPause.Name = "SimulationPause";
            this.SimulationPause.Size = new System.Drawing.Size(43, 34);
            this.SimulationPause.TabIndex = 3;
            this.SimulationPause.Text = "| |";
            this.SimulationPause.UseMnemonic = false;
            this.SimulationPause.UseVisualStyleBackColor = false;
            this.SimulationPause.Click += new System.EventHandler(this.SimulationPause_Click);
            // 
            // Timelabel
            // 
            this.Timelabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timelabel.Location = new System.Drawing.Point(1162, 49);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(100, 43);
            this.Timelabel.TabIndex = 4;
            this.Timelabel.Text = "00:00";
            this.Timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeSpeedlabel
            // 
            this.TimeSpeedlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeSpeedlabel.Location = new System.Drawing.Point(1067, 49);
            this.TimeSpeedlabel.Name = "TimeSpeedlabel";
            this.TimeSpeedlabel.Size = new System.Drawing.Size(56, 43);
            this.TimeSpeedlabel.TabIndex = 5;
            this.TimeSpeedlabel.Text = "X0";
            this.TimeSpeedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowElements
            // 
            this.ShowElements.BackColor = System.Drawing.Color.PowderBlue;
            this.ShowElements.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ShowElements.Location = new System.Drawing.Point(12, 605);
            this.ShowElements.Name = "ShowElements";
            this.ShowElements.Size = new System.Drawing.Size(219, 44);
            this.ShowElements.TabIndex = 9;
            this.ShowElements.Text = "Посмотреть элементы";
            this.ShowElements.UseVisualStyleBackColor = false;
            this.ShowElements.Click += new System.EventHandler(this.ShowElements_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 661);
            this.Controls.Add(this.ShowElements);
            this.Controls.Add(this.TimeSpeedlabel);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.SimulationPause);
            this.Controls.Add(this.TimeSpeedX5);
            this.Controls.Add(this.TimeSpeedX2);
            this.Controls.Add(this.TimeSpeedX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Electric simulator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer RealTimeTick;
        private System.Windows.Forms.Button TimeSpeedX1;
        private System.Windows.Forms.Button TimeSpeedX2;
        private System.Windows.Forms.Button TimeSpeedX5;
        private System.Windows.Forms.Button SimulationPause;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label TimeSpeedlabel;
        private System.Windows.Forms.Button ShowElements;
    }
}

