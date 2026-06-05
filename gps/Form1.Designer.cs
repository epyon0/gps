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
            commComboBox.Location = new Point(116, 12);
            commComboBox.Name = "commComboBox";
            commComboBox.Size = new Size(150, 19);
            commComboBox.TabIndex = 1;
            // 
            // refreshCommInterfacesButton
            // 
            refreshCommInterfacesButton.FlatStyle = FlatStyle.Flat;
            refreshCommInterfacesButton.Location = new Point(191, 37);
            refreshCommInterfacesButton.Name = "refreshCommInterfacesButton";
            refreshCommInterfacesButton.Size = new Size(75, 23);
            refreshCommInterfacesButton.TabIndex = 2;
            refreshCommInterfacesButton.Text = "Refresh";
            refreshCommInterfacesButton.UseVisualStyleBackColor = true;
            refreshCommInterfacesButton.Click += refreshCommInterfacesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 330);
            Controls.Add(refreshCommInterfacesButton);
            Controls.Add(commComboBox);
            Controls.Add(richTextBox1);
            Font = new Font("Lucida Console", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox commComboBox;
        private Button refreshCommInterfacesButton;
    }
}
