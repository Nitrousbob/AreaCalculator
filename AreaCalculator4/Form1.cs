namespace AreaCalculator4
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load event when the form loads

            //change the text on the txtWidth to 314
            //txtWidth.Text = "314";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //btn needs to make a noise when pressed
            //btn also calculates some area
            int total = (int.Parse(txtWidth.Text)) * (int.Parse(txtHeight.Text));

            //lblTotal.Text = "Total: " + total.ToString();
        }
    }
}
