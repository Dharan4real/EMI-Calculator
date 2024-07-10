using System.Data;


namespace EMIcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double principle = Convert.ToDouble(textBox_Principle.Text);
            double interest = Convert.ToDouble(textBox_Interest.Text) / 12 / 100;
            double tenure = Convert.ToDouble(textBox_Tenure.Text);

            double emi = principle * interest * Math.Pow((1 + interest), tenure) / (Math.Pow((1 + interest), tenure) - 1);
            double total_interest = 0;
            double total_amount = principle;
            DateTime monYr = DateTime.Now;
            double summa = 0;

            textBox_EMI_Result.Text = Math.Round(emi).ToString();

            DataTable emiTable = new DataTable();

            emiTable.Columns.Add("Year / Month");
            emiTable.Columns.Add("Principle");
            emiTable.Columns.Add("Interest");
            emiTable.Columns.Add("Total Payment");
            emiTable.Columns.Add("Balance");
            emiTable.Columns.Add("% Loan Paid");

            for (int i = 1; i <= tenure; i++)
            {
                double curIntrest = total_amount * interest;
                double curPrincipal = emi - curIntrest;
                total_interest += curIntrest;
                total_amount -= curPrincipal;

                DataRow row = emiTable.NewRow();
                row[0] = monYr.ToString("MMMM, yyyy");
                monYr = monYr.AddMonths(1);
                row[1] = Math.Round(curPrincipal);
                row[2] = Math.Round(curIntrest);
                row[3] = Math.Round(curPrincipal + curIntrest);
                row[4] = Math.Round(total_amount);
                summa += curPrincipal;
                row[5] = Math.Round(100 - ((principle - summa) / principle) * 100, 2);

                emiTable.Rows.Add(row);
            }

            textBox_TotalInterest_Result.Text = Math.Round(total_interest).ToString();
            textBox_TotalAmount_Result.Text = Math.Round(emi * tenure).ToString();



            dataGridView.DataSource = emiTable;

        }
    }
}
