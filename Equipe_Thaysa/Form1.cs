using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.IE;
//using excelapp = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using System.IO;
//using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using WFICALib;

namespace Equipe_Thaysa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
         {

            try
            {
                string Path = System.Windows.Forms.Application.StartupPath;

                 var teste =  Process.Start(Path + @"\launch (1).ica");
                    
                Process[] processlist = Process.GetProcesses();

                foreach (Process process in processlist)
                {
                    if (process.ProcessName == "winlogon")
                    {
                        Console.WriteLine(process.ToString());

                    }
                }

            }

            catch (Exception)
            {
                MessageBox.Show(@"Erro");
            }


        }

    }
}
