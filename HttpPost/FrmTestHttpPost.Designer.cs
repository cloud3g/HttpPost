namespace TestHttpPost
{
	partial class FrmTestHttpPost
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
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlTool = new System.Windows.Forms.Panel();
            this.proxytitle = new System.Windows.Forms.Label();
            this.textPostProxy = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.headertitle = new System.Windows.Forms.Label();
            this.cboResEncoding = new System.Windows.Forms.ComboBox();
            this.txtPostHeader = new System.Windows.Forms.TextBox();
            this.lblResEncoding = new System.Windows.Forms.Label();
            this.cookietitle = new System.Windows.Forms.Label();
            this.cbb_contenttype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPostCookie = new System.Windows.Forms.TextBox();
            this.PostDataTitle = new System.Windows.Forms.Label();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.proxytitle);
            this.pnlTool.Controls.Add(this.textPostProxy);
            this.pnlTool.Controls.Add(this.btnClear);
            this.pnlTool.Controls.Add(this.headertitle);
            this.pnlTool.Controls.Add(this.cboResEncoding);
            this.pnlTool.Controls.Add(this.txtPostHeader);
            this.pnlTool.Controls.Add(this.lblResEncoding);
            this.pnlTool.Controls.Add(this.cookietitle);
            this.pnlTool.Controls.Add(this.cbb_contenttype);
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Controls.Add(this.txtPostCookie);
            this.pnlTool.Controls.Add(this.PostDataTitle);
            this.pnlTool.Controls.Add(this.txtPostData);
            this.pnlTool.Controls.Add(this.btnGo);
            this.pnlTool.Controls.Add(this.txtUrl);
            this.pnlTool.Controls.Add(this.cboMode);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(784, 222);
            this.pnlTool.TabIndex = 0;
            // 
            // proxytitle
            // 
            this.proxytitle.AutoSize = true;
            this.proxytitle.Location = new System.Drawing.Point(10, 175);
            this.proxytitle.Name = "proxytitle";
            this.proxytitle.Size = new System.Drawing.Size(35, 12);
            this.proxytitle.TabIndex = 13;
            this.proxytitle.Text = "Proxy";
            // 
            // textPostProxy
            // 
            this.textPostProxy.Location = new System.Drawing.Point(90, 172);
            this.textPostProxy.Name = "textPostProxy";
            this.textPostProxy.Size = new System.Drawing.Size(317, 21);
            this.textPostProxy.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(720, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // headertitle
            // 
            this.headertitle.AutoSize = true;
            this.headertitle.Location = new System.Drawing.Point(12, 118);
            this.headertitle.Name = "headertitle";
            this.headertitle.Size = new System.Drawing.Size(41, 12);
            this.headertitle.TabIndex = 11;
            this.headertitle.Text = "Header";
            // 
            // cboResEncoding
            // 
            this.cboResEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboResEncoding.DropDownHeight = 400;
            this.cboResEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResEncoding.FormattingEnabled = true;
            this.cboResEncoding.IntegralHeight = false;
            this.cboResEncoding.Location = new System.Drawing.Point(87, 199);
            this.cboResEncoding.Name = "cboResEncoding";
            this.cboResEncoding.Size = new System.Drawing.Size(627, 20);
            this.cboResEncoding.TabIndex = 6;
            this.cboResEncoding.SelectedIndexChanged += new System.EventHandler(this.cboResEncoding_SelectedIndexChanged);
            // 
            // txtPostHeader
            // 
            this.txtPostHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostHeader.Location = new System.Drawing.Point(87, 115);
            this.txtPostHeader.Multiline = true;
            this.txtPostHeader.Name = "txtPostHeader";
            this.txtPostHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostHeader.Size = new System.Drawing.Size(695, 53);
            this.txtPostHeader.TabIndex = 10;
            // 
            // lblResEncoding
            // 
            this.lblResEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResEncoding.AutoSize = true;
            this.lblResEncoding.Location = new System.Drawing.Point(10, 199);
            this.lblResEncoding.Name = "lblResEncoding";
            this.lblResEncoding.Size = new System.Drawing.Size(77, 12);
            this.lblResEncoding.TabIndex = 5;
            this.lblResEncoding.Text = "RespEncoding";
            // 
            // cookietitle
            // 
            this.cookietitle.AutoSize = true;
            this.cookietitle.Location = new System.Drawing.Point(10, 61);
            this.cookietitle.Name = "cookietitle";
            this.cookietitle.Size = new System.Drawing.Size(41, 12);
            this.cookietitle.TabIndex = 8;
            this.cookietitle.Text = "Cookie";
            // 
            // cbb_contenttype
            // 
            this.cbb_contenttype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_contenttype.DropDownHeight = 400;
            this.cbb_contenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_contenttype.FormattingEnabled = true;
            this.cbb_contenttype.IntegralHeight = false;
            this.cbb_contenttype.Location = new System.Drawing.Point(478, 174);
            this.cbb_contenttype.Name = "cbb_contenttype";
            this.cbb_contenttype.Size = new System.Drawing.Size(303, 20);
            this.cbb_contenttype.TabIndex = 6;
            this.cbb_contenttype.SelectedIndexChanged += new System.EventHandler(this.cboResEncoding_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "ReqAccept";
            // 
            // txtPostCookie
            // 
            this.txtPostCookie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostCookie.Location = new System.Drawing.Point(86, 59);
            this.txtPostCookie.Multiline = true;
            this.txtPostCookie.Name = "txtPostCookie";
            this.txtPostCookie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostCookie.Size = new System.Drawing.Size(695, 52);
            this.txtPostCookie.TabIndex = 7;
            // 
            // PostDataTitle
            // 
            this.PostDataTitle.AutoSize = true;
            this.PostDataTitle.Location = new System.Drawing.Point(10, 24);
            this.PostDataTitle.Name = "PostDataTitle";
            this.PostDataTitle.Size = new System.Drawing.Size(29, 12);
            this.PostDataTitle.TabIndex = 4;
            this.PostDataTitle.Text = "Post";
            // 
            // txtPostData
            // 
            this.txtPostData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostData.Location = new System.Drawing.Point(86, 24);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostData.Size = new System.Drawing.Size(695, 30);
            this.txtPostData.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(720, 0);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(64, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(87, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(627, 21);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://192.168.0.1/";
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cboMode.Location = new System.Drawing.Point(10, 2);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(64, 20);
            this.cboMode.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 222);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(784, 420);
            this.txtLog.TabIndex = 1;
            this.txtLog.WordWrap = false;
            // 
            // FrmTestHttpPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 642);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.pnlTool);
            this.Name = "FrmTestHttpPost";
            this.Text = "TestHttpPost(测试Http的POST方法)";
            this.Load += new System.EventHandler(this.FrmTestHttpPost_Load);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlTool;
		private System.Windows.Forms.ComboBox cboMode;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox txtPostData;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Label PostDataTitle;
		private System.Windows.Forms.Label lblResEncoding;
		private System.Windows.Forms.ComboBox cboResEncoding;
        private System.Windows.Forms.TextBox txtPostCookie;
        private System.Windows.Forms.Label cookietitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label headertitle;
        private System.Windows.Forms.TextBox txtPostHeader;
        private System.Windows.Forms.Label proxytitle;
        private System.Windows.Forms.TextBox textPostProxy;
        private System.Windows.Forms.ComboBox cbb_contenttype;
        private System.Windows.Forms.Label label1;
	}
}

