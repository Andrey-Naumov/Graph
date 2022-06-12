namespace PressureGraph
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel_Chart_Button = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Chart_Data = new System.Windows.Forms.TableLayoutPanel();
            this.chartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Chart_Button.SuspendLayout();
            this.tableLayoutPanel_Chart_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Chart_Button
            // 
            this.tableLayoutPanel_Chart_Button.ColumnCount = 1;
            this.tableLayoutPanel_Chart_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Chart_Button.Controls.Add(this.tableLayoutPanel_Chart_Data, 0, 0);
            this.tableLayoutPanel_Chart_Button.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel_Chart_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Chart_Button.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Chart_Button.Name = "tableLayoutPanel_Chart_Button";
            this.tableLayoutPanel_Chart_Button.RowCount = 2;
            this.tableLayoutPanel_Chart_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_Chart_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Chart_Button.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel_Chart_Button.TabIndex = 0;
            // 
            // tableLayoutPanel_Chart_Data
            // 
            this.tableLayoutPanel_Chart_Data.ColumnCount = 2;
            this.tableLayoutPanel_Chart_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Chart_Data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_Chart_Data.Controls.Add(this.chartPressure, 0, 0);
            this.tableLayoutPanel_Chart_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Chart_Data.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Chart_Data.Name = "tableLayoutPanel_Chart_Data";
            this.tableLayoutPanel_Chart_Data.RowCount = 1;
            this.tableLayoutPanel_Chart_Data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Chart_Data.Size = new System.Drawing.Size(794, 399);
            this.tableLayoutPanel_Chart_Data.TabIndex = 0;
            // 
            // chartPressure
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea1);
            this.chartPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartPressure.Legends.Add(legend1);
            this.chartPressure.Location = new System.Drawing.Point(3, 3);
            this.chartPressure.Name = "chartPressure";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series0";
            this.chartPressure.Series.Add(series1);
            this.chartPressure.Size = new System.Drawing.Size(549, 393);
            this.chartPressure.TabIndex = 1;
            this.chartPressure.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(794, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel_Chart_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel_Chart_Button.ResumeLayout(false);
            this.tableLayoutPanel_Chart_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Chart_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Chart_Data;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressure;
        private System.Windows.Forms.Button button1;
    }
}

