
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
            this.SuspendLayout();
            // 
            // iteration_button
            // 
            this.iteration_button.Location = new System.Drawing.Point(690, 429);
            this.iteration_button.Name = "iteration_button";
            this.iteration_button.Size = new System.Drawing.Size(250, 69);
            this.iteration_button.TabIndex = 0;
            this.iteration_button.Text = "NEXT";
            this.iteration_button.UseVisualStyleBackColor = true;
            this.iteration_button.Click += new System.EventHandler(this.IterationButtonClick);
            // 
            // fish_koeff
            // 
            this.fish_koeff.Location = new System.Drawing.Point(249, 212);
            this.fish_koeff.Name = "fish_koeff";
            this.fish_koeff.Size = new System.Drawing.Size(149, 22);
            this.fish_koeff.TabIndex = 1;
            // 
            // invest_koeff
            // 
            this.invest_koeff.Location = new System.Drawing.Point(249, 250);
            this.invest_koeff.Name = "invest_koeff";
            this.invest_koeff.Size = new System.Drawing.Size(149, 22);
            this.invest_koeff.TabIndex = 2;
            // 
            // ship_life
            // 
            this.ship_life.Location = new System.Drawing.Point(249, 288);
            this.ship_life.Name = "ship_life";
            this.ship_life.Size = new System.Drawing.Size(149, 22);
            this.ship_life.TabIndex = 3;
            // 
            // ship_cost
            // 
            this.ship_cost.Location = new System.Drawing.Point(249, 325);
            this.ship_cost.Name = "ship_cost";
            this.ship_cost.Size = new System.Drawing.Size(149, 22);
            this.ship_cost.TabIndex = 4;
            // 
            // ship_command
            // 
            this.ship_command.Location = new System.Drawing.Point(249, 362);
            this.ship_command.Name = "ship_command";
            this.ship_command.Size = new System.Drawing.Size(149, 22);
            this.ship_command.TabIndex = 5;
            // 
            // ship_earn
            // 
            this.ship_earn.Location = new System.Drawing.Point(249, 400);
            this.ship_earn.Name = "ship_earn";
            this.ship_earn.Size = new System.Drawing.Size(149, 22);
            this.ship_earn.TabIndex = 6;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(249, 438);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(149, 22);
            this.salary.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Коэфф. восстановления рыбы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Коэфф. инвестирования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Срок службы судна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Стоимость судна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Экипаж судна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Добыча судна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Зарплата рабочего";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Рыночная цена";
            // 
            // fish_cost
            // 
            this.fish_cost.Location = new System.Drawing.Point(249, 476);
            this.fish_cost.Name = "fish_cost";
            this.fish_cost.Size = new System.Drawing.Size(149, 22);
            this.fish_cost.TabIndex = 15;
            // 
            // calculation_label
            // 
            this.calculation_label.AutoSize = true;
            this.calculation_label.Location = new System.Drawing.Point(41, 34);
            this.calculation_label.Name = "calculation_label";
            this.calculation_label.Size = new System.Drawing.Size(0, 17);
            this.calculation_label.TabIndex = 17;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 507);
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
            this.Name = "MainWindow";
            this.Text = "BusinessSimulation";
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
    }
}

