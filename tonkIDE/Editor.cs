using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static tonkIDE.Editor;
using System.IO;

namespace tonkIDE
{
    public partial class Editor : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public Editor()
        {

            InitializeComponent();
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            highlightAllCode();
            if (Properties.Settings.Default.theme == "Dark")
            {
                TH.setDarkTheme(richTextBox1, keywords, highlightAllCode);
            }
            if (Properties.Settings.Default.theme == "White")
            {
                TH.setWhiteTheme(richTextBox1, keywords, highlightAllCode);
            }
            if (Properties.Settings.Default.theme == "Obsidian")
            {
                TH.setObsidianTheme(richTextBox1, keywords, highlightAllCode);
            }
            if (Properties.Settings.Default.theme == "Brainhurt")
            {
                TH.setBrainhurtTheme(richTextBox1, keywords, highlightAllCode);
            }
            if (Properties.Settings.Default.theme == "SussyBaka")
            {
                TH.setDarkTheme(richTextBox1, keywords, highlightAllCode);
            }

            this.turtle_box.Visible = false;
            this.turtle_close.Visible = false;
            this.turtle_image.Visible = false;
            this.turtle_label.Visible = false;
            this.turtle_label.ReadOnly = true;

            this.richTextBox1.Multiline = true;
            richTextBox1.WordWrap = false;  // Disable word wrapping
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Horizontal;  // Enable horizontal scrollbar
            this.file_name.ReadOnly = true;



        }
        OpenFileDialog currFile = new OpenFileDialog();
        private bool isHighlighting = false;
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl + F is pressed
            if (e.Control && e.KeyCode == Keys.F)
            {
                // Call highlightAllCode function
                highlightAllCode();

                // Mark the event as handled to prevent any default behavior
                e.Handled = true;
            }
        }
        public delegate void HighlightDelegate();

        int a = 3;
        int b = 5;
        //THEME CHANGING CLASS METHODS
        public class themeChanger
        {
            public void setDarkTheme(RichTextBox richTextBox1, KW[] keywords, HighlightDelegate highlightAllCode)
            {
                richTextBox1.BackColor = Color.FromArgb(35, 35, 35);
                richTextBox1.ForeColor = Color.Silver;
                for (int i = 0; i < 5; i++) // cout,cin,new,return
                {
                    keywords[i].color = Color.Magenta;
                }
                keywords[4].color = Color.LightBlue; //include
                keywords[5].color = Color.DarkGreen; // << and >>
                keywords[6].color = Color.DarkGreen;
                for (int i = 7; i < 12; i++) //variables
                {
                    keywords[i].color = Color.CadetBlue;
                }
                keywords[13].color = Color.Violet; //Brackets
                keywords[14].color = Color.Violet;
                keywords[15].color = Color.DarkGreen; //class
                keywords[16].color = Color.DarkGreen;


                highlightAllCode();
                Properties.Settings.Default.theme = "Dark";
                Properties.Settings.Default.Save();
            }
            public void setWhiteTheme(RichTextBox richTextBox1, KW[] keywords, HighlightDelegate highlightAllCode)
            {
                richTextBox1.BackColor = Color.FromArgb(255, 255, 255);
                richTextBox1.ForeColor = Color.Black;
                for (int i = 0; i < 5; i++) // cout,cin,new,return
                {
                    keywords[i].color = Color.DarkMagenta;
                }
                keywords[4].color = Color.DarkBlue; //include
                keywords[5].color = Color.DarkGreen; // << and >>
                keywords[6].color = Color.DarkGreen;
                for (int i = 7; i < 12; i++) //variables
                {
                    keywords[i].color = Color.DarkOliveGreen;
                }
                keywords[13].color = Color.DarkViolet; //Brackets
                keywords[14].color = Color.DarkViolet;
                keywords[15].color = Color.DarkGreen; //class
                keywords[16].color = Color.DarkGreen;

                highlightAllCode();
                Properties.Settings.Default.theme = "White";
                Properties.Settings.Default.Save();
            }

            public void setObsidianTheme(RichTextBox richTextBox1, KW[] keywords, HighlightDelegate highlightAllCode)
            {
                richTextBox1.BackColor = Color.FromArgb(10, 0, 10);
                richTextBox1.ForeColor = Color.Silver;
                for (int i = 0; i < 5; i++) // cout,cin,new,return
                {
                    keywords[i].color = Color.Magenta;
                }
                keywords[4].color = Color.LightBlue; //include
                keywords[5].color = Color.DarkGreen; // << and >>
                keywords[6].color = Color.DarkGreen;
                for (int i = 7; i < 12; i++) //variables
                {
                    keywords[i].color = Color.CadetBlue;
                }
                keywords[13].color = Color.Violet; //Brackets
                keywords[14].color = Color.Violet;
                keywords[15].color = Color.DarkGreen; //class
                keywords[16].color = Color.DarkGreen;


                highlightAllCode();
                Properties.Settings.Default.theme = "Obsidian";
                Properties.Settings.Default.Save();

            }

            public void setBrainhurtTheme(RichTextBox richTextBox1, KW[] keywords, HighlightDelegate highlightAllCode)
            {
                richTextBox1.BackColor = Color.FromArgb(255, 128, 0);
                richTextBox1.ForeColor = Color.Pink;
                for (int i = 0; i < 5; i++) // cout,cin,new,return
                {
                    keywords[i].color = Color.Red;
                }
                keywords[4].color = Color.DarkOrange; //include
                keywords[5].color = Color.Coral; // << and >>
                keywords[6].color = Color.SeaGreen;
                for (int i = 7; i < 12; i++) //variables
                {
                    keywords[i].color = Color.SeaShell;
                }
                keywords[13].color = Color.Yellow; //Brackets
                keywords[14].color = Color.GreenYellow;
                keywords[15].color = Color.LawnGreen; //class
                keywords[16].color = Color.Gold;


                highlightAllCode();
                Properties.Settings.Default.theme = "Brainhurt";
                Properties.Settings.Default.Save();
            }
            public void setSussyBakaTheme(RichTextBox richTextBox1, KW[] keywords, HighlightDelegate highlightAllCode)
            {
                richTextBox1.BackColor = Color.FromArgb(0, 255, 0);
                richTextBox1.ForeColor = Color.Pink;
                for (int i = 0; i < 5; i++) // cout,cin,new,return
                {
                    keywords[i].color = Color.Red;
                }
                keywords[4].color = Color.DarkOrange; //include
                keywords[5].color = Color.Coral; // << and >>
                keywords[6].color = Color.SeaGreen;
                for (int i = 7; i < 12; i++) //variables
                {
                    keywords[i].color = Color.SeaShell;
                }
                keywords[13].color = Color.Yellow; //Brackets
                keywords[14].color = Color.GreenYellow;
                keywords[15].color = Color.LawnGreen; //class
                keywords[16].color = Color.Gold;


                highlightAllCode();
                Properties.Settings.Default.theme = "SussyBaka";
                Properties.Settings.Default.Save();
            }
        }


        themeChanger TH = new themeChanger();

        private Size oldSize;
        private void Form1_Load(object sender, EventArgs e) => oldSize = base.Size;

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
        }
        private void ResizeAll(Control control, Size newSize)
        {
            int width = newSize.Width - oldSize.Width;
            control.Left += (control.Left * width) / oldSize.Width;
            control.Width += (control.Width * width) / oldSize.Width;

            int height = newSize.Height - oldSize.Height;
            control.Top += (control.Top * height) / oldSize.Height;
            control.Height += (control.Height * height) / oldSize.Height;
        }

        public void openFile()
        {
            OpenFileDialog odf = new OpenFileDialog();
            if (odf.ShowDialog() == DialogResult.OK)
            {
                String S = File.ReadAllText(odf.FileName);
                this.richTextBox1.Text = S;
                this.codeVal = false;
                this.file_name.Text = odf.FileName;
                this.file_name.Text = odf.FileName;

                string directoryPath = Path.GetDirectoryName(odf.FileName);
                this.file_list.Items.Clear();
                String[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    this.file_list.Items.Add(Path.GetFileName(file)); // Only add the file name
                }
            }
        }
        public class KW
        {

            public String keyword;
            public Color color;
            public int ID;
            public KW(String k, Color c, int i)
            {
                this.keyword = k;
                this.color = c;
                this.ID = i;
            }

        }





        public void saveFile(String format)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string FileName = sfd.FileName + format;
                File.WriteAllText(FileName, this.richTextBox1.Text, Encoding.UTF8);
                this.file_name.Text = sfd.FileName;
            }

        }
        public char returnChar(String txt, int index)
        {
            return txt[index];
        }
        public void recolor(int startIndex, Color clr, int length)
        {
            this.richTextBox1.SelectionStart = startIndex;
            this.richTextBox1.SelectionLength = length;
            this.richTextBox1.SelectionColor = clr;

            // Deselect and reset color to default
            this.richTextBox1.SelectionStart = startIndex + length - 1;
            this.richTextBox1.SelectionLength = 0;
            this.richTextBox1.SelectionColor = richTextBox1.ForeColor;
            this.richTextBox1.DeselectAll();
        }
        public void recolor_initialize(String txt, int i)
        {

            if (returnChar(txt, i) == '{' || returnChar(txt, i) == '}')
            {
                recolor(i, Color.Violet, 1);
            }
            else
            if (returnChar(txt, i) == '(' || returnChar(txt, i) == ')')
            {
                recolor(i, Color.Violet, 1);
            }
            else
            if (returnChar(txt, i) == '[' || returnChar(txt, i) == ']')
            {
                recolor(i, Color.Violet, 1);
            }
            else
            if (returnChar(txt, i) == ';')
            {
                recolor(i, Color.Orange, 1);
            }
            else
            if (returnChar(txt, i) == '"' || returnChar(txt, i) == '"')
            {
                recolor(i, Color.Yellow, 1);
            }
            else
            {
                recolor(i, richTextBox1.ForeColor, 1);
            }
        }







        public List<int> FindAllOccurrences(string searchText, string keyword)
        {
            List<int> occurrences = new List<int>();
            int startIndex = 0;

            while ((startIndex = searchText.IndexOf(keyword, startIndex)) != -1)
            {
                // Add the index of the found keyword to the list
                occurrences.Add(startIndex);

                // Move startIndex past the current found keyword
                startIndex += keyword.Length;
            }

            return occurrences;
        }

        public void HighlightAllOccurrencesOf(String keyword, Color clr)
        {
            // Get the text from the RichTextBox
            string txt = this.richTextBox1.Text;

            // Find all occurrences of "cout"
            List<int> occurrences = FindAllOccurrences(txt, keyword);

            // Highlight each occurrence
            foreach (int index in occurrences)
            {
                recolor(index, clr, keyword.Length);
            }
        }


        KW[] keywords = new KW[]
       {
            new KW("cout", Color.Magenta,1),
            new KW("cin", Color.Magenta,2),
            new KW("new", Color.Magenta,3),
            new KW("return", Color.Magenta,4),
            new KW("#include", Color.LightBlue,5),
            new KW("<<", Color.DarkGreen,6),
            new KW(">>", Color.DarkGreen,7),

            new KW("int", Color.CadetBlue,8),
            new KW("String", Color.CadetBlue,9),
            new KW("string", Color.CadetBlue,10),
            new KW("boolean", Color.CadetBlue,11),
            new KW("float", Color.CadetBlue,12),
            new KW("double", Color.CadetBlue,13),

             new KW("{", Color.Violet,14),
             new KW("}", Color.Violet,15),


            new KW("class", Color.DarkGreen,16),
            new KW("Class", Color.DarkGreen,17),
       };



        public void HighlightXOccurrencesOf(string keyword, Color clr, int x)
        {
            // Get the text from the RichTextBox
            string txt = this.richTextBox1.Text;

            // Determine the starting index of search range based on the current cursor position
            int startIndex = Math.Max(0, this.richTextBox1.SelectionStart - x);

            // Adjust the search range based on the length of text
            string searchText = txt.Substring(startIndex, Math.Min(x, txt.Length - startIndex));

            // Find all occurrences of the keyword within the specified range
            List<int> occurrences = FindAllOccurrences(searchText, keyword);

            // Highlight each occurrence, adjusting the index to match the original text
            foreach (int index in occurrences)
            {
                int originalIndex = startIndex + index; // Adjust the index to match the original text
                recolor(originalIndex, clr, keyword.Length);
            }
        }

        String theme = "Dark";

        public void highlightAllCode()
        {
            // Set the flag to true to prevent TextChanged events
            isHighlighting = true;

            try
            {
                String txt = this.richTextBox1.Text;
                int length = this.richTextBox1.Text.Length;

                for (int i = 0; i < length; i++)
                {
                    recolor_initialize(txt, i);
                }

                int arr_length = keywords.Length;
                for (int i = 0; i < arr_length; i++)
                {
                    if (theme == "Dark")
                    {
                        HighlightAllOccurrencesOf(keywords[i].keyword, keywords[i].color);
                    }

                }
            }
            finally
            {
                // Reset the flag after highlighting is complete
                isHighlighting = false;
            }
        }
        public void highlightLastX(int x)
        {
            richTextBox1.SuspendLayout();
            String txt = this.richTextBox1.Text;
            int startIndex = richTextBox1.SelectionStart;
            for (int i = startIndex - x; i < startIndex; i++)
            {
                recolor_initialize(txt, i);
            }

            int arr_lenght = keywords.Length;
            for (int xyz = 0; xyz < arr_lenght; xyz++)
            {
                HighlightAllOccurrencesOf(keywords[xyz].keyword, keywords[xyz].color);
            }
            richTextBox1.ResumeLayout();
        }









        Boolean isCode = false;





        public OpenFileDialog setCurrFile
        {
            get
            {
                return this.currFile;
            }
            set
            {
                this.currFile = value;
                this.file_name.Text = currFile.FileName;
                string directoryPath = Path.GetDirectoryName(currFile.FileName);
                this.file_list.Items.Clear();
                String[] files = Directory.GetFiles(directoryPath);
                foreach (string file in files)
                {
                    this.file_list.Items.Add(Path.GetFileName(file)); // Only add the file name
                }
            }
        }

        public string richTBtext
        {
            get
            {
                return this.richTextBox1.Text;
            }
            set
            {
                this.richTextBox1.Text = value;
            }
        }
        public string fileNameText
        {
            get
            {
                return this.file_name.Text;
            }
            set
            {
                this.file_name.Text = value;
            }
        }

        public Boolean codeVal
        {
            get
            {
                return this.isCode;
            }
            set
            {
                this.isCode = value;
            }
        }

        public void runCPP()
        {

            FileDialog odf = new OpenFileDialog();
            odf.Filter = "C++ Files (*.cpp)|*.cpp";
            if (odf.ShowDialog() == DialogResult.OK)
            {

                string selectedFilePath = odf.FileName;
                string directoryPath = Path.GetDirectoryName(selectedFilePath);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(selectedFilePath);


                ProcessStartInfo compileProcess = new ProcessStartInfo();
                compileProcess.FileName = "cmd.exe";
                compileProcess.WindowStyle = ProcessWindowStyle.Normal;
                compileProcess.Arguments = $"/C g++ \"{selectedFilePath}\" -o \"{directoryPath}\\{fileNameWithoutExtension}.exe\"";


                using (Process process = Process.Start(compileProcess))
                {
                    process.WaitForExit();
                    if (process.ExitCode == 0)
                    {

                        ProcessStartInfo runProcess = new ProcessStartInfo();
                        runProcess.FileName = $"{directoryPath}\\{fileNameWithoutExtension}.exe";
                        runProcess.WorkingDirectory = directoryPath;
                        runProcess.WindowStyle = ProcessWindowStyle.Normal;


                        Process.Start(runProcess);
                    }
                    else
                    {
                        MessageBox.Show("Compilation failed. Check your code for errors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveAstxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(".txt");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.codeVal == true)
            {
                // Prevent recursive highlighting by checking the flag
                if (isHighlighting)
                    return;

                // Save the current caret position
                int currentPosition = richTextBox1.SelectionStart;

                // Suspend layout updates to prevent flickering
                richTextBox1.SuspendLayout();

                try
                {
                    // Call methods to highlight the last character and last word
                    int arr_length = keywords.Length;
                    for (int i = 0; i < arr_length; i++)
                    {
                        HighlightXOccurrencesOf(keywords[i].keyword, keywords[i].color, 7);

                    }

                    // Reset SelectionColor to default color (e.g., Color.Silver)
                    richTextBox1.SelectionStart = currentPosition;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.SelectionColor = richTextBox1.ForeColor; // Default color for non-highlighted text
                }
                finally
                {
                    // Resume layout updates
                    richTextBox1.ResumeLayout();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFile(".txt");
            this.codeVal = false;

        }

        private void open_txt_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void opentxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void open_cpp_Click(object sender, EventArgs e)
        {
            openFile();
            highlightAllCode();
        }

        private void opencppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
            highlightAllCode();
        }

        private void saveAscppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(".cpp");
        }

        private void newtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        private void save_cpp_Click(object sender, EventArgs e)
        {
            saveFile(".cpp");
            this.codeVal = true;
        }

        private void run_cpp_Click(object sender, EventArgs e)
        {
            runCPP();
            this.codeVal = true;
        }

        private void runCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runCPP();
        }

        private void new_cpp_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "#include <iostream> \n using namespace std; \n int main()\n{\n\n}";
            this.codeVal = true;
        }

        private void new_txt_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.codeVal = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void newcppFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "#include <iostream> \n using namespace std; \n int main()\n{\n\n}";
        }

        private void highlight_Click(object sender, EventArgs e)
        {
            if (this.codeVal == true)
            {
                highlightAllCode();
            }
        }
        public static int spaces = 4;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Handle Tab key
            if (keyData == Keys.Tab)
            {
                // Insert spaces at the current cursor position
                richTextBox1.SelectedText = new string(' ', spaces);
                return true; // Indicate that we've handled the key
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TH.setDarkTheme(richTextBox1, keywords, highlightAllCode);
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TH.setWhiteTheme(richTextBox1, keywords, highlightAllCode);
        }

        private void obsidianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TH.setObsidianTheme(richTextBox1, keywords, highlightAllCode);
        }

        private void brainHurtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TH.setBrainhurtTheme(richTextBox1, keywords, highlightAllCode);
        }
        private void sussyBakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TH.setSussyBakaTheme(richTextBox1, keywords, highlightAllCode);
        }

        private void debug_btn_Click(object sender, EventArgs e)
        {
            int lenght = this.richTextBox1.Text.Length;
            int openBracketCount = 0;
            int closedBracketCount = 0;

            for (int i = 0; i < lenght; i++)
            {
                if (richTextBox1.Text[i] == '{')
                {
                    openBracketCount++;
                }
                if (richTextBox1.Text[i] == '}')
                {
                    closedBracketCount++;
                }
            }
            if (openBracketCount == closedBracketCount)
            {
                MessageBox.Show("You have the correct number of brackets!", "Debug Bracket Counter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have: \n " + openBracketCount.ToString() + " Opening brackets  {  \n " + closedBracketCount.ToString() + " Closing Brackets  } ", "Debug Bracket Counter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void turtle_close_Click(object sender, EventArgs e)
        {
            this.turtle_box.Visible = false;
            this.turtle_close.Visible = false;
            this.turtle_image.Visible = false;
            this.turtle_label.Visible = false;
        }
        String[] turtle_quotes = new String[]
            {
                "You suck",
                "Bro forgot a semicolomn 😂😂😂",
                "This code = McDonald Ice cream machine",
                "You sure 'bout that?",
                "Go back to Scratch",
                "Ты полный отстой",
            };

        private void turtle_btn_Click(object sender, EventArgs e)
        {
            this.turtle_box.Visible = true;
            this.turtle_close.Visible = true;
            this.turtle_image.Visible = true;
            this.turtle_label.Visible = true;
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, 6);
            this.turtle_label.Text = turtle_quotes[rndIndex];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
    }
}
