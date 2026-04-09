namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppname = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMenu = new GroupBox();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppname
            // 
            lblAppname.AutoSize = true;
            lblAppname.Font = new Font("맑은 고딕", 30F);
            lblAppname.ForeColor = SystemColors.HotTrack;
            lblAppname.Location = new Point(12, 9);
            lblAppname.Name = "lblAppname";
            lblAppname.Size = new Size(371, 54);
            lblAppname.TabIndex = 0;
            lblAppname.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 20F);
            rdoHamBurger.ForeColor = SystemColors.ActiveCaptionText;
            rdoHamBurger.Location = new Point(37, 117);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(116, 41);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 20F);
            rdoBulgogiBurger.ForeColor = SystemColors.ActiveCaptionText;
            rdoBulgogiBurger.Location = new Point(37, 227);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(170, 41);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 20F);
            rdoChickenBurger.ForeColor = SystemColors.ActiveCaptionText;
            rdoChickenBurger.Location = new Point(37, 343);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(143, 41);
            rdoChickenBurger.TabIndex = 1;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(224, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(224, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(224, 331);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 20F);
            chkPotato.ForeColor = SystemColors.ActiveCaptionText;
            chkPotato.Location = new Point(28, 38);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(144, 41);
            chkPotato.TabIndex = 3;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 20F);
            chkCola.ForeColor = SystemColors.ActiveCaptionText;
            chkCola.Location = new Point(28, 120);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(90, 41);
            chkCola.TabIndex = 3;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 20F);
            chkCheese.ForeColor = SystemColors.ActiveCaptionText;
            chkCheese.Location = new Point(28, 212);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(153, 41);
            chkCheese.TabIndex = 3;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 20F);
            chkSauce.ForeColor = SystemColors.ActiveCaptionText;
            chkSauce.Location = new Point(28, 299);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(153, 41);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Font = new Font("맑은 고딕", 15F);
            grpMenu.ForeColor = Color.IndianRed;
            grpMenu.Location = new Point(12, 66);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(362, 372);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkCheese);
            grpOption.Font = new Font("맑은 고딕", 15F);
            grpOption.ForeColor = Color.IndianRed;
            grpOption.Location = new Point(380, 66);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(217, 372);
            grpOption.TabIndex = 1;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 15F);
            grpOrder.ForeColor = Color.IndianRed;
            grpOrder.Location = new Point(603, 66);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(313, 299);
            grpOrder.TabIndex = 5;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 18F);
            lblTotalCost.ForeColor = SystemColors.MenuHighlight;
            lblTotalCost.Location = new Point(23, 254);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(152, 32);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(23, 39);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(272, 200);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.GreenYellow;
            btnOrder.Font = new Font("맑은 고딕", 20F);
            btnOrder.Location = new Point(612, 379);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(147, 59);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.LightCoral;
            btnInit.Font = new Font("맑은 고딕", 20F);
            btnInit.Location = new Point(776, 379);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(140, 59);
            btnInit.TabIndex = 3;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 460);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rdoChickenBurger);
            Controls.Add(rdoBulgogiBurger);
            Controls.Add(rdoHamBurger);
            Controls.Add(grpMenu);
            Controls.Add(lblAppname);
            Controls.Add(grpOption);
            Name = "Form1";
            Text = "Burger Kiost v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppname;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnInit;
    }
}
