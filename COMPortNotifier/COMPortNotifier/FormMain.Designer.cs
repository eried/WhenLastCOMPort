namespace COMPortNotifier
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.serialPortMonitor = new System.IO.Ports.SerialPort(this.components);
            this.listBoxCOMPorts = new System.Windows.Forms.ListBox();
            this.timerMonitor = new System.Windows.Forms.Timer(this.components);
            this.notifyIconNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelWaiting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCOMPorts
            // 
            this.listBoxCOMPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCOMPorts.FormattingEnabled = true;
            this.listBoxCOMPorts.IntegralHeight = false;
            this.listBoxCOMPorts.ItemHeight = 28;
            this.listBoxCOMPorts.Location = new System.Drawing.Point(0, 0);
            this.listBoxCOMPorts.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.listBoxCOMPorts.Name = "listBoxCOMPorts";
            this.listBoxCOMPorts.Size = new System.Drawing.Size(416, 212);
            this.listBoxCOMPorts.TabIndex = 0;
            // 
            // timerMonitor
            // 
            this.timerMonitor.Interval = 1000;
            this.timerMonitor.Tick += new System.EventHandler(this.timerMonitor_Tick);
            // 
            // notifyIconNotification
            // 
            this.notifyIconNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconNotification.Icon")));
            this.notifyIconNotification.Visible = true;
            this.notifyIconNotification.BalloonTipClicked += new System.EventHandler(this.notifyIconNotification_BalloonTipClicked);
            this.notifyIconNotification.Click += new System.EventHandler(this.notifyIconNotification_Click);
            this.notifyIconNotification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconNotification_MouseDoubleClick);
            // 
            // labelWaiting
            // 
            this.labelWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaiting.Location = new System.Drawing.Point(0, 0);
            this.labelWaiting.Name = "labelWaiting";
            this.labelWaiting.Size = new System.Drawing.Size(416, 212);
            this.labelWaiting.TabIndex = 1;
            this.labelWaiting.Text = "Waiting for Serial Ports...";
            this.labelWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 212);
            this.Controls.Add(this.labelWaiting);
            this.Controls.Add(this.listBoxCOMPorts);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Connected COM Ports";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortMonitor;
        private System.Windows.Forms.ListBox listBoxCOMPorts;
        private System.Windows.Forms.Timer timerMonitor;
        private System.Windows.Forms.NotifyIcon notifyIconNotification;
        private System.Windows.Forms.Label labelWaiting;
    }
}

