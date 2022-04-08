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
            return init;
        }
        public MainWindow()
        {
            InitializeComponent();
            simulation = new Calculate();
        }

        private void IterationButtonClick(object sender, EventArgs e)
        {
            if (ReadValues(simulation))
            {
                simulation.Iteration();
                calculation_label.Text = $"Доход: {simulation.income}\n" +
                    $"Расход: {simulation.expenses}\n" +
                    $"Запас рыбы: {simulation.fish_stock}\n" +
                    $"Добыча: {simulation.prod}\n" +
                    $"Судна: {simulation.ships.Count}\n" +
                    $"Капитал: {simulation.capital}\n" +
                    $"Личный капитал: {simulation.personal_capital}\n";
            }
        }
    }
}
