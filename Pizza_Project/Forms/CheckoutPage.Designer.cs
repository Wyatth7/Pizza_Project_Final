namespace Pizza_Project.Forms
{
    partial class CheckoutPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.deliveryComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryText = new System.Windows.Forms.Label();
            this.deliveryInputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.zipCodeInput = new System.Windows.Forms.TextBox();
            this.stateInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.paymentText = new System.Windows.Forms.Label();
            this.paymentInputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cvcInput = new System.Windows.Forms.TextBox();
            this.expInput = new System.Windows.Forms.TextBox();
            this.cardNumberInput = new System.Windows.Forms.TextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.nameOnCardInput = new System.Windows.Forms.TextBox();
            this.cardExpLabel = new System.Windows.Forms.Label();
            this.cardCvcLabel = new System.Windows.Forms.Label();
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.errorText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.deliveryInputLayout.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.paymentInputLayout.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.61194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.38806F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.payButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.Orange;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(16, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(116, 28);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout";
            // 
            // payButton
            // 
            this.payButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payButton.BackColor = System.Drawing.Color.Orange;
            this.payButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.Location = new System.Drawing.Point(548, 8);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(116, 28);
            this.payButton.TabIndex = 3;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 90);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.92776F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.07224F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(676, 242);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delivery Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Items";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(271, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Payment Type";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.deliveryComboBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.deliveryText, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.deliveryInputLayout, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(453, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(219, 205);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // deliveryComboBox
            // 
            this.deliveryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deliveryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliveryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deliveryComboBox.FormattingEnabled = true;
            this.deliveryComboBox.Items.AddRange(new object[] {
            "Pickup",
            "Delivery"});
            this.deliveryComboBox.Location = new System.Drawing.Point(3, 3);
            this.deliveryComboBox.Name = "deliveryComboBox";
            this.deliveryComboBox.Size = new System.Drawing.Size(213, 27);
            this.deliveryComboBox.TabIndex = 0;
            this.deliveryComboBox.SelectedIndexChanged += new System.EventHandler(this.deliveryComboBox_SelectedIndexChanged);
            // 
            // deliveryText
            // 
            this.deliveryText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deliveryText.AutoSize = true;
            this.deliveryText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deliveryText.ForeColor = System.Drawing.Color.White;
            this.deliveryText.Location = new System.Drawing.Point(60, 34);
            this.deliveryText.Name = "deliveryText";
            this.deliveryText.Size = new System.Drawing.Size(99, 19);
            this.deliveryText.TabIndex = 3;
            this.deliveryText.Text = "Enter Address";
            // 
            // deliveryInputLayout
            // 
            this.deliveryInputLayout.ColumnCount = 2;
            this.deliveryInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.68075F));
            this.deliveryInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.31925F));
            this.deliveryInputLayout.Controls.Add(this.zipCodeInput, 1, 3);
            this.deliveryInputLayout.Controls.Add(this.stateInput, 1, 2);
            this.deliveryInputLayout.Controls.Add(this.cityInput, 1, 1);
            this.deliveryInputLayout.Controls.Add(this.label6, 0, 1);
            this.deliveryInputLayout.Controls.Add(this.label5, 0, 0);
            this.deliveryInputLayout.Controls.Add(this.addressInput, 1, 0);
            this.deliveryInputLayout.Controls.Add(this.label7, 0, 2);
            this.deliveryInputLayout.Controls.Add(this.label8, 0, 3);
            this.deliveryInputLayout.Location = new System.Drawing.Point(3, 61);
            this.deliveryInputLayout.Name = "deliveryInputLayout";
            this.deliveryInputLayout.RowCount = 5;
            this.deliveryInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.deliveryInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.deliveryInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.deliveryInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.deliveryInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.deliveryInputLayout.Size = new System.Drawing.Size(213, 132);
            this.deliveryInputLayout.TabIndex = 4;
            this.deliveryInputLayout.Visible = false;
            this.deliveryInputLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.cardDetailsLayout_Paint);
            // 
            // zipCodeInput
            // 
            this.zipCodeInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zipCodeInput.Location = new System.Drawing.Point(79, 104);
            this.zipCodeInput.Name = "zipCodeInput";
            this.zipCodeInput.Size = new System.Drawing.Size(131, 23);
            this.zipCodeInput.TabIndex = 12;
            this.zipCodeInput.TextChanged += new System.EventHandler(this.zipCodeInput_TextChanged);
            // 
            // stateInput
            // 
            this.stateInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stateInput.Location = new System.Drawing.Point(79, 71);
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(131, 23);
            this.stateInput.TabIndex = 11;
            this.stateInput.TextChanged += new System.EventHandler(this.stateInput_TextChanged);
            // 
            // cityInput
            // 
            this.cityInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityInput.Location = new System.Drawing.Point(79, 38);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(131, 23);
            this.cityInput.TabIndex = 10;
            this.cityInput.TextChanged += new System.EventHandler(this.cityInput_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "City";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // addressInput
            // 
            this.addressInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressInput.Location = new System.Drawing.Point(79, 5);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(131, 23);
            this.addressInput.TabIndex = 6;
            this.addressInput.TextChanged += new System.EventHandler(this.addressInput_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "State";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Zipcode";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.paymentComboBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.paymentText, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.paymentInputLayout, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(228, 34);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(219, 205);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.paymentComboBox.Location = new System.Drawing.Point(3, 3);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(213, 27);
            this.paymentComboBox.TabIndex = 0;
            this.paymentComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentComboBox_SelectedIndexChanged);
            // 
            // paymentText
            // 
            this.paymentText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentText.AutoSize = true;
            this.paymentText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentText.ForeColor = System.Drawing.Color.White;
            this.paymentText.Location = new System.Drawing.Point(46, 34);
            this.paymentText.Name = "paymentText";
            this.paymentText.Size = new System.Drawing.Size(127, 19);
            this.paymentText.TabIndex = 3;
            this.paymentText.Text = "Enter Card Details";
            // 
            // paymentInputLayout
            // 
            this.paymentInputLayout.ColumnCount = 2;
            this.paymentInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.paymentInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.paymentInputLayout.Controls.Add(this.cvcInput, 1, 3);
            this.paymentInputLayout.Controls.Add(this.expInput, 1, 2);
            this.paymentInputLayout.Controls.Add(this.cardNumberInput, 1, 1);
            this.paymentInputLayout.Controls.Add(this.cardNumberLabel, 0, 1);
            this.paymentInputLayout.Controls.Add(this.nameOnCardInput, 1, 0);
            this.paymentInputLayout.Controls.Add(this.cardExpLabel, 0, 2);
            this.paymentInputLayout.Controls.Add(this.cardCvcLabel, 0, 3);
            this.paymentInputLayout.Controls.Add(this.cardNameLabel, 0, 0);
            this.paymentInputLayout.Location = new System.Drawing.Point(3, 61);
            this.paymentInputLayout.Name = "paymentInputLayout";
            this.paymentInputLayout.RowCount = 5;
            this.paymentInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.paymentInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.paymentInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.paymentInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.paymentInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.paymentInputLayout.Size = new System.Drawing.Size(213, 133);
            this.paymentInputLayout.TabIndex = 4;
            this.paymentInputLayout.Visible = false;
            // 
            // cvcInput
            // 
            this.cvcInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cvcInput.Location = new System.Drawing.Point(103, 104);
            this.cvcInput.Name = "cvcInput";
            this.cvcInput.Size = new System.Drawing.Size(107, 23);
            this.cvcInput.TabIndex = 12;
            this.cvcInput.TextChanged += new System.EventHandler(this.cvcInput_TextChanged);
            // 
            // expInput
            // 
            this.expInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expInput.Location = new System.Drawing.Point(103, 71);
            this.expInput.Name = "expInput";
            this.expInput.Size = new System.Drawing.Size(107, 23);
            this.expInput.TabIndex = 11;
            this.expInput.TextChanged += new System.EventHandler(this.expInput_TextChanged);
            // 
            // cardNumberInput
            // 
            this.cardNumberInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardNumberInput.Location = new System.Drawing.Point(103, 38);
            this.cardNumberInput.Name = "cardNumberInput";
            this.cardNumberInput.Size = new System.Drawing.Size(107, 23);
            this.cardNumberInput.TabIndex = 10;
            this.cardNumberInput.TextChanged += new System.EventHandler(this.cardNumberInput_TextChanged);
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardNumberLabel.ForeColor = System.Drawing.Color.White;
            this.cardNumberLabel.Location = new System.Drawing.Point(46, 40);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(51, 19);
            this.cardNumberLabel.TabIndex = 7;
            this.cardNumberLabel.Text = "Card #";
            this.cardNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameOnCardInput
            // 
            this.nameOnCardInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOnCardInput.Location = new System.Drawing.Point(103, 5);
            this.nameOnCardInput.Name = "nameOnCardInput";
            this.nameOnCardInput.Size = new System.Drawing.Size(107, 23);
            this.nameOnCardInput.TabIndex = 6;
            this.nameOnCardInput.TextChanged += new System.EventHandler(this.nameOnCardInput_TextChanged);
            // 
            // cardExpLabel
            // 
            this.cardExpLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cardExpLabel.AutoSize = true;
            this.cardExpLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardExpLabel.ForeColor = System.Drawing.Color.White;
            this.cardExpLabel.Location = new System.Drawing.Point(64, 73);
            this.cardExpLabel.Name = "cardExpLabel";
            this.cardExpLabel.Size = new System.Drawing.Size(33, 19);
            this.cardExpLabel.TabIndex = 8;
            this.cardExpLabel.Text = "EXP";
            // 
            // cardCvcLabel
            // 
            this.cardCvcLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cardCvcLabel.AutoSize = true;
            this.cardCvcLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardCvcLabel.ForeColor = System.Drawing.Color.White;
            this.cardCvcLabel.Location = new System.Drawing.Point(61, 106);
            this.cardCvcLabel.Name = "cardCvcLabel";
            this.cardCvcLabel.Size = new System.Drawing.Size(36, 19);
            this.cardCvcLabel.TabIndex = 9;
            this.cardCvcLabel.Text = "CVC";
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cardNameLabel.AutoSize = true;
            this.cardNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardNameLabel.ForeColor = System.Drawing.Color.White;
            this.cardNameLabel.Location = new System.Drawing.Point(50, 7);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(47, 19);
            this.cardNameLabel.TabIndex = 5;
            this.cardNameLabel.Text = "Name";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.itemDataGridView, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(219, 205);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToResizeColumns = false;
            this.itemDataGridView.AllowUserToResizeRows = false;
            this.itemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemDataGridView.BackgroundColor = System.Drawing.Color.DimGray;
            this.itemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemDataGridView.EnableHeadersVisualStyles = false;
            this.itemDataGridView.GridColor = System.Drawing.Color.DimGray;
            this.itemDataGridView.Location = new System.Drawing.Point(3, 3);
            this.itemDataGridView.MultiSelect = false;
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.RowHeadersVisible = false;
            this.itemDataGridView.RowTemplate.Height = 25;
            this.itemDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemDataGridView.ShowCellErrors = false;
            this.itemDataGridView.ShowCellToolTips = false;
            this.itemDataGridView.ShowEditingIcon = false;
            this.itemDataGridView.ShowRowErrors = false;
            this.itemDataGridView.Size = new System.Drawing.Size(213, 199);
            this.itemDataGridView.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(103, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 23);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(103, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 23);
            this.textBox2.TabIndex = 11;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.08876F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.91124F));
            this.tableLayoutPanel8.Controls.Add(this.errorText, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(12, 55);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(676, 34);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // errorText
            // 
            this.errorText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorText.ForeColor = System.Drawing.Color.White;
            this.errorText.Location = new System.Drawing.Point(673, 7);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 19);
            this.errorText.TabIndex = 0;
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckoutPage";
            this.Text = "Checkout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckoutPage_FormClosing);
            this.Load += new System.EventHandler(this.CheckoutPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.deliveryInputLayout.ResumeLayout(false);
            this.deliveryInputLayout.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.paymentInputLayout.ResumeLayout(false);
            this.paymentInputLayout.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox deliveryComboBox;
        private System.Windows.Forms.Label deliveryText;
        private System.Windows.Forms.TableLayoutPanel deliveryInputLayout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zipCodeInput;
        private System.Windows.Forms.TextBox stateInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.Label paymentText;
        private System.Windows.Forms.TableLayoutPanel paymentInputLayout;
        private System.Windows.Forms.TextBox cvcInput;
        private System.Windows.Forms.TextBox expInput;
        private System.Windows.Forms.TextBox cardNumberInput;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label cardNameLabel;
        private System.Windows.Forms.TextBox nameOnCardInput;
        private System.Windows.Forms.Label cardExpLabel;
        private System.Windows.Forms.Label cardCvcLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label errorText;
    }
}