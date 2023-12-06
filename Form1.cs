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
                Coach.attTact = rounding(stars);
            }
            if (attributeChanged == 0 || attributeChanged == 4 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Attacking Technical
            {
                int sum = Coach.attacking + Coach.technical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                Coach.attTech = rounding(stars);
            }

            if (attributeChanged == 1 || attributeChanged == 3 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Defending Tactical
            {
                int sum = Coach.defending + Coach.tactical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                Coach.defTact = rounding(stars);
            }
            if (attributeChanged == 1 || attributeChanged == 4 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Defending Technical
            {
                int sum = Coach.defending + Coach.technical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                Coach.defTech = rounding(stars);
            }

            if (attributeChanged == 2 || attributeChanged == 3 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Possesion Tactical
            {
                int sum = Coach.mental + Coach.tactical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                Coach.posTact = rounding(stars);
            }
            if (attributeChanged == 2 || attributeChanged == 4 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Possesion Technical
            {
                int sum = Coach.mental + Coach.technical + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                Coach.posTech = rounding(stars);
            }

            if (attributeChanged == 5 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Fitness
            {
                int sum = Coach.fitness + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 4;
                double stars = average / 2;
                Coach.fitnessRating = rounding(stars);
            }

            if (attributeChanged == 6 || attributeChanged == 7 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //Set Pieces
            {
                int sum = Coach.setPieces + Coach.tactKnow + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                Coach.setPiecesRating = rounding(stars);
            }

            if (attributeChanged == 8 || attributeChanged == 9 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //GK Handling
            {
                int sum = Coach.gkDistribution + Coach.gkHandling + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 5;
                double stars = average / 2;
                Coach.gkHandlingRating = rounding(stars);
            }
            if (attributeChanged == 10 || attributeChanged == 11 || attributeChanged == 12 || attributeChanged == 13) //GK Shot Stopping
            {
                int sum = Coach.gkShotStopping + Coach.determination + Coach.levelOfDisc + Coach.motivating;
                double average = sum / 4;
                double stars = average / 2;
                Coach.gkShotRating = rounding(stars);
            }



            //Change stars here ******
            labAttTac.Text = Coach.attTact.ToString();
            labAttTech.Text = Coach.attTech.ToString();
            labDefTac.Text = Coach.defTact.ToString();
            labDefTech.Text = Coach.defTech.ToString();
            labPosTac.Text = Coach.posTact.ToString();
            labPosTech.Text = Coach.posTech.ToString();
            labFit.Text = Coach.fitnessRating.ToString();
            labSet.Text = Coach.setPiecesRating.ToString();
            labGKHand.Text = Coach.gkHandlingRating.ToString();
            labGKShot.Text = Coach.gkShotRating.ToString();
            //*******
        }


        private int rounding(double value)
        {
            double remainder = value % 1;
            if (value < 1)
            {
                return 1;
            }
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





        private void tacPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.tactical, 0, 3);
        }

        private void tacMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.tactical, 1, 3);
        }

        private void tacText_TextChanged(object sender, EventArgs e)
        {
            string textString = tacText.Text;
            textChange(ref textString, ref Coach.tactical, 3);
        }




        private void techPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.technical, 0, 4);
        }

        private void techMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.technical, 1, 4);
        }

        private void techText_TextChanged(object sender, EventArgs e)
        {
            string textString = techText.Text;
            textChange(ref textString, ref Coach.technical, 4);
        }




        private void fitPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.fitness, 0, 5);
        }

        private void fitMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.fitness, 1, 5);
        }

        private void fitText_TextChanged(object sender, EventArgs e)
        {
            string textString = fitText.Text;
            textChange(ref textString, ref Coach.fitness, 5);
        }




        private void setPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.setPieces, 0, 6);
        }

        private void setMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.setPieces, 1, 6);
        }

        private void setText_TextChanged(object sender, EventArgs e)
        {
            string textString = setText.Text;
            textChange(ref textString, ref Coach.setPieces, 6);
        }




        private void knowPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.tactKnow, 0, 7);
        }

        private void knowMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.tactKnow, 1, 7);
        }

        private void knowText_TextChanged(object sender, EventArgs e)
        {
            string textString = knowText.Text;
            textChange(ref textString, ref Coach.tactKnow, 7);
        }




        private void disPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.gkDistribution, 0, 8);
        }

        private void disMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.gkDistribution, 1, 8);
        }

        private void disText_TextChanged(object sender, EventArgs e)
        {
            string textString = disText.Text;
            textChange(ref textString, ref Coach.gkDistribution, 8);
        }




        private void handPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.gkHandling, 0, 9);
        }

        private void handMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.gkHandling, 1, 9);
        }

        private void handText_TextChanged(object sender, EventArgs e)
        {
            string textString = handText.Text;
            textChange(ref textString, ref Coach.gkHandling, 9);
        }




        private void shotPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.gkShotStopping, 0, 10);
        }

        private void shotMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.gkShotStopping, 1, 10);
        }

        private void shotText_TextChanged(object sender, EventArgs e)
        {
            string textString = shotText.Text;
            textChange(ref textString, ref Coach.gkShotStopping, 10);
        }




        private void detPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.determination, 0, 11);
        }

        private void detMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.determination, 1, 11);
        }

        private void detText_TextChanged(object sender, EventArgs e)
        {
            string textString = detText.Text;
            textChange(ref textString, ref Coach.determination, 11);
        }




        private void levPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.levelOfDisc, 0, 12);
        }

        private void levMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.levelOfDisc, 1, 12);
        }

        private void levText_TextChanged(object sender, EventArgs e)
        {
            string textString = levText.Text;
            textChange(ref textString, ref Coach.levelOfDisc, 12);
        }




        private void motPlus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.motivating, 0, 13);
        }

        private void motMinus_Click(object sender, EventArgs e)
        {
            addOrMinus(ref Coach.motivating, 1, 13);
        }

        private void motText_TextChanged(object sender, EventArgs e)
        {
            string textString = motText.Text;
            textChange(ref textString, ref Coach.motivating, 13);
        }
    }
}