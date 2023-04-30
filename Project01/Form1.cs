namespace Project01
{
    public partial class CrazyDayForm : Form
    {

        public CrazyDayForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt01.Clear();
            txt02.Clear();
            txt03.Clear();
            txt04.Clear();
            txt05.Clear();
            txt06.Clear();
            txt07.Clear();
            txt08.Clear(); 
            txt09.Clear();
            txt10.Clear();
            txt11.Clear();
            txt12.Clear();
            rtxtDisplay.Clear();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string subject = txt01.Text + " " + txt02.Text;
            string w03 = txt03.Text;
            string w04 = txt04.Text;
            string w05 = txt05.Text;
            string w06 = txt06.Text; 
            string w07 = txt07.Text;
            string w08 = txt08.Text;
            string w09 = txt09.Text;
            string w10 = txt10.Text;
            string w11 = txt11.Text;
            string w12 = txt12.Text;

            string text = $"    A {subject} walked into a bar and ordered a {w03}. The bartender asked, " +
                $"\"What's the {w04} twist?\" The {subject} replied, \"Put a {w05} in it!\"" +
                $" \n\n    As the {subject} enjoyed their drink, they began to {w06} uncontrollably. They" +
                $" jumped on the bar and started {w07} to the beat of the music. The other patrons" +
                $" were {w08} and cheered them on. \n\n    After their impromptu performance, the" +
                $" {subject} left the bar and decided to {w09} to the moon. They hopped into" +
                $" a {w10} spaceship and took off. As they soared through space, they realized they" +
                $" had forgotten their {w11} on Earth. \n\n    The {subject} laughed and said, \"Oh" +
                $" well, I guess I'll just have to make a {w11} on the moon!\" \n\n    But {w12}! They can't" +
                " survive on the moon so they died!\n\n The End!";

            rtxtDisplay.Text = text;
        }
    }
}