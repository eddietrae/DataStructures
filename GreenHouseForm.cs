using DataStructsFinalEddie.PlantDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : GreenHouse Final Project
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
    public partial class GreenHouseForm : Form
    {
        // Set up adapters for each table - Create our data structures
        ForSaleTableAdapter forSaleTableAdapter = new ForSaleTableAdapter();
        InspectionTableAdapter inspectionTableAdapter = new InspectionTableAdapter();
        PottingTableAdapter pottingTableAdapter = new PottingTableAdapter();
        Stack<int> stack = new Stack<int>();
        Queue<Plant> pottingQ = new Queue<Plant>();
        Queue<Plant> inspectionQ = new Queue<Plant>();
        List<Plant> forSaleList = new List<Plant>();

        public GreenHouseForm()
        {
            InitializeComponent();
            // Load everything from database into our queues and sale list
            PlantDatabaseDataSet.PottingDataTable pottingRows = new PlantDatabaseDataSet.PottingDataTable();
            PlantDatabaseDataSet.InspectionDataTable inspectionRows = new PlantDatabaseDataSet.InspectionDataTable();
            PlantDatabaseDataSet.ForSaleDataTable forSaleRows = new PlantDatabaseDataSet.ForSaleDataTable();

            pottingTableAdapter.Fill(pottingRows);
            inspectionTableAdapter.Fill(inspectionRows);
            forSaleTableAdapter.Fill(forSaleRows);
            // Add each item to its queue or list
            foreach (DataRow item in pottingRows)
            {
                Plant plant = new Plant(item["Name"].ToString(), int.Parse(item["Id"].ToString()));
                pottingQ.Enqueue(plant);
            }
            foreach (DataRow item in inspectionRows)
            {
                Plant plant = new Plant(item["Name"].ToString(), int.Parse(item["Id"].ToString()));
                inspectionQ.Enqueue(plant);
            }
            foreach (DataRow item in forSaleRows)
            {
                Plant plant = new Plant(item["Name"].ToString(), int.Parse(item["Id"].ToString()));
                forSaleList.Add(plant);
            }
            forSaleList = Plant.InsertionSort(forSaleList); // Insertion sort database objects

            // Rebuild stack if it exists in text file or build for first time
            if (System.IO.File.Exists("stack.txt"))
            {
                List<string> newStack = new List<string>();
                newStack.AddRange(System.IO.File.ReadAllLines("stack.txt"));
                for(int i = newStack.Count-1; i >= 0; i--)
                {
                    stack.Push(int.Parse(newStack[i]));
                }
            }
            else
            {
                // Change i if you want a different stack size. Delete or modify the existing text file.
                // Make sure database is clear or that stack file doesnt contain any tray numbers that already
                // exist in the database if you change this.
                for (int i = 200; i > 0; i--) 
                {
                    stack.Push(i);
                }
            }
                
            // Set our queues and list to display on the datagrid
            pottingDataGrid.DataSource = pottingQ.ToList();
            inspectionDataGrid.DataSource = inspectionQ.ToList();
            forSaleDataGrid.DataSource = forSaleList.ToList();
        }

        

        private void pottingAddButton_Click(object sender, EventArgs e)
        {
            // Take user entered name and top tray in stack - add them to potting queue
            // Update database
            if(plantNameTextBox.Text != null)
            {
                Plant plant = new Plant(plantNameTextBox.Text, stack.Pop());
                pottingQ.Enqueue(plant);
                pottingTableAdapter.Insert(Id: plant.TrayNum, Name: plant.Name);
            }
            // Update datagrids
            pottingDataGrid.DataSource = pottingQ.ToList();
            inspectionDataGrid.DataSource = inspectionQ.ToList();
            forSaleDataGrid.DataSource = forSaleList.ToList();
        }

        private void pottingPassButton_Click(object sender, EventArgs e)
        {
            // Dequeue a plant from potting and enqueue into inspection
            // Update database
            if (pottingQ.Count > 0)
            {
                pottingTableAdapter.Delete(pottingQ.Peek().TrayNum, pottingQ.Peek().Name);
                inspectionTableAdapter.Insert(pottingQ.Peek().TrayNum, pottingQ.Peek().Name);
                inspectionQ.Enqueue(pottingQ.Dequeue());
            }
            // Update datagrids
            pottingDataGrid.DataSource = pottingQ.ToList();
            inspectionDataGrid.DataSource = inspectionQ.ToList();
            forSaleDataGrid.DataSource = forSaleList.ToList();
        }

        
        private void inspectionPassButton_Click(object sender, EventArgs e)
        {
            // Dequeue a plant from inspection and insertion sort it into the forSaleList
            // Update database
            if (inspectionQ.Count > 0)
            {
                inspectionTableAdapter.Delete(inspectionQ.Peek().TrayNum, inspectionQ.Peek().Name);
                forSaleTableAdapter.Insert(inspectionQ.Peek().TrayNum, inspectionQ.Peek().Name);
                forSaleList.Add(inspectionQ.Dequeue());
                forSaleList = Plant.InsertionSort(forSaleList);
            }
            // Update datagrids
            pottingDataGrid.DataSource = pottingQ.ToList();
            inspectionDataGrid.DataSource = inspectionQ.ToList();
            forSaleDataGrid.DataSource = forSaleList.ToList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Take user entered tray number and remove it from the sale list - push tray to top of stack
            // Update database
            foreach (var item in forSaleList.ToList())
            {
                if (removeTextBox.Text.Equals(item.TrayNum.ToString()))
                {
                    forSaleList.Remove(item);
                    forSaleTableAdapter.Delete(item.TrayNum, item.Name);
                    stack.Push(item.TrayNum);
                }
            }
            // Update datagrids
            pottingDataGrid.DataSource = pottingQ.ToList();
            inspectionDataGrid.DataSource = inspectionQ.ToList();
            forSaleDataGrid.DataSource = forSaleList.ToList();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Stores the stack into a text file so it can be rebuilt in the order that it was in
            // You may encounter primary key errors if you run this in debug because the database resets.
            // Run in the executable for correct results
            int count = stack.Count;
            List<string> newStack = new List<string>();
            for (int i = 0; i < count; i++)
            {
                newStack.Add(stack.Pop().ToString());
            }
            System.IO.File.Delete("stack.txt");
            System.IO.File.WriteAllLines("stack.txt", newStack);
            this.Close();
        }
    }
}
