namespace FM24_Coach_Calculator
{


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







        public class Coach
        {
            void coachAttributes()
            {
                int attacking = 1;
                int defending = 1;
                int mental = 1;
                int tactical = 1;
                int technical = 1;
                int fitness = 1;
                int setPieces = 1;
                int tactKnow = 1;
                int gkDistribution = 1;
                int gkHandling = 1;
                int gkShotStopping = 1;
                int determination = 1;
                int levelOfDisc = 1;
                int motivating = 1;
            }

            public Coach()
            {
                this.coachAttributes();
            }

        }



        private void attPlus_Click(object sender, EventArgs e)
        {
            
        }

        private void attText_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}