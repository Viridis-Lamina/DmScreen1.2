using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DmScreen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random(); // Declare Random instance outside methods

        private void button1_Click(object sender, EventArgs e)
        {
            string dicestring = Dicebox.Text;

            // New code using the flexible dice rolling mechanism for attack roll
            Tuple<int, string> attackRollResult = RollDice(dicestring);

            int diceresult = attackRollResult.Item1;
            string diceRollDetails = attackRollResult.Item2;

            int AC = comboBox1.SelectedItem?.ToString() != null ? int.Parse(comboBox1.SelectedItem.ToString()) : 0;
            int damageresult = 0;

            Random random = new Random();

            bool advantage = checkBoxAdvantage.Checked;
            bool disadvantage = checkBoxDisadvantage.Checked;

            // Check if both advantage and disadvantage are selected
            if (advantage && disadvantage)
            {
                MessageBox.Show("Cannot select both Advantage and Disadvantage.");
                return;
            }

            // Display the details of the attack roll
            label1.Text = $"Attack Roll: {diceRollDetails}\nEnemy AC: {AC}\n";

            int roll1 = random.Next(1, 21);
            int roll2 = random.Next(1, 21);

            if (advantage)
            {
                diceresult = Math.Max(roll1, roll2);
                label1.Text += $"\nRoll 1: {roll1} \nRoll 2: {roll2}";
            }
            else if (disadvantage)
            {
                diceresult = Math.Min(roll1, roll2);
                label1.Text += $"\nRoll 1: {roll1} \nRoll 2: {roll2}";
            }
            else
            {
                diceresult = roll1;
            }

            // Handle damage roll
            string damagestring = Damagebox.Text;

            // New code using the flexible dice rolling mechanism for damage roll
            Tuple<int, string> damageRollResult = RollDice(damagestring);

            damageresult = damageRollResult.Item1;
            string damageRollDetails = damageRollResult.Item2;

            // Display the details of the damage roll
            label4.Text = $"Damage Roll: {damageRollDetails}\n";

            // Check for critical hit
            if (diceresult == 20)
            {
                damageresult *= 2;
                label4.Text += $"Critical hit! You deal {damageresult} damage!";
            }
            else
            {
                label4.Text += $"You deal {damageresult} damage!";
            }

            // Display the result of the attack
            if (diceresult > AC)
            {
                label3.Text = "It's a Hit";
            }
            else
            {
                label3.Text = "It's a miss!";
            }
        }

        private Tuple<int, string> RollDice(string input)
        {
            int total = 0;
            List<string> rolls = new List<string>();

            // Use regular expression to extract dice and constants
            string pattern = @"(\d+d\d+|\d+)";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string matchValue = match.Value;

                if (matchValue.Contains("d"))
                {
                    // It's a dice expression like NdM
                    Tuple<int, string> diceRollResult = RollSingleDice(matchValue);
                    total += diceRollResult.Item1;

                    rolls.Add($"{matchValue} ({diceRollResult.Item2})");
                }
                else
                {
                    // It's a constant
                    total += int.Parse(matchValue);
                    rolls.Add($"{matchValue}");
                }
            }

            string calculation = string.Join(" + ", rolls);
            return Tuple.Create(total, calculation);
        }

        private Tuple<int, string> RollSingleDice(string diceExpression)
        {
            string[] parts = diceExpression.Split('d');
            int count = int.Parse(parts[0]);
            int type = int.Parse(parts[1]);

            Random random = new Random();
            List<int> individualRolls = new List<int>();
            int result = Enumerable.Range(1, count).Sum(_ =>
            {
                int roll = random.Next(1, type + 1);
                individualRolls.Add(roll);
                return roll;
            });

            string rollsText = $"{string.Join(", ", individualRolls)}";
            return Tuple.Create(result, rollsText);
        }
    }
}
