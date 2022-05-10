
namespace UIRS
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.iteration_button = new System.Windows.Forms.Button();
            this.fish_koeff = new System.Windows.Forms.TextBox();
            this.invest_koeff = new System.Windows.Forms.TextBox();
            this.ship_life = new System.Windows.Forms.TextBox();
            this.ship_cost = new System.Windows.Forms.TextBox();
            this.ship_command = new System.Windows.Forms.TextBox();
            this.ship_earn = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fish_cost = new System.Windows.Forms.TextBox();
            this.calculation_label = new System.Windows.Forms.Label();
            this.fish_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.capital_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.personalcapital_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.earn_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.personal_capital_textbox = new System.Windows.Forms.TextBox();
            this.Scenaries = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RegulatorRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.fish_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capital_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalcapital_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earn_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // iteration_button
            // 
            this.iteration_button.Location = new System.Drawing.Point(26, 600);
            this.iteration_button.Margin = new System.Windows.Forms.Padding(2);
            this.iteration_button.Name = "iteration_button";
            this.iteration_button.Size = new System.Drawing.Size(915, 56);
            this.iteration_button.TabIndex = 0;
            this.iteration_button.Text = "NEXT";
            this.iteration_button.UseVisualStyleBackColor = true;
            this.iteration_button.Click += new System.EventHandler(this.IterationButtonClick);
            // 
            // fish_koeff
            // 
            this.fish_koeff.Location = new System.Drawing.Point(188, 280);
            this.fish_koeff.Margin = new System.Windows.Forms.Padding(2);
            this.fish_koeff.Name = "fish_koeff";
            this.fish_koeff.Size = new System.Drawing.Size(113, 20);
            this.fish_koeff.TabIndex = 1;
            // 
            // invest_koeff
            // 
            this.invest_koeff.Location = new System.Drawing.Point(188, 311);
            this.invest_koeff.Margin = new System.Windows.Forms.Padding(2);
            this.invest_koeff.Name = "invest_koeff";
            this.invest_koeff.Size = new System.Drawing.Size(113, 20);
            this.invest_koeff.TabIndex = 2;
            // 
            // ship_life
            // 
            this.ship_life.Location = new System.Drawing.Point(188, 342);
            this.ship_life.Margin = new System.Windows.Forms.Padding(2);
            this.ship_life.Name = "ship_life";
            this.ship_life.Size = new System.Drawing.Size(113, 20);
            this.ship_life.TabIndex = 3;
            // 
            // ship_cost
            // 
            this.ship_cost.Location = new System.Drawing.Point(188, 372);
            this.ship_cost.Margin = new System.Windows.Forms.Padding(2);
            this.ship_cost.Name = "ship_cost";
            this.ship_cost.Size = new System.Drawing.Size(113, 20);
            this.ship_cost.TabIndex = 4;
            // 
            // ship_command
            // 
            this.ship_command.Location = new System.Drawing.Point(188, 402);
            this.ship_command.Margin = new System.Windows.Forms.Padding(2);
            this.ship_command.Name = "ship_command";
            this.ship_command.Size = new System.Drawing.Size(113, 20);
            this.ship_command.TabIndex = 5;
            // 
            // ship_earn
            // 
            this.ship_earn.Location = new System.Drawing.Point(188, 433);
            this.ship_earn.Margin = new System.Windows.Forms.Padding(2);
            this.ship_earn.Name = "ship_earn";
            this.ship_earn.Size = new System.Drawing.Size(113, 20);
            this.ship_earn.TabIndex = 6;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(188, 464);
            this.salary.Margin = new System.Windows.Forms.Padding(2);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(113, 20);
            this.salary.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Коэфф. восстановления рыбы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Коэфф. инвестирования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Срок службы судна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Стоимость судна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Экипаж судна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 433);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Добыча судна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 464);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Зарплата рабочего";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 495);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Рыночная цена";
            // 
            // fish_cost
            // 
            this.fish_cost.Location = new System.Drawing.Point(188, 495);
            this.fish_cost.Margin = new System.Windows.Forms.Padding(2);
            this.fish_cost.Name = "fish_cost";
            this.fish_cost.Size = new System.Drawing.Size(113, 20);
            this.fish_cost.TabIndex = 15;
            // 
            // calculation_label
            // 
            this.calculation_label.AutoSize = true;
            this.calculation_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculation_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculation_label.Location = new System.Drawing.Point(26, 21);
            this.calculation_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculation_label.Name = "calculation_label";
            this.calculation_label.Size = new System.Drawing.Size(2, 19);
            this.calculation_label.TabIndex = 17;
            // 
            // fish_chart
            // 
            chartArea5.Name = "ChartArea1";
            this.fish_chart.ChartAreas.Add(chartArea5);
            this.fish_chart.Location = new System.Drawing.Point(331, 43);
            this.fish_chart.Margin = new System.Windows.Forms.Padding(2);
            this.fish_chart.Name = "fish_chart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.fish_chart.Series.Add(series5);
            this.fish_chart.Size = new System.Drawing.Size(284, 215);
            this.fish_chart.TabIndex = 18;
            this.fish_chart.Text = "chart1";
            // 
            // capital_chart
            // 
            chartArea6.Name = "ChartArea1";
            this.capital_chart.ChartAreas.Add(chartArea6);
            this.capital_chart.Location = new System.Drawing.Point(331, 297);
            this.capital_chart.Margin = new System.Windows.Forms.Padding(2);
            this.capital_chart.Name = "capital_chart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.capital_chart.Series.Add(series6);
            this.capital_chart.Size = new System.Drawing.Size(284, 215);
            this.capital_chart.TabIndex = 19;
            this.capital_chart.Text = "chart1";
            // 
            // personalcapital_chart
            // 
            chartArea7.Name = "ChartArea1";
            this.personalcapital_chart.ChartAreas.Add(chartArea7);
            this.personalcapital_chart.Location = new System.Drawing.Point(657, 43);
            this.personalcapital_chart.Margin = new System.Windows.Forms.Padding(2);
            this.personalcapital_chart.Name = "personalcapital_chart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "Series1";
            this.personalcapital_chart.Series.Add(series7);
            this.personalcapital_chart.Size = new System.Drawing.Size(284, 215);
            this.personalcapital_chart.TabIndex = 20;
            this.personalcapital_chart.Text = "chart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(658, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Личный капитал";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Запас рыбы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Капитал";
            // 
            // earn_chart
            // 
            chartArea8.Name = "ChartArea1";
            this.earn_chart.ChartAreas.Add(chartArea8);
            this.earn_chart.Location = new System.Drawing.Point(657, 297);
            this.earn_chart.Margin = new System.Windows.Forms.Padding(2);
            this.earn_chart.Name = "earn_chart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Series1";
            this.earn_chart.Series.Add(series8);
            this.earn_chart.Size = new System.Drawing.Size(284, 215);
            this.earn_chart.TabIndex = 24;
            this.earn_chart.Text = "chart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 272);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Добыча";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 526);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "% отчислений в лич. капитал";
            // 
            // personal_capital_textbox
            // 
            this.personal_capital_textbox.Location = new System.Drawing.Point(188, 526);
            this.personal_capital_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.personal_capital_textbox.Name = "personal_capital_textbox";
            this.personal_capital_textbox.Size = new System.Drawing.Size(113, 20);
            this.personal_capital_textbox.TabIndex = 26;
            // 
            // Scenaries
            // 
            this.Scenaries.FormattingEnabled = true;
            this.Scenaries.Items.AddRange(new object[] {
            "Cвой сценарий",
            "Жадная добыча",
            "Быстрый рост капитала"});
            this.Scenaries.Location = new System.Drawing.Point(84, 215);
            this.Scenaries.Name = "Scenaries";
            this.Scenaries.Size = new System.Drawing.Size(217, 43);
            this.Scenaries.TabIndex = 28;
            this.Scenaries.SelectedIndexChanged += new System.EventHandler(this.Scenaries_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 215);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Сценарии";
            // 
            // RegulatorRadioButton
            // 
            this.RegulatorRadioButton.AutoSize = true;
            this.RegulatorRadioButton.Location = new System.Drawing.Point(26, 563);
            this.RegulatorRadioButton.Name = "RegulatorRadioButton";
            this.RegulatorRadioButton.Size = new System.Drawing.Size(77, 17);
            this.RegulatorRadioButton.TabIndex = 30;
            this.RegulatorRadioButton.TabStop = true;
            this.RegulatorRadioButton.Text = "Регулятор";
            this.RegulatorRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 667);
            this.Controls.Add(this.RegulatorRadioButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Scenaries);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.personal_capital_textbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.earn_chart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.personalcapital_chart);
            this.Controls.Add(this.capital_chart);
            this.Controls.Add(this.fish_chart);
            this.Controls.Add(this.calculation_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fish_cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.ship_earn);
            this.Controls.Add(this.ship_command);
            this.Controls.Add(this.ship_cost);
            this.Controls.Add(this.ship_life);
            this.Controls.Add(this.invest_koeff);
            this.Controls.Add(this.fish_koeff);
            this.Controls.Add(this.iteration_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "BusinessSimulation";
            ((System.ComponentModel.ISupportInitialize)(this.fish_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capital_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalcapital_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earn_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iteration_button;
        private System.Windows.Forms.TextBox fish_koeff;
        private System.Windows.Forms.TextBox invest_koeff;
        private System.Windows.Forms.TextBox ship_life;
        private System.Windows.Forms.TextBox ship_cost;
        private System.Windows.Forms.TextBox ship_command;
        private System.Windows.Forms.TextBox ship_earn;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fish_cost;
        private System.Windows.Forms.Label calculation_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart fish_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart capital_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart personalcapital_chart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart earn_chart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox personal_capital_textbox;
        private System.Windows.Forms.ListBox Scenaries;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton RegulatorRadioButton;
    }
}

