using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantProject_mkII
{

    /*

    Written by: Andrew Castro and Yashraj Nagpal
    Written for: Mr. Kolch
    Subject: TER4M1 - 01
    Date: January 20 2020
    Description: This code gets a value from the form and sends it to the arduino. This
    value includes how many times per day the plants should be watered, the number of hours of 
    light needed for the plants, whether the plants need direct or indeirect sunlight, and the
    temperature that the plants should be kept at
 
   */

    public partial class frmPlantProject : Form
    {
        
        //the following string objects are declared and initialized
        String submit = ""; //string object for the submit value 
        String waterPerDay = ""; //string object for the number of times the plants should be watered per day
        String sunlightHours = ""; //string object for the number of hours of light the plants need
        String typeofSunlight = ""; //string object for either direct or indirect sunlight
        String typeofSunlightInterface = ""; //string object for the type of sunlight being output onto the form 
        String temperature = ""; //string for the temperature the plants should be kept at
        String plantType = ""; //string for the type of plant 


        public frmPlantProject()
        {
            InitializeComponent();
            
            //the following code prevents the user from typing into the combo box field
            this.cmboDaylightHours.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmboPlantList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmPlantProject_Load(object sender, EventArgs e)
        {

        }

        private void chkOncePerDay_CheckedChanged(object sender, EventArgs e)
        {
            
            //if the once per day box is checked, a 01 value is given and any other checks are deleated
            waterPerDay = "01";
            chkTwicePerDay.Checked = false;
            chkThricePerDay.Checked = false;
            

        }

        private void chkTwicePerDay_CheckedChanged(object sender, EventArgs e)
        {

            //if the once per day box is checked, a 02 value is given and any other checks are deleated
            waterPerDay = "02";
            chkOncePerDay.Checked = false;
            chkThricePerDay.Checked = false;

        }

        private void chkThricePerDay_CheckedChanged(object sender, EventArgs e)
        {

            //if the once per day box is checked, a 03 value is given and any other checks are deleated
            waterPerDay = "03";
            chkOncePerDay.Checked = false;
            chkTwicePerDay.Checked = false;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*
            if the submit button is clicked, the different values representing the different
            settings are added togther as strings
            */        
            submit = waterPerDay + sunlightHours + typeofSunlight + temperature;

            //the serial port is opened, the master string value is submitted, and the serial port is closed
            serialPort2.Open();
            serialPort2.Write(submit);
            serialPort2.Close();
            

        }

        private void cmboDaylightHours_SelectedIndexChanged(object sender, EventArgs e)
        {

            //the hours of light needed for the plants is input by the combo box
            sunlightHours = cmboDaylightHours.Text;

        }

        private void rdoDirect_CheckedChanged(object sender, EventArgs e)
        {

            //if the direct radio button is clicked, then direct light is given a string value of 10
            typeofSunlight = "10";

        }

        private void rdoIndirect_CheckedChanged(object sender, EventArgs e)
        {

            //if the direct radio button is clicked, then direct light is given a string value of 20
            typeofSunlight = "20";

        }

        private void txtTemperature_TextChanged(object sender, EventArgs e)
        {

            //the temperature that the plants need to be kept at is input into the text field
            temperature = txtTemperature.Text;

        }

        private void cmboPlantList_SelectedIndexChanged(object sender, EventArgs e)
        {

            //the plant type chosen is included in the combo box
            plantType = cmboPlantList.Text;

            //if African Violet is chosen
            if (plantType.Equals("African Violet"))
            {
                
                //the settings unique to African Violet
                waterPerDay = "01";
                sunlightHours = "12";
                typeofSunlight = "10";
                temperature = "16";

                picbxAfricanViolet.Visible = true;
                picbxGeneralFern.Visible = false;
                picbxBostonFern.Visible = false;
                picbxBirdsNestFern.Visible = false;
                picbxCanaryDatePalm.Visible = false;
                picbxAloeVera.Visible = false;
                picbxCoralCactus.Visible = false;
                picbxBirdOfParadise.Visible = false;
                picbxIvy.Visible = false;

            }

            //if General Fern is chosen
            if (plantType.Equals("General Fern"))
            {

                //the settings unique to General Fern
                waterPerDay = "02";
                sunlightHours = "04";
                typeofSunlight = "10";
                temperature = "20";

                picbxAfricanViolet.Visible = false;
                picbxGeneralFern.Visible = true;
                picbxBostonFern.Visible = false;
                picbxBirdsNestFern.Visible = false;
                picbxCanaryDatePalm.Visible = false;
                picbxAloeVera.Visible = false;
                picbxCoralCactus.Visible = false;
                picbxBirdOfParadise.Visible = false;
                picbxIvy.Visible = false;

            }

            //if Boston Fern is chosen
            if (plantType.Equals("Boston Fern"))
            {

                //the settings unique to Boston Fern
                waterPerDay = "03";
                sunlightHours = "08";
                typeofSunlight = "10";
                temperature = "20";

                picbxAfricanViolet.Visible = false;
                picbxGeneralFern.Visible = false;
                picbxBostonFern.Visible = true;
                picbxBirdsNestFern.Visible = false;
                picbxCanaryDatePalm.Visible = false;
                picbxAloeVera.Visible = false;
                picbxCoralCactus.Visible = false;
                picbxBirdOfParadise.Visible = false;
                picbxIvy.Visible = false;

            }

            //if Birds Nest Fern is chosen
            if (plantType.Equals("Birds Nest Fern"))
            {

                //the settings unique to Birds Nest Fern
                waterPerDay = "03";
                sunlightHours = "08";
                typeofSunlight = "10";
                temperature = "22";

                picbxAfricanViolet.Visible = false;
                picbxGeneralFern.Visible = false;
                picbxBostonFern.Visible = false;
                picbxBirdsNestFern.Visible = true;
                picbxCanaryDatePalm.Visible = false;
                picbxAloeVera.Visible = false;
                picbxCoralCactus.Visible = false;
                picbxBirdOfParadise.Visible = false;
                picbxIvy.Visible = false;

            }

            //if Ivy is chosen
            if (plantType.Equals("Ivy"))
            {

                //the settings unique to Ivy
                waterPerDay = "02";
                sunlightHours = "09";
                typeofSunlight = "10";
                temperature = "17";

                picbxAfricanViolet.Visible = false;
                picbxGeneralFern.Visible = false;
                picbxBostonFern.Visible = false;
                picbxBirdsNestFern.Visible = false;
                picbxCanaryDatePalm.Visible = false;
                picbxAloeVera.Visible = false;
                picbxCoralCactus.Visible = false;
                picbxBirdOfParadise.Visible = false;
                picbxIvy.Visible = true;

            }

            //if Canary Date Palm is chosen
            if (plantType.Equals("Canary Date Palm"))
            {

                //the settings unique to Canary Date Palm
                waterPerDay = "01";
                sunlightHours = "15";
                typeofSunlight = "10";
                temperature = "17";

                picbxAfricanViolet.Visible = false;
                picbxGeneralFern.Visible = false;
                picbxBostonFern.Visible = false;
                picbxBirdsNestFern.Visible = false;
                picbxCanaryDatePalm.Visible = true;
                picbxAloeVera.Visible = false;
                picbxCoralCactus.Visible = false;
                picbxBirdOfParadise.Visible = false;
                picbxIvy.Visible = false;

            }

            //if Aloe Vera is chosen
            if (plantType.Equals("Aloe Vera"))
            {

                //the settings unique to Aloe Vera
                waterPerDay = "03";
                sunlightHours = "15";
                typeofSunlight = "10";
                temperature = "26";

                picbxAfricanViolet.Visible = false;
                picbxGeneralFern.Visible = false;
                picbxBostonFern.Visible = false;
                picbxBirdsNestFern.Visible = false;
                picbxCanaryDatePalm.Visible = false;
                picbxAloeVera.Visible = true;
                picbxCoralCactus.Visible = false;
                picbxBirdOfParadise.Visible = false;
                picbxIvy.Visible = false;

            }

            //if Coral Cactus is chosen
            if (plantType.Equals("Coral Cactus"))
            {

                //the settings unique to Coral Cactus
                waterPerDay = "01";
                sunlightHours = "18";
                typeofSunlight = "10";
                temperature = "15";

                picbxAfricanViolet.Visible = false;
                picbxGeneralFern.Visible = false;
                picbxBostonFern.Visible = false;
                picbxBirdsNestFern.Visible = false;
                picbxCanaryDatePalm.Visible = false;
                picbxAloeVera.Visible = false;
                picbxCoralCactus.Visible = true;
                picbxBirdOfParadise.Visible = false;
                picbxIvy.Visible = false;

            }

            //if Bird of Paradise is chosen
            if (plantType.Equals("Bird of Paradise"))
            {

                //the settings unique to Bird of Paradise
                waterPerDay = "02";
                sunlightHours = "20";
                typeofSunlight = "10";
                temperature = "23";

                picbxAfricanViolet.Visible = false;
                picbxGeneralFern.Visible = false;
                picbxBostonFern.Visible = false;
                picbxBirdsNestFern.Visible = false;
                picbxCanaryDatePalm.Visible = false;
                picbxAloeVera.Visible = false;
                picbxCoralCactus.Visible = false;
                picbxBirdOfParadise.Visible = true;
                picbxIvy.Visible = false;

            }


            //the following two if statements output 'direct' or 'indirect' depending on the settings for the plant chosen
            if (typeofSunlight.Equals("10"))
            {

                typeofSunlightInterface = "Direct";

            }

            if (typeofSunlight.Equals("20"))
            {

                typeofSunlightInterface = "Indirect";

            }

            //the following labels output the settings of the plant chosen
            lblWaterInfo.Text = waterPerDay + " times per day";
            lblHoursOfSunlightInfo.Text = sunlightHours + " hours per day";
            lblDirectOrIndirectInfo.Text = typeofSunlightInterface + " sunlight";
            lblTemperatureInfo.Text = temperature + " degrees Celcius";

            //the following labels are made visible when the plant is chosen
            lblWaterInfo.Visible = true;
            lblHoursOfSunlightInfo.Visible = true;
            lblDirectOrIndirectInfo.Visible = true;
            lblTemperatureInfo.Visible = true;

        }
    }
}
