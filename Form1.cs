using System;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private TextBox inputTextBox;
        private Button showButton;

        public Form1()
        {
            // Initialize the TextBox
            inputTextBox = new TextBox
            {
                Location = new System.Drawing.Point(20, 20),
                Width = 200
            };

            // Initialize the Button
            showButton = new Button
            {
                Text = "Show Text",
                Location = new System.Drawing.Point(230, 18)
            };

            EventHandler? ShowButton_Click = null;
            // Hook up the button click event
            showButton.Click += ShowButton_Click;

            // Add the controls to the form
            Controls.Add(inputTextBox);
            Controls.Add(showButton);

            // Set up the form properties
            Text = "Show Text in MessageBox";
            Size = new System.Drawing.Size(350, 120);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                // Display the text from the TextBox in a MessageBox
                MessageBox.Show(input, "Your Input", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optional: clear and refocus the input box
                inputTextBox.Clear();
                inputTextBox.Focus();
            }
            else
            {
                // Show a warning if the TextBox is empty
                MessageBox.Show("Please enter some text.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
