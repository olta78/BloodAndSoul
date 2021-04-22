
namespace Fruit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtStart = new System.Windows.Forms.Button();
            this.BtStop = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Timer(this.components);
            this.MinDes = new System.Windows.Forms.Label();
            this.MinEd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecDes = new System.Windows.Forms.Label();
            this.SecEd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtStart
            // 
            this.BtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtStart.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtStart.Location = new System.Drawing.Point(3, 53);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(100, 23);
            this.BtStart.TabIndex = 0;
            this.BtStart.Text = "S T A R T";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // BtStop
            // 
            this.BtStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtStop.ForeColor = System.Drawing.Color.Red;
            this.BtStop.Location = new System.Drawing.Point(114, 53);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(100, 23);
            this.BtStop.TabIndex = 1;
            this.BtStop.Text = "S T O P";
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // Count
            // 
            this.Count.Tick += new System.EventHandler(this.Count_Tick);
            // 
            // MinDes
            // 
            this.MinDes.AutoSize = true;
            this.MinDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinDes.ForeColor = System.Drawing.Color.Blue;
            this.MinDes.Location = new System.Drawing.Point(7, -2);
            this.MinDes.Name = "MinDes";
            this.MinDes.Size = new System.Drawing.Size(52, 55);
            this.MinDes.TabIndex = 2;
            this.MinDes.Text = "0";
            // 
            // MinEd
            // 
            this.MinEd.AutoSize = true;
            this.MinEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinEd.ForeColor = System.Drawing.Color.Blue;
            this.MinEd.Location = new System.Drawing.Point(47, -2);
            this.MinEd.Name = "MinEd";
            this.MinEd.Size = new System.Drawing.Size(52, 55);
            this.MinEd.TabIndex = 3;
            this.MinEd.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(86, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // SecDes
            // 
            this.SecDes.AutoSize = true;
            this.SecDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecDes.ForeColor = System.Drawing.Color.Blue;
            this.SecDes.Location = new System.Drawing.Point(121, -2);
            this.SecDes.Name = "SecDes";
            this.SecDes.Size = new System.Drawing.Size(52, 55);
            this.SecDes.TabIndex = 5;
            this.SecDes.Text = "0";
            // 
            // SecEd
            // 
            this.SecEd.AutoSize = true;
            this.SecEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecEd.ForeColor = System.Drawing.Color.Blue;
            this.SecEd.Location = new System.Drawing.Point(165, -2);
            this.SecEd.Name = "SecEd";
            this.SecEd.Size = new System.Drawing.Size(52, 55);
            this.SecEd.TabIndex = 6;
            this.SecEd.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 78);
            this.Controls.Add(this.SecEd);
            this.Controls.Add(this.SecDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinEd);
            this.Controls.Add(this.MinDes);
            this.Controls.Add(this.BtStop);
            this.Controls.Add(this.BtStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.85D;
            this.Text = "FRUIT";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.Timer Count;
        private System.Windows.Forms.Label MinDes;
        private System.Windows.Forms.Label MinEd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SecDes;
        private System.Windows.Forms.Label SecEd;
    }
}

