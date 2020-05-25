using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EmailAddressValidator
{
    public partial class MainWindow : Form
    {
        Dictionary<string, State> StateTable;
        State CurrentState;

        public MainWindow()
        {
            InitializeComponent();
            InitializeTransitionsTable();
            this.CurrentState = StateTable["q0"];
        }

        public void InitializeTransitionsTable()
        {
            this.StateTable = new Dictionary<string, State>();

            foreach (string state in File.ReadLines("../../../resources/finite-automata.txt"))
                StateTable[state.Split('|')[0]] = new State(state.Split('|')[1]);
        }

        private void Button_Check_Click(object sender, EventArgs e)
        {
            bool acceptedEmail = ValidateEmail(TextBox_Email.Text.ToLower());

            if (acceptedEmail)
            {
                PictureBox_Result.Image = Image.FromFile("../../../resources/true.png");
                Label_Result.ForeColor = Color.Green;
            }
            else
            {
                PictureBox_Result.Image = Image.FromFile("../../../resources/false.png");
                Label_Result.ForeColor = Color.Firebrick;
            }

            Label_Result.Text = TextBox_Email.Text;
            TextBox_Email.Text = "";
            CurrentState = StateTable["q0"];
            Label_Result.Visible = true;
            PictureBox_Result.Visible = true;
            this.Refresh();
        }

        private bool ValidateEmail(string input)
        {
            bool reachFinalState = false;

            foreach (char c in input.ToArray())
            {
                string nextState = CurrentState.GetState(c);

                if (nextState == null)
                    return false;

                CurrentState = StateTable[nextState];

                if (nextState == "q5" || nextState == "q6")
                    reachFinalState = true;
            }

            return reachFinalState;
        }
    }
}
