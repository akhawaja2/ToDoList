using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListASC
{
    public partial class EditForm : Form
    {
        //Getting data from the Listview in the other form
        public Main mainForm;
        public EditForm()
        {
            InitializeComponent();
            
        }

        /* In this function I make the changes to the item in the list view and then update it */
        private void CompleteEdit_Click(object sender, EventArgs e)
        {
            //Index of the selected item
            var index = mainForm.ListView.FocusedItem.Index;
            mainForm.ListView.Items[index].Text = TaskToEnter.Text;
            mainForm.ListView.SelectedItems[0].SubItems[1].Text = TaskDate.Text;
            mainForm.ListView.SelectedItems[0].SubItems[2].Text = TaskDescript.Text;

            this.Hide();
        }
    }
}
