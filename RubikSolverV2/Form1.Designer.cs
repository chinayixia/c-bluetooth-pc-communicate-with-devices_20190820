namespace RubikSolverV2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BlueToothMessage = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendMessage = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.StatusMessage = new System.Windows.Forms.TextBox();
            this.MonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PortList
            // 
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(117, 9);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(71, 20);
            this.PortList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择蓝牙连接端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "从NXT读取的数据：";
            // 
            // BlueToothMessage
            // 
            this.BlueToothMessage.Location = new System.Drawing.Point(15, 66);
            this.BlueToothMessage.Multiline = true;
            this.BlueToothMessage.Name = "BlueToothMessage";
            this.BlueToothMessage.ReadOnly = true;
            this.BlueToothMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BlueToothMessage.Size = new System.Drawing.Size(353, 316);
            this.BlueToothMessage.TabIndex = 3;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(212, 7);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 21);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "连接";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(125, 41);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(243, 21);
            this.SendMessage.TabIndex = 5;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(293, 7);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 21);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // StatusMessage
            // 
            this.StatusMessage.Location = new System.Drawing.Point(-3, 390);
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.ReadOnly = true;
            this.StatusMessage.Size = new System.Drawing.Size(682, 21);
            this.StatusMessage.TabIndex = 12;
            // 
            // MonitorTimer
            // 
            this.MonitorTimer.Enabled = true;
            this.MonitorTimer.Interval = 200;
            this.MonitorTimer.Tick += new System.EventHandler(this.MonitorTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 409);
            this.Controls.Add(this.StatusMessage);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.BlueToothMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoTao蓝牙PC端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BlueToothMessage;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox SendMessage;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox StatusMessage;
        private System.Windows.Forms.Timer MonitorTimer;
    }
}

