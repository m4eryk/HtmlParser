using System;
using System.Windows.Forms;
using ParserHTML.core;

namespace ParserHTML
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;

        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                    new Parser()
                );

            parser.OnComplited += Parser_OnComplited;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object item, string[] titlesArray)
        {
            ListTitels.Items.AddRange(titlesArray);
        }

        private void Parser_OnComplited(object item)
        {
            MessageBox.Show("All work done!");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            parser.ParserSettings = new ParserSettings((int)NumericStart.Value, (int)NumericEnd.Value);
            parser.Start();
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
