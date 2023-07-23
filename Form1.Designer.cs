namespace Pizza
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxRbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxRbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThik = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbxRbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbInOrder = new System.Windows.Forms.RadioButton();
            this.rbOutOrder = new System.Windows.Forms.RadioButton();
            this.gbxToppings = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbxSummary = new System.Windows.Forms.GroupBox();
            this.lblSizeResult = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTotalPriseResult = new System.Windows.Forms.Label();
            this.lblWhereToEatResult = new System.Windows.Forms.Label();
            this.lblCrustTypeResult = new System.Windows.Forms.Label();
            this.lblToppingsResult = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblTotalPrise = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.gbxRbSize.SuspendLayout();
            this.gbxRbCrustType.SuspendLayout();
            this.gbxRbWhereToEat.SuspendLayout();
            this.gbxToppings.SuspendLayout();
            this.gbxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font( "Segoe Script", 36F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 64 ) ) ) ), ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 64 ) ) ) ) );
            this.lblTitle.Location = new System.Drawing.Point( 258, 9 );
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size( 587, 80 );
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ORDER YOUR PIZZA";
            // 
            // gbxRbSize
            // 
            this.gbxRbSize.Controls.Add( this.rbLarge );
            this.gbxRbSize.Controls.Add( this.rbMedium );
            this.gbxRbSize.Controls.Add( this.rbSmall );
            this.gbxRbSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxRbSize.Font = new System.Drawing.Font( "Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.gbxRbSize.Location = new System.Drawing.Point( 35, 100 );
            this.gbxRbSize.Name = "gbxRbSize";
            this.gbxRbSize.Size = new System.Drawing.Size( 232, 165 );
            this.gbxRbSize.TabIndex = 1;
            this.gbxRbSize.TabStop = false;
            this.gbxRbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point( 17, 122 );
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size( 59, 20 );
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "45";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler( this.rbLarge_CheckedChanged );
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point( 17, 80 );
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size( 76, 20 );
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler( this.rbMedium_CheckedChanged );
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point( 17, 38 );
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size( 59, 20 );
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "15";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler( this.rbSmall_CheckedChanged );
            // 
            // gbxRbCrustType
            // 
            this.gbxRbCrustType.Controls.Add( this.rbThik );
            this.gbxRbCrustType.Controls.Add( this.rbThin );
            this.gbxRbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxRbCrustType.Font = new System.Drawing.Font( "Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.gbxRbCrustType.Location = new System.Drawing.Point( 35, 294 );
            this.gbxRbCrustType.Name = "gbxRbCrustType";
            this.gbxRbCrustType.Size = new System.Drawing.Size( 232, 169 );
            this.gbxRbCrustType.TabIndex = 2;
            this.gbxRbCrustType.TabStop = false;
            this.gbxRbCrustType.Text = "Crust Type";
            // 
            // rbThik
            // 
            this.rbThik.AutoSize = true;
            this.rbThik.Location = new System.Drawing.Point( 18, 110 );
            this.rbThik.Name = "rbThik";
            this.rbThik.Size = new System.Drawing.Size( 88, 20 );
            this.rbThik.TabIndex = 4;
            this.rbThik.Tag = "10";
            this.rbThik.Text = "Thik Crust";
            this.rbThik.UseVisualStyleBackColor = true;
            this.rbThik.CheckedChanged += new System.EventHandler( this.rbThik_CheckedChanged );
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point( 17, 56 );
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size( 89, 20 );
            this.rbThin.TabIndex = 3;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler( this.rbThin_CheckedChanged );
            // 
            // gbxRbWhereToEat
            // 
            this.gbxRbWhereToEat.Controls.Add( this.rbInOrder );
            this.gbxRbWhereToEat.Controls.Add( this.rbOutOrder );
            this.gbxRbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxRbWhereToEat.Font = new System.Drawing.Font( "Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.gbxRbWhereToEat.Location = new System.Drawing.Point( 363, 370 );
            this.gbxRbWhereToEat.Name = "gbxRbWhereToEat";
            this.gbxRbWhereToEat.Size = new System.Drawing.Size( 389, 93 );
            this.gbxRbWhereToEat.TabIndex = 3;
            this.gbxRbWhereToEat.TabStop = false;
            this.gbxRbWhereToEat.Text = "Where To Eat";
            // 
            // rbInOrder
            // 
            this.rbInOrder.AutoSize = true;
            this.rbInOrder.Location = new System.Drawing.Point( 290, 37 );
            this.rbInOrder.Name = "rbInOrder";
            this.rbInOrder.Size = new System.Drawing.Size( 76, 20 );
            this.rbInOrder.TabIndex = 6;
            this.rbInOrder.Text = "In Order";
            this.rbInOrder.UseVisualStyleBackColor = true;
            this.rbInOrder.CheckedChanged += new System.EventHandler( this.rbInOrder_CheckedChanged );
            // 
            // rbOutOrder
            // 
            this.rbOutOrder.AutoSize = true;
            this.rbOutOrder.Checked = true;
            this.rbOutOrder.Location = new System.Drawing.Point( 30, 37 );
            this.rbOutOrder.Name = "rbOutOrder";
            this.rbOutOrder.Size = new System.Drawing.Size( 87, 20 );
            this.rbOutOrder.TabIndex = 5;
            this.rbOutOrder.TabStop = true;
            this.rbOutOrder.Text = "Out Order";
            this.rbOutOrder.UseVisualStyleBackColor = true;
            this.rbOutOrder.CheckedChanged += new System.EventHandler( this.rbOutOrder_CheckedChanged );
            // 
            // gbxToppings
            // 
            this.gbxToppings.Controls.Add( this.checkBox6 );
            this.gbxToppings.Controls.Add( this.checkBox5 );
            this.gbxToppings.Controls.Add( this.checkBox4 );
            this.gbxToppings.Controls.Add( this.checkBox3 );
            this.gbxToppings.Controls.Add( this.checkBox2 );
            this.gbxToppings.Controls.Add( this.checkBox1 );
            this.gbxToppings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxToppings.Font = new System.Drawing.Font( "Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.gbxToppings.Location = new System.Drawing.Point( 337, 100 );
            this.gbxToppings.Name = "gbxToppings";
            this.gbxToppings.Size = new System.Drawing.Size( 442, 165 );
            this.gbxToppings.TabIndex = 2;
            this.gbxToppings.TabStop = false;
            this.gbxToppings.Text = "Toppings";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point( 282, 122 );
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size( 115, 20 );
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Tag = "5";
            this.checkBox6.Text = "Green Peppers";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler( this.checkBox6_CheckedChanged );
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point( 282, 82 );
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size( 64, 20 );
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Tag = "5";
            this.checkBox5.Text = "Olives";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler( this.checkBox5_CheckedChanged );
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point( 282, 39 );
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size( 64, 20 );
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Tag = "5";
            this.checkBox4.Text = "Onion";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler( this.checkBox4_CheckedChanged );
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point( 30, 122 );
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size( 87, 20 );
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Tag = "5";
            this.checkBox3.Text = "Tomatoes";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler( this.checkBox3_CheckedChanged );
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point( 30, 82 );
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size( 99, 20 );
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Tag = "5";
            this.checkBox2.Text = "Mushrooms";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler( this.checkBox2_CheckedChanged );
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point( 30, 38 );
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size( 104, 20 );
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "5";
            this.checkBox1.Text = "Extra Cheese";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler( this.checkBox1_CheckedChanged );
            // 
            // gbxSummary
            // 
            this.gbxSummary.Controls.Add( this.lblSizeResult );
            this.gbxSummary.Controls.Add( this.lblSize );
            this.gbxSummary.Controls.Add( this.lblTotalPriseResult );
            this.gbxSummary.Controls.Add( this.lblWhereToEatResult );
            this.gbxSummary.Controls.Add( this.lblCrustTypeResult );
            this.gbxSummary.Controls.Add( this.lblToppingsResult );
            this.gbxSummary.Controls.Add( this.lblToppings );
            this.gbxSummary.Controls.Add( this.lblCrustType );
            this.gbxSummary.Controls.Add( this.lblTotalPrise );
            this.gbxSummary.Controls.Add( this.lblWhereToEat );
            this.gbxSummary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxSummary.Font = new System.Drawing.Font( "Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.gbxSummary.Location = new System.Drawing.Point( 848, 100 );
            this.gbxSummary.Name = "gbxSummary";
            this.gbxSummary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxSummary.Size = new System.Drawing.Size( 246, 500 );
            this.gbxSummary.TabIndex = 2;
            this.gbxSummary.TabStop = false;
            this.gbxSummary.Text = "Order Summary";
            // 
            // lblSizeResult
            // 
            this.lblSizeResult.AutoSize = true;
            this.lblSizeResult.ForeColor = System.Drawing.Color.Red;
            this.lblSizeResult.Location = new System.Drawing.Point( 55, 60 );
            this.lblSizeResult.Name = "lblSizeResult";
            this.lblSizeResult.Size = new System.Drawing.Size( 41, 16 );
            this.lblSizeResult.TabIndex = 16;
            this.lblSizeResult.Text = "Small";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point( 10, 60 );
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size( 35, 16 );
            this.lblSize.TabIndex = 15;
            this.lblSize.Text = "Size:";
            // 
            // lblTotalPriseResult
            // 
            this.lblTotalPriseResult.AutoSize = true;
            this.lblTotalPriseResult.Font = new System.Drawing.Font( "Rockwell Nova", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblTotalPriseResult.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            this.lblTotalPriseResult.Location = new System.Drawing.Point( 43, 441 );
            this.lblTotalPriseResult.Name = "lblTotalPriseResult";
            this.lblTotalPriseResult.Size = new System.Drawing.Size( 85, 42 );
            this.lblTotalPriseResult.TabIndex = 14;
            this.lblTotalPriseResult.Tag = "0";
            this.lblTotalPriseResult.Text = "$ 15";
            // 
            // lblWhereToEatResult
            // 
            this.lblWhereToEatResult.AutoSize = true;
            this.lblWhereToEatResult.ForeColor = System.Drawing.Color.Red;
            this.lblWhereToEatResult.Location = new System.Drawing.Point( 117, 287 );
            this.lblWhereToEatResult.Name = "lblWhereToEatResult";
            this.lblWhereToEatResult.Size = new System.Drawing.Size( 60, 16 );
            this.lblWhereToEatResult.TabIndex = 13;
            this.lblWhereToEatResult.Text = "Out Side";
            // 
            // lblCrustTypeResult
            // 
            this.lblCrustTypeResult.AutoSize = true;
            this.lblCrustTypeResult.ForeColor = System.Drawing.Color.Red;
            this.lblCrustTypeResult.Location = new System.Drawing.Point( 93, 122 );
            this.lblCrustTypeResult.Name = "lblCrustTypeResult";
            this.lblCrustTypeResult.Size = new System.Drawing.Size( 35, 16 );
            this.lblCrustTypeResult.TabIndex = 12;
            this.lblCrustTypeResult.Text = "Thin";
            // 
            // lblToppingsResult
            // 
            this.lblToppingsResult.AutoSize = true;
            this.lblToppingsResult.ForeColor = System.Drawing.Color.Red;
            this.lblToppingsResult.Location = new System.Drawing.Point( 55, 219 );
            this.lblToppingsResult.MaximumSize = new System.Drawing.Size( 150, 0 );
            this.lblToppingsResult.Name = "lblToppingsResult";
            this.lblToppingsResult.Size = new System.Drawing.Size( 83, 16 );
            this.lblToppingsResult.TabIndex = 11;
            this.lblToppingsResult.Text = "No Tippings";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point( 10, 194 );
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size( 69, 16 );
            this.lblToppings.TabIndex = 4;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point( 10, 122 );
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size( 77, 16 );
            this.lblCrustType.TabIndex = 8;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // lblTotalPrise
            // 
            this.lblTotalPrise.AutoSize = true;
            this.lblTotalPrise.Location = new System.Drawing.Point( 10, 401 );
            this.lblTotalPrise.Name = "lblTotalPrise";
            this.lblTotalPrise.Size = new System.Drawing.Size( 77, 16 );
            this.lblTotalPrise.TabIndex = 10;
            this.lblTotalPrise.Text = "Total Prise:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point( 10, 287 );
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size( 101, 16 );
            this.lblWhereToEat.TabIndex = 6;
            this.lblWhereToEat.Text = "Where To Eate:";
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font( "Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            this.btnOrder.Location = new System.Drawing.Point( 386, 541 );
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size( 144, 59 );
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler( this.btnOrder_Click );
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font( "Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point( 617, 541 );
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size( 144, 59 );
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler( this.btnReset_Click );
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size( 61, 4 );
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1128, 631 );
            this.Controls.Add( this.btnReset );
            this.Controls.Add( this.btnOrder );
            this.Controls.Add( this.gbxSummary );
            this.Controls.Add( this.gbxToppings );
            this.Controls.Add( this.gbxRbWhereToEat );
            this.Controls.Add( this.gbxRbCrustType );
            this.Controls.Add( this.gbxRbSize );
            this.Controls.Add( this.lblTitle );
            this.Name = "frmMain";
            this.Text = "Pizza Oeder";
            this.Load += new System.EventHandler( this.frmMain_Load );
            this.gbxRbSize.ResumeLayout( false );
            this.gbxRbSize.PerformLayout();
            this.gbxRbCrustType.ResumeLayout( false );
            this.gbxRbCrustType.PerformLayout();
            this.gbxRbWhereToEat.ResumeLayout( false );
            this.gbxRbWhereToEat.PerformLayout();
            this.gbxToppings.ResumeLayout( false );
            this.gbxToppings.PerformLayout();
            this.gbxSummary.ResumeLayout( false );
            this.gbxSummary.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxRbSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxRbCrustType;
        private System.Windows.Forms.GroupBox gbxRbWhereToEat;
        private System.Windows.Forms.GroupBox gbxToppings;
        private System.Windows.Forms.GroupBox gbxSummary;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblTotalPrise;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbThik;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbInOrder;
        private System.Windows.Forms.RadioButton rbOutOrder;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblTotalPriseResult;
        private System.Windows.Forms.Label lblWhereToEatResult;
        private System.Windows.Forms.Label lblCrustTypeResult;
        private System.Windows.Forms.Label lblToppingsResult;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblSizeResult;
    }
}

