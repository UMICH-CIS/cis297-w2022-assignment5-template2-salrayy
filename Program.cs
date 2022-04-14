//Summer Alrayyashi
//CIS 297 Winter 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorGUI
{
   static class Program
   {
      /// <summary>
      /// This application is a GUI Calculator for all the functions used in Assignment 1
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new CalculatorGUIForm() );
      }
   }
}
