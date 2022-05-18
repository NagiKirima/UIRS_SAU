using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIRS
{
    public partial class MainWindow : Form
    {
        private Calculate simulation;
        private int iteration = 0;
        public MainWindow()
        {
            InitializeComponent();
            simulation = new Calculate();
        }


        // work with user
        public void OutputData()
        {
            var eps = 1000;
            calculation_label.Text = $"Шаг - {iteration + 1}\n" +
                $"Доход: {Math.Floor(simulation.income * eps) / eps}\n" +
                $"Расход: {Math.Floor(simulation.expenses * eps) / eps}\n" +
                $"Запас рыбы: {Math.Floor(simulation.fish_stock * eps) / eps}\n" +
                $"Добыча: {Math.Floor(simulation.prod * eps) / eps}\n" +
                $"Судна: {simulation.ships.Count}\n" +
                $"Капитал: {Math.Floor(simulation.capital * eps) / eps}\n" +
                $"Личный капитал: {Math.Floor(simulation.personal_capital * eps) / eps}\n" +
                $"Персонал: {simulation.personal}\n" +
                $"Инвестиционный вклад: {Math.Floor(simulation.investition * eps) / eps}";
        }
        private void BlockTextBoxes(bool block)
        {
            if (block)
            {
                fish_koeff.Enabled = false;
                invest_koeff.Enabled = false;
                ship_life.Enabled = false;
                ship_cost.Enabled = false;
                ship_command.Enabled = false;
                ship_earn.Enabled = false;
                fish_cost.Enabled = false;
                salary.Enabled = false;
                fish_cost.Enabled = false;
                personal_capital_textbox.Enabled = false;
            }
            else
            {
                fish_koeff.Enabled = true;
                invest_koeff.Enabled = true;
                ship_life.Enabled = true;
                ship_cost.Enabled = true;
                ship_command.Enabled = true;
                ship_earn.Enabled = true;
                fish_cost.Enabled = true;
                salary.Enabled = true;
                fish_cost.Enabled = true;
                personal_capital_textbox.Enabled = true;
            }
        }
        private bool ReadValues(Calculate a)
        {
            bool init = true;
            try { a.fish_koeff = double.Parse(fish_koeff.Text); }
            catch
            {
                //a.fish_koeff = 1.005;
                fish_koeff.Text = a.fish_koeff.ToString();
                init = false;
            }
            try { a.invest_koeff = double.Parse(invest_koeff.Text); }
            catch
            {
                // a.invest_koeff = 0.1;
                invest_koeff.Text = a.invest_koeff.ToString();
                init = false;
            }
            try { a.salary = double.Parse(salary.Text); }
            catch
            {
                // a.salary = 10;
                salary.Text = a.salary.ToString();
                init = false;
            }
            try { a.ship_command = int.Parse(ship_command.Text); }
            catch
            {
                //a.ship_command = 15;
                ship_command.Text = a.ship_command.ToString();
                init = false;
            }
            try { a.ship_cost = double.Parse(ship_cost.Text); }
            catch
            {
                // a.ship_cost = 1500;
                ship_cost.Text = a.ship_cost.ToString();
                init = false;
            }
            try { a.ship_earn = double.Parse(ship_earn.Text); }
            catch
            {
                //a.ship_earn = 100;
                ship_earn.Text = a.ship_earn.ToString();
                init = false;
            }
            try { a.ship_life = int.Parse(ship_life.Text); }
            catch
            {
                //a.ship_life = 20;
                ship_life.Text = a.ship_life.ToString();
                init = false;
            }
            try { a.fish_cost = double.Parse(fish_cost.Text); }
            catch
            {
                // a.fish_cost = 35;
                fish_cost.Text = a.fish_cost.ToString();
                init = false;
            }
            try { a.personal_koef = double.Parse(personal_capital_textbox.Text); }
            catch
            {
                personal_capital_textbox.Text = a.personal_koef.ToString();
                init = false;
            }
            return init;
        }
        private void WriteValues(Calculate a)
        {
            fish_koeff.Text = a.fish_koeff.ToString();
            invest_koeff.Text = a.invest_koeff.ToString();
            salary.Text = a.salary.ToString();
            ship_command.Text = a.ship_command.ToString();
            ship_cost.Text = a.ship_cost.ToString();
            ship_earn.Text = a.ship_earn.ToString();
            ship_life.Text = a.ship_life.ToString();
            fish_cost.Text = a.fish_cost.ToString();
            personal_capital_textbox.Text = a.personal_koef.ToString();
        }

        // update chart data
        public void ChartIteration()
        {
            fish_chart.Series[0].Points.AddXY(0, simulation.fish_stock);
            capital_chart.Series[0].Points.AddXY(0, simulation.capital);
            personalcapital_chart.Series[0].Points.AddXY(0, simulation.personal_capital);
            earn_chart.Series[0].Points.AddXY(0, simulation.prod);
            iteration++;
        }
        private void ChartReset()
        {
            capital_chart.Series[0].Points.Clear();
            earn_chart.Series[0].Points.Clear();
            fish_chart.Series[0].Points.Clear();
            personalcapital_chart.Series[0].Points.Clear();
        }


        // iteration click
        private void IterationButtonClick(object sender, EventArgs e)
        {
            if (Scenaries.SelectedIndex == 3)
            {
                simulation.Iteration(true);
                WriteValues(simulation);
                OutputData();
                ChartIteration();
            }
            else if (Scenaries.SelectedIndex == 0)
            {
                if (ReadValues(simulation))
                {
                    simulation.Iteration();
                    OutputData();
                    ChartIteration();
                }
            }
            else if (Scenaries.SelectedItem != null)
            {
                simulation.Iteration();
                OutputData();
                ChartIteration();
            }
        }


        //select scenaries
        private void Scenaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            iteration = 0;
            switch (Scenaries.SelectedIndex)
            {
                case 0:
                    {
                        ChartReset();
                        simulation = new Calculate();
                        WriteValues(simulation);
                        BlockTextBoxes(false);
                        break;
                    }
                case 1:
                    {
                        ChartReset();
                        simulation.Init(1, 0.1, 0.1, 20, 1000, 15, 100, 10, 5, 1000, 5000, 0);
                        WriteValues(simulation);
                        OutputData();
                        BlockTextBoxes(true);
                        break;
                    }
                case 2:
                    {
                        ChartReset();
                        simulation.Init(1.05, 0.5, 0.1, 30, 1000, 12, 300, 10, 5, 100000, 5000, 0);
                        WriteValues(simulation);
                        OutputData();
                        BlockTextBoxes(true);
                        break;
                    }
                case 3:
                    {
                        ChartReset();
                        simulation.Init(1.1, 0.1, 0.1, 30, 800, 15, 15, 1, 15, 500, 1000, 0);
                        WriteValues(simulation);
                        OutputData();
                        BlockTextBoxes(true);
                        break;
                    }
            }
        }
    }
}
