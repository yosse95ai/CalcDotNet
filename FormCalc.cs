using System;
using System.Windows.Forms;

namespace CalcDotNet
{
    public partial class FormCalc : Form
    {
        enum eArithmetic
        {
            Div,
            Mult,
            Sub,
            Add,
            None                
        }
        bool error = false;

        eArithmetic gArithmetic;
        decimal gVal1;

        public FormCalc()
        {
            InitializeComponent();
            cleaAction();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (error) return;
            Button btn = (Button)sender;
            decimal inpNum = decimal.Parse(this.txtResult.Text + btn.Text);
            this.txtResult.Text = inpNum.ToString();
        }

        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            if (error) return;
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "÷":
                    gArithmetic = eArithmetic.Div;
                    break;
                case "×":
                    gArithmetic = eArithmetic.Mult;
                    break;
                case "-":
                    gArithmetic = eArithmetic.Sub;
                    break;
                case "+":
                    gArithmetic = eArithmetic.Add;
                    break;
                default:
                    gArithmetic = eArithmetic.None;
                    break;
            }
            gVal1 = decimal.Parse(this.txtResult.Text);
            this.txtResult.Text = "0";
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            if (error) return;
            decimal val2 = decimal.Parse(this.txtResult.Text);
            decimal valResult = 0;
            switch (gArithmetic)
            {
                case eArithmetic.Div:
                    if (val2 == 0)
                    {
                        this.txtResult.Text = "Error";
                        initiliaze();
                        error = true;
                        return;
                    }
                    valResult = gVal1 / val2;
                    break;
                case eArithmetic.Mult:
                    valResult = gVal1 * val2;
                    break;
                case eArithmetic.Sub:
                    valResult = gVal1 - val2;
                    break;
                case eArithmetic.Add:
                    valResult = gVal1 + val2;
                    break;
            }
            this.txtResult.Text = (valResult).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleaAction();
        }
        private void initiliaze()
        {
            gVal1 = 0;
            gArithmetic = eArithmetic.None;
        }
        private void cleaAction()
        {
            initiliaze();
            this.txtResult.Text = "0";
            error = false;
        }
    }
}
