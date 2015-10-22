﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/****************************************************************************
 * This is an inventory management system that tracks phone parts for a
 * retail/repair store.  It is under development.
 *
 * Produced by: Joseph Larson, Michael Williams, Arbin Rai
 * **************************************************************************/

namespace InventoryManagement
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Global list that holds all parts that are added
        //changes are made to this list and then this list is
        //displayed in the listbox control
        List<string> partsList = new List<string> { };
        List<string> searchList = new List<string> { };
      

        //Method to add parts takes in the info from the combo and txtboxes
        //and generates a string description of the part, then adds it to the
        //global list

        private void AddPart(string make, string model, string part, string color, int quantity, DateTime currentDate)
        {
            

            string fullPart = make + " " + model + " " + part + ", " + color + ", Recieved: " + currentDate;

            for (int i = 0; i < quantity; i++)
            {
                partsList.Add(fullPart);
            }
        }

        /*********************************
         * OLD METHOD OF ADDPART -- keeping just incase we revert to this way
         * However, the new way I think will be easier to add test data with
         * And should function the same, so, you know, we'll probably stick
         * with that way.
         * ******************************/

        //private void AddPart()
        //{
        //    string make = cmbMake.Text;
        //    string model = cmbModel.Text;
        //    string part = "";
        //    string color = txtColor.Text;
        //    int quantity = Convert.ToInt16(txtQuantity.Text);
        //    DateTime currentDateTime = DateTime.Now;

        //    //conditional for if user selects "Other" part
        //    if (cmbPart.Text == "Other")
        //    {
        //        part = txtOther.Text;
        //    }
        //    else
        //    {
        //        part = cmbPart.Text;
        //    }

        //    string fullPart = make + " " + model + " " + part + ", " + color + ", Recieved: " + currentDateTime.ToShortDateString();

            
        //    for (int i = 0; i < quantity; i++)
        //    {
        //        partsList.Add(fullPart);
        //    }
        //}

        //adds each item in the global parts list to the listbox control
        private void UpdateListBox()
        {
            foreach (string part in partsList)
                lstParts.Items.Add(part);
        }



        //remove the selected part
        private void RemovePart()
        {
            int index = lstParts.SelectedIndex;
            partsList.RemoveAt(index);
        }

        //clears all the items in the listbox
        private void ClearListBox()
        {
            lstParts.Items.Clear();
        }


        //sorts the global list
        private void SortList()
        {
            partsList.Sort();
        }

        //method to clear the form and reset it.  Does not work
        //as well to reset the combo boxes, but I'll try to figure it out
        private void ClearForm()
        {
            txtColor.Clear();
            txtQuantity.Clear();
            txtOther.Clear();
            cmbModel.Refresh();
            cmbMake.Refresh();
            cmbPart.ResetText();
            cmbMake.Focus();

        }

        //wired to selected index changed for parts combo box to show/hide
        //the "Other" textboxes and labels

        private void ChangeOtherVisible(object sender, EventArgs e)
        {
            if (cmbPart.Text == "Other")
            {
                lblOther.Visible = true;
                txtOther.Visible = true;
            }
            else
            {
                lblOther.Visible = false;
                txtOther.Visible = false;
            }
        }

        //This method uses a switch to vary which models are available for 
        //different phone brands
        private void ChangeModelCollection(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            string make = cmbMake.Text;

            switch (make)
            {
                case "Apple":
                cmbModel.Items.Add("iPhone 5C");
                cmbModel.Items.Add("iPhone 5S");
                cmbModel.Items.Add("iPhone 6");
                cmbModel.Items.Add("iPhone 6+");
                break;
                case "Samsung":
                cmbModel.Items.Add("Galaxy S4");
                cmbModel.Items.Add("Galaxy S5");
                cmbModel.Items.Add("Galaxy Note III");
                cmbModel.Items.Add("Galaxy Note IV");
                break;
                case "Nokia":
                cmbModel.Items.Add("Lumia 925");
                cmbModel.Items.Add("Lumia 1020");
                cmbModel.Items.Add("Lumia 1520");

                break;
            }
        }

        //add part to the global part list, clear the list box, then
        //update the listbox with the new global list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string part = "";
            DateTime currentDate = DateTime.Now;

            //conditional for if user selects "Other" part
            if (cmbPart.Text == "Other")
            {
                part = txtOther.Text;
            }
            else
            {
                part = cmbPart.Text;
            }

            AddPart(cmbMake.Text, cmbModel.Text, part, txtColor.Text, Convert.ToInt16(txtQuantity.Text), currentDate);
            ClearListBox();
            UpdateListBox();
            ClearForm();
        }
      
        //sorts global list, clears the box, updates the box
        private void btnSort_Click(object sender, EventArgs e)
        {
            SortList();
            ClearListBox();
            UpdateListBox();
        }

        //event handler for the remove button, removes the part from the 
        //global list, clears the box, and then updates the box
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemovePart();
            ClearListBox();
            UpdateListBox();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Search method for the parts list
        private void SearchParts(object sender, EventArgs e)
        {
            searchList.Clear();
            string searchString = txtSearch.Text;

            foreach (string part in partsList)
            {
                if (part.Contains(searchString))
                {
                    searchList.Add(part);
                }
            }

            ClearListBox();
            foreach (string part in searchList)
            {
                lstParts.Items.Add(part);
            }
        }


        //Test Data
        private void LoadSmallTest()
        {
            DateTime testDate = DateTime.Now;
            AddPart("Apple", "iPhone 5C", "Charging Port", "", 3, testDate);
            AddPart("Samsung", "Galaxy S5", "Display", "Charcoal", 1, testDate);
            AddPart("Apple", "iPhone 6", "Display", "White", 2, testDate);
            AddPart("Apple", "iPhone 6", "Battery", "", 2, testDate);
            AddPart("Nokia", "Lumia 1020", "Power/Lock Button", "Black", 1, testDate);
        }

        private void LoadLargeTest()
        {
            DateTime testDate = DateTime.Now;
            AddPart("Apple", "iPhone 5C", "Charging Port", "", 3, testDate);
            AddPart("Samsung", "Galaxy S5", "Display", "Charcoal", 3, testDate);
            AddPart("Apple", "iPhone 6", "Display", "White", 2, testDate);
            AddPart("Apple", "iPhone 6", "Battery", "", 2, testDate);
            AddPart("Nokia", "Lumia 1020", "Power/Lock Button", "Black", 2, testDate);
            AddPart("Samsung", "Galaxy S4", "Charging Port", "Charcoal", 4, testDate);
            AddPart("Nokia", "Lumia 1520", "Display", "White", 2, testDate);
            AddPart("Apple", "iPhone 5S", "Display", "Black", 5, testDate);
            AddPart("Samsung", "Note IV", "Stylus", "White", 3, testDate);
            AddPart("Samsung", "Note III", "Home Button", "", 2, testDate);
            AddPart("Apple", "iPhone 6+", "Display", "White", 2, testDate);
            AddPart("Apple", "iPhone 6+", "Display", "Black", 2, testDate);
            AddPart("Nokia", "Lumia 1520", "Battery", "", 2, testDate);

        }

        private void btnSmallTest_Click(object sender, EventArgs e)
        {
            LoadSmallTest();
            ClearListBox();
            UpdateListBox();
            ClearForm();
        }

        private void btnLoadLargeTest_Click(object sender, EventArgs e)
        {
            LoadLargeTest();
            ClearListBox();
            UpdateListBox();
            ClearForm();
        }






    }
}