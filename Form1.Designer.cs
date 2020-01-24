namespace Calculate
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblExpression = new System.Windows.Forms.Label();
            this.brnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.panelCalculate = new System.Windows.Forms.Panel();
            this.panelConversion = new System.Windows.Forms.Panel();
            this.btnReverte = new System.Windows.Forms.Button();
            this.grpBoxType = new System.Windows.Forms.GroupBox();
            this.lblType02 = new System.Windows.Forms.Label();
            this.txtInput02 = new System.Windows.Forms.TextBox();
            this.lblType01 = new System.Windows.Forms.Label();
            this.txtInput01 = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lstType = new System.Windows.Forms.ListBox();
            this.panelCalculate.SuspendLayout();
            this.panelConversion.SuspendLayout();
            this.grpBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(3, 26);
            this.txtInput.MaxLength = 16;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(252, 80);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // lblExpression
            // 
            this.lblExpression.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(3, 4);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(252, 23);
            this.lblExpression.TabIndex = 1;
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExpression.TextChanged += new System.EventHandler(this.LblExpression_TextChanged);
            // 
            // brnClear
            // 
            this.brnClear.Location = new System.Drawing.Point(144, 120);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(60, 46);
            this.brnClear.TabIndex = 4;
            this.brnClear.Text = "C";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.BrnClear_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(210, 120);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(60, 46);
            this.btnBackSpace.TabIndex = 5;
            this.btnBackSpace.Text = "<";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(210, 172);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 46);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(210, 224);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(60, 46);
            this.btnMultiple.TabIndex = 13;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.BtnMultiple_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(144, 172);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(60, 46);
            this.btnNine.TabIndex = 12;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(78, 172);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(60, 46);
            this.btnEight.TabIndex = 11;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 172);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(60, 46);
            this.btnSeven.TabIndex = 10;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(210, 276);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 46);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(12, 224);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(60, 46);
            this.btnFour.TabIndex = 16;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(78, 224);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(60, 46);
            this.btnFive.TabIndex = 15;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.BtnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(144, 224);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(60, 46);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(210, 328);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(60, 46);
            this.btnSum.TabIndex = 21;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 276);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(60, 46);
            this.btnOne.TabIndex = 20;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(78, 276);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(60, 46);
            this.btnTwo.TabIndex = 19;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(144, 276);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(60, 46);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(12, 380);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(258, 46);
            this.btnEqual.TabIndex = 25;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(144, 328);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 46);
            this.btnDot.TabIndex = 24;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(78, 328);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(60, 46);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.BtnZero_Click_1);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Location = new System.Drawing.Point(12, 328);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(60, 46);
            this.btnChangeSign.TabIndex = 22;
            this.btnChangeSign.Text = "-/+";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.BtnChangeSign_Click);
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(12, 120);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(126, 46);
            this.btnConversion.TabIndex = 26;
            this.btnConversion.Text = "Conversion";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.BtnConversion_Click);
            // 
            // panelCalculate
            // 
            this.panelCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.panelCalculate.Controls.Add(this.lblExpression);
            this.panelCalculate.Controls.Add(this.txtInput);
            this.panelCalculate.Location = new System.Drawing.Point(12, 4);
            this.panelCalculate.Name = "panelCalculate";
            this.panelCalculate.Size = new System.Drawing.Size(258, 109);
            this.panelCalculate.TabIndex = 27;
            // 
            // panelConversion
            // 
            this.panelConversion.BackColor = System.Drawing.Color.Gray;
            this.panelConversion.Controls.Add(this.btnReverte);
            this.panelConversion.Controls.Add(this.grpBoxType);
            this.panelConversion.Controls.Add(this.lblType);
            this.panelConversion.Controls.Add(this.lstType);
            this.panelConversion.Location = new System.Drawing.Point(12, 4);
            this.panelConversion.Name = "panelConversion";
            this.panelConversion.Size = new System.Drawing.Size(258, 110);
            this.panelConversion.TabIndex = 28;
            this.panelConversion.Visible = false;
            // 
            // btnReverte
            // 
            this.btnReverte.Image = global::Calculate.Properties.Resources.Reverse01;
            this.btnReverte.Location = new System.Drawing.Point(11, 62);
            this.btnReverte.Name = "btnReverte";
            this.btnReverte.Size = new System.Drawing.Size(45, 43);
            this.btnReverte.TabIndex = 3;
            this.btnReverte.UseVisualStyleBackColor = true;
            this.btnReverte.Click += new System.EventHandler(this.BtnReverte_Click);
            // 
            // grpBoxType
            // 
            this.grpBoxType.Controls.Add(this.lblType02);
            this.grpBoxType.Controls.Add(this.txtInput02);
            this.grpBoxType.Controls.Add(this.lblType01);
            this.grpBoxType.Controls.Add(this.txtInput01);
            this.grpBoxType.Location = new System.Drawing.Point(76, 1);
            this.grpBoxType.Name = "grpBoxType";
            this.grpBoxType.Size = new System.Drawing.Size(177, 103);
            this.grpBoxType.TabIndex = 2;
            this.grpBoxType.TabStop = false;
            // 
            // lblType02
            // 
            this.lblType02.AutoSize = true;
            this.lblType02.Location = new System.Drawing.Point(5, 60);
            this.lblType02.Name = "lblType02";
            this.lblType02.Size = new System.Drawing.Size(55, 13);
            this.lblType02.TabIndex = 3;
            this.lblType02.Text = "Kilometres";
            // 
            // txtInput02
            // 
            this.txtInput02.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput02.Location = new System.Drawing.Point(6, 72);
            this.txtInput02.Multiline = true;
            this.txtInput02.Name = "txtInput02";
            this.txtInput02.ReadOnly = true;
            this.txtInput02.Size = new System.Drawing.Size(165, 25);
            this.txtInput02.TabIndex = 2;
            this.txtInput02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblType01
            // 
            this.lblType01.AutoSize = true;
            this.lblType01.Location = new System.Drawing.Point(6, 15);
            this.lblType01.Name = "lblType01";
            this.lblType01.Size = new System.Drawing.Size(31, 13);
            this.lblType01.TabIndex = 1;
            this.lblType01.Text = "Miles";
            // 
            // txtInput01
            // 
            this.txtInput01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput01.Location = new System.Drawing.Point(6, 28);
            this.txtInput01.Multiline = true;
            this.txtInput01.Name = "txtInput01";
            this.txtInput01.ReadOnly = true;
            this.txtInput01.Size = new System.Drawing.Size(165, 25);
            this.txtInput01.TabIndex = 0;
            this.txtInput01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput01.TextChanged += new System.EventHandler(this.TxtInput01_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 7);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lstType
            // 
            this.lstType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstType.FormattingEnabled = true;
            this.lstType.ItemHeight = 16;
            this.lstType.Items.AddRange(new object[] {
            "Length",
            "Weight"});
            this.lstType.Location = new System.Drawing.Point(3, 23);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(69, 36);
            this.lstType.TabIndex = 0;
            this.lstType.SelectedIndexChanged += new System.EventHandler(this.LstType_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 434);
            this.Controls.Add(this.panelConversion);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnChangeSign);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.panelCalculate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panelCalculate.ResumeLayout(false);
            this.panelCalculate.PerformLayout();
            this.panelConversion.ResumeLayout(false);
            this.panelConversion.PerformLayout();
            this.grpBoxType.ResumeLayout(false);
            this.grpBoxType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Panel panelCalculate;
        private System.Windows.Forms.Panel panelConversion;
        private System.Windows.Forms.ListBox lstType;
        private System.Windows.Forms.GroupBox grpBoxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblType02;
        private System.Windows.Forms.TextBox txtInput02;
        private System.Windows.Forms.Label lblType01;
        private System.Windows.Forms.TextBox txtInput01;
        private System.Windows.Forms.Button btnReverte;
    }
}

