using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeIo;
using System.Threading;

namespace SupervisionHomeIo
{

    public partial class Form1 : Form
    {
        bool X0 = true;
        bool X1 = false;
        bool StoreX0 = true;
        bool StoreX1 = false;
        bool StoreX2 = false;

        private bool garagX0 = true;
        private bool garagX1 = false;
        private bool garagX2 = false;
        private bool garagX3 = false;
        private bool garagX4 = false;
        private bool garagX5 = false;

        private bool portalX0 = true;
        private bool portalX1 = false;
        private bool portalX2 = false;
        private bool portalX3 = false;
        private bool portalX4 = false;
        private bool portalX5 = false;

        private bool iBouton1 = false;
        private bool iInfraRouge = false;
        private bool iOuvert = false;
        private bool iFerme = false;
        private bool iOuvertPortal = false;
        private bool iFermePortal = false;
        private bool iTimer = false;
        private bool iTimer3 = false;

        private bool iBouton1Prec = false;
        private bool iInfraRougePrec = false;
        private bool iOuvertPrec = false;
        private bool iFermePrec = false;
        private bool iOuvertPortalPrec = false;
        private bool iFermePortalPrec = false;
        private bool iTimerPrec = false;
        private bool iTimer3Prec = false;

        bool boutonTelecommande1Prec = false;
        bool boutonTelecommande1 = false;

        bool boutonPoussoirAPrec = false;
        bool boutonPoussoirA = false;

        private int compteur = 0;
        private int compteur3 = 0;

        bool monter = false;
        bool descendre = false;

        bool initialise = false;
        private int comp = 0;

        private DateTime dateTime = new DateTime();

        private Dictionary<string, Input> listInputBool = new Dictionary<string, Input>();
        private Dictionary<string, Output> listOutputBool = new Dictionary<string, Output>();
        private List<Label> listLabelInput = new List<Label>();
        private List<Label> listLabelOutput = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PIECE A INPUT
            this.listInputBool.Add("lblLightSwitch1A", new Input("Light Switch 1", 0, "bool", "lblLightSwitch1A"));
            this.listInputBool.Add("lblLightSwitch2A", new Input("Light Switch 2", 1, "bool", "lblLightSwitch2A"));
            this.listInputBool.Add("lblLightSwitch3A", new Input("Light Switch 3", 2, "bool", "lblLightSwitch3A"));
            this.listInputBool.Add("lblUpSwitch1A", new Input("Up/ Down Switch 1(Up)", 3, "bool", "lblUpSwitch1A"));
            this.listInputBool.Add("lblDownSwitch1A", new Input("Up/ Down Switch 1(Down)", 4, "bool", "lblDownSwitch1A"));
            this.listInputBool.Add("lblUpSwitch2A", new Input("Up/ Down Switch 2(Up)", 5, "bool", "lblUpSwitch2A"));
            this.listInputBool.Add("lblDownSwitch2A", new Input("Up / Down Switch 2(Down)", 6, "bool", "lblDownSwitch2A"));
            this.listInputBool.Add("lblLightDimmerUp1A", new Input("Light Switch Dimmer 1(Up)", 7, "bool", "lblLightDimmerUp1A"));
            this.listInputBool.Add("lblLightDimmerDown1A", new Input("Light Switch Dimmer 1(Down)", 8, "bool", "lblLightDimmerDown1A"));
            this.listInputBool.Add("lblLightDimmerUp2A", new Input("Light Switch Dimmer 2(Up)", 9, "bool", "lblLightDimmerUp2A"));
            this.listInputBool.Add("lblLightDimmerDown2A",new Input("Light Switch Dimmer 2(Down)", 10, "bool", "lblLightDimmerDown2A"));
            this.listInputBool.Add("lblLightDimmerUp3A", new Input("Light Switch Dimmer 3(Up)", 11, "bool", "lblLightDimmerUp3A"));
            this.listInputBool.Add("lblLightDimmerDown3A", new Input("Light Switch Dimmer 3(Down)", 12, "bool", "lblLightDimmerDown3A"));
            this.listInputBool.Add("lblDoorDectector1A", new Input("Door Detector 1", 13, "bool", "lblDoorDectector1A"));
            this.listInputBool.Add("lblDoorDectector2A", new Input("Door Detector 2", 14, "bool", "lblDoorDectector2A"));
            this.listInputBool.Add("lblMotionDetector1", new Input("Motion Detector", 15, "bool", "lblMotionDetector1"));
            this.listInputBool.Add("lblBrightnessSensorA", new Input("Brightness Sensor", 16, "bool", "lblBrightnessSensorA"));
            this.listInputBool.Add("lblSmokeDetectorA", new Input("Smoke Detector", 17, "bool", "lblSmokeDetectorA"));
            this.listInputBool.Add("lblTelcommande1", new Input("Telecommande bouton 1", 274, "bool", "lblTelcommande1"));
            this.listInputBool.Add("lblGarageOuvert", new Input("Porte Garage Ouverte", 100, "bool", "lblGarageOuvert"));
            this.listInputBool.Add("lblGarageFerme", new Input("Porte Garage fermée", 101, "bool", "lblGarageFerme"));
            this.listInputBool.Add("lblGarageInfrarouge", new Input("Garage infrarouge", 102, "bool", "lblGarageInfrarouge"));

            //PIECE A OUTPUT
            this.listOutputBool.Add("lbllightsA", new Output("Lights", 0, "bool", "lights"));
            this.listOutputBool.Add("rollerUp1A", new Output("Roller Shades 1(Up)", 1, "bool", "rollerUp1A"));
            this.listOutputBool.Add("rollerDown1A", new Output("Roller Shades 1(Down)", 2, "bool", "rollerDown1A"));
            this.listOutputBool.Add("rollerUp2A", new Output("Roller Shades 2(Up)", 3, "bool", "rollerUp2A"));
            this.listOutputBool.Add("rollerDown2A", new Output("Roller Shades 2(Down)", 4, "bool", "rollerDown2A"));
            this.listOutputBool.Add("rollerUp3A", new Output("Roller Shades 3(Up)", 5, "bool", "rollerUp3A"));
            this.listOutputBool.Add("rollerDown3A", new Output("Roller Shades 3(Down)", 6, "bool", "rollerDown3A"));
            this.listOutputBool.Add("rollerUp4A", new Output("Roller Shades 4(Up)", 7, "bool", "rollerUp4A"));
            this.listOutputBool.Add("rollerDown4A", new Output("Roller Shades 4(Down)", 8, "bool", "rollerDown4A"));
            this.listOutputBool.Add("heaterA", new Output("Heater", 9, "bool", "heaterA"));
            this.listOutputBool.Add("garageUp", new Output("Porte garage Up", 72, "bool", "garageUp"));
            this.listOutputBool.Add("garageDown", new Output("Porte Garage Down", 73, "bool", "garageDown"));            
        
            timer1.Start();
        }

        private void updateLabel()
        {
            foreach (Label lbl in this.listLabelInput)
            {
               lbl.Text = this.listInputBool[lbl.Name].getValeur().ToString();     
            }

            foreach (Label lbl in this.listLabelOutput)
            {
                lbl.Text = this.listOutputBool[lbl.Name].getValeur().ToString();
            }
        }

        private void updateData()
        {
            //mise à jour des capteurs de type Bool
            foreach (KeyValuePair<string, Input> capteur in this.listInputBool)
            {
                capteur.Value.update();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HomeIo.ReadIO.update();

            //lecture de l'heure
            this.dateTime = HomeIo.ReadIO.ReadDateTimeMemory();

            //mise à jour des informations capteurs
            this.updateData();

            //mise à jour de l'affichage
            this.updateLabel();
            this.roomHSupervision();
            this.roomLTemperatureSupervision();

            //execution des commandes
            this.manageStoreA();
            this.manageLightA();
            this.manageGarage();
            this.managePortal();
            this.manageStoreWithDateTimeA();
            this.motionSensorLightA();
        }

        public void manageGarage()
        {
            this.iBouton1Prec = this.iBouton1;
            this.iInfraRougePrec = this.iInfraRouge;
            this.iOuvertPrec = this.iOuvert;
            this.iFermePrec = this.iFerme;
            this.iTimerPrec = this.iTimer;

            iBouton1 = HomeIo.ReadIO.ReadBitInput(274);
            iInfraRouge = HomeIo.ReadIO.ReadBitInput(102);
            iOuvert = HomeIo.ReadIO.ReadBitInput(100);
            iFerme = HomeIo.ReadIO.ReadBitInput(101);

            bool ft0 = garagX0 && frontMontant(iBouton1, iBouton1Prec);
            bool ft1 = garagX1 && iOuvert;
            bool ft2 = garagX2 && true;
            bool ft3 = garagX3 && iTimer;
            bool ft4 = garagX4 && iFerme;
            bool ft5 = garagX4 && (!iFerme && (iBouton1 || iInfraRouge));
            bool ft6 = garagX5 && true;

            garagX0 = ft6 || garagX0 && !ft0;
            garagX1 = (ft0 || ft5) || garagX1 && !ft1;
            garagX2 = ft1 || garagX2 && !ft2;
            garagX3 = ft2 || garagX3 && !ft3;
            garagX4 = ft3 || garagX4 && !(ft4 || ft5);
            garagX5 = ft4 || garagX5 && !ft6;

            if (garagX1) //ouverture
            {
                HomeIo.WriteIO.BitOutput(72, true);
            }

            if (garagX4) //ouverture
            {
                HomeIo.WriteIO.BitOutput(73, true);
            }

            if (garagX5 || garagX2) //ouverture
            {
                HomeIo.WriteIO.BitOutput(73, false);
                HomeIo.WriteIO.BitOutput(72, false);
            }

            if (garagX3)
            {
                if (compteur == 0)
                {
                    timer2.Start();
                }
            }

            if (iTimer == true)
            {
                timer2.Stop();
                compteur = 0;
                iTimer = false;
            }
        }

        public void managePortal()
        {
            this.iOuvertPortalPrec = this.iOuvertPortal;
            this.iFermePortalPrec = this.iFermePortal;
            this.iTimer3Prec = this.iTimer3;
            
            iOuvertPortal = HomeIo.ReadIO.ReadBitInput(260);
            iFermePortal = HomeIo.ReadIO.ReadBitInput(261);

            bool ft0 = portalX0 && frontMontant(iBouton1, iBouton1Prec);
            bool ft1 = portalX1 && iOuvertPortal;
            bool ft2 = portalX2 && true;
            bool ft3 = portalX3 && iTimer3;
            bool ft4 = portalX4 && iFermePortal;
            bool ft5 = portalX4 && (!iFermePortal && iBouton1);
            bool ft6 = portalX5 && true;

            portalX0 = ft6 || portalX0 && !ft0;
            portalX1 = (ft0 || ft5) || portalX1 && !ft1;
            portalX2 = ft1 || portalX2 && !ft2;
            portalX3 = ft2 || portalX3 && !ft3;
            portalX4 = ft3 || portalX4 && !(ft4 || ft5);
            portalX5 = ft4 || portalX5 && !ft6;

            if (portalX1) //ouverture
            {
                HomeIo.WriteIO.BitOutput(193, true);
            }

            if (portalX4) //ouverture
            {
                HomeIo.WriteIO.BitOutput(194, true);
            }

            if (portalX5 || portalX2) //ouverture
            {
                HomeIo.WriteIO.BitOutput(194, false);
                HomeIo.WriteIO.BitOutput(193, false);
            }

            if (portalX3)
            {
                if (compteur3 == 0)
                {
                    timer3.Start();
                }
            }

            if (iTimer3 == true)
            {
                timer3.Stop();
                compteur3 = 0;
                iTimer3 = false;
            }
        }

        private bool frontMontant(Input input)
        {
            if ((bool) input.getValeurPrec() == false && (bool) input.getValeur() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool frontMontant(bool prec, bool courant)
        {
            if (prec == false && courant == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void manageLightA()
        {
            //sauvegarde des états précédents
            this.boutonPoussoirAPrec = this.boutonPoussoirA;
            //lecture des capteurs
            this.boutonPoussoirA = HomeIo.ReadIO.ReadBitInput(0);

            //calcul des transitions
            bool ft0 = this.X0 && this.frontMontant(this.boutonPoussoirAPrec, this.boutonPoussoirA);
            bool ft1 = this.X1 && this.frontMontant(this.boutonPoussoirAPrec, this.boutonPoussoirA);

            //calcul des étapes
            this.X0 = ft1 || (this.X0 && !ft0);
            this.X1 = ft0 || (this.X1 && !ft1);
            

            if (this.X0)
            {
                HomeIo.WriteIO.BitOutput(0, true);
            }
            if (this.X1)
            {
                HomeIo.WriteIO.BitOutput(0, false);
            }
        }

        private void manageStoreA()
        {
                    
            if ((frontMontant(this.listInputBool["lblUpSwitch1A"]) || monter) && HomeIo.ReadIO.ReadFloatInput(3) != 10)
            {
                if (descendre)
                {
                    this.listOutputBool["rollerDown1A"].off();
                    this.listOutputBool["rollerDown2A"].off();
                    this.listOutputBool["rollerDown3A"].off();
                    this.listOutputBool["rollerDown4A"].off();
                    descendre = false;
                }
                else{
                    this.listOutputBool["rollerUp1A"].on();
                    this.listOutputBool["rollerUp2A"].on();
                    this.listOutputBool["rollerUp3A"].on();
                    this.listOutputBool["rollerUp4A"].on();
                    monter = true;
                }
            }

            if (HomeIo.ReadIO.ReadFloatInput(3) == 10)
            {
                this.listOutputBool["rollerUp1A"].off();
                this.listOutputBool["rollerUp2A"].off();
                this.listOutputBool["rollerUp3A"].off();
                this.listOutputBool["rollerUp4A"].off();
                monter = false;
            }

            if ((frontMontant(this.listInputBool["lblDownSwitch1A"]) || descendre) && HomeIo.ReadIO.ReadFloatInput(3) != 0)
            {
                if (monter)
                {
                    this.listOutputBool["rollerUp1A"].off();
                    this.listOutputBool["rollerUp2A"].off();
                    this.listOutputBool["rollerUp3A"].off();
                    this.listOutputBool["rollerUp4A"].off();
                    monter = false;
                }
                else{
                    this.listOutputBool["rollerDown1A"].on();
                    this.listOutputBool["rollerDown2A"].on();
                    this.listOutputBool["rollerDown3A"].on();
                    this.listOutputBool["rollerDown4A"].on();
                    descendre = true;
                }
            }

             if(HomeIo.ReadIO.ReadFloatInput(3) == 0)
            {
                this.listOutputBool["rollerDown1A"].off();
                this.listOutputBool["rollerDown2A"].off();
                this.listOutputBool["rollerDown3A"].off();
                this.listOutputBool["rollerDown4A"].off();
                descendre = false;
            }
        }

        // Ouvre les volets automatiquement à 8h00 et les ferments à 19h00
        // !!! Ne fonctionne pas en mode accéléré
        public void manageStoreWithDateTimeA()
        {
            this.time.Text = "Heure : " + dateTime.Hour + ": " + dateTime.Minute + ": " + dateTime.Second;
            if (this.dateTime.Hour == 8 && this.dateTime.Minute == 0 && this.dateTime.Second == 0 && HomeIo.ReadIO.ReadFloatInput(3) != 10)
            {
                this.listOutputBool["rollerUp1A"].on();
                this.listOutputBool["rollerUp2A"].on();
                this.listOutputBool["rollerUp3A"].on();
                this.listOutputBool["rollerUp4A"].on();
            }
            if(this.dateTime.Hour == 19 && this.dateTime.Minute == 0 && this.dateTime.Second == 0 && HomeIo.ReadIO.ReadFloatInput(3) != 0)
            {
                this.listOutputBool["rollerDown1A"].on();
                this.listOutputBool["rollerDown2A"].on();
                this.listOutputBool["rollerDown3A"].on();
                this.listOutputBool["rollerDown4A"].on();
            }
        }

        //Allumes les lumières de la pièce A lorsque la luminosité est faible et que le capteur de mouvement s'active. Eteint les lumières sinon.
        // !!! les volets doivent être ouverts le matin
        public void motionSensorLightA()
        {
            bool motionDetector = HomeIo.ReadIO.ReadBitInput(15);
            bool brightnessSensor = HomeIo.ReadIO.ReadBitInput(16);
            //this.time.Text = "lumière ? " + brightnessSensor;
            if (brightnessSensor)
            {
                if (motionDetector && HomeIo.ReadIO.ReadBitOutput(0) == false)
                {
                    this.listOutputBool["lbllightsA"].inverse();
                }
            }
            else
            {
                if (motionDetector == false && HomeIo.ReadIO.ReadBitOutput(0))
                {
                    this.listOutputBool["lbllightsA"].inverse();
                }
            }
        }

        public void roomHSupervision()
        {
            this.labelChbrH1Value.Text = "" + HomeIo.ReadIO.ReadBitInput(139);
            this.labelChbrH2Value.Text = "" + HomeIo.ReadIO.ReadBitInput(138);
            this.labelChbrH3Value.Text = "" + HomeIo.ReadIO.ReadBitInput(140);
            this.labelChbrH4Value.Text = "" + HomeIo.ReadIO.ReadBitInput(130);
            this.labelChbrH5Value.Text = "" + HomeIo.ReadIO.ReadBitInput(131);
            this.labelChbrH6Value.Text = "" + HomeIo.ReadIO.ReadBitInput(136);
            this.labelChbrH7Value.Text = "" + HomeIo.ReadIO.ReadBitInput(137);
        }

        public void roomLTemperatureSupervision()
        {
            if (this.initialise == false)
            {
                this.chartTest.Series.Add("test");
                this.chartTest.Series["test"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                this.initialise = true;
            }

            if(this.comp < 20)
            {
                this.comp++;
            }

            if (this.comp >= 20)
            {
                if (this.dateTime.Minute == 0 && this.dateTime.Second == 0)
                {
                    this.labelTemperature.Text = "Température : " + (HomeIo.ReadIO.ReadFloatMemory(132) - 273.15).ToString();
                    double temp = HomeIo.ReadIO.ReadFloatMemory(132) - 273.15;
                    this.chartTest.Series["test"].Points.AddXY(this.dateTime.Hour, temp);
                    //this.chartTest.Series["test"].Points.AddXY(9, HomeIo.ReadIO.ReadFloatMemory(132) - 273.15);

                    //System.Diagnostics.Debug.WriteLine("lecture " + HomeIo.ReadIO.ReadFloatMemory(132));

                    //System.Diagnostics.Debug.WriteLine("cel" + temp);
                    this.listView1.Items.Add(temp.ToString());
                }
            }

        }

        /*
         Dans le timer récuperer les datas des inputs. (MAJ).
         Ecrire une méthode avec l'écriture des actions. (équation logiques)
         Mettre à jour la MemoryMap en écrivant le nouvel état des sorties.
             */
        private void button1_Click(object sender, EventArgs e)
        {
            HomeIo.WriteIO.BitOutput(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //while (HomeIo.ReadIO.ReadFloatInput(3) != 1) {
                HomeIo.WriteIO.BitOutput(1);
                //HomeIo.WriteIO.BitOutput(3);
            //}
        }

        private void btnCloseStoresA_Click(object sender, EventArgs e)
        {
            HomeIo.WriteIO.BitOutput(2);
            //HomeIo.WriteIO.BitOutput(4, true);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HomeIo.WriteIO.BitOutput(193);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeIo.WriteIO.BitOutput(194);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("compteur 5 secondes");

            if (compteur >= 5)
            {
                System.Diagnostics.Debug.Write("compteur "+ compteur.ToString());
                iTimer = true;
                timer2.Stop();
            }
            else
            {
                compteur = compteur + 1;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelChbrH6_Click(object sender, EventArgs e)
        {

        }

        private void lblLightSwitch1A_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void labelChbrH7Value_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("compteur 5 secondes");

            if (compteur3 >= 1)
            {
                System.Diagnostics.Debug.Write("compteur " + compteur3.ToString());
                iTimer3 = true;
                timer3.Stop();
            }
            else
            {
                compteur3 = compteur3 + 1;
            }
        }
    }
}
