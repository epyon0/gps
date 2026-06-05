namespace gps
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
            richTextBox1 = new RichTextBox();
            commComboBox = new ComboBox();
            refreshCommInterfacesButton = new Button();
            getSerialDataButton = new Button();
            closeSerialConnButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            this.baudNumericUpDown = new NumericUpDown();
            this.dataBitsNumericUpDown = new NumericUpDown();
            this.parityComboBox = new ComboBox();
            stopBitsComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)this.baudNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dataBitsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.Lime;
            richTextBox1.Location = new Point(272, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(820, 306);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // commComboBox
            // 
            commComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            commComboBox.FlatStyle = FlatStyle.Flat;
            commComboBox.FormattingEnabled = true;
            commComboBox.Location = new Point(93, 12);
            commComboBox.Name = "commComboBox";
            commComboBox.Size = new Size(92, 19);
            commComboBox.TabIndex = 1;
            // 
            // refreshCommInterfacesButton
            // 
            refreshCommInterfacesButton.FlatStyle = FlatStyle.Flat;
            refreshCommInterfacesButton.Location = new Point(191, 12);
            refreshCommInterfacesButton.Name = "refreshCommInterfacesButton";
            refreshCommInterfacesButton.Size = new Size(75, 23);
            refreshCommInterfacesButton.TabIndex = 2;
            refreshCommInterfacesButton.Text = "Refresh";
            refreshCommInterfacesButton.UseVisualStyleBackColor = true;
            refreshCommInterfacesButton.Click += refreshCommInterfacesButton_Click;
            // 
            // getSerialDataButton
            // 
            getSerialDataButton.FlatStyle = FlatStyle.Flat;
            getSerialDataButton.Location = new Point(110, 295);
            getSerialDataButton.Name = "getSerialDataButton";
            getSerialDataButton.Size = new Size(75, 23);
            getSerialDataButton.TabIndex = 3;
            getSerialDataButton.Text = "Connect";
            getSerialDataButton.UseVisualStyleBackColor = true;
            getSerialDataButton.Click += getSerialDataButton_Click;
            // 
            // closeSerialConnButton
            // 
            closeSerialConnButton.FlatStyle = FlatStyle.Flat;
            closeSerialConnButton.Location = new Point(191, 295);
            closeSerialConnButton.Name = "closeSerialConnButton";
            closeSerialConnButton.Size = new Size(75, 23);
            closeSerialConnButton.TabIndex = 4;
            closeSerialConnButton.Text = "Close";
            closeSerialConnButton.UseVisualStyleBackColor = true;
            closeSerialConnButton.Click += closeSerialConnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(40, 11);
            label1.TabIndex = 5;
            label1.Text = "Baud:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 11);
            label2.TabIndex = 6;
            label2.Text = "Data Bits:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(75, 11);
            label3.TabIndex = 7;
            label3.Text = "Stop Bits:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(54, 11);
            label4.TabIndex = 8;
            label4.Text = "Parity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 15);
            label6.Name = "label6";
            label6.Size = new Size(75, 11);
            label6.TabIndex = 10;
            label6.Text = "Interface:";
            // 
            // baudNumericUpDown
            // 
            this.baudNumericUpDown.Location = new Point(93, 54);
            this.baudNumericUpDown.Name = "baudNumericUpDown";
            this.baudNumericUpDown.Size = new Size(92, 18);
            this.baudNumericUpDown.TabIndex = 11;
            // 
            // dataBitsNumericUpDown
            // 
            this.dataBitsNumericUpDown.Location = new Point(93, 84);
            this.dataBitsNumericUpDown.Name = "dataBitsNumericUpDown";
            this.dataBitsNumericUpDown.Size = new Size(92, 18);
            this.dataBitsNumericUpDown.TabIndex = 12;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.parityComboBox.FlatStyle = FlatStyle.Flat;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            this.parityComboBox.Location = new Point(93, 143);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new Size(92, 19);
            this.parityComboBox.TabIndex = 14;
            // 
            // stopBitsComboBox
            // 
            stopBitsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stopBitsComboBox.FlatStyle = FlatStyle.Flat;
            stopBitsComboBox.FormattingEnabled = true;
            stopBitsComboBox.Items.AddRange(new object[] { "None", "1", "1.5", "2" });
            stopBitsComboBox.Location = new Point(93, 113);
            stopBitsComboBox.Name = "stopBitsComboBox";
            stopBitsComboBox.Size = new Size(92, 19);
            stopBitsComboBox.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 330);
            Controls.Add(stopBitsComboBox);
            Controls.Add(this.parityComboBox);
            Controls.Add(this.dataBitsNumericUpDown);
            Controls.Add(this.baudNumericUpDown);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeSerialConnButton);
            Controls.Add(getSerialDataButton);
            Controls.Add(refreshCommInterfacesButton);
            Controls.Add(commComboBox);
            Controls.Add(richTextBox1);
            Font = new Font("Lucida Console", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)this.baudNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dataBitsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox commComboBox;
        private Button refreshCommInterfacesButton;
        private Button getSerialDataButton;
        private Button closeSerialConnButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown baudNumericUpDown;
        private NumericUpDown dataBitsNumericUpDown;
        private ComboBox parityComboBox;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox stopBitsComboBox;
    }
}
