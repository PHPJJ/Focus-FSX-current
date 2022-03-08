namespace SetFocusFSX
{
    partial class SetFocusFSX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetFocusFSX));
            this.cboWindows = new System.Windows.Forms.ComboBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btHide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboWindows
            // 
            this.cboWindows.FormattingEnabled = true;
            this.cboWindows.Location = new System.Drawing.Point(19, 13);
            this.cboWindows.Name = "cboWindows";
            this.cboWindows.Size = new System.Drawing.Size(387, 21);
            this.cboWindows.TabIndex = 13;
            this.cboWindows.SelectedIndexChanged += new System.EventHandler(this.cboWindows_SelectedIndexChanged);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "SendKeys Files (*.sky)|*.sky";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.DefaultExt = "sky";
            this.saveFileDlg.Filter = "SendKeys Files (*.sky)|*.sky";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(412, 14);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(63, 20);
            this.btnSelect.TabIndex = 37;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtApplication
            // 
            this.txtApplication.Location = new System.Drawing.Point(19, 13);
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.Size = new System.Drawing.Size(387, 20);
            this.txtApplication.TabIndex = 38;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(260, 60);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(70, 20);
            this.btExit.TabIndex = 44;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SendKey";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btHide
            // 
            this.btHide.Location = new System.Drawing.Point(336, 60);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(70, 20);
            this.btHide.TabIndex = 45;
            this.btHide.Text = "TRAY";
            this.btHide.UseVisualStyleBackColor = true;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 31);
            this.button3.TabIndex = 46;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SetFocusFSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(493, 104);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.txtApplication);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cboWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SetFocusFSX";
            this.Text = "SetFocus";
            this.Load += new System.EventHandler(this.SendKeysToApps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboWindows;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtApplication;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}

