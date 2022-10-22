using FastColoredTextBoxNS;
using Newtonsoft.Json;
using SD_Prompt_Manager.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace SD_Prompt_Manager
{
    public partial class Form1 : Form
    {
        private List<Prompt> Prompts = new List<Prompt>();
        private int currentPage = 0;
        public Form1()
        {
            InitializeComponent();
            loadPromptsFromJson(Path.Combine(Environment.CurrentDirectory, @"Save\", "default.json"));
            if(Prompts.Count == 0)
            {
                Prompts.Add(new Prompt("first", "", "", "", -1, 7, 75));
                updatePromptDataGrid();
            }
        }

        

        private void updatePromptDataGrid()
        {

            //WebComicGrid.DataSource = null;
            var bindingList = new BindingList<Prompt>(Prompts);
            var source = new BindingSource(bindingList, null);
            PromptDataGrid.DataSource = source;
            //WebComicGrid.DataSource = WebComic;
            PromptDataGrid.Update();
            PromptDataGrid.Refresh();


            //Form1.ActiveForm.Text = Prompts[currentPage].Name;
        }

        private void PromptDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Prompts.Count > e.RowIndex)
            {
                Prompt selectedPage = Prompts[e.RowIndex];

                txt2imgPositive.Text = selectedPage.Positive;
                txt2imgNegative.Text = selectedPage.Negative;

                currentPage = e.RowIndex;
            }
        }

        private void promptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt newPage = new Prompt("NewPrompt", "", "", "", -1, 7, 75);
            Prompts.Add(newPage);
            updatePromptDataGrid();
            PromptDataGrid.ClearSelection();
            PromptDataGrid.FirstDisplayedScrollingRowIndex = PromptDataGrid.RowCount - 1;
            PromptDataGrid.Rows[PromptDataGrid.RowCount - 1].Selected = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string save = JsonConvert.SerializeObject(Prompts, Formatting.Indented);
            string fileName = "default" + ".json";
            string path = Path.Combine(Environment.CurrentDirectory, @"Save\", fileName);
            if (!Directory.Exists(path))
            {
                // Try to create the directory.
                string FolderPath = Path.Combine(Environment.CurrentDirectory, @"Save\");
                DirectoryInfo di = Directory.CreateDirectory(FolderPath);
            }
            File.WriteAllText(path, save);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadPromptsFromJson(string JsonPath)
        {
            if (!File.Exists(JsonPath))
            {
                return;
            } 
            string jsonString = File.ReadAllText(JsonPath);
            Prompts = JsonConvert.DeserializeObject<List<Prompt>>(jsonString);
            updatePromptDataGrid();
        }

        private void imagepreview_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void txt2imgPositive_TextChangedDelayed(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            Prompts[currentPage].Positive = txt2imgPositive.Text;
        }

        private void txt2imgNegative_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            Prompts[currentPage].Negative = txt2imgNegative.Text;
        }

        private void STEPS_ValueChanged(object sender, EventArgs e)
        {
            Prompts[currentPage].Steps = (int)STEPS.Value;
        }

        private void Width_Scroll(object sender, EventArgs e)
        {
            Prompts[currentPage].Width = Width.Value;
            WidthText.Text = Width.Value.ToString();
        }

        private void Height_Scroll(object sender, EventArgs e)
        {
            Prompts[currentPage].Height = Height.Value;
            HeightText.Text = Height.Value.ToString();
        }

        private void CFG_Scroll(object sender, EventArgs e)
        {
            Prompts[currentPage].CFG = CFG.Value;
            CFGText.Text = CFG.Value.ToString();
        }

        private void Denoise_Scroll(object sender, EventArgs e)
        {
            Prompts[currentPage].Denoise = Denoise.Value;
            DenoiseText.Text = Denoise.Value.ToString();
        }

        private void SEED_ValueChanged(object sender, EventArgs e)
        {
            Prompts[currentPage].Seed = (int)SEED.Value;
        }
    }
}
