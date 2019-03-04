using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoListASC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /* Adding a new task to the ListView */
        private void AddItem_Click(object sender, EventArgs e)
        {
            ListView.SmallImageList = new ImageList();

            //Adding it to the actual GUI so I can see the additions
            var item = new ListViewItem();
            item.Text = TaskToEnter.Text;
            item.SubItems.Add(TaskDate.Text);
            item.SubItems.Add(TaskDescript.Text);
            
            ListView.Items.Add(item);
        }
        /* adding a task in the ListView */
        private void EditTask_Click(object sender, EventArgs e)
        {
            //If there is a selected item and one clicks the edit button we can 
            //begin to edit the item on the list. Otherwise nothing happens.
            if (ListView.SelectedItems.Count > 0)
            {
                //Getting the selected items index and then sending
                //the column data to the form that pops up 
                var index = ListView.FocusedItem.Index;
                string taskName = ListView.Items[index].Text;
                string dueDate = ListView.SelectedItems[0].SubItems[1].Text;
                string taskDescript = ListView.SelectedItems[0].SubItems[2].Text;

                //Now the form where we edit the tasks information is pre-populated
                //with whatever info was previously in it. When one clicks (Make Changes)
                //then the update is made
                using (EditForm dataToEdit = new EditForm())
                {
                    dataToEdit.mainForm = this;
                    dataToEdit.TaskToEnter.Text = taskName;
                    dataToEdit.TaskDate.Text = dueDate;
                    dataToEdit.TaskDescript.Text = taskDescript;
                    dataToEdit.ShowDialog();

                }
            }
            
        }
        /* 
        * When the user selects a row and clicks on the remove item
        * I loop through the listview and check if anything is selected
        * and if something is selected I remove it
        */
        private void RemoveItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListView.Items.Count; i++)
            {
                if (ListView.Items[i].Selected)
                {
                    ListView.Items[i].Remove();
                    i--;
                }
            }
        }
        /* 
        * When the user selects a row to move up I check if the row
        * is not at the top:
        *   if it is not I swap the index with the row data above it
        */
        private void MoveUp_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem row in ListView.SelectedItems)
            {
                if (row.Index > 0)
                {
                    int index = row.Index - 1;
                    ListView.Items.RemoveAt(row.Index);
                    ListView.Items.Insert(index, row);
                }
            }
        }
        /* 
        * When the user selects a row to move down I check if the row
        * is not at the bottom:
        *   if it is not I swap the index with the row data below it
        */
        private void MoveDown_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem row in ListView.SelectedItems)
            {
                if (row.Index < ListView.Items.Count-1)
                {
                    int index = row.Index + 1;
                    ListView.Items.RemoveAt(row.Index);
                    ListView.Items.Insert(index, row);
                }
            }
        }

        /* 
        * Here I save the items in the list view to a text file. 
        */
        private void SaveTasks_Click(object sender, EventArgs e)
        {
            string fileNameToSave = fileNameString.Text;
            StringBuilder sb;
            if (ListView.Items.Count >0)
            {
                using (StreamWriter sw = new StreamWriter(fileNameToSave + ".txt"))
                {
                    foreach (ListViewItem item in ListView.Items)
                    {
                        sb = new StringBuilder();
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            sb.Append(string.Format("{0}\t", subItem.Text));
                        }
                        sw.WriteLine(sb.ToString());
                    }
                    sw.WriteLine();
                }
                MessageBox.Show("List saved to" + fileNameToSave + ".txt");
            }
        }
        /* 
        * Here I load from a text file. (I load in any text file seperated by 
        * new lines in the column format)
        */
        private void LoadFile_Click(object sender, EventArgs e)
        {
            var fileLines = File.ReadAllLines(fileString.Text + ".txt");
            if (fileLines.Length > 0)
            {
                //Clearing the list view if previous items are inside
                ListView.Items.Clear();
                for (int i = 0; i < fileLines.Length-1; i++)
                {
                    var content = fileLines[i];
                    string[] rowContent = content.Split('\t');
                    ListView.Items.Add(
                        new ListViewItem(new[]
                        {
                            rowContent[0],
                            rowContent[1],
                            rowContent[2],
                        }));
                }
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
        }
    }
}
