
namespace WavTrimmer
{
    partial class frm_Main
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
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_Reference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BrowseLocation = new System.Windows.Forms.Button();
            this.btn_BrowseReference = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lv_Logs = new System.Windows.Forms.ListBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cb_Silence = new System.Windows.Forms.CheckBox();
            this.cb_Trim = new System.Windows.Forms.CheckBox();
            this.cb_ALT = new System.Windows.Forms.CheckBox();
            this.rb_50 = new System.Windows.Forms.RadioButton();
            this.rb_End = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_Location
            // 
            this.txt_Location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Location.Location = new System.Drawing.Point(134, 38);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(465, 26);
            this.txt_Location.TabIndex = 0;
            // 
            // txt_Reference
            // 
            this.txt_Reference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reference.Location = new System.Drawing.Point(134, 84);
            this.txt_Reference.Name = "txt_Reference";
            this.txt_Reference.Size = new System.Drawing.Size(465, 26);
            this.txt_Reference.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // btn_BrowseLocation
            // 
            this.btn_BrowseLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseLocation.Location = new System.Drawing.Point(605, 38);
            this.btn_BrowseLocation.Name = "btn_BrowseLocation";
            this.btn_BrowseLocation.Size = new System.Drawing.Size(107, 26);
            this.btn_BrowseLocation.TabIndex = 4;
            this.btn_BrowseLocation.Text = "Browse";
            this.btn_BrowseLocation.UseVisualStyleBackColor = true;
            this.btn_BrowseLocation.Click += new System.EventHandler(this.btn_BrowseLocation_Click);
            // 
            // btn_BrowseReference
            // 
            this.btn_BrowseReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseReference.Location = new System.Drawing.Point(605, 84);
            this.btn_BrowseReference.Name = "btn_BrowseReference";
            this.btn_BrowseReference.Size = new System.Drawing.Size(107, 26);
            this.btn_BrowseReference.TabIndex = 5;
            this.btn_BrowseReference.Text = "Browse";
            this.btn_BrowseReference.UseVisualStyleBackColor = true;
            this.btn_BrowseReference.Click += new System.EventHandler(this.btn_BrowseReference_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(492, 464);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(107, 37);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lv_Logs
            // 
            this.lv_Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Logs.FormattingEnabled = true;
            this.lv_Logs.HorizontalScrollbar = true;
            this.lv_Logs.ItemHeight = 16;
            this.lv_Logs.Location = new System.Drawing.Point(72, 176);
            this.lv_Logs.Name = "lv_Logs";
            this.lv_Logs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lv_Logs.Size = new System.Drawing.Size(640, 260);
            this.lv_Logs.TabIndex = 8;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(605, 464);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(107, 37);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // folderDialog
            // 
            this.folderDialog.ShowNewFolderButton = false;
            // 
            // cb_Silence
            // 
            this.cb_Silence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Silence.AutoSize = true;
            this.cb_Silence.Checked = true;
            this.cb_Silence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Silence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Silence.Location = new System.Drawing.Point(599, 131);
            this.cb_Silence.Name = "cb_Silence";
            this.cb_Silence.Size = new System.Drawing.Size(113, 24);
            this.cb_Silence.TabIndex = 10;
            this.cb_Silence.Text = "Add Silence";
            this.cb_Silence.UseVisualStyleBackColor = true;
            // 
            // cb_Trim
            // 
            this.cb_Trim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Trim.AutoSize = true;
            this.cb_Trim.Checked = true;
            this.cb_Trim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Trim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Trim.Location = new System.Drawing.Point(535, 131);
            this.cb_Trim.Name = "cb_Trim";
            this.cb_Trim.Size = new System.Drawing.Size(58, 24);
            this.cb_Trim.TabIndex = 11;
            this.cb_Trim.Text = "Trim";
            this.cb_Trim.UseVisualStyleBackColor = true;
            // 
            // cb_ALT
            // 
            this.cb_ALT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ALT.AutoSize = true;
            this.cb_ALT.Checked = true;
            this.cb_ALT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ALT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ALT.Location = new System.Drawing.Point(402, 131);
            this.cb_ALT.Name = "cb_ALT";
            this.cb_ALT.Size = new System.Drawing.Size(127, 24);
            this.cb_ALT.TabIndex = 12;
            this.cb_ALT.Text = "Process _ALT";
            this.cb_ALT.UseVisualStyleBackColor = true;
            // 
            // rb_50
            // 
            this.rb_50.AutoSize = true;
            this.rb_50.Checked = true;
            this.rb_50.Location = new System.Drawing.Point(72, 464);
            this.rb_50.Name = "rb_50";
            this.rb_50.Size = new System.Drawing.Size(116, 20);
            this.rb_50.TabIndex = 13;
            this.rb_50.TabStop = true;
            this.rb_50.Text = "50% Start / End";
            this.rb_50.UseVisualStyleBackColor = true;
            // 
            // rb_End
            // 
            this.rb_End.AutoSize = true;
            this.rb_End.Location = new System.Drawing.Point(196, 464);
            this.rb_End.Name = "rb_End";
            this.rb_End.Size = new System.Drawing.Size(86, 20);
            this.rb_End.TabIndex = 14;
            this.rb_End.Text = "100% End";
            this.rb_End.UseVisualStyleBackColor = true;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rb_End);
            this.Controls.Add(this.rb_50);
            this.Controls.Add(this.cb_ALT);
            this.Controls.Add(this.cb_Trim);
            this.Controls.Add(this.cb_Silence);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lv_Logs);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_BrowseReference);
            this.Controls.Add(this.btn_BrowseLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Reference);
            this.Controls.Add(this.txt_Location);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wav Trimmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.TextBox txt_Reference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BrowseLocation;
        private System.Windows.Forms.Button btn_BrowseReference;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ListBox lv_Logs;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.CheckBox cb_Silence;
        private System.Windows.Forms.CheckBox cb_Trim;
        private System.Windows.Forms.CheckBox cb_ALT;
        private System.Windows.Forms.RadioButton rb_50;
        private System.Windows.Forms.RadioButton rb_End;
    }
}

