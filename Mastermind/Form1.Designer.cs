
namespace Mastermind
{
    partial class MastermindGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MastermindGame));
            this.lblAnswer = new System.Windows.Forms.Label();
            this.cbColourPicker = new System.Windows.Forms.ComboBox();
            this.lblColourPalette = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudCodeLength = new System.Windows.Forms.NumericUpDown();
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.btnDebugClear = new System.Windows.Forms.Button();
            this.cbDebug = new System.Windows.Forms.CheckBox();
            this.lblCodeLength = new System.Windows.Forms.Label();
            this.lblEasterEgg = new System.Windows.Forms.Label();
            this.nudAttempts = new System.Windows.Forms.NumericUpDown();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblAttemptsDisplay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblHint1 = new System.Windows.Forms.Label();
            this.lblHint2 = new System.Windows.Forms.Label();
            this.flpGuessHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.flpColours = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpColours = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGuesses = new System.Windows.Forms.TableLayoutPanel();
            this.flpGuesses = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.cbDuplicates = new System.Windows.Forms.CheckBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelDebug = new System.Windows.Forms.Panel();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttempts)).BeginInit();
            this.tlpColours.SuspendLayout();
            this.tlpGuesses.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(7, 3);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 6;
            // 
            // cbColourPicker
            // 
            this.cbColourPicker.FormattingEnabled = true;
            this.cbColourPicker.Items.AddRange(new object[] {
            "Default",
            "Monochrome",
            "RGB",
            "Ten Colour Test"});
            this.cbColourPicker.Location = new System.Drawing.Point(80, 37);
            this.cbColourPicker.Name = "cbColourPicker";
            this.cbColourPicker.Size = new System.Drawing.Size(103, 21);
            this.cbColourPicker.TabIndex = 7;
            this.cbColourPicker.Text = "Default";
            this.cbColourPicker.SelectedIndexChanged += new System.EventHandler(this.cbColourPicker_SelectedIndexChanged);
            // 
            // lblColourPalette
            // 
            this.lblColourPalette.AutoSize = true;
            this.lblColourPalette.BackColor = System.Drawing.Color.DimGray;
            this.lblColourPalette.Location = new System.Drawing.Point(6, 40);
            this.lblColourPalette.Name = "lblColourPalette";
            this.lblColourPalette.Size = new System.Drawing.Size(75, 13);
            this.lblColourPalette.TabIndex = 8;
            this.lblColourPalette.Text = "Colour palette:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(96, 91);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 14;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(83, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudCodeLength
            // 
            this.nudCodeLength.Location = new System.Drawing.Point(80, 65);
            this.nudCodeLength.Name = "nudCodeLength";
            this.nudCodeLength.Size = new System.Drawing.Size(35, 20);
            this.nudCodeLength.TabIndex = 19;
            this.nudCodeLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCodeLength.ValueChanged += new System.EventHandler(this.nudCodeLength_ValueChanged);
            // 
            // tbDebug
            // 
            this.tbDebug.Location = new System.Drawing.Point(8, 22);
            this.tbDebug.Multiline = true;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDebug.Size = new System.Drawing.Size(502, 240);
            this.tbDebug.TabIndex = 20;
            // 
            // btnDebugClear
            // 
            this.btnDebugClear.Location = new System.Drawing.Point(8, 268);
            this.btnDebugClear.Name = "btnDebugClear";
            this.btnDebugClear.Size = new System.Drawing.Size(502, 23);
            this.btnDebugClear.TabIndex = 23;
            this.btnDebugClear.Text = "Clear debug output";
            this.btnDebugClear.UseVisualStyleBackColor = true;
            this.btnDebugClear.Click += new System.EventHandler(this.btnDebugClear_Click);
            // 
            // cbDebug
            // 
            this.cbDebug.AutoSize = true;
            this.cbDebug.BackColor = System.Drawing.Color.DimGray;
            this.cbDebug.Location = new System.Drawing.Point(26, 140);
            this.cbDebug.Name = "cbDebug";
            this.cbDebug.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDebug.Size = new System.Drawing.Size(67, 17);
            this.cbDebug.TabIndex = 24;
            this.cbDebug.Text = "  :Debug";
            this.cbDebug.UseVisualStyleBackColor = false;
            this.cbDebug.CheckedChanged += new System.EventHandler(this.cbDebug_CheckedChanged);
            // 
            // lblCodeLength
            // 
            this.lblCodeLength.AutoSize = true;
            this.lblCodeLength.BackColor = System.Drawing.Color.DimGray;
            this.lblCodeLength.Location = new System.Drawing.Point(10, 68);
            this.lblCodeLength.Name = "lblCodeLength";
            this.lblCodeLength.Size = new System.Drawing.Size(67, 13);
            this.lblCodeLength.TabIndex = 26;
            this.lblCodeLength.Text = "Code length:";
            // 
            // lblEasterEgg
            // 
            this.lblEasterEgg.AutoSize = true;
            this.lblEasterEgg.Location = new System.Drawing.Point(1088, 656);
            this.lblEasterEgg.Name = "lblEasterEgg";
            this.lblEasterEgg.Size = new System.Drawing.Size(124, 13);
            this.lblEasterEgg.TabIndex = 28;
            this.lblEasterEgg.Text = "Why are you full-screen?";
            // 
            // nudAttempts
            // 
            this.nudAttempts.Location = new System.Drawing.Point(80, 92);
            this.nudAttempts.Name = "nudAttempts";
            this.nudAttempts.Size = new System.Drawing.Size(35, 20);
            this.nudAttempts.TabIndex = 29;
            this.nudAttempts.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAttempts.ValueChanged += new System.EventHandler(this.nudAttempts_ValueChanged);
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.BackColor = System.Drawing.Color.DimGray;
            this.lblAttempts.Location = new System.Drawing.Point(23, 94);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(54, 13);
            this.lblAttempts.TabIndex = 30;
            this.lblAttempts.Text = "Attempts: ";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator.Location = new System.Drawing.Point(0, 0);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(361, 54);
            this.lblSeparator.TabIndex = 32;
            this.lblSeparator.Text = "_____________";
            // 
            // lblAttemptsDisplay
            // 
            this.lblAttemptsDisplay.AutoSize = true;
            this.lblAttemptsDisplay.BackColor = System.Drawing.Color.Black;
            this.lblAttemptsDisplay.ForeColor = System.Drawing.Color.White;
            this.lblAttemptsDisplay.Location = new System.Drawing.Point(245, 116);
            this.lblAttemptsDisplay.Name = "lblAttemptsDisplay";
            this.lblAttemptsDisplay.Size = new System.Drawing.Size(69, 13);
            this.lblAttemptsDisplay.TabIndex = 33;
            this.lblAttemptsDisplay.Text = "Attempt 1/10";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(6, 111);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 34;
            this.lblTimer.Text = "Timer";
            this.lblTimer.Visible = false;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblHint1
            // 
            this.lblHint1.AutoSize = true;
            this.lblHint1.BackColor = System.Drawing.Color.Red;
            this.lblHint1.ForeColor = System.Drawing.Color.White;
            this.lblHint1.Location = new System.Drawing.Point(177, 92);
            this.lblHint1.Name = "lblHint1";
            this.lblHint1.Size = new System.Drawing.Size(13, 13);
            this.lblHint1.TabIndex = 81;
            this.lblHint1.Text = "0";
            // 
            // lblHint2
            // 
            this.lblHint2.AutoSize = true;
            this.lblHint2.BackColor = System.Drawing.Color.White;
            this.lblHint2.ForeColor = System.Drawing.Color.Black;
            this.lblHint2.Location = new System.Drawing.Point(207, 92);
            this.lblHint2.Name = "lblHint2";
            this.lblHint2.Size = new System.Drawing.Size(13, 13);
            this.lblHint2.TabIndex = 82;
            this.lblHint2.Text = "0";
            // 
            // flpGuessHistory
            // 
            this.flpGuessHistory.AutoScroll = true;
            this.flpGuessHistory.BackColor = System.Drawing.Color.Silver;
            this.flpGuessHistory.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpGuessHistory.Location = new System.Drawing.Point(10, 135);
            this.flpGuessHistory.Name = "flpGuessHistory";
            this.flpGuessHistory.Size = new System.Drawing.Size(304, 270);
            this.flpGuessHistory.TabIndex = 83;
            this.flpGuessHistory.WrapContents = false;
            // 
            // flpColours
            // 
            this.flpColours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpColours.AutoSize = true;
            this.flpColours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpColours.Location = new System.Drawing.Point(161, 3);
            this.flpColours.MaximumSize = new System.Drawing.Size(328, 37);
            this.flpColours.Name = "flpColours";
            this.flpColours.Size = new System.Drawing.Size(0, 31);
            this.flpColours.TabIndex = 84;
            this.flpColours.WrapContents = false;
            // 
            // tlpColours
            // 
            this.tlpColours.AutoSize = true;
            this.tlpColours.ColumnCount = 1;
            this.tlpColours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpColours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpColours.Controls.Add(this.flpColours, 0, 0);
            this.tlpColours.Location = new System.Drawing.Point(0, 3);
            this.tlpColours.MaximumSize = new System.Drawing.Size(328, 37);
            this.tlpColours.Name = "tlpColours";
            this.tlpColours.RowCount = 1;
            this.tlpColours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpColours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpColours.Size = new System.Drawing.Size(322, 37);
            this.tlpColours.TabIndex = 85;
            // 
            // tlpGuesses
            // 
            this.tlpGuesses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGuesses.ColumnCount = 1;
            this.tlpGuesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGuesses.Controls.Add(this.flpGuesses, 0, 0);
            this.tlpGuesses.Location = new System.Drawing.Point(0, 56);
            this.tlpGuesses.Name = "tlpGuesses";
            this.tlpGuesses.RowCount = 1;
            this.tlpGuesses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGuesses.Size = new System.Drawing.Size(322, 37);
            this.tlpGuesses.TabIndex = 86;
            // 
            // flpGuesses
            // 
            this.flpGuesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpGuesses.AutoSize = true;
            this.flpGuesses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpGuesses.Location = new System.Drawing.Point(161, 3);
            this.flpGuesses.MaximumSize = new System.Drawing.Size(328, 50);
            this.flpGuesses.Name = "flpGuesses";
            this.flpGuesses.Size = new System.Drawing.Size(0, 31);
            this.flpGuesses.TabIndex = 85;
            this.flpGuesses.WrapContents = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(65, 288);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(59, 21);
            this.btnHelp.TabIndex = 87;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.DimGray;
            this.panelSettings.Controls.Add(this.cbDuplicates);
            this.panelSettings.Controls.Add(this.lblSettings);
            this.panelSettings.Controls.Add(this.btnHelp);
            this.panelSettings.Controls.Add(this.nudCodeLength);
            this.panelSettings.Controls.Add(this.cbDebug);
            this.panelSettings.Controls.Add(this.lblColourPalette);
            this.panelSettings.Controls.Add(this.cbColourPicker);
            this.panelSettings.Controls.Add(this.lblCodeLength);
            this.panelSettings.Controls.Add(this.lblAttempts);
            this.panelSettings.Controls.Add(this.nudAttempts);
            this.panelSettings.Controls.Add(this.pbLogo);
            this.panelSettings.Location = new System.Drawing.Point(328, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(191, 405);
            this.panelSettings.TabIndex = 89;
            this.panelSettings.Visible = false;
            // 
            // cbDuplicates
            // 
            this.cbDuplicates.AutoSize = true;
            this.cbDuplicates.BackColor = System.Drawing.Color.DimGray;
            this.cbDuplicates.Checked = true;
            this.cbDuplicates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDuplicates.Location = new System.Drawing.Point(9, 117);
            this.cbDuplicates.Name = "cbDuplicates";
            this.cbDuplicates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbDuplicates.Size = new System.Drawing.Size(85, 17);
            this.cbDuplicates.TabIndex = 91;
            this.cbDuplicates.Text = "  :Duplicates";
            this.cbDuplicates.UseVisualStyleBackColor = false;
            this.cbDuplicates.CheckedChanged += new System.EventHandler(this.cbDuplicates_CheckedChanged);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(49, 5);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(93, 24);
            this.lblSettings.TabIndex = 89;
            this.lblSettings.Text = "Settings";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Mastermind.Properties.Resources.Mastermind_ST;
            this.pbLogo.Location = new System.Drawing.Point(-5, 140);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(196, 169);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 88;
            this.pbLogo.TabStop = false;
            // 
            // panelDebug
            // 
            this.panelDebug.BackColor = System.Drawing.Color.Transparent;
            this.panelDebug.Controls.Add(this.lblAnswer);
            this.panelDebug.Controls.Add(this.tbDebug);
            this.panelDebug.Controls.Add(this.btnDebugClear);
            this.panelDebug.Location = new System.Drawing.Point(0, 405);
            this.panelDebug.Name = "panelDebug";
            this.panelDebug.Size = new System.Drawing.Size(519, 297);
            this.panelDebug.TabIndex = 90;
            this.panelDebug.Visible = false;
            // 
            // pbSettings
            // 
            this.pbSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSettings.Image = global::Mastermind.Properties.Resources.settings;
            this.pbSettings.Location = new System.Drawing.Point(0, 35);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(30, 30);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 25;
            this.pbSettings.TabStop = false;
            this.pbSettings.Tag = "Hidden";
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // MastermindGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(627, 704);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.tlpGuesses);
            this.Controls.Add(this.tlpColours);
            this.Controls.Add(this.flpGuessHistory);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblAttemptsDisplay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHint2);
            this.Controls.Add(this.lblHint1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelDebug);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.lblEasterEgg);
            this.Controls.Add(this.lblSeparator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MastermindGame";
            this.Text = "Mastermind";
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttempts)).EndInit();
            this.tlpColours.ResumeLayout(false);
            this.tlpColours.PerformLayout();
            this.tlpGuesses.ResumeLayout(false);
            this.tlpGuesses.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelDebug.ResumeLayout(false);
            this.panelDebug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ComboBox cbColourPicker;
        private System.Windows.Forms.Label lblColourPalette;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudCodeLength;
        private System.Windows.Forms.TextBox tbDebug;
        private System.Windows.Forms.Button btnDebugClear;
        private System.Windows.Forms.CheckBox cbDebug;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Label lblCodeLength;
        private System.Windows.Forms.Label lblEasterEgg;
        private System.Windows.Forms.NumericUpDown nudAttempts;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblAttemptsDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblHint1;
        private System.Windows.Forms.Label lblHint2;
        private System.Windows.Forms.FlowLayoutPanel flpGuessHistory;
        private System.Windows.Forms.FlowLayoutPanel flpColours;
        private System.Windows.Forms.TableLayoutPanel tlpColours;
        private System.Windows.Forms.TableLayoutPanel tlpGuesses;
        private System.Windows.Forms.FlowLayoutPanel flpGuesses;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelDebug;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.CheckBox cbDuplicates;
    }
}

