using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> symbolTable = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get symbol and value from textboxes.
            string symbol = textBox1.Text;
            int value;

            if (int.TryParse(textBox2.Text, out value))
            {
                // Add the symbol and its associated value to the symbol table.
                if (!symbolTable.ContainsKey(symbol))
                {
                    symbolTable[symbol] = value;
                    label1.Text = "Symbol added to the table.";
                }
                else
                {
                    label1.Text = "Symbol already exists.";
                }
            }
            else
            {
                label1.Text = "Invalid value.";
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            // Get symbol to search for.
            string symbolToSearch = textBox1.Text;

            // Check if the symbol exists in the table.
            if (symbolTable.ContainsKey(symbolToSearch))
            {
                int value = symbolTable[symbolToSearch];
                label1.Text = "Value: " + value;
            }
            else
            {
                label1.Text = "Symbol not found.";
            }
        }
    }
}
