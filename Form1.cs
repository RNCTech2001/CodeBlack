using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeBlack
{
    public partial class MainForm : Form
    {


        bool mouseDown;
        private Point offset;
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.maximize_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.maximize_btn);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 53);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // maximize_btn
            // 
            this.maximize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_btn.BackColor = System.Drawing.Color.Gray;
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maximize_btn.Location = new System.Drawing.Point(1250, 12);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(75, 23);
            this.maximize_btn.TabIndex = 1;
            this.maximize_btn.Text = "O";
            this.maximize_btn.UseVisualStyleBackColor = false;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.Gray;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.Location = new System.Drawing.Point(1331, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.splitContainer1.Panel2.Controls.Add(this.cbWebView);
            this.splitContainer1.Size = new System.Drawing.Size(1427, 713);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 1;
            // 
            // cbWebView
            // 
            this.cbWebView.AllowExternalDrop = true;
            this.cbWebView.CreationProperties = null;
            this.cbWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.cbWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWebView.Location = new System.Drawing.Point(0, 0);
            this.cbWebView.Name = "cbWebView";
            this.cbWebView.Size = new System.Drawing.Size(1174, 713);
            this.cbWebView.Source = new System.Uri("https://uiverse.io/all", System.UriKind.Absolute);
            this.cbWebView.TabIndex = 0;
            this.cbWebView.ZoomFactor = 1D;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1427, 802);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeBlack";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbWebView)).EndInit();
            this.ResumeLayout(false);

        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }                    
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        
        }

        private void btn_css_Click(object sender, EventArgs e)
        {
 
            
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.MaximizeBox = true;
        }
    }
}
