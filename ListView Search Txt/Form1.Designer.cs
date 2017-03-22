namespace ListView_Search_Txt
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
            this.mListView = new MetroFramework.Controls.MetroListView();
            this.searchTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mListView
            // 
            this.mListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mListView.FullRowSelect = true;
            this.mListView.Location = new System.Drawing.Point(57, 165);
            this.mListView.Name = "mListView";
            this.mListView.OwnerDraw = true;
            this.mListView.Size = new System.Drawing.Size(348, 378);
            this.mListView.TabIndex = 0;
            this.mListView.UseCompatibleStateImageBehavior = false;
            this.mListView.UseSelectable = true;
            // 
            // searchTxt
            // 
            // 
            // 
            // 
            this.searchTxt.CustomButton.Image = null;
            this.searchTxt.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.searchTxt.CustomButton.Name = "";
            this.searchTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTxt.CustomButton.TabIndex = 1;
            this.searchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTxt.CustomButton.UseSelectable = true;
            this.searchTxt.CustomButton.Visible = false;
            this.searchTxt.Lines = new string[0];
            this.searchTxt.Location = new System.Drawing.Point(146, 106);
            this.searchTxt.MaxLength = 32767;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTxt.SelectedText = "";
            this.searchTxt.SelectionLength = 0;
            this.searchTxt.SelectionStart = 0;
            this.searchTxt.ShortcutsEnabled = true;
            this.searchTxt.ShowClearButton = true;
            this.searchTxt.Size = new System.Drawing.Size(173, 23);
            this.searchTxt.TabIndex = 1;
            this.searchTxt.UseSelectable = true;
            this.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 585);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.mListView);
            this.Name = "Form1";
            this.Text = "ListView Search Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView mListView;
        private MetroFramework.Controls.MetroTextBox searchTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

