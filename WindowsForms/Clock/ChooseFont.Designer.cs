
namespace Clock
{
	partial class ChooseFontForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFontForm));
			this.nudFontSize = new System.Windows.Forms.NumericUpDown();
			this.labelChooseFont = new System.Windows.Forms.Label();
			this.labelFontSize = new System.Windows.Forms.Label();
			this.labelExample = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbFonts = new System.Windows.Forms.ComboBox();
			this.btnAapply = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// nudFontSize
			// 
			this.nudFontSize.CausesValidation = false;
			this.nudFontSize.Location = new System.Drawing.Point(696, 56);
			this.nudFontSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudFontSize.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.nudFontSize.Name = "nudFontSize";
			this.nudFontSize.Size = new System.Drawing.Size(101, 22);
			this.nudFontSize.TabIndex = 1;
			this.nudFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudFontSize.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
			// 
			// labelChooseFont
			// 
			this.labelChooseFont.CausesValidation = false;
			this.labelChooseFont.Location = new System.Drawing.Point(13, 32);
			this.labelChooseFont.Name = "labelChooseFont";
			this.labelChooseFont.Size = new System.Drawing.Size(76, 17);
			this.labelChooseFont.TabIndex = 2;
			this.labelChooseFont.Text = "ChoosFont";
			this.labelChooseFont.UseMnemonic = false;
			// 
			// labelFontSize
			// 
			this.labelFontSize.CausesValidation = false;
			this.labelFontSize.Location = new System.Drawing.Point(722, 33);
			this.labelFontSize.Name = "labelFontSize";
			this.labelFontSize.Size = new System.Drawing.Size(65, 17);
			this.labelFontSize.TabIndex = 3;
			this.labelFontSize.Text = "Font size";
			this.labelFontSize.UseMnemonic = false;
			// 
			// labelExample
			// 
			this.labelExample.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.labelExample.AutoSize = true;
			this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelExample.Location = new System.Drawing.Point(16, 109);
			this.labelExample.Name = "labelExample";
			this.labelExample.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.labelExample.Size = new System.Drawing.Size(176, 46);
			this.labelExample.TabIndex = 4;
			this.labelExample.Text = "Example";
			// 
			// btnOK
			// 
			this.btnOK.CausesValidation = false;
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(517, 398);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(105, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(628, 398);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(118, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// cbFonts
			// 
			this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFonts.FormattingEnabled = true;
			this.cbFonts.Location = new System.Drawing.Point(12, 55);
			this.cbFonts.Name = "cbFonts";
			this.cbFonts.Size = new System.Drawing.Size(661, 24);
			this.cbFonts.TabIndex = 0;
			this.cbFonts.UseWaitCursor = true;
			// 
			// btnAapply
			// 
			this.btnAapply.CausesValidation = false;
			this.btnAapply.Location = new System.Drawing.Point(696, 89);
			this.btnAapply.Name = "btnAapply";
			this.btnAapply.Size = new System.Drawing.Size(101, 27);
			this.btnAapply.TabIndex = 7;
			this.btnAapply.Text = "Apply";
			this.btnAapply.UseVisualStyleBackColor = true;
			this.btnAapply.Click += new System.EventHandler(this.btnAapply_Click);
			// 
			// ChooseFontForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAapply);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.labelFontSize);
			this.Controls.Add(this.labelChooseFont);
			this.Controls.Add(this.nudFontSize);
			this.Controls.Add(this.cbFonts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ChooseFontForm";
			this.Text = "ChooseFont";
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NumericUpDown nudFontSize;
		private System.Windows.Forms.Label labelChooseFont;
		private System.Windows.Forms.Label labelFontSize;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cbFonts;
		public System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.Button btnAapply;
	}
}