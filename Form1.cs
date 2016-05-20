using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool inputset = false;
        bool outputset = false;
        string FileOutputPath;
        string FileInputPath;

        public Form1()
        {
            InitializeComponent();
            InputTooltip.SetToolTip(SourceLabel, "No source file selected");
            InputTooltip.SetToolTip(OutputLabel, "No output destination selected");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sourcefile = BrowseSourceDialog.ShowDialog(); // Show the dialog.
            if (sourcefile == DialogResult.OK) // Test result.
            {
                FileInputPath = BrowseSourceDialog.FileName;
                SourceLabel.Text = FileInputPath;
                inputset = true;
                InputTooltip.SetToolTip(SourceLabel, FileInputPath);
                if (inputset && outputset) button3.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult outputfile = BrowseOutputDialog.ShowDialog(); // Show the dialog.
            if (outputfile == DialogResult.OK) // Test result.
            {
                FileOutputPath = BrowseOutputDialog.SelectedPath;
                OutputLabel.Text = FileOutputPath;
                outputset = true;
                InputTooltip.SetToolTip(OutputLabel, FileOutputPath + "\\MyCollection.csv");
                if (inputset && outputset) button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgressLabel.Visible = false;
            ProgressLabel.Text = "In progress..";
            ProgressLabel.Visible = true;
            int size = -1;
            string text = " ";
            string result = BrowseSourceDialog.FileName;
            try
            {
                text = File.ReadAllText(result);
                size = text.Length;
                bool initem = false;
                for (int i = 0; i < size; i++)
                {
                    if (text[i] == '"')
                    {
                        initem = !initem;
                    }
                    else if (text[i] == ',' && !initem)
                    {
                        //text[i]. = ';';
                        text = text.Remove(i, 1);
                        text = text.Insert(i, ";");
                    }
                }

                StreamWriter sw = new StreamWriter(FileOutputPath + "\\MyCollection.csv");
                string[] lines = text.Split('\n');
                string[] items;
                string header = ",Name,Edition,Qty,Foil\n";
                sw.Write(header);
                for (int i = 1; i < lines.Length; i++)
                {
                    items = lines[i].Split(';');
                    if (items.Length == 15)
                    {
                        int foilnumber = Int32.Parse(items[2]);
                        if (foilnumber > 0)
                        {
                            sw.Write("," + items[3] + "," + items[4] + "," + items[2] + "," + "TRUE\n");
                        }
                        string layout = "," + items[3] + "," + items[4] + "," + items[1] + ","  + "FALSE\n";
                        sw.Write(layout);
                    }
                }

                sw.Close();
                ProgressLabel.Text = "Converting done";
                button3.Text = "Convert again";

            }
            catch (IOException ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
