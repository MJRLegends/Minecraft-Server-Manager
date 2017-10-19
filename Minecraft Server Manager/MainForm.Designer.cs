namespace Minecraft_Server_Manager
{
    partial class MainForm
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
            this.btnAddServer = new System.Windows.Forms.Button();
            this.btnDeleteServer = new System.Windows.Forms.Button();
            this.btnEditServer = new System.Windows.Forms.Button();
            this.btnRunServer = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlugins = new System.Windows.Forms.Button();
            this.listBoxServers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOpenServerFolder = new System.Windows.Forms.Button();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.memorymax = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.memorymin = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serverversion = new System.Windows.Forms.ComboBox();
            this.lblServerVersion = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.servername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btnPluginOpenFile = new System.Windows.Forms.Button();
            this.btnDeletePlugin2 = new System.Windows.Forms.Button();
            this.btnAddPlugin = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnClosePlugin = new System.Windows.Forms.Button();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(227, 12);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(209, 28);
            this.btnAddServer.TabIndex = 1;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // btnDeleteServer
            // 
            this.btnDeleteServer.Location = new System.Drawing.Point(227, 46);
            this.btnDeleteServer.Name = "btnDeleteServer";
            this.btnDeleteServer.Size = new System.Drawing.Size(209, 28);
            this.btnDeleteServer.TabIndex = 2;
            this.btnDeleteServer.Text = "Delete Server";
            this.btnDeleteServer.UseVisualStyleBackColor = true;
            this.btnDeleteServer.Click += new System.EventHandler(this.btnDeleteServer_Click);
            // 
            // btnEditServer
            // 
            this.btnEditServer.Enabled = false;
            this.btnEditServer.Location = new System.Drawing.Point(227, 80);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(209, 28);
            this.btnEditServer.TabIndex = 3;
            this.btnEditServer.Text = "Edit Server";
            this.btnEditServer.UseVisualStyleBackColor = true;
            this.btnEditServer.Click += new System.EventHandler(this.btnEditServer_Click);
            // 
            // btnRunServer
            // 
            this.btnRunServer.Location = new System.Drawing.Point(227, 182);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Size = new System.Drawing.Size(209, 28);
            this.btnRunServer.TabIndex = 7;
            this.btnRunServer.Text = "Run Server";
            this.btnRunServer.UseVisualStyleBackColor = true;
            this.btnRunServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // btnPlugins
            // 
            this.btnPlugins.Location = new System.Drawing.Point(227, 114);
            this.btnPlugins.Name = "btnPlugins";
            this.btnPlugins.Size = new System.Drawing.Size(209, 28);
            this.btnPlugins.TabIndex = 18;
            this.btnPlugins.Text = "Plugin Manager";
            this.btnPlugins.UseVisualStyleBackColor = true;
            this.btnPlugins.Click += new System.EventHandler(this.btnPlugins_Click);
            // 
            // listBoxServers
            // 
            this.listBoxServers.FormattingEnabled = true;
            this.listBoxServers.Location = new System.Drawing.Point(12, 12);
            this.listBoxServers.Name = "listBoxServers";
            this.listBoxServers.Size = new System.Drawing.Size(209, 277);
            this.listBoxServers.TabIndex = 20;
            this.listBoxServers.SelectedIndexChanged += new System.EventHandler(this.listBoxServers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Server Version:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Server Path:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(303, 58);
            this.textBox1.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Server Memory:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(135, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "-";
            // 
            // btnOpenServerFolder
            // 
            this.btnOpenServerFolder.Location = new System.Drawing.Point(227, 148);
            this.btnOpenServerFolder.Name = "btnOpenServerFolder";
            this.btnOpenServerFolder.Size = new System.Drawing.Size(209, 28);
            this.btnOpenServerFolder.TabIndex = 27;
            this.btnOpenServerFolder.Text = "Open Server Directory";
            this.btnOpenServerFolder.UseVisualStyleBackColor = true;
            this.btnOpenServerFolder.Click += new System.EventHandler(this.btnOpenServerFolder_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.label11);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.label12);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.label8);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label5);
            this.panelEx1.Controls.Add(this.textBox1);
            this.panelEx1.Location = new System.Drawing.Point(442, 12);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(327, 277);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 95;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.memorymax);
            this.panelEx2.Controls.Add(this.label10);
            this.panelEx2.Controls.Add(this.memorymin);
            this.panelEx2.Controls.Add(this.label9);
            this.panelEx2.Controls.Add(this.label7);
            this.panelEx2.Controls.Add(this.serverversion);
            this.panelEx2.Controls.Add(this.lblServerVersion);
            this.panelEx2.Controls.Add(this.btnClose);
            this.panelEx2.Controls.Add(this.label6);
            this.panelEx2.Controls.Add(this.servername);
            this.panelEx2.Controls.Add(this.btnSave);
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.MaximumSize = new System.Drawing.Size(779, 299);
            this.panelEx2.MinimumSize = new System.Drawing.Size(779, 299);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(779, 299);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 96;
            // 
            // memorymax
            // 
            this.memorymax.FormattingEnabled = true;
            this.memorymax.Location = new System.Drawing.Point(121, 131);
            this.memorymax.Name = "memorymax";
            this.memorymax.Size = new System.Drawing.Size(94, 21);
            this.memorymax.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 103;
            this.label10.Text = "Max";
            // 
            // memorymin
            // 
            this.memorymin.FormattingEnabled = true;
            this.memorymin.Location = new System.Drawing.Point(14, 131);
            this.memorymin.Name = "memorymin";
            this.memorymin.Size = new System.Drawing.Size(94, 21);
            this.memorymin.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Server Memory";
            // 
            // serverversion
            // 
            this.serverversion.FormattingEnabled = true;
            this.serverversion.Location = new System.Drawing.Point(12, 63);
            this.serverversion.Name = "serverversion";
            this.serverversion.Size = new System.Drawing.Size(202, 21);
            this.serverversion.TabIndex = 99;
            // 
            // lblServerVersion
            // 
            this.lblServerVersion.AutoSize = true;
            this.lblServerVersion.Location = new System.Drawing.Point(10, 47);
            this.lblServerVersion.Name = "lblServerVersion";
            this.lblServerVersion.Size = new System.Drawing.Size(76, 13);
            this.lblServerVersion.TabIndex = 98;
            this.lblServerVersion.Text = "Server Version";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(0, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(779, 33);
            this.btnClose.TabIndex = 97;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Server Name";
            // 
            // servername
            // 
            this.servername.Location = new System.Drawing.Point(13, 18);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(202, 20);
            this.servername.TabIndex = 95;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(779, 33);
            this.btnSave.TabIndex = 94;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btnPluginOpenFile);
            this.panelEx3.Controls.Add(this.btnDeletePlugin2);
            this.panelEx3.Controls.Add(this.btnAddPlugin);
            this.panelEx3.Controls.Add(this.listBox2);
            this.panelEx3.Controls.Add(this.btnClosePlugin);
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.MaximumSize = new System.Drawing.Size(779, 299);
            this.panelEx3.MinimumSize = new System.Drawing.Size(779, 299);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(779, 299);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 97;
            // 
            // btnPluginOpenFile
            // 
            this.btnPluginOpenFile.Location = new System.Drawing.Point(193, 238);
            this.btnPluginOpenFile.Name = "btnPluginOpenFile";
            this.btnPluginOpenFile.Size = new System.Drawing.Size(143, 23);
            this.btnPluginOpenFile.TabIndex = 95;
            this.btnPluginOpenFile.Text = "Open File Location";
            this.btnPluginOpenFile.UseVisualStyleBackColor = true;
            this.btnPluginOpenFile.Click += new System.EventHandler(this.btnPluginOpenFile_Click);
            // 
            // btnDeletePlugin2
            // 
            this.btnDeletePlugin2.Location = new System.Drawing.Point(193, 39);
            this.btnDeletePlugin2.Name = "btnDeletePlugin2";
            this.btnDeletePlugin2.Size = new System.Drawing.Size(143, 23);
            this.btnDeletePlugin2.TabIndex = 94;
            this.btnDeletePlugin2.Text = "Delete Plugin";
            this.btnDeletePlugin2.UseVisualStyleBackColor = true;
            this.btnDeletePlugin2.Click += new System.EventHandler(this.btnDeletePlugin2_Click);
            // 
            // btnAddPlugin
            // 
            this.btnAddPlugin.Location = new System.Drawing.Point(193, 10);
            this.btnAddPlugin.Name = "btnAddPlugin";
            this.btnAddPlugin.Size = new System.Drawing.Size(143, 23);
            this.btnAddPlugin.TabIndex = 93;
            this.btnAddPlugin.Text = "Add Plugin";
            this.btnAddPlugin.UseVisualStyleBackColor = true;
            this.btnAddPlugin.Click += new System.EventHandler(this.btnAddPlugin_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 1);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(184, 264);
            this.listBox2.TabIndex = 92;
            // 
            // btnClosePlugin
            // 
            this.btnClosePlugin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClosePlugin.Location = new System.Drawing.Point(0, 266);
            this.btnClosePlugin.Name = "btnClosePlugin";
            this.btnClosePlugin.Size = new System.Drawing.Size(779, 33);
            this.btnClosePlugin.TabIndex = 91;
            this.btnClosePlugin.Text = "Close";
            this.btnClosePlugin.UseVisualStyleBackColor = true;
            this.btnClosePlugin.Click += new System.EventHandler(this.btnClosePlugin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 296);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.btnOpenServerFolder);
            this.Controls.Add(this.listBoxServers);
            this.Controls.Add(this.btnPlugins);
            this.Controls.Add(this.btnRunServer);
            this.Controls.Add(this.btnEditServer);
            this.Controls.Add(this.btnDeleteServer);
            this.Controls.Add(this.btnAddServer);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(795, 335);
            this.MinimumSize = new System.Drawing.Size(795, 335);
            this.Name = "MainForm";
            this.Text = "MJR MC Server Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Button btnDeleteServer;
        private System.Windows.Forms.Button btnEditServer;
        private System.Windows.Forms.Button btnRunServer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlugins;
        private System.Windows.Forms.ListBox listBoxServers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOpenServerFolder;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.ComboBox memorymax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox memorymin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox serverversion;
        private System.Windows.Forms.Label lblServerVersion;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox servername;
        private System.Windows.Forms.Button btnSave;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.Button btnPluginOpenFile;
        private System.Windows.Forms.Button btnDeletePlugin2;
        private System.Windows.Forms.Button btnAddPlugin;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnClosePlugin;
    }
}

