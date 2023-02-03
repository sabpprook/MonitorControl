namespace MonitorControl
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_PowerSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_HDMI1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_HDMI2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DisplayPort1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DisplayPort2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "MonitorControl";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_PowerSwitch,
            this.toolStripSeparator1,
            this.menu_DisplayPort1,
            this.menu_DisplayPort2,
            this.toolStripSeparator2,
            this.menu_HDMI1,
            this.menu_HDMI2,
            this.toolStripSeparator3,
            this.menu_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 176);
            // 
            // menu_PowerSwitch
            // 
            this.menu_PowerSwitch.Image = global::MonitorControl.Properties.Resources.power;
            this.menu_PowerSwitch.Name = "menu_PowerSwitch";
            this.menu_PowerSwitch.ShortcutKeyDisplayString = "(Alt+Esc)";
            this.menu_PowerSwitch.Size = new System.Drawing.Size(212, 22);
            this.menu_PowerSwitch.Text = "PowerSwitch";
            this.menu_PowerSwitch.Click += new System.EventHandler(this.Menu_Switch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // menu_HDMI1
            // 
            this.menu_HDMI1.Image = global::MonitorControl.Properties.Resources.hdmi;
            this.menu_HDMI1.Name = "menu_HDMI1";
            this.menu_HDMI1.ShortcutKeyDisplayString = "(Shift+F3)";
            this.menu_HDMI1.Size = new System.Drawing.Size(212, 22);
            this.menu_HDMI1.Text = "HDMI_1";
            this.menu_HDMI1.Click += new System.EventHandler(this.Menu_Switch_Click);
            // 
            // menu_HDMI2
            // 
            this.menu_HDMI2.Image = global::MonitorControl.Properties.Resources.hdmi;
            this.menu_HDMI2.Name = "menu_HDMI2";
            this.menu_HDMI2.ShortcutKeyDisplayString = "(Shift+F4)";
            this.menu_HDMI2.Size = new System.Drawing.Size(212, 22);
            this.menu_HDMI2.Text = "HDMI_2";
            this.menu_HDMI2.Click += new System.EventHandler(this.Menu_Switch_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // menu_Exit
            // 
            this.menu_Exit.Image = global::MonitorControl.Properties.Resources.exit;
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.Size = new System.Drawing.Size(212, 22);
            this.menu_Exit.Text = "Exit";
            this.menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // menu_DisplayPort1
            // 
            this.menu_DisplayPort1.Image = ((System.Drawing.Image)(resources.GetObject("menu_DisplayPort1.Image")));
            this.menu_DisplayPort1.Name = "menu_DisplayPort1";
            this.menu_DisplayPort1.ShortcutKeyDisplayString = "(Shift+F1)";
            this.menu_DisplayPort1.Size = new System.Drawing.Size(212, 22);
            this.menu_DisplayPort1.Text = "DisplayPort_1";
            this.menu_DisplayPort1.Click += new System.EventHandler(this.Menu_Switch_Click);
            // 
            // menu_DisplayPort2
            // 
            this.menu_DisplayPort2.Image = ((System.Drawing.Image)(resources.GetObject("menu_DisplayPort2.Image")));
            this.menu_DisplayPort2.Name = "menu_DisplayPort2";
            this.menu_DisplayPort2.ShortcutKeyDisplayString = "(Shift+F2)";
            this.menu_DisplayPort2.Size = new System.Drawing.Size(212, 22);
            this.menu_DisplayPort2.Text = "DisplayPort_2";
            this.menu_DisplayPort2.Click += new System.EventHandler(this.Menu_Switch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_PowerSwitch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_DisplayPort1;
        private System.Windows.Forms.ToolStripMenuItem menu_DisplayPort2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_HDMI1;
        private System.Windows.Forms.ToolStripMenuItem menu_HDMI2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
    }
}

