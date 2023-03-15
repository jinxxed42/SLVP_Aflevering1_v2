using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLVP_Aflevering1_v2
{
    public partial class Form1 : Form
    {

        // Global variables that are used and accessed everywhere in the program.
        string[] nameArray = { "The data in this box is stored in an array." };
        List<string> nameList = new List<string>();
        int currentLine;
        bool autoSort = true; // Autosorting enabled by default.
        bool autoSortReverse = false;

        public Form1()
        {
            InitializeComponent();
            nameList.Add("The data in this box is stored in a list.");
            textUpdate();
        }


        /// <summary>
        /// Eventhandler for the Add button btnAdd. Unless the input is blank it takes the text input in the tbAdd box and sends it to the textAdd function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // We only proceed if something was entered in the field. Else we print an error message.
            if (tbAdd.Text == "")
            {
                tbOutput.Text = "Error, you must input a name!";
            }
            else
            {
                textAdd(tbAdd.Text);
            }
        }


        /// <summary>
        /// Event handler for the delete button btnDelPos. Checks if the input is an integer value >= 0. If so it calls the textRemove function with that value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelPos_Click(object sender, EventArgs e)
        {
            int position;
            bool isInt = int.TryParse(tbDelPos.Text, out position);
            if (isInt && position >= 0)
            {
                textRemove(position);
            }
            else
            {
                tbOutput.Text = "Integer values >= 0 only.";
            }
        }

        /// <summary>
        /// Eventhandler. Stores the last line the text cursor was on inside rtbArray in currentLine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        /**
        private void rtbArray_SelectionChanged(object sender, EventArgs e)
        {
            currentLine = rtbArray.GetLineFromCharIndex(rtbArray.SelectionStart);
            //currentLine = dgvArray.Rows[e.RowIndex].Cells.Value.ToString();
            //var cellValue = dgvAccount.Rows[e.RowIndex].Cells["AccountID"].Value.ToString();
        }
        **/

        /// <summary>
        /// Eventhandler. Stores the last line the text cursor was on inside rtbList in currentLine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        /**
        private void rtbList_SelectionChanged(object sender, EventArgs e)
        {
            currentLine = rtbList.GetLineFromCharIndex(rtbList.SelectionStart);
        }
        **/


        /// <summary>
        /// Eventhandler for the delete button. Calls textRemove with the last selected line in rtbArray or rtbList when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrayDel_Click(object sender, EventArgs e)
        {
            // We use the fact that the SelectionChanged eventhandlers above will keep the global variable currentLine updated when calling textRemove.
            textRemove(currentLine);
        }


        /// <summary>
        /// Eventhandler for the sort button btnSort.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (!autoSort)
            {
                if (trySort(false))
                {
                    tbOutput.Text = "Array & list sorted!";
                }
                else
                {
                    tbOutput.Text = "Seems something went wrong with the sorting.";
                }
            }
            else if (autoSortReverse) // autoSort == true
            {
                if (trySort(false))
                {
                    autoSortReverse = false;
                    tbOutput.Text = "Autosorting.";
                    btnAutoSort.Text = "Autosort: yes";
                }
                else
                {
                    tbOutput.Text = "Seems something went wrong with the sorting.";
                }
            }

            // After sorting the displayed text needs to be updated.
            textUpdate();
        }

        /// <summary>
        /// Eventhandler for the sort reversed button btnRevSort.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevSort_Click(object sender, EventArgs e)
        {
            if (!autoSort)
            {
                if (trySort(true))
                {
                    tbOutput.Text = "Array & list sorted and reversed!";
                }
                else
                {
                    tbOutput.Text = "Seems something went wrong with the sorting.";
                }
            }
            else if (autoSort && !autoSortReverse)
            {
                if (trySort(true))
                {
                    autoSortReverse = true;
                    tbOutput.Text = "Autosorting in reverse.";
                    btnAutoSort.Text = "Autosort: reverse";
                }
                else
                {
                    tbOutput.Text = "Seems something went wrong with the sorting.";
                }
            }
            else //autoSort == true && autoSortReverse == true
            {
                if (trySort(false))
                {
                    autoSortReverse = false;
                    tbOutput.Text = "Autosorting.";
                    btnAutoSort.Text = "Autosort: yes";

                }
                else
                {
                    tbOutput.Text = "Seems something went wrong with the sorting.";
                }
            }

            // Update text after sorting.
            textUpdate();
        }

        /// <summary>
        /// Eventhandler for the autosort button btnAutoSort. Turns autosorting on or off when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoSort_Click(object sender, EventArgs e)
        {
            if (autoSort)
            {
                autoSort = false;
                tbOutput.Text = "Autosorting disabled.";
                btnAutoSort.Text = "Autosort: no";
            }
            else
            {
                if (!autoSortReverse)
                {
                    if (trySort(false))
                    {
                        autoSort = true;
                        tbOutput.Text = "Autosorting.";
                        btnAutoSort.Text = "Autosort: yes";
                    }
                    else
                    {
                        tbOutput.Text = "Seems something went wrong with the sorting.";
                    }
                }
                else
                {
                    if (trySort(true))
                    {
                        autoSort = true;
                        tbOutput.Text = "Autosorting in reverse.";
                        btnAutoSort.Text = "Autosort: reverse";
                    }
                    else
                    {
                        tbOutput.Text = "Seems something went wrong with the sorting.";
                    }
                }
            }
            textUpdate();
        }




        /// <summary>
        /// Updates the displayed text for both the rtbArray and rtbList boxes. 
        /// </summary>
        private void textUpdate()
        {
            // Update rtbArray text.
            /**
            rtbArray.Text = "";
            for (int i = 0; i < nameArray.Length; i++)
            {
                rtbArray.Text += $"Position {i}: {nameArray[i]}\n";
            }
            **/

            BindingSource bs = new BindingSource();
            bs.DataSource = nameArray;
            dgvArray.DataSource = bs;

            // Update rtbList text.
            // Both of these could have been handled by the same loop instead of 2 different ones, since the list and array will always be the same size.
            // I have kept them separate for clarity's sake. It matters little in a small program like this anyways.

            /**
            rtbList.Text = "";
            for (int i = 0; i < nameList.Count; i++)
            {
                rtbList.Text += $"Position {i}: {nameList[i]}\n";
            }
            **/

            bs.DataSource = nameList;
            dgvList.DataSource = bs;
        }

        /// <summary>
        /// Adds the text in the string parameter to both the array and list.
        /// </summary>
        /// <param name="textToAdd"></param>
        private void textAdd(string textToAdd)
        {
            // Increase size of array by 1
            Array.Resize(ref nameArray, nameArray.Length + 1);
            // We just increased the size by 1, so we subtract 1 from the length to access the last position. 
            nameArray[nameArray.Length - 1] = textToAdd;

            // Text can be added directly to the list.
            nameList.Add(textToAdd);

            tbOutput.Text = $"{textToAdd} successfully added.";

            // If autosorting is enabled we need to sort it again after adding anything.
            if (autoSort)
            {
                if (autoSortReverse)
                {
                    if (trySort(true))
                    {
                        tbOutput.Text += "..autosorting in reverse.";
                    }
                    else
                    {
                        tbOutput.Text += "Seems something went wrong with the sorting though.";
                    }
                }
                else
                {
                    if (trySort(false))
                    {
                        tbOutput.Text += "..autosorting.";
                    }
                    else
                    {
                        tbOutput.Text += "Seems something went wrong with the sorting though.";
                    }
                }

            }

            // After any changes we need to update the text shown in both boxes.
            textUpdate();
        }

        /// <summary>
        /// Removes the string data at position numToRemove in both array and lists, if possible.
        /// </summary>
        /// <param name="numToRemove"></param>
        private void textRemove(int numToRemove)
        {

            bool toUpdate = false;
            // Test if there is anything in the array - we will have made it bigger than size 0 in that case, and if the supplied value is valid.
            if (nameArray.Length != 0 && numToRemove < nameArray.Length)
            {
                // Unless we are removing the last element, then we need to move all elements placed after the element to be removed 1 space forward
                // before resizing. That will overwrite and thus delete the intended position.
                if (numToRemove != nameArray.Length - 1)
                {
                    for (int i = numToRemove; i < nameArray.Length - 1; i++)
                    {
                        nameArray[i] = nameArray[i + 1];
                    }
                }
                Array.Resize(ref nameArray, nameArray.Length - 1);
                toUpdate = true;
            }

            // Removes directly from the list if the input is valid.
            if (nameList.Count != 0 && numToRemove < nameList.Count)
            {
                nameList.RemoveAt(numToRemove);
                toUpdate = true; // Is true here if it was for array, so only included for completeness. Would be used if we just worked on the list.
            }
            // In case we deleted anything we need to update the text and print a success message. If it fails an error is printed.
            if (toUpdate)
            {
                textUpdate();
                tbOutput.Text = $"Line #{numToRemove} has been removed.";
            }
            else
            {
                tbOutput.Text = "Invalid input!";
            }

        }



        /// <summary>
        /// Sorts both the array and list. 
        /// </summary>
        /// <param name="reverse">Bool - False for normal sort, true for reversed sorting.</param>
        /// <returns>True if the sorting was performed, else false.</returns>
        private bool trySort(bool reverse)
        {
            // There's no reason to sort if there's 0 or 1 element in the array and list.
            // Not necessary to test for both conditions since both the array and list
            // will have same size. Left in for completeness.
            if (nameArray.Length == 1 && nameList.Count == 1)
            {
                return true; // We return true since with 1 element the array and list is sorted. Exits function.
            }
            else if (nameArray.Length > 0 && nameList.Count > 0)
            {
                if (!reverse)
                {
                    Array.Sort(nameArray, StringComparer.InvariantCulture);
                    // Without this it placed aa after z while sorting on my pc, which is unintended.
                    // By using the InvariantCulture when sorting we ensure that the result will be correct and the same on any machine.


                    nameList.Sort(StringComparer.InvariantCulture);

                    return true; // Exits function


                }
                else
                {

                    Array.Sort(nameArray, StringComparer.InvariantCulture);
                    Array.Reverse(nameArray);


                    nameList.Sort(StringComparer.InvariantCulture);
                    nameList.Reverse();

                    return true; // Exits function
                }
            }
            // Default. If no sorting is performed it will reach this point and return false. Otherwise the function will have terminated earlier and returned true.
            return false;
        }

        private void dgvArray_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentLine = e.RowIndex;
            /**
            currentLine = dgvArray.Rows[e.RowIndex].Cells.Value.ToString();
            currentLine = dgvArray.Rows[e.RowIndex];
            currentLine = dgvArray.Rows[e.RowIndex].Cell
            **/
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentLine = e.RowIndex;
        }
    }
}
