using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/***************************************************************
* Name        : Data Structures Final Project
* Author      : Trae Eddie
* Created     : 12/13/2020
* Course      : CIS 152 - Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            
*               specifications issued by our instructor
*               
* Description : This program uses data structures for greenhouse
* employees. It allows an employee to grab a physical tray off of
* the stack and start the potting process. They are worked on in
* a queue-like fashion. Once a plant has finished the potting process,
* it is dequeued and enqueued into the inspection process. Finally it 
* is dequeued from inspection to the forsale list. The list is sorted
* alphabetically by insertion sort. When a plant is sold the employee
* can enter its tray number and place that tray back on top of the stack.
* The program uses a database and a text file to keep track of what plants
* are in what stage at all times. It saves the current stack order to be rebuilt
* on program reset via text file. Plants are objects with an id value and name value.
* Use the bin executable for full functionality.
* 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or  
* unmodified. I have not given other fellow student(s) access to 
* my program.         
***************************************************************/
namespace DataStructsFinalEddie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GreenHouseForm());
        }
    }
}
