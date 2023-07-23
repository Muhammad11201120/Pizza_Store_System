using System;
using System.Windows.Forms;

namespace Pizza
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void changeSizeLabel()
        {
            updatePrise();
            if ( rbSmall.Checked )
            {
                lblSizeResult.Text = "Small";
                return;
            }
            if ( rbMedium.Checked )
            {
                lblSizeResult.Text = "Medium";
                return;
            }
            lblSizeResult.Text = "Large";
        }
        void changeCrust()
        {
            updatePrise();
            if ( rbThik.Checked )
            {
                lblCrustTypeResult.Text = "Thik";
                return;
            }
            lblCrustTypeResult.Text = "Thin";
        }
        void updateToppings()
        {
            updatePrise();
            string sToppings = "";
            if ( checkBox1.Checked )
            {
                sToppings += ", Extra Cheese";
            }
            if ( checkBox2.Checked )
            {
                sToppings += ", Mushrooms";
            }
            if ( checkBox3.Checked )
            {
                sToppings += ", Tomatoes";
            }
            if ( checkBox4.Checked )
            {
                sToppings += ", Onion";
            }
            if ( checkBox5.Checked )
            {
                sToppings += ", Olives";
            }
            if ( checkBox6.Checked )
            {
                sToppings += ", Green Peppers";
            }
            if ( sToppings.StartsWith( "," ) )
            {
                sToppings = sToppings.Substring( 1, sToppings.Length - 1 ).Trim();
            }
            if ( sToppings == "" )
            {
                sToppings = "No Toppings";
            }

            lblToppingsResult.Text = sToppings;
        }
        float selectedSizePris()
        {
            if ( rbSmall.Checked )
            {
                return Convert.ToSingle( rbSmall.Tag );
            }
            if ( rbMedium.Checked )
            {
                return Convert.ToSingle( rbMedium.Tag );
            }
            return Convert.ToSingle( rbLarge.Tag );
        }
        float selectedCrustPrise()
        {
            if ( rbThin.Checked )
            {
                return Convert.ToSingle( rbThin.Tag );
            }
            return Convert.ToSingle( rbThik.Tag );
        }
        float selectedToppingsPrise()
        {
            float total = 0;
            if ( checkBox1.Checked )
            {
                total += Convert.ToSingle( checkBox1.Tag );
            }
            if ( checkBox2.Checked )
            {
                total += Convert.ToSingle( checkBox1.Tag );
            }
            if ( checkBox3.Checked )
            {
                total += Convert.ToSingle( checkBox1.Tag );
            }
            if ( checkBox4.Checked )
            {
                total += Convert.ToSingle( checkBox1.Tag );
            }
            if ( checkBox5.Checked )
            {
                total += Convert.ToSingle( checkBox1.Tag );
            }
            if ( checkBox6.Checked )
            {
                total += Convert.ToSingle( checkBox1.Tag );
            }
            return total;
        }
        float calculatePrise()
        {
            return selectedSizePris() + selectedCrustPrise() + selectedToppingsPrise();
        }
        void updatePrise()
        {
            lblTotalPriseResult.Text = " $ " + calculatePrise().ToString();
        }
        void ResetForm()
        {

            //reset Groups
            gbxRbSize.Enabled = true;
            gbxRbCrustType.Enabled = true;
            gbxRbWhereToEat.Enabled = true;
            gbxToppings.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            //reset CrustType
            rbThin.Checked = true;

            //reset Where to Eat
            rbOutOrder.Checked = true;

            //Reset Order Button
            btnOrder.Enabled = true;

        }
        private void rbSmall_CheckedChanged( object sender, System.EventArgs e )
        {

            changeSizeLabel();
        }

        private void rbMedium_CheckedChanged( object sender, System.EventArgs e )
        {
            changeSizeLabel();
        }

        private void rbLarge_CheckedChanged( object sender, System.EventArgs e )
        {
            changeSizeLabel();
        }

        private void rbThin_CheckedChanged( object sender, System.EventArgs e )
        {
            changeCrust();
        }

        private void rbThik_CheckedChanged( object sender, System.EventArgs e )
        {
            changeCrust();
        }

        private void rbOutOrder_CheckedChanged( object sender, System.EventArgs e )
        {
            lblWhereToEatResult.Text = "Out Order";
        }

        private void rbInOrder_CheckedChanged( object sender, System.EventArgs e )
        {
            lblWhereToEatResult.Text = "In Order";
        }

        private void checkBox1_CheckedChanged( object sender, EventArgs e )
        {
            updateToppings();
        }

        private void checkBox2_CheckedChanged( object sender, EventArgs e )
        {
            updateToppings();
        }

        private void checkBox3_CheckedChanged( object sender, EventArgs e )
        {
            updateToppings();
        }

        private void checkBox4_CheckedChanged( object sender, EventArgs e )
        {
            updateToppings();
        }

        private void checkBox5_CheckedChanged( object sender, EventArgs e )
        {
            updateToppings();
        }

        private void checkBox6_CheckedChanged( object sender, EventArgs e )
        {
            updateToppings();
        }

        private void btnOrder_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Confirm this Order ?? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
            {
                gbxRbSize.Enabled = false;
                gbxRbCrustType.Enabled = false;
                gbxRbWhereToEat.Enabled = false;
                gbxToppings.Enabled = false;
                btnOrder.Enabled = false;
                MessageBox.Show( "Your Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnReset_Click( object sender, EventArgs e )
        {
            ResetForm();
        }

        private void frmMain_Load( object sender, EventArgs e )
        {
            // to calculate price from selected items when loading form
            changeCrust();
            changeSizeLabel();
            updatePrise();
            updateToppings();
        }
    }
}
