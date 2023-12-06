namespace FM24_Coach_Calculator
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Purposefully blank
        }

        static class Coach
        {
            //Attributes
            public static int attacking = 1;        //0
            public static int defending = 1;        //1
            public static int mental = 1;           //2
            public static int tactical = 1;         //3
            public static int technical = 1;        //4
            public static int fitness = 1;          //5
            public static int setPieces = 1;        //6
            public static int tactKnow = 1;         //7
            public static int gkDistribution = 1;   //8
            public static int gkHandling = 1;       //9
            public static int gkShotStopping = 1;   //10
            public static int determination = 1;    //11
            public static int levelOfDisc = 1;      //12
            public static int motivating = 1;       //13

            //Ratings
            public static int attTact = 1;
            public static int attTech = 1;
            public static int defTact = 1;
            public static int defTech = 1;
            public static int posTact = 1;
            public static int posTech = 1;
            public static int fitnessRating = 1;
            public static int setPiecesRating = 1;
            public static int gkHandlingRating = 1;
            public static int gkShotRating = 1;


        }



        private void changeRatings(int attributeChanged)
        {
            if (attributeChanged == 0 || attributeChanged == 3 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Attacking Tactical
            {
                int sum = Coach.attacking + Coach.tactical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.attTact = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }
            if (attributeChanged == 0 || attributeChanged == 4 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Attacking Technical
            {
                int sum = Coach.attacking + Coach.technical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.attTech = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }

            if (attributeChanged == 1 || attributeChanged == 3 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Defending Tactical
            {
                int sum = Coach.defending + Coach.tactical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.defTact = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }
            if (attributeChanged == 1 || attributeChanged == 4 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Attacking Technical
            {
                int sum = Coach.defending + Coach.technical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.defTech = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }

            if (attributeChanged == 2 || attributeChanged == 3 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Possesion Tactical
            {
                int sum = Coach.mental + Coach.tactical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.posTact = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }
            if (attributeChanged == 2 || attributeChanged == 4 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Possesion Technical
            {
                int sum = Coach.mental + Coach.technical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.posTech = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }

            if (attributeChanged == 5 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Fitness
            {
                int sum = Coach.mental + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 4;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.fitnessRating = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }

            if (attributeChanged == 6 || attributeChanged == 7 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Set Pieces
            {
                int sum = Coach.setPieces + Coach.tactKnow + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.setPiecesRating = intStars + 1;       //Everything starts with 1 star (out of ten)
            }

            if (attributeChanged == 8 || attributeChanged == 9 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //GK Handling
            {
                int sum = Coach.gkDistribution + Coach.gkHandling + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.gkHandlingRating = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }
            if (attributeChanged == 10 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //GK Shot Stopping
            {
                int sum = Coach.gkShotRating + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                int intStars = rounding(stars);
                Coach.gkShotRating = intStars + 1;       //Everything has a minimum of 1 star (out of ten)
            }



            //Change star images here ******

            //*******
        }


        private int rounding(double value)
        {
            double remainder = value % 1;
            if (remainder == 0)
            {
                return Convert.ToInt32(value);
            }
            else //Always round down
            {
                double roundDown = value - remainder;
                return Convert.ToInt32(roundDown);
            }
        }

        private void changeText(int attributeID)
        {
            switch (attributeID)
            {
                case 0:
                    attText.Text = Coach.attacking.ToString();
                    break;
                case 1:
                    defText.Text = Coach.defending.ToString();
                    break;
                case 2:
                    menText.Text = Coach.mental.ToString();
                    break;
                case 3:
                    tacText.Text = Coach.tactical.ToString();
                    break;
                case 4:
                    techText.Text = Coach.technical.ToString();
                    break;
                case 5:
                    fitText.Text = Coach.fitness.ToString();
                    break;
                case 6:
                    setText.Text = Coach.setPieces.ToString();
                    break;
                case 7:
                    knowText.Text = Coach.tactKnow.ToString();
                    break;
                case 8:
                    disText.Text = Coach.gkDistribution.ToString();
                    break;
                case 9:
                    handText.Text = Coach.gkHandling.ToString();
                    break;
                case 10:
                    shotText.Text = Coach.gkShotStopping.ToString();
                    break;
                case 11:
                    detText.Text = Coach.determination.ToString();
                    break;
                case 12:
                    levText.Text = Coach.levelOfDisc.ToString();
                    break;
                case 13:
                    motText.Text = Coach.motivating.ToString();
                    break;

            }
        }


        private void textChange(ref string newValue, ref int oldValue, int attributeID)
        {
            int newValueInt;
            try
            {
                newValueInt = int.Parse(newValue);
            }
            catch (FormatException ex)
            {
                changeText(attributeID);
                return;
            }

            if (newValueInt > 20)
            {
                newValueInt = 20;
            }
            else if (newValueInt < 1)
            {
                newValueInt = 1;
            }


            oldValue = newValueInt;
            changeText(attributeID);
            changeRatings(attributeID);
            return;
        }



        private void addOrMinus(ref int oldValue, int addBit, int attributeID)
        {
            int newValueInt;
            if (addBit == 0)
            {
                newValueInt = oldValue + 1;
            }
            else
            {
                newValueInt = oldValue - 1;
            }

            if ((newValueInt > 20) || newValueInt < 1)
            {
                return;
            }
            oldValue = newValueInt;
            changeText(attributeID);
            changeRatings(attributeID);
            return;
        }




        private void attPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.attacking, 0, 0);
        }

        private void attMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.attacking, 1, 0);
        }

        private void attText_TextChanged(object sender, EventArgs e)
        {
            string textString = attText.Text;
            textChange(ref textString, ref Coach.attacking, 0);
        }




        private void defPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.defending, 0, 1);
        }

        private void defMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.defending, 1, 1);
        }

        private void defText_TextChanged(object sender, EventArgs e)
        {
            string textString = defText.Text;
            textChange(ref textString, ref Coach.defending, 1);
        }






        private void menPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.mental, 0, 2);
        }

        private void menMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.mental, 1, 2);
        }

        private void menText_TextChanged(object sender, EventArgs e)
        {
            string textString = menText.Text;
            textChange(ref textString, ref Coach.mental, 2);
        }











    }
}