using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mastermind
{
    public partial class MastermindGame : Form
    {
        // ### Is it a good idea to make these public? Certainly less of a headache.
        public List<string> colours;
        public int[] code;
        public List<PictureBox> pbGuesses;
        public int codeLength = 4;
        public bool display;
        public int timeLeft;
        public bool infiniteAttempts;
        public bool allowDuplicates;


        public MastermindGame()
        {
            InitializeComponent();

            // Code that runs on start-up.

            this.Size = new Size(344, 456);
            colours = new List<string>(new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple" });
            allowDuplicates = true;
            infiniteAttempts = false;

            StartGame();
            RefreshColourPalette();

            // Uncomment to enable.
            //DebugModeOn();

        }

        private void StartGame()
        {
            tbDebug.Text += "<RESTART>\r";

            GenerateCode(length: codeLength);
            nudAttempts.Tag = 1;
            lblAttemptsDisplay.Text = $"Attempt 1/{nudAttempts.Value}";

            // Delete controls
            if (pbGuesses != null)
            {
                foreach (PictureBox old in pbGuesses)
                {
                    Controls.Remove(old);
                    old.Dispose();
                }
            }

            if (flpGuessHistory.Controls.Count != 0)
            {
                tbDebug.Text += "<GH CLEAR>\r";
                for (int i = flpGuessHistory.Controls.Count - 1; i >= 0; i--)
                {
                    Controls.Remove(flpGuessHistory.Controls[i]);
                    flpGuessHistory.Controls[i].Dispose();
                }
            }



            /*FlowLayoutPanel flpGuessHistory = new FlowLayoutPanel
            {
                AutoScroll = true,
                BackColor = Color.Silver,
                FlowDirection = FlowDirection.BottomUp,
                Location = new Point(10,135),
                Size = new Size(304,226)
            };*/

            this.Controls.Add(flpGuessHistory);

            pbGuesses = new List<PictureBox>(); // Creates a list to store all guess PictureBoxes in.

            for (int n = 1; n <= codeLength; n++)
            {

                PictureBox pbGuess = new PictureBox
                {
                    Height = 25,
                    Width = 25,
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.Fixed3D
                };

                flpGuesses.Controls.Add(pbGuess);

                pbGuesses.Add(pbGuess); // Storing each PictureBox in list to reference them.
            }

            foreach (Button btnColour in flpColours.Controls)
            {
                btnColour.Enabled = true;
            }


        }

        private int[] GenerateCode(int length = 4)
        { // Generates a random code with values representing all the colours in the palette and of length codeLength.
            int n = colours.Count;

            tbDebug.Text += "<GEN>";
            code = new int[length];

            Random r = new Random();
            for (int pos = 0; pos < length; pos++)
            {
                int generated = r.Next(0, n);

                while (!allowDuplicates)
                { // Prevents duplicates in the code
                    if (code.Contains(generated))
                    {
                        tbDebug.Text += "<g>";
                        generated = r.Next(0, n);
                    }
                    else
                    {
                        break;
                    }
                }

                code[pos] = generated;

            }

            if (display)
            { DisplayCode(); }

            return code; // Unnecessary, but may be needed later.
        }

        private void DisplayCode()
        { // Updates label with the generated code. Currently for debug purposes only.
            lblAnswer.Text = "";
            foreach (int digit in code)
            {
                lblAnswer.Text += colours[digit];
                lblAnswer.Text += $"[{digit}] ";
            }
        }

        private void RefreshColourPalette()
        {
            tbDebug.Text = "<RCP>";

            if (flpColours.HasChildren)
            { // Dispose of old buttons and refresh.
                for (int i = flpColours.Controls.Count - 1; i >= 0; i--)
                {
                    flpColours.Controls[i].Dispose();
                }
            }

            foreach (string colour in colours)
            { // Add a new button with the corresponding colour from the palette.
                Button btnColour = new Button
                {
                    BackColor = Color.FromName(colour),
                    Size = new Size(25, 25),
                    FlatStyle = FlatStyle.Flat, //### Should I change this back?

                    // ### Pick one!
                    Name = $"btnColour{colours.IndexOf(colour)}",
                    Tag = colour
                };

                btnColour.Click += new EventHandler(this.btnColour_Click);

                flpColours.Controls.Add(btnColour);
            }

            // ### Add to list?
            ClearGuess();
        }

        private void btnColour_Click(object sender, EventArgs e)
        { // Event triggered by selecting a colour.
            Button btnColour = sender as Button;

            // ### Pick one!
            //UpdateGuess(Convert.ToInt32(btnColour.Name.Substring(9)));
            UpdateGuess(colours.IndexOf(btnColour.Tag.ToString()));
        }

        private void UpdateGuess(int pick)
        {
            tbDebug.Text += $"<GUESS:{pick}>\r";
            // Bad way of finding colour
            /*string colour = $"{(Controls.Find($"btnPick{pick}", true)[0].BackColor)}";
            colour = colour.Substring(7, colour.Length - 8);*/


            if (pbGuesses[codeLength - 1].BackColor != Color.Transparent)
            { // Clears the previous guess from the slots upon the next function call.
                ClearGuess();
            }

            foreach (PictureBox pbGuess in pbGuesses)
            { // Iterates through all the guess slots until an empty one is found, updated and the loop is broken.
                if (pbGuess.BackColor == Color.Transparent)
                {
                    pbGuess.BackColor = Color.FromName(colours[pick]);
                    pbGuess.Tag = pick;
                    break;
                }
            }

            if (pbGuesses[codeLength - 1].BackColor != Color.Transparent)
            { // Checks if the last slot is filled. If it is, the guess is checked against the answer.
                if (CheckGuess())
                { lblResult.Text = "Correct!"; }
                else { lblResult.Text = "Incorrect!"; }
            }
        }

        private bool CheckGuess() // ### Separate into multiple functions?
        {
            tbDebug.Text += "<CHECK>\r";
            List<int> guess = new List<int>();

            // ### NEEDS TO BE REWORKED SO IT CENTRES
            TableLayoutPanel tlpGuess = new TableLayoutPanel
            {
                Width = flpGuessHistory.Width
            };

            FlowLayoutPanel flpGuess = new FlowLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                WrapContents = false,
                Anchor = AnchorStyles.Top

            };

            tlpGuess.Controls.Add(flpGuess);

            flpGuessHistory.Controls.Add(flpGuess);
            Label lblAttemptNumber = new Label
            {
                Text = nudAttempts.Tag + ".",
                AutoSize = true
            };
            flpGuess.Controls.Add(lblAttemptNumber);


            foreach (PictureBox pbGuess in pbGuesses)
            {
                tbDebug.Text += $"[{pbGuess.Tag}]";
                guess.Add(Convert.ToInt32(pbGuess.Tag));

                // Store current guess in history.
                PictureBox pbSaveGuess = new PictureBox
                {
                    Size = new Size(15, 15), // 10 
                    BackColor = pbGuess.BackColor,
                    BorderStyle = BorderStyle.FixedSingle
                };

                flpGuess.Controls.Add(pbSaveGuess);
            }

            int correctPositionAndColour = 0;
            int incorrectPositionButCorrectColour = 0;

            int[] ignore = new int[code.Length]; // Janky solution for duplicates

            for (int i = 0; i < guess.Count; i++) //guess.Count/Length
            {
                if (guess[i] == code[i])
                {
                    correctPositionAndColour += 1;
                    ignore[i] = 2;
                }
            }
            for (int g = 0; g < guess.Count; g++)
            {
                if (ignore[g] != 2)
                {
                    for (int c = 0; c < code.Length; c++)
                    {
                        if (guess[g] == code[c] && ignore[c] == 0)
                        {
                            incorrectPositionButCorrectColour += 1;
                            ignore[c] = 1;
                            break; ///duplicates?
                        }
                    }
                }

            }

            // Updating hint text
            lblHint1.Text = $"{correctPositionAndColour}";
            lblHint2.Text = $"{incorrectPositionButCorrectColour}";

            Label lblGuessHint1 = new Label
            {
                BackColor = Color.Red,
                ForeColor = Color.White,
                Size = new Size(15, 15),
                Text = correctPositionAndColour.ToString()
            };

            Label lblGuessHint2 = new Label
            {
                BackColor = Color.White,
                ForeColor = Color.Black,
                Size = new Size(15, 15), //13
                Text = incorrectPositionButCorrectColour.ToString()
            };

            flpGuess.Controls.Add(lblGuessHint1);
            flpGuess.Controls.Add(lblGuessHint2);


            if (correctPositionAndColour == code.Length)
            {
                //StartGame();
                GenerateCode();
                return true;
            }
            else
            {
                nudAttempts.Tag = Convert.ToInt32(nudAttempts.Tag) + 1;
                if ((Convert.ToInt32(nudAttempts.Tag) > nudAttempts.Value) && !infiniteAttempts)
                {
                    MessageBox.Show("Game over!");
                    foreach (Button btnColour in flpColours.Controls)
                    {
                        btnColour.Enabled = false;
                    }
                }
                else
                {
                    lblAttemptsDisplay.Text = $"Attempt {nudAttempts.Tag}/{nudAttempts.Value}";
                }

                return false;
            }

        }

        private void cbColourPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handles changing colour palettes throughout the code.
            switch (cbColourPicker.Text)
            {
                case "Default":
                    colours = new List<string>(new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple" });
                    this.BackColor = Color.FromName("Gray");
                    InvertColours(false);
                    break;

                case "Monochrome":
                    colours = new List<string>(new string[] { "Black", "DimGray", "DarkGray", "Silver", "LightGray", "White" });
                    this.BackColor = Color.FromName("White");
                    InvertColours(false);
                    break;

                case "RGB":
                    colours = new List<string>(new string[] { "Red", "Green", "Blue" });
                    this.BackColor = Color.FromName("Black");
                    InvertColours(true);
                    break;

                case "Ten Colour Test": // ### Delete?
                    colours = new List<string>(new string[] { "Red", "Red", "Red", "Red", "Red", "Red", "Red", "Red", "Red", "Red" });
                    this.BackColor = Color.FromName("Pink");
                    InvertColours(false);
                    break;

            } // ### Todo: Update CB values dynamically.

            RefreshColourPalette();
            GenerateCode();
        }

        private void InvertColours(bool mode = true)
        { // Fixes colours for readability.
            if (mode)
            {
                lblResult.ForeColor = Color.White;
                lblSeparator.ForeColor = Color.White;
                pbSettings.Image = new Bitmap(Mastermind.Properties.Resources.settingswhite);
            }
            else
            {
                lblResult.ForeColor = Color.Black;
                lblSeparator.ForeColor = Color.Black;
                pbSettings.Image = new Bitmap(Mastermind.Properties.Resources.settings);
            }

        }

        private void ClearGuess()
        { // Resets current displayed guess and associated labels.
            tbDebug.Text += "<CLEAR>\r";
            foreach (PictureBox pbGuess in pbGuesses)
            {
                pbGuess.Tag = "";
                pbGuess.BackColor = Color.Transparent;
            }

            lblResult.Text = "";
            lblHint1.Text = "";
            lblHint2.Text = "";

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGuess();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ClearGuess();
            StartGame();
        }

        private void nudCodeLength_ValueChanged(object sender, EventArgs e)
        { // Settings: Change the length of the code generated.
            if (nudCodeLength.Value == 0)
            {
                nudCodeLength.Value = 1; // Prevents a length of 0.
            }
            else if (nudCodeLength.Value == 11)
            {
                nudCodeLength.Value = 10; // Prevents a length of above 10. ### May change this later to use a scrollbar.
                MessageBox.Show("A code length greater than 10 is not currently available.");
            }
            else
            {
                codeLength = Convert.ToInt32(nudCodeLength.Value);
                tbDebug.Text += $"[LEN:{codeLength}]";
                StartGame();
            }


        }

        private void cbDebug_CheckedChanged(object sender, EventArgs e)
        { // Settings: Opens and closes debug panel.
            if (cbDebug.Checked)
            {
                display = true;
                DisplayCode();
                panelDebug.Visible = true;
                this.Size = new Size(535, 743);
            }
            else
            {
                display = false;
                panelDebug.Visible = false;
                this.Size = new Size(535, 456);
            }
        }
        private void btnDebugClear_Click(object sender, EventArgs e)
        {
            tbDebug.Text = "";
        }

        private void pbSettings_Click(object sender, EventArgs e)
        { // Opens and closes settings panel.
            if (pbSettings.Tag.ToString() == "Hidden")
            {
                pbSettings.Tag = "Shown";
                panelSettings.Visible = true;

                this.Size = new Size(535, 456);
            }
            else
            {
                pbSettings.Tag = "Hidden";
                panelSettings.Visible = false;

                cbDebug.Checked = false;
                this.Size = new Size(344, 456);
            }

        }
        private void DebugModeOn()
        { // Call the function within the code for ease-of-access when debugging. (Not for end-user)
            display = true;
            infiniteAttempts = true;
            tbDebug.Text += "<DM>\r";
            cbDebug.Checked = true;

            pbSettings.Tag = "Shown";
            panelSettings.Visible = true;

            this.Size = new Size(535, 743);
        }

        private void nudAttempts_ValueChanged(object sender, EventArgs e)
        {
            lblAttemptsDisplay.Text = $"Attempt 1/{nudAttempts.Value}";
        }

        private void cbDuplicates_CheckedChanged(object sender, EventArgs e)
        { // Settings: Allow/Disallow duplicate colours within the combination code. 
            if (codeLength >= colours.Count && !cbDuplicates.Checked)
            {
                MessageBox.Show("Code length is longer than the available amount of colours. Duplicates must be allowed.");
                cbDuplicates.Checked = true;
            }

            else if (cbDuplicates.Checked)
            {
                allowDuplicates = true;
                StartGame();
            }

            else
            {
                allowDuplicates = false;
                StartGame();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        { // ### More design properties? Better help for my program specifically (settings, how to...etc)
            MessageBox.Show("Mastermind is a game that involves guessing a given colour combination within a set amount of attempts. Each guess yields a hint on the number of correct colours – those with the correct position (and color) and those only with the correct colour.");
        }

        private void lblTimer_Click(object sender, EventArgs e)
        { // ### Not properly implemented.
            if (!timer.Enabled)
            {
                timer.Enabled = true;
                timer.Start();
                timeLeft = 60;
                lblTimer.Text = "60s";
            }
            else
            {
                timer.Stop();
                timer.Enabled = false;
            }

        }
        private void timer_Tick(object sender, EventArgs e)
        { // ### Not properly implemented
            timeLeft--;
            lblTimer.Text = $"{timeLeft}s";

            if (timeLeft == 0)
            {
                timer.Stop();
                timer.Enabled = false;
                lblTimer.Text = "TIMER";
            }

        }



        // ### Delete or use later for background colour change.
        /*if (pbSettings.Tag == "")
        {
            pbSettings.Image = new Bitmap(Mastermind.Properties.Resources.settingswhite);
            pbSettings.Tag = "Hovered";
        }
        else
        {
            pbSettings.Image = new Bitmap(Mastermind.Properties.Resources.settings);
            pbSettings.Tag = "";
        }*/

    }
}

/*
 private void AlignControls()
        {
            tbDebug.Text += "<ALIGN";
            int offset;
            int pbSize = 25; // In-case the value ever changes. Float needed for .5?
            int pbGap = 6;

            int numberOfColours = colours.Count;
            int lengthOfCode = codeLength;

            Point picksStart = new Point(48, 5);
            Point guessStart = new Point(58, 60);

            if (numberOfColours > lengthOfCode)
            {
                tbDebug.Text += "-GT>\r";
                offset = (numberOfColours * pbSize) + ((numberOfColours - 1) * pbGap);
                offset -= (lengthOfCode * pbSize) + ((lengthOfCode - 1) * pbGap);
                offset /= 2;
                tbDebug.Text += $"[+{offset}]";

                foreach (PictureBox pbGuess in pbGuesses)
                {
                    pbGuess.Location = new Point(pbGuess.Location.X + offset, pbGuess.Location.Y);
                }

            }
            // Next one is temporary.
            else if (codeLength == 7)
            {
                tbDebug.Text += "-7>\r";
                foreach (PictureBox pbGuess in pbGuesses)
                {  
                    pbGuess.Location = new Point(pbGuess.Location.X - 31, pbGuess.Location.Y);
                }

            }
            else if (numberOfColours < lengthOfCode)
            {
                tbDebug.Text += "-LT>\r";

                foreach (PictureBox pbGuess in pbGuesses)
                {
                    pbGuess.Location = new Point(pbGuess.Location.X - 56, pbGuess.Location.Y);
                }

                //TBA - Need to store colour picks in list.
            }
            else
            {
                // Otherwise, do nothing as they are already aligned.
                tbDebug.Text += "#>\r";
            }

            
        }

        private void UpdateColours() // Updates colour palette of pick buttons.
        {
            tbDebug.Text += "<UPDATECOLOURS>\r";
            
            var picks = this.Controls.OfType<Button>();
            int count = 0;

            foreach (Button pick in picks)
            {
                pick.BackColor = Color.FromName(colours[count]);
                count++;
            }

        for (int count = 0; count < colours.Count; count++)
        {
            Controls.Find($"btnPick{count + 1}", true)[0].BackColor = Color.FromName(colours[count]);
        }

        ClearGuess();
                }
*/