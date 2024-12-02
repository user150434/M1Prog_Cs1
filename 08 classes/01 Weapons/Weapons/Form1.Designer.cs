namespace SelectYourPower
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // Create a Button
            Button button = new Button();
            button.Text = "Click Me";
            button.Location = new System.Drawing.Point(100, 100); // Position of the button
            button.Click += Button_Click; // Event handler for button click

            // Create a Label
            Label label = new Label();
            label.Text = "Hello, World!";
            label.Location = new System.Drawing.Point(100, 150); // Position of the label

            // Add controls to the form
            this.Controls.Add(button);
            this.Controls.Add(label);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }

        #endregion
    }
}
