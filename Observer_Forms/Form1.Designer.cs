namespace Observer_Forms
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
            lstDevices = new ListBox();
            btnRemove = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTemp = new TextBox();
            txtHum = new TextBox();
            btnUpdate = new Button();
            txtName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstDevices
            // 
            lstDevices.FormattingEnabled = true;
            lstDevices.ItemHeight = 20;
            lstDevices.Location = new Point(638, 12);
            lstDevices.Name = "lstDevices";
            lstDevices.Size = new Size(150, 324);
            lstDevices.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(638, 346);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 29);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Odebrat Uživatele";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(638, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Přidat Uživatele";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 107);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Teplota:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 181);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Vlhkost:";
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(271, 104);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(125, 27);
            txtTemp.TabIndex = 5;
            // 
            // txtHum
            // 
            txtHum.Location = new Point(269, 178);
            txtHum.Name = "txtHum";
            txtHum.Size = new Size(125, 27);
            txtHum.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(271, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Nahraj!";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(430, 397);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 404);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 9;
            label3.Text = "Add user:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(btnUpdate);
            Controls.Add(txtHum);
            Controls.Add(txtTemp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(lstDevices);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDevices;
        private Button btnRemove;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private TextBox txtTemp;
        private TextBox txtHum;
        private Button btnUpdate;
        private TextBox txtName;
        private Label label3;
    }
}