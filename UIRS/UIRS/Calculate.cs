﻿using System;
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
        public int ship_life { get; set; }
        public double ship_cost { get; set; }
        public double salary { get; set; }
        public int ship_command { get; set; }
        public double ship_earn { get; set; }
        public double fish_cost { get; set; }

        //calculate prop
        public double expenses { get; set; }
        public double income { get; set; }
        public double capital { get; set; } = 1000;
        public double personal_capital { get; set; } = 0;
        public int personal { get; set; }
        public double fish_stock { get; set; } = 1000;
        public double prod { get; set; }
        public double investition { get; set; }

        public Calculate() 
        {
            fish_koeff = 1.05;
            invest_koeff = 0.1;
            ship_life = 20;
            ship_cost = 1500;
            salary = 10;
            ship_command = 15;
            ship_earn = 20;
            fish_cost = 35;
            capital = 1000;
            personal_capital = 0;
            fish_stock = 1000;
            ships.Add(ship_life);
        }
        //calculate methods
        public void Iteration() 
        {
            FishStockCalculate();
            ExpensesCalculate();
            IncomeCalculate();
            Amortization();
            CapitalCalculate();
            ShipsCalculate();
        }
        
        private void IncomeCalculate() 
        {
            income = prod * fish_cost;
        }
        private void ExpensesCalculate() 
        {
            personal = ship_command * ships.Count;
            expenses = personal * salary;
        }
        private void FishStockCalculate() 
        {
            double eff = Math.Sqrt(fish_stock / 1000);
            if (ships.Count * ship_earn * eff > fish_stock) prod = 0;
            else prod = ships.Count * ship_earn * eff;
            if (prod / fish_stock > 0.5) prod = 0;
            fish_stock = fish_stock * fish_koeff - prod;
        }
        private void Amortization() 
        {
            for (var i = 0; i < ships.Count; i++)
            {
                if (ships[i] > 0) ships[i]--;
                else ships.RemoveAt(i);
            }
        }
        private void CapitalCalculate() 
        {
            var benefit = income - expenses;
            if (benefit > 0)
            {
                personal_capital += benefit * (1 - invest_koeff);
                investition += benefit * invest_koeff;
                capital += benefit - benefit * invest_koeff - benefit * (1 - invest_koeff);
            }
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
