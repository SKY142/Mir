﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LexicalAnaylzerRexton
{
    public partial class Form1 : Form
    {

        breakWork wordBreaker;
        List<token> wordBreakerOutput;
        List<token> TokenOutput;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    codebox1.Text = text;
                }
                catch (IOException)
                {
                    MessageBox.Show("Can not read from file");
                }
            }
            //codebox1.Text = "25.1aa.24";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LexAnalyzer lex = new LexAnalyzer();
            if (codebox1.Text.Length > 0) {
                wordBreaker = new breakWork();

                wordBreakerOutput = new List<token>();
                TokenOutput = new List<token>();

                wordBreakerOutput = wordBreaker.breakString(codebox1.Text);

                foreach (token s in wordBreakerOutput)
                {
                    if (lex.checkKeyword(s.wordStr) != "") {
                        codebox1.Text += lex.checkKeyword(s.wordStr) + "\n";
                    }

                    if (lex.checkPunctuators(s.wordStr) != "")
                    {
                        codebox1.Text += lex.checkPunctuators(s.wordStr) + "\n";
                    }
                    
                    richTextBox1.Text += "(" + s.lineNumber + ") " + s.wordStr + "\n";
                }
            }
        }
    }
}
