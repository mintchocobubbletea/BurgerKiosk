namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnOrder;
            this.ActiveControl = lblTotalCost;
        }
        int totalCost = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            rdoHamBurger.TabStop = true;
            rdoBulgogiBurger.TabStop = true;
            rdoChickenBurger.TabStop = true;
            rdoHamBurger.TabIndex = 0;
            rdoBulgogiBurger.TabIndex = 1;
            rdoChickenBurger.TabIndex = 2;
            grpMenu.Enter += (s, e) =>
            {
                rdoHamBurger.Focus();
            };
            rdoHamBurger.TabStop = true;
            rdoBulgogiBurger.TabStop = false;
            rdoChickenBurger.TabStop = false;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool isSelected = rdoHamBurger.Checked || rdoBulgogiBurger.Checked || rdoChickenBurger.Checked
                  || chkPotato.Checked || chkCola.Checked || chkCheese.Checked || chkSauce.Checked;

            if (!isSelected)
            {
                lblTotalCost.Text = "메뉴를 하나 이상 선택해주세요!";
                lblTotalCost.Font = new Font(lblTotalCost.Font.FontFamily, 12);
                lblTotalCost.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblTotalCost.ForeColor = Color.MediumBlue;
                lblTotalCost.Font = new Font(lblTotalCost.Font.FontFamily, 18);
                lblTotalCost.Text = "총 금액 : 0원";

            }

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 500원");
            }
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            this.ActiveControl = lblTotalCost;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Font = new Font(lblTotalCost.Font.FontFamily, 18);
            lblTotalCost.Text = "총 금액 : 0원";
        }

       
    }
}
