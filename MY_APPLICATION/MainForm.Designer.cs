namespace MY_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.addSomeDataButton = new System.Windows.Forms.Button();
			this.displayDataButton = new System.Windows.Forms.Button();
			this.peopleDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// addSomeDataButton
			// 
			this.addSomeDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addSomeDataButton.Location = new System.Drawing.Point(12, 12);
			this.addSomeDataButton.Name = "addSomeDataButton";
			this.addSomeDataButton.Size = new System.Drawing.Size(421, 23);
			this.addSomeDataButton.TabIndex = 0;
			this.addSomeDataButton.Text = "&Add Some Data Button";
			this.addSomeDataButton.UseVisualStyleBackColor = true;
			this.addSomeDataButton.Click += new System.EventHandler(this.AddSomeDataButton_Click);
			// 
			// displayDataButton
			// 
			this.displayDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayDataButton.Location = new System.Drawing.Point(12, 41);
			this.displayDataButton.Name = "displayDataButton";
			this.displayDataButton.Size = new System.Drawing.Size(421, 23);
			this.displayDataButton.TabIndex = 1;
			this.displayDataButton.Text = "&Display Data";
			this.displayDataButton.UseVisualStyleBackColor = true;
			this.displayDataButton.Click += new System.EventHandler(this.DisplayDataButton_Click);
			// 
			// peopleDataGridView
			// 
			this.peopleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.peopleDataGridView.Location = new System.Drawing.Point(12, 70);
			this.peopleDataGridView.Name = "peopleDataGridView";
			this.peopleDataGridView.Size = new System.Drawing.Size(421, 269);
			this.peopleDataGridView.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 351);
			this.Controls.Add(this.peopleDataGridView);
			this.Controls.Add(this.displayDataButton);
			this.Controls.Add(this.addSomeDataButton);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addSomeDataButton;
		private System.Windows.Forms.Button displayDataButton;
		private System.Windows.Forms.DataGridView peopleDataGridView;
	}
}
