//Summer Alrayyashi
//CIS 297 Winter 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// This application is a GUI calculator using functions from assignment 1
/// </summary>
namespace CalculatorGUI
{
   static class Program
   {
     
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new CalculatorGUIForm() );
      }
   }
}
