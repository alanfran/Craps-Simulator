// Antonio Lanfranchi

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Project3
{
    public partial class aCraps : Form
    {
        public aCraps()
        {
            InitializeComponent();
            winlose.Series["Series1"].Enabled = false;
            rollHistogram.Series["Series1"].Enabled = false;
            this.AcceptButton = goButton;
            winlose.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            rollHistogram.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int n;
            int seed;
            List<string> outputList = new List<string> { };
            int nwin = 0;
            int nlose = 0;

            // Make sure the user has entered a seed number.
            if (seedBox.Text == "")
            {
                MessageBox.Show("Please enter a seed for the random number generator.");
                // go back and wait for the user to enter a seed and click Go!
                return;
            }


            // read seed to instantiate our dice
            try
            {
                seed = int.Parse(seedBox.Text);

                // clear charts
                winlose.Series.Clear();
                rollHistogram.Series.Clear();

                aDie myDie = new aDie(seed);

                // read # of rolls
                // TODO: error checking
                n = int.Parse(nRollsBox.Text);

                // make an array to hold n games
                int[] games = new int[n];


                // simulate n games
                // store results in an array
                for (int i = 0; i < n; i++)
                {
                    // add the first 5 game strings up in output
                    games[i] = myDie.simulateGame(i, ref outputList, ref nwin, ref nlose);
                }

                // Add final stats to the output string.
                outputList.Add("OVERALL STATISTICS:");
                outputList.Add("Total games played: " + n.ToString());
                outputList.Add("Total games won: " + nwin.ToString());
                outputList.Add("Total games lost: " + nlose.ToString());

                outputList.Add("");
                outputList.Add("CONCLUSION:\n");

                // convert to floating point arithmetic to accomodate the % win calculation
                float fwin = nwin;
                float fn = n;
                float winPct = fwin * 100 / n;

                outputList.Add("Odds of winning: " + winPct.ToString() + "%");
                outputList.Add("Conclusion: ");
                if (winPct > 50.00)
                {
                    outputList[outputList.Count() - 1] += "Play this game.";
                }
                else
                {
                    outputList[outputList.Count() - 1] += "Do not play this game.";
                }


                // chart total games won and lost
                string[] seriesNames = { "Wins", "Losses" };
                int[] points = { nwin, nlose };

                // max # of wins/losses
                int maxWL = 0;

                for (int i = 0; i < 2; i++)
                {
                    // adds the series {win, lose} to the chart
                    Series tempSeries = winlose.Series.Add(seriesNames[i]);
                    // adds the points associated with that series
                    tempSeries.Points.Add(points[i]);

                    if (points[i] > maxWL)
                    {
                        maxWL = points[i];
                    }
                }

                // update Y axis scale
                winlose.ChartAreas[0].AxisY.Maximum = maxWL + (maxWL * .15);

                // chart histogram of dice rolls (2 ... 12)
                string[] histogramLabels = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
                int[] hPoints = { myDie.rollCount[2], myDie.rollCount[3], myDie.rollCount[4], myDie.rollCount[5], myDie.rollCount[6], myDie.rollCount[7], myDie.rollCount[8], myDie.rollCount[9], myDie.rollCount[10], myDie.rollCount[11], myDie.rollCount[12] };

                // max # of rolls used to scale Y axis
                int maxNrolls = 0;

                for (int i = 0; i < 11; i++)
                {
                    Series thSeries = rollHistogram.Series.Add(histogramLabels[i]);

                    thSeries.Points.Add(hPoints[i]);

                    if (hPoints[i] > maxNrolls)
                    {
                        maxNrolls = hPoints[i];
                    }
                }

                // update Y axis scale
                rollHistogram.ChartAreas[0].AxisY.Maximum = maxNrolls + (maxNrolls * .15);

                // TXTBOX: first 5 games + final stats
                string[] results = outputList.ToArray();
                resultBox.Lines = results;
            }
            catch
            {
                MessageBox.Show("Invalid seed. Please enter a number.");
            }
        }

        private void seedBox_Enter(object sender, EventArgs e)
        {
            seedBox.Text = "";
        }

        private void nRollsBox_Enter(object sender, EventArgs e)
        {
            nRollsBox.Text = "";
        }
    }
}
