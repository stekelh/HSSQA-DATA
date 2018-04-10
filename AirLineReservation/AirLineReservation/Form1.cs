using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

/* Lab 7
By: Stacy Clem
 * Plane Maifest 
 * This is suppose to take input on Seating Assignements for First and Bussiness class and then assign it to a manifest. Then write it to a file
  */
namespace AirLineReservation
{
    public partial class Form1 : Form
    {
        bool activeFlight = true;
        private string[] passNameAr = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        private string[] seatAr ={"1A", "1B", "2A", "2B", "4A", "4B", "4C", "4D", "5A", "5B", "5C", "5D", "6A", "6B", "6C", "6D", "7A",
                                    "7B", "7C", "7D"};
        private int numFirstClass = 0, numBussinessClass = 0;
        private string[] flightClassAr = { "First", "Bussiness" };
        int index = 0;
        private string flightClass, passName;
        public Form1()
        {
            
            InitializeComponent();
            
           
            flightClassBox.Items.AddRange(flightClassAr);

            seatNoBox.Items.Clear();
            if (flightClassBox.Text == "First")
                for (int j = 0; j < 4; j++)
                {

                    seatNoBox.Items.Add(seatAr[j]);
                }

            
            
            DisplayManifest();
            

        }


        private void addPass_Click(object sender, EventArgs e)
        {

            passName = textBox1.Text;
            flightClass = seatNoBox.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("You must enter a name.");
                return;
            }
            if (seatNoBox.Text == "")
            {
                MessageBox.Show("You Must Choose a Seat");
                return;
            }

                 for(int i = 0; i < seatAr.Length; i++)
            {
                if(seatNoBox.Text == seatAr[i])
                    index = i;
            }
           
            assignSeat(passName, flightClass, index);
            DisplayManifest();
            PopulateSeatCombo();
        }

        private void flightClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            seatNoBox.Items.Clear();
            if (flightClassBox.Text == "First")
                for (int j = 0; j < 4; j++)
                {
                    if (passNameAr[j] == "")
                        seatNoBox.Items.Add(seatAr[j]);
                }
            else if (flightClassBox.Text == "Bussiness")
                for (int i = 4; i < 20; i++)
                {
                    if (passNameAr[i] == "")
                        seatNoBox.Items.Add(seatAr[i]);

                }
            try
            {
                seatNoBox.SelectedIndex = 0;
            }
            catch
            {
                flightClassBox.SelectedIndex = 1;
                if (seatNoBox.SelectedIndex != 0)
                    closeFlight.Focus();
                else
                    seatNoBox.SelectedIndex = 0;
            }

         }

        private void closeFlight_Click(object sender, EventArgs e)
        {
            
            string[] sortAr = new string[20];

            if (activeFlight == true)
            {
                DisplayManifest();
                for (int i = 0; i < seatAr.Length; i++)
                {
                    if (!string.IsNullOrEmpty(passNameAr[i]))
                        sortAr[i] = passNameAr[i] + "\t\t\t\t\t" + seatAr[i];
                }
                Array.Sort(sortAr);
                StreamWriter sw = new StreamWriter(@"passlist.txt");

                for (int i = 0; i < sortAr.Length; i++)
                {
                    if (!string.IsNullOrEmpty(sortAr[i]))
                        sw.WriteLine(sortAr[i]);
                }
                sw.Close();
                DisplayManifest();
                DisplayPassList();
                closeFlight.Text = "Start New Flight";
                activeFlight = false;
                addPass.Enabled = false;
                closeFlight.Focus();
            }

            else
            {
               
                this.closeFlight.Text = "Close Flight";
                addPass.Enabled = true;
                for (int i = 0; i < passNameAr.Length; i++)
                    passNameAr[i] = "";
                DisplayManifest();
                PopulateSeatCombo();
                activeFlight = true;
                textBox1.Enabled = true;

            }
        }
       public void DisplayManifest()
        {
              listBox1.Items.Clear();
            
            this.listBox1.Items.AddRange(new object[] {
            "            P  L  A  N  E        M  A  N  I  F  E  S  T",
            "Seat                         Passenger Name"});
            for(int i=0; i < seatAr.Length; i++)
            {
                listBox1.Items.Add(seatAr[i] + "\t\t" + passNameAr[i]);
            }
        
            
        }

        public void assignSeat(string passName, string flightClass, int index)
        {

            passNameAr[index] = passName;
             if(flightClassBox.Text == "First")
              numFirstClass++;
                else
                 numBussinessClass++;

        }

        public void PopulateSeatCombo()
        {

            int count = 0;
            textBox1.Text = "";
            flightClassBox.Items.Clear();
            flightClassBox.Items.AddRange(flightClassAr);
            flightClassBox.SelectedIndex = 0;
            
            seatNoBox.Items.Clear();
            textBox1.Focus();

            if (flightClassBox.Text == "First")
                for (int j = 0; j < 4; j++)
                {
                    if (passNameAr[j] == "")
                        seatNoBox.Items.Add(seatAr[j]);
                }
            else if (flightClassBox.Text == "Bussiness")
                for (int i = 4; i < 20; i++)
                {
                    if (passNameAr[i] == "")
                        seatNoBox.Items.Add(seatAr[i]);

                }

            if (seatNoBox.SelectedIndex != 0)
                closeFlight.Focus();
            else
                seatNoBox.SelectedIndex = 0;

            for (int i = 0; i < seatAr.Length; i++)
            {
                if (passNameAr[i] != "")
                {
                    count++;

                }
                if (count == passNameAr.Length)
                {
                    closeFlight.Focus();
                    addPass.Enabled = false;
                    return;
                }
            }
           
        }

        public void DisplayPassList()
        {
            //Populate the number of Passangers and pull it from the file.

            this.listBox1.Items.Add("");
            this.listBox1.Items.Add("");
            this.listBox1.Items.Add("N   U   M   B   E   R      O   F      P   A   S   S   E   N   G   E   R   S");
            this.listBox1.Items.Add("First Class: " + numFirstClass + "\t\t\t\tBusiness Class: " + numBussinessClass);
            this.listBox1.Items.Add("");
            this.listBox1.Items.Add("");
            this.listBox1.Items.Add("\tP   A   S   S   E   N   G   E   R         L   I   S   T");
            this.listBox1.Items.Add("  Passenger Name\t\t\t\tSeat");
            

            StreamReader sr = File.OpenText(@"passList.txt");
            while (!sr.EndOfStream)
            {
                this.listBox1.Items.Add(sr.ReadLine());
            
            }
            sr.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            if (listBox1.SelectedIndex != '\0')
            {
                
                index = listBox1.SelectedIndex;
                
                try
                {
                    if (passNameAr[index - 2] != "")
                    {
                        if (flightClassBox.Enabled == false)
                            return;
                        result = MessageBox.Show("Do you want to remove the passenger from seat " + seatAr[index - 2] + "?", "Are you sure?", buttons);
                        if (result == DialogResult.Yes)
                        {
                            passNameAr[index - 2] = "";
                            if (index - 2 < 4)
                                numFirstClass--;
                            else
                                numBussinessClass--;
                            PopulateSeatCombo();
                            DisplayManifest();
                        }

                    }
                    else
                        return;
                }
                catch
              {
                    return;
                }
            }
        }
            }
           
        }
    
