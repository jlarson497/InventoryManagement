using System;
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
 * retail/repair store.  You can use the drop down boxes to select makes, models, and parts,
 * and textboxes for colors and quantity.  The list can be sorted, and parts removed.
 * Instead of displaying each item once with a quantity as part of the display, the list iterates 
 * a part listing for each quantity -- 3 screens showup as the particular brand and model of screen 3 times.  
 * Since we didn't use a class, we found that this may have been the best way.  There is also a search 
 * function, since due to the nature of the way we are displaying the inventory, the list can get quite 
 * long.  There is a date-dif counter that shows how long a part has been in stock in the lower left.
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
            string shortCurrentDate = currentDate.ToShortDateString();
            string fullPart = make + " " + model + " " + part + ", " + color + ", Recieved: " + shortCurrentDate;

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
                picPhone.BackgroundImage = Properties.Resources.Apple;
                break;
                case "Samsung":
                cmbModel.Items.Add("Galaxy S4");
                cmbModel.Items.Add("Galaxy S5");
                cmbModel.Items.Add("Galaxy Note III");
                cmbModel.Items.Add("Galaxy Note IV");
                picPhone.BackgroundImage = Properties.Resources.Samsung;
                break;
                case "Nokia":
                cmbModel.Items.Add("Lumia 925");
                cmbModel.Items.Add("Lumia 1020");
                cmbModel.Items.Add("Lumia 1520");
                picPhone.BackgroundImage = Properties.Resources.Nokia;

                break;
            }
        }

        //add part to the global part list, clear the list box, then
        //update the listbox with the new global list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isValidForm())
            {
                return;
            }
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

        //Method to get the number of days we've had a part in stock
        //creates a variable with the current date.
        //Gets the date string from the full string in the list, which begins after the last ":"
        //
        private int GetDateDif()
        {
            DateTime currentDate = DateTime.Now;
            int index = lstParts.SelectedIndex;
            string stringToDif = partsList.ElementAt(index);

            string dateString = stringToDif.Substring(stringToDif.LastIndexOf(":") + 1);
            DateTime dayRecieved = Convert.ToDateTime(dateString);

            TimeSpan inStockTimeSpan = currentDate.Subtract(dayRecieved);
            int daysInStock = inStockTimeSpan.Days;

            return daysInStock;


        }

        

        //data validation for textbox presence
        //extra logic for if the textbox is the color textbox
        public bool isPresentTextBox(TextBox textbox, string name)
        {
            if (textbox == txtColor)
            {
                if (textbox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.  Enter N/A if not applicable.", "Error");
                    textbox.Clear();
                    textbox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (textbox.Text == "")
                {
                    MessageBox.Show(name + " is a required field", "Error");
                    textbox.Clear();
                    textbox.Focus();
                    return false;
                }
            }

            return true;
        }

        //presence validation for if a combo box is selected
        public bool isSelected(ComboBox combobox, string name)
        {
            if (combobox.SelectedIndex < 0)
            {
                MessageBox.Show(name + " must be selected", "Error");
                combobox.Refresh();
                combobox.Focus();
                return false;
            }

            return true;
        }

        //Data type validation for INT
        public bool IsInt(TextBox textbox, string name)
        {
            int number = 0;
            if (int.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textbox.Clear();
                textbox.Focus();
                return false;
            }

        }

        //Range Validation
        private bool IsWithinRange(TextBox textbox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textbox.Text);
            if (number > max || number < min)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString(), "Entry Error");
                textbox.Clear();
                textbox.Focus();
                return false;
            }

            return true;
        }

        //Form Validation
        private bool isValidForm()
        {
            return
                isSelected(cmbMake, "Make") && isSelected(cmbModel, "Model") && isSelected(cmbPart, "Part") &&
                isPresentTextBox(txtColor, "Color") &&
                isPresentTextBox(txtQuantity, "Quantity") && IsInt(txtQuantity, "Quantity") && IsWithinRange(txtQuantity, "Quantity", 0, 10);
                
        }
        

        //Test Data
        //Method for adding test data is slightly different so that previous dates can be entered
        private void AddTestPart(string make, string model, string part, string color, int quantity, string dayRecieved)
        {

            string fullPart = make + " " + model + " " + part + ", " + color + ", Recieved: " + dayRecieved;

            for (int i = 0; i < quantity; i++)
            {
                partsList.Add(fullPart);
            }
        }
        private void LoadSmallTest()
        {
            DateTime testDate = DateTime.Now;
            AddTestPart("Apple", "iPhone 5C", "Charging Port", "N/A", 3, "12/1/2014");
            AddTestPart("Samsung", "Galaxy S5", "Display", "Charcoal", 1, "3/14/2015");
            AddTestPart("Apple", "iPhone 6", "Display", "White", 2, "10/2/2015");
            AddTestPart("Apple", "iPhone 6", "Battery", "N/A", 2, "9/9/2015");
            AddTestPart("Nokia", "Lumia 1020", "Power/Lock Button", "Black", 1, "6/7/2014");
        }

        private void LoadLargeTest()
        {
            DateTime testDate = DateTime.Now;
            AddTestPart("Apple", "iPhone 5C", "Charging Port", "N/A", 3, "12/1/2014");
            AddTestPart("Samsung", "Galaxy S5", "Display", "Charcoal", 1, "3/14/2014");
            AddTestPart("Apple", "iPhone 6", "Display", "White", 2, "10/2/2015");
            AddTestPart("Apple", "iPhone 6", "Battery", "N/A", 2, "9/9/2015");
            AddTestPart("Nokia", "Lumia 1020", "Power/Lock Button", "Black", 1, "6/7/2014");
            AddTestPart("Samsung", "Galaxy S4", "Charging Port", "Charcoal", 4, "1/17/2015");
            AddTestPart("Nokia", "Lumia 1520", "Display", "White", 2, "5/9/2015");
            AddTestPart("Apple", "iPhone 5S", "Display", "Black", 5, "7/11/2015");
            AddTestPart("Samsung", "Note IV", "Stylus", "White", 3, "8/16/2014");
            AddTestPart("Samsung", "Note III", "Home Button", "Black", 2, "2/14/2015");
            AddTestPart("Apple", "iPhone 6+", "Display", "White", 2, "10/26/2015");
            AddTestPart("Apple", "iPhone 6+", "Display", "Black", 2, "9/18/2015");
            AddTestPart("Nokia", "Lumia 1520", "Battery", "N/A", 2, "8/8/2015");

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

        private void DisplayDaysInStock(object sender, EventArgs e)
        {
            txtDaysInStock.Text = Convert.ToString(GetDateDif());
        }






    }
}