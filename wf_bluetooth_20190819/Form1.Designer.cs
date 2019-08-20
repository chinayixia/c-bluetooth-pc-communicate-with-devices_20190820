namespace wf_bluetooth_20190819
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRecDir = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelRecInfo = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonListen = new System.Windows.Forms.Button();
            this.buttonselectRecDir = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonSelectBluetooth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRecDir
            // 
            this.labelRecDir.AutoSize = true;
            this.labelRecDir.Location = new System.Drawing.Point(132, 231);
            this.labelRecDir.Name = "labelRecDir";
            this.labelRecDir.Size = new System.Drawing.Size(71, 12);
            this.labelRecDir.TabIndex = 0;
            this.labelRecDir.Text = "labelRecDir";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(132, 36);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(77, 12);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "labelAddress";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(132, 81);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(59, 12);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "labelPath";
            // 
            // labelRecInfo
            // 
            this.labelRecInfo.AutoSize = true;
            this.labelRecInfo.Location = new System.Drawing.Point(132, 260);
            this.labelRecInfo.Name = "labelRecInfo";
            this.labelRecInfo.Size = new System.Drawing.Size(77, 12);
            this.labelRecInfo.TabIndex = 4;
            this.labelRecInfo.Text = "labelRecInfo";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(132, 132);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(59, 12);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "labelInfo";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(559, 127);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(146, 23);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "buttonSend";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(559, 255);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(146, 23);
            this.buttonListen.TabIndex = 7;
            this.buttonListen.Text = "buttonListen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.ButtonListen_Click);
            // 
            // buttonselectRecDir
            // 
            this.buttonselectRecDir.Location = new System.Drawing.Point(559, 226);
            this.buttonselectRecDir.Name = "buttonselectRecDir";
            this.buttonselectRecDir.Size = new System.Drawing.Size(146, 23);
            this.buttonselectRecDir.TabIndex = 8;
            this.buttonselectRecDir.Text = "buttonselectRecDir";
            this.buttonselectRecDir.UseVisualStyleBackColor = true;
            this.buttonselectRecDir.Click += new System.EventHandler(this.ButtonselectRecDir_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(559, 76);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(146, 23);
            this.buttonSelectFile.TabIndex = 9;
            this.buttonSelectFile.Text = "buttonSelectFile";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonSelectBluetooth
            // 
            this.buttonSelectBluetooth.Location = new System.Drawing.Point(559, 31);
            this.buttonSelectBluetooth.Name = "buttonSelectBluetooth";
            this.buttonSelectBluetooth.Size = new System.Drawing.Size(146, 23);
            this.buttonSelectBluetooth.TabIndex = 10;
            this.buttonSelectBluetooth.Text = "buttonSelectBluetooth";
            this.buttonSelectBluetooth.UseVisualStyleBackColor = true;
            this.buttonSelectBluetooth.Click += new System.EventHandler(this.buttonSelectBluetooth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelectBluetooth);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.buttonselectRecDir);
            this.Controls.Add(this.buttonListen);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelRecInfo);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelRecDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRecDir;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelRecInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.Button buttonselectRecDir;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonSelectBluetooth;
    }
}

