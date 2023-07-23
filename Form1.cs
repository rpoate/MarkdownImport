namespace MarkdownImport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var oMarkdownBtn = this.htmlEditControl1.ToolStripItems.Add("Add Markdown");
            oMarkdownBtn.Padding = new System.Windows.Forms.Padding(3);
            oMarkdownBtn.Click += OMarkdownBtn_Click;

            this.htmlEditControl1.CleanMSWordHTMLOnPaste = true;

        }

        private void OMarkdownBtn_Click(object? sender, EventArgs e)
        {

            MarkdownSharp.Markdown oMD = new MarkdownSharp.Markdown();
            
            this.htmlEditControl1.InsertHTMLELement("div").InnerHtml = oMD.Transform("## Welcome to a Heading\r\n\r\n" +
                "This is a standard sentence\r\n\r\n" +
                "* list item 1\r\n* list item 2." +
                "\r\n\r\n[Read more here](https://www.zoople.tech).\r\n");


        }
    }
}