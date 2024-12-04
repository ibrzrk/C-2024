// Author      : Noah Lancaster and Bryant Alarcon
// Date        : 2024.12.02
// Email       : mrkiblingz@gmail.com
// Assignment  : FINAL PROJECT: We have created a simple data base that allows users to see the state data for Presidential elections from 2020-1992
// Des         : Change to Exact Cents
// Pledge      : As a Falcon @ Solano College, I will conduct myself with honor and integrity at all 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace ELECTION_DATA_CIS_PROJECT
{
    public partial class form1 : Form
    {

        public form1()
        {
            InitializeComponent();
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            string year = txt1.Text;
            if (year == "2020")
            {
                //our code can only run with correct directory we are using flash drive
                //we will include video of our code running
                DataTable dt = new DataTable();
                Directory.SetCurrentDirectory(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2020");
                string fpath = Directory.GetCurrentDirectory();
                string[] csv_file = Directory.GetFiles(fpath, "*.data");

                //stream reader
                StreamReader sr = new StreamReader(csv_file[0].ToString());
                //categorizes data so it can be read as follows
                dt.Columns.Add("State");
                dt.Columns.Add("Total Votes");
                dt.Columns.Add("BIDEN Votes");
                dt.Columns.Add("BIDEN %");
                dt.Columns.Add("BIDEN EV");
                dt.Columns.Add("TRUMP Votes");
                dt.Columns.Add("TRUMP %");
                dt.Columns.Add("TRUMP EV");
                dt.Columns.Add("OTHER Votes");
                dt.Columns.Add("OTHER %");
                dt.Columns.Add("OTHER EV");
                string[] data = new string[File.ReadAllLines(csv_file[0]).Length];
                data = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10]); //creates data tables
                }
                dgv.DataSource = dt;
            }
            else if (year == "2016")
            {
                DataTable dt = new DataTable();
                Directory.SetCurrentDirectory(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2016");
                string fpath = Directory.GetCurrentDirectory();
                string[] csv_file = Directory.GetFiles(fpath, "*.data");

                //stream reader
                StreamReader sr = new StreamReader(csv_file[0].ToString());
                dt.Columns.Add("State");
                dt.Columns.Add("Total Votes");
                dt.Columns.Add("CLINTON Votes");
                dt.Columns.Add("CLINTON %");
                dt.Columns.Add("CLINTON EV");
                dt.Columns.Add("TRUMP Votes");
                dt.Columns.Add("TRUMP %");
                dt.Columns.Add("TRUMP EV");
                dt.Columns.Add("JOHNSON Votes");
                dt.Columns.Add("JOHNSON %");
                dt.Columns.Add("JOHNSON EV");
                string[] data = new string[File.ReadAllLines(csv_file[0]).Length];
                data = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10]);
                }
                dgv.DataSource = dt;
            }
            else if (year == "2012")
            {
                DataTable dt = new DataTable();
                Directory.SetCurrentDirectory(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2012");
                string fpath = Directory.GetCurrentDirectory();
                string[] csv_file = Directory.GetFiles(fpath, "*.data");

                //stream reader
                StreamReader sr = new StreamReader(csv_file[0].ToString());
                dt.Columns.Add("State");
                dt.Columns.Add("Total Votes");
                dt.Columns.Add("OBAMA Votes");
                dt.Columns.Add("OBAMA %");
                dt.Columns.Add("OBAMA EV");
                dt.Columns.Add("ROMNEY Votes");
                dt.Columns.Add("ROMNEY %");
                dt.Columns.Add("ROMNEY EV");
                string[] data = new string[File.ReadAllLines(csv_file[0]).Length];
                data = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
                }
                dgv.DataSource = dt;
            }
            else if (year == "2008")
            {
                DataTable dt = new DataTable();
                Directory.SetCurrentDirectory(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2008");
                string fpath = Directory.GetCurrentDirectory();
                string[] csv_file = Directory.GetFiles(fpath, "*.data");

                //stream reader
                StreamReader sr = new StreamReader(csv_file[0].ToString());
                dt.Columns.Add("State");
                dt.Columns.Add("Total Votes");
                dt.Columns.Add("OBAMA Votes");
                dt.Columns.Add("OBAMA %");
                dt.Columns.Add("OBAMA EV");
                dt.Columns.Add("McCAIN Votes");
                dt.Columns.Add("McCAIN %");
                dt.Columns.Add("McCAIN EV");
                string[] data = new string[File.ReadAllLines(csv_file[0]).Length];
                data = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
                }
                dgv.DataSource = dt;
            }
            else if (year == "2004")
            {
                DataTable dt = new DataTable();
                Directory.SetCurrentDirectory(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2004");
                string fpath = Directory.GetCurrentDirectory();
                string[] csv_file = Directory.GetFiles(fpath, "*.data");

                //stream reader
                StreamReader sr = new StreamReader(csv_file[0].ToString());
                dt.Columns.Add("State");
                dt.Columns.Add("Total Votes");
                dt.Columns.Add("BUSH Votes");
                dt.Columns.Add("BUSH %");
                dt.Columns.Add("BUSH EV");
                dt.Columns.Add("KERRY Votes");
                dt.Columns.Add("KERRY %");
                dt.Columns.Add("KERRY EV");
                string[] data = new string[File.ReadAllLines(csv_file[0]).Length];
                data = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
                }
                dgv.DataSource = dt;
            }
            else if (year == "2000")
            {
                DataTable dt = new DataTable();
                Directory.SetCurrentDirectory(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2000");
                string fpath = Directory.GetCurrentDirectory();
                string[] csv_file = Directory.GetFiles(fpath, "*.data");

                //stream reader
                StreamReader sr = new StreamReader(csv_file[0].ToString());
                dt.Columns.Add("State");
                dt.Columns.Add("Total Votes");
                dt.Columns.Add("BUSH Votes");
                dt.Columns.Add("BUSH %");
                dt.Columns.Add("BUSH EV");
                dt.Columns.Add("GORE Votes");
                dt.Columns.Add("GORE %");
                dt.Columns.Add("GORE EV");
                dt.Columns.Add("NADER Votes");
                dt.Columns.Add("NADER %");
                dt.Columns.Add("NADER EV");
                string[] data = new string[File.ReadAllLines(csv_file[0]).Length];
                data = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10]);
                }
                dgv.DataSource = dt;
            }
            else if (year == "1996")
            {
                DataTable dt = new DataTable();
                Directory.SetCurrentDirectory(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\1996");
                string fpath = Directory.GetCurrentDirectory();
                string[] csv_file = Directory.GetFiles(fpath, "*.data");

                //stream reader
                StreamReader sr = new StreamReader(csv_file[0].ToString());
                dt.Columns.Add("State");
                dt.Columns.Add("Total Votes");
                dt.Columns.Add("Clinton Votes");
                dt.Columns.Add("Clinton %");
                dt.Columns.Add("Clinton EV");
                dt.Columns.Add("BUSH Votes");
                dt.Columns.Add("BUSH %");
                dt.Columns.Add("BUSH EV");
                dt.Columns.Add("PEROT Votes");
                dt.Columns.Add("PEROT %");
                dt.Columns.Add("PEROT EV");
                string[] data = new string[File.ReadAllLines(csv_file[0]).Length];
                data = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10]);
                }
                dgv.DataSource = dt;
            }
            else if (year == "1992")
            {
                DataTable dt = new DataTable();
                Directory.SetCurrentDirectory(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\1992");
                string fpath = Directory.GetCurrentDirectory();
                string[] csv_file = Directory.GetFiles(fpath, "*.data");

                //stream reader
                StreamReader sr = new StreamReader(csv_file[0].ToString());
                dt.Columns.Add("State");
                dt.Columns.Add("Total Votes");
                dt.Columns.Add("Clinton Votes");
                dt.Columns.Add("Clinton %");
                dt.Columns.Add("Clinton EV");
                dt.Columns.Add("BUSH Votes");
                dt.Columns.Add("BUSH %");
                dt.Columns.Add("BUSH EV");
                dt.Columns.Add("PEROT Votes");
                dt.Columns.Add("PEROT %");
                dt.Columns.Add("PEROT EV");
                string[] data = new string[File.ReadAllLines(csv_file[0]).Length];
                data = sr.ReadLine().Split(',');
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(',');
                    dt.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10]);
                }
                dgv.DataSource = dt;
            }

            {
                if (year == "2020")
                {

                    pic.Image = Image.FromFile(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2020map\2020.jpg");
                }
                else if (year == "2016")
                {
                    PictureBox dt = new PictureBox();
                    pic.Image = Image.FromFile(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2016Map\2016.jpg");
                }
                else if (year == "2012")
                {
                    PictureBox dt = new PictureBox();
                    pic.Image = Image.FromFile(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2012map\2012.jpg");
                }
                else if (year == "2008")
                {
                    PictureBox dt = new PictureBox();
                    pic.Image = Image.FromFile(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2008map\2008.jpg");
                }
                else if (year == "2004")
                {
                    PictureBox dt = new PictureBox();
                    pic.Image = Image.FromFile(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2004map\2004.jpg");
                }
                else if (year == "2000")
                {
                    PictureBox dt = new PictureBox();
                    pic.Image = Image.FromFile(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\2000map\2000.jpg");
                }
                else if (year == "1996")
                {
                    PictureBox dt = new PictureBox();
                    pic.Image = Image.FromFile(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\1996map\1996.jpg");
                }
                else if (year == "1992")
                {
                    PictureBox dt = new PictureBox();
                    pic.Image = Image.FromFile(@"E:\CIS22 PROJECT\ELECTION DATA CIS PROJECT\1992map\1992.jpg");
                }
                {
                }

                {
                    if (year == "2020")
                    {
                        lbl1.Text = ("Democratic Joe Biden");
                    }
                    else if (year == "2016")
                    {
                        lbl1.Text = ("Republican Donald Trump");
                    }
                    else if (year == "2012")
                    {
                        lbl1.Text = ("Democratic Barack Obama");

                    }
                    else if (year == "2008")
                    {
                        lbl1.Text = ("Democratic Barack Obama");

                    }
                    else if (year == "2004")
                    {
                        lbl1.Text = ("Republican George W. Bush");


                    }
                    else if (year == "2000")
                    {
                        lbl1.Text = ("Republican George W. Bush");

                    }
                    else if (year == "1996")
                    {
                        lbl1.Text = ("Democratic William J. Clinton");

                    }
                    else if (year == "1992")
                    {
                        lbl1.Text = ("Democratic William J. Clinton");

                    }
                }
            }
        }
            
           
            
            
            


           
        
        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            

            }
        }
    }


// SOURCE: https://www.presidency.ucsb.edu/statistics/elections/1992 used to get data everything else we learned in class and used it in our final project.


