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
            
            if (!Validators.IsMinimumLength(txtWidth.Text, 1) ||
            Validators.IsMinimumLength(txtHeight.Text, 1)) ;
            {
                //calculate width * height and change the total label
                int total = (int.Parse(txtWidth.Text)) * (int.Parse(txtHeight.Text));

                //change the label to show the total
                lblTotal.Text = "Total: " + total.ToString();
            }

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
