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
            
            if (ValidateField(txtWidth.Text, "The Width Field is too short."))
            {
                return;
            }
            if (ValidateField(txtHeight.Text, "The Height Field is too short."))
            {
                return;
            }

            if (Validators.ContainsInteger(txtWidth.Text, out int width) == false)
            {
                MessageBox.Show("The Width field is not a valid number.", "Error");
            }

            if (Validators.ContainsInteger(txtHeight.Text, out int height) == false)
            {
                MessageBox.Show("The Height field is not a valid number.", "Error");
            }

            //if (int.TryParse(txtWidth.Text, out int width) == false)
            //{
            //    MessageBox.Show("The Width field is not a valid number.", "Error");
            //    return;
            //}
            //if (int.TryParse(txtHeight.Text, out int height) == false)
            //{
            //    MessageBox.Show("The Height field is not a valid number.", "Error");
            //    return;
            //}

            //calculate width * height and change the total label
            int total = width * height;

            //change the label to show the total
            lblTotal.Text = "Total: " + total.ToString();
        }

        private bool ValidateField(string field, string errorMsg)
        {
            var result = !Validators.IsMinimumLength(field, 1);

            if (result)  //if result is true
            {
                var dialogResult = MessageBox.Show(
                    errorMsg,
                    "Error"
                    );
            }
            return result;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
