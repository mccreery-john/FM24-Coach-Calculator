namespace FM24_Coach_Calculator
{
    static class Coach
    {
        public static int attacking = 1;
        public static int defending = 1;
        public static int mental = 1;
        public static int tactical = 1;
        public static int technical = 1;
        public static int fitness = 1;
        public static int setPieces = 1;
        public static int tactKnow = 1;
        public static int gkDistribution = 1;
        public static int gkHandling = 1;
        public static int gkShotStopping = 1;
        public static int determination = 1;
        public static int levelOfDisc = 1;
        public static int motivating = 1;
        
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Coach newCoach;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Coach newCoach;// = new Coach();
            
        }







        



        private void attPlus_Click(object sender, EventArgs e)
        {
            
        }

        private void attText_TextChanged(object sender, EventArgs e)
        {
            string newValue = attText.Text;
            int attack = Coach.attacking;
            try
            {
                attack = int.Parse(newValue);
            }
            catch (FormatException ex )
            {
                attText.Text = Coach.attacking.ToString();
                return;
            }

            if (attack > 20)
            {
                attack = 20;
            }else if (attack < 1)
            {
                attack = 1;
            }

            attText.Text = attack.ToString();
            Coach.attacking = attack;
        }
    }
}