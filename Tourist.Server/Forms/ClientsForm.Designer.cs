namespace Tourist.Server.Forms
{
	partial class ClientsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.metroTabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(-1, 751);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1368, 150);
			this.FooterPanel.TabIndex = 15;
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.panel2);
			this.HeaderPanel.Controls.Add(this.SubTitleLabel);
			this.HeaderPanel.Controls.Add(this.TitleLabel);
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 28);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1368, 150);
			this.HeaderPanel.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(562, 153);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 32);
			this.panel2.TabIndex = 11;
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(32, 82);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(216, 38);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Manage Clients ";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(23, 3);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(338, 65);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Clients Details";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.metroTabControl1);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 184);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1368, 561);
			this.BodyPanel.TabIndex = 16;
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Controls.Add(this.metroTabPage3);
			this.metroTabControl1.Controls.Add(this.metroTabPage4);
			this.metroTabControl1.Controls.Add(this.metroTabPage5);
			this.metroTabControl1.Controls.Add(this.metroTabPage6);
			this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
			this.metroTabControl1.ItemSize = new System.Drawing.Size(138, 100);
			this.metroTabControl1.Location = new System.Drawing.Point(63, 14);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(1249, 524);
			this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.metroTabControl1.TabIndex = 0;
			this.metroTabControl1.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 104);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(1241, 416);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "metroTabPage1";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 104);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(1241, 416);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "metroTabPage2";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 10;
			// 
			// metroTabPage3
			// 
			this.metroTabPage3.HorizontalScrollbarBarColor = true;
			this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.HorizontalScrollbarSize = 10;
			this.metroTabPage3.Location = new System.Drawing.Point(4, 104);
			this.metroTabPage3.Name = "metroTabPage3";
			this.metroTabPage3.Size = new System.Drawing.Size(1241, 416);
			this.metroTabPage3.TabIndex = 2;
			this.metroTabPage3.Text = "metroTabPage3";
			this.metroTabPage3.VerticalScrollbarBarColor = true;
			this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.VerticalScrollbarSize = 10;
			// 
			// metroTabPage4
			// 
			this.metroTabPage4.HorizontalScrollbarBarColor = true;
			this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage4.HorizontalScrollbarSize = 10;
			this.metroTabPage4.Location = new System.Drawing.Point(4, 104);
			this.metroTabPage4.Name = "metroTabPage4";
			this.metroTabPage4.Size = new System.Drawing.Size(1241, 416);
			this.metroTabPage4.TabIndex = 3;
			this.metroTabPage4.Text = "metroTabPage4";
			this.metroTabPage4.VerticalScrollbarBarColor = true;
			this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage4.VerticalScrollbarSize = 10;
			// 
			// metroTabPage5
			// 
			this.metroTabPage5.HorizontalScrollbarBarColor = true;
			this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage5.HorizontalScrollbarSize = 10;
			this.metroTabPage5.Location = new System.Drawing.Point(4, 104);
			this.metroTabPage5.Name = "metroTabPage5";
			this.metroTabPage5.Size = new System.Drawing.Size(1241, 416);
			this.metroTabPage5.TabIndex = 4;
			this.metroTabPage5.Text = "metroTabPage5";
			this.metroTabPage5.VerticalScrollbarBarColor = true;
			this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage5.VerticalScrollbarSize = 10;
			// 
			// metroTabPage6
			// 
			this.metroTabPage6.HorizontalScrollbarBarColor = true;
			this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage6.HorizontalScrollbarSize = 10;
			this.metroTabPage6.Location = new System.Drawing.Point(4, 104);
			this.metroTabPage6.Name = "metroTabPage6";
			this.metroTabPage6.Size = new System.Drawing.Size(1241, 416);
			this.metroTabPage6.TabIndex = 5;
			this.metroTabPage6.Text = "metroTabPage6";
			this.metroTabPage6.VerticalScrollbarBarColor = true;
			this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage6.VerticalScrollbarSize = 10;
			// 
			// ClientsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1366, 900);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Name = "ClientsForm";
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.ClientsForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.metroTabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel BodyPanel;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private MetroFramework.Controls.MetroTabPage metroTabPage3;
		private MetroFramework.Controls.MetroTabPage metroTabPage4;
		private MetroFramework.Controls.MetroTabPage metroTabPage5;
		private MetroFramework.Controls.MetroTabPage metroTabPage6;

	}
}