namespace tonkIDE
{
    public partial class TonkIDE : Form
    {

        public TonkIDE()
        {
            InitializeComponent();

        }

        private void new_txt_Click(object sender, EventArgs e)
        {
            Editor EditorWindow = new Editor();
            EditorWindow.richTBtext = "";
            EditorWindow.codeVal = false;
            EditorWindow.ShowDialog();
        }
        private void new_txt_MouseEnter(object sender, EventArgs e)
        {
            this.new_txt.BackColor = Color.Indigo;
        }

        private void new_cpp_Click(object sender, EventArgs e)
        {
            Editor EditorWindow = new Editor();
            EditorWindow.richTBtext = "#include <iostream> \n using namespace std; \n int main()\n{\n\n\nint prevent_terminal_closing; \n cin>>prevent_terminal_closing;}";
            EditorWindow.codeVal = true;
            EditorWindow.ShowDialog();
        }

        private void open_cpp_Click(object sender, EventArgs e)
        {


            OpenFileDialog odf = new OpenFileDialog();
            if (odf.ShowDialog() == DialogResult.OK)
            {
                String S = File.ReadAllText(odf.FileName);
                Editor EditorWindow = new Editor();
                EditorWindow.codeVal = true;
                EditorWindow.richTBtext = S;
                EditorWindow.ShowDialog();

            }

        }

        private void open_txt_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            if (odf.ShowDialog() == DialogResult.OK)
            {
                String S = File.ReadAllText(odf.FileName);
                Editor EditorWindow = new Editor();
                EditorWindow.codeVal = false;
                EditorWindow.richTBtext = S;
                EditorWindow.ShowDialog();

            }
        }
    }
}
