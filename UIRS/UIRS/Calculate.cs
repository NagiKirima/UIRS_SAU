using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIRS
{
    class Calculate
    {
        public List<int> ships { get; set; } = new List<int>();
        // read prop
        public double fish_koeff { get; set; }
        public double invest_koeff { get; set; }
        public double personal_koef { get; set; }
        public int ship_life { get; set; }
        public double ship_cost { get; set; }
        public double salary { get; set; }
        public int ship_command { get; set; }
        public double ship_earn { get; set; }
        public double fish_cost { get; set; }

        //calculate prop
        public double expenses { get; set; }
        public double income { get; set; }
        public double capital { get; set; }
        public double personal_capital { get; set; }
        public int personal { get; set; }
        public double fish_stock { get; set; }
        private double prev_fish_stock { get; set; }
        public double prod { get; set; }
        private double kprod { get; set; } = 1;
        public double investition { get; set; }

        // initialize
        public Calculate()
        {
            //koef
            fish_koeff = 1.05;
            invest_koeff = 0.1;
            personal_koef = 0.1;

            //ship data
            ship_life = 20;
            ship_cost = 800;
            ship_command = 15;
            ship_earn = 30;
            ships.Add(ship_life);

            //salary
            salary = 10;

            //fish data
            fish_cost = 35;
            fish_stock = 10000;

            //capital data
            capital = 1000;
            personal_capital = 0;
        }
        public void Init(double fish_koeff, double invest_koeff, double personal_koeff, int ship_life,
            double ship_cost, int ship_command, double ship_earn, double salary,
            double fish_cost, double fish_stock, double capital, double personal_capital)
        {
            //koef
            this.fish_koeff = fish_koeff;
            this.invest_koeff = invest_koeff;
            this.personal_koef = personal_koef;

            //ship data
            this.ship_life = ship_life;
            this.ship_cost = ship_cost;
            this.ship_command = ship_command;
            this.ship_earn = ship_earn;
            this.ships.Clear();
            this.ships.Add(ship_life);

            //salary
            this.salary = salary;

            //fish data
            this.fish_cost = fish_cost;
            this.fish_stock = fish_stock;

            //capital data
            this.capital = capital;
            this.personal_capital = personal_capital;

            //reset values
            prod = investition = expenses = income = personal = 0;
        }


        //calculate methods
        public void Iteration()
        {
            ShipsCalculate();
            Amortization();
            FishStockCalculate();
            ExpensesCalculate();
            IncomeCalculate();
            CapitalCalculate();
        }


        //regulation
        public void Iteration(bool a)
        {
            FishStockCalculate();
            ExpensesCalculate();
            IncomeCalculate();
            CapitalCalculate();
            Amortization();
            Regulation();
        }
        private void Regulation()
        {
            if (fish_stock > prev_fish_stock)
            {
                kprod = 1;
                if (capital / ship_cost < 2.5 && capital - expenses < 0)
                {
                    invest_koeff = 0;
                    personal_koef = 0.1;
                }
                else
                {
                    invest_koeff = 0.7;
                    personal_koef = 0.15;
                    ShipsCalculate();
                }
            }
            else
            {
                invest_koeff = 0;
                personal_koef = 0.2;
                kprod = Math.Abs(fish_stock - prev_fish_stock) / fish_stock;
            }
        }

        private void IncomeCalculate()
        {
            income = prod * fish_cost;
        }
        private void ExpensesCalculate()
        {
            personal = ship_command * ships.Count;
            expenses = personal * salary + ship_cost / ship_life * ships.Count;
        }
        private double GetEff()
        {
            if (fish_stock > 1000)
                return 1;
            else
                return Math.Sqrt(fish_stock / 1000.0);
        }
        private void FishStockCalculate()
        {
            prev_fish_stock = fish_stock;
            double eff = GetEff();
            if (ships.Count * ship_earn * eff > fish_stock) prod = 0;
            else prod = ships.Count * ship_earn * eff;
            if (prod / fish_stock > 0.5) prod = 0;
            fish_stock = fish_stock * fish_koeff - prod;
        }
        private void Amortization()
        {
            for (var i = 0; i < ships.Count; i++)
            {
                if (ships[i] > 1) ships[i]--;
                else ships.RemoveAt(i);
            }
        }
        private void CapitalCalculate()
        {
            var benefit = income - expenses;
            if (benefit > 0)
            {
                var p_salary = benefit * personal_koef;
                var investsum = benefit * invest_koeff;
                personal_capital += p_salary;
                investition += investsum;
                capital = capital + benefit - investsum - p_salary;
            }
            else capital += benefit;
        }
        private void ShipsCalculate()
        {
            if (investition > ship_cost)
            {
                ships.Add(ship_life);
                investition -= ship_cost;
            }
        }
    }
}
