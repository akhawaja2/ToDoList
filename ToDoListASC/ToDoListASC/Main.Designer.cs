namespace ToDoListASC
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddItem = new System.Windows.Forms.Button();
            this.TaskToEnter = new System.Windows.Forms.TextBox();
            this.EditTask = new System.Windows.Forms.Button();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.TaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskDate = new System.Windows.Forms.TextBox();
            this.TaskDescript = new System.Windows.Forms.RichTextBox();
            this.SaveTasks = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.fileString = new System.Windows.Forms.TextBox();
            this.fileNameString = new System.Windows.Forms.TextBox();
            this.ClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(39, 204);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(107, 40);
            this.AddItem.TabIndex = 0;
            this.AddItem.Text = "Add List Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // TaskToEnter
            // 
            this.TaskToEnter.Location = new System.Drawing.Point(18, 22);
            this.TaskToEnter.Name = "TaskToEnter";
            this.TaskToEnter.Size = new System.Drawing.Size(155, 22);
            this.TaskToEnter.TabIndex = 2;
            this.TaskToEnter.Text = "Enter Task Name Here";
            // 
            // EditTask
            // 
            this.EditTask.Location = new System.Drawing.Point(39, 250);
            this.EditTask.Name = "EditTask";
            this.EditTask.Size = new System.Drawing.Size(107, 44);
            this.EditTask.TabIndex = 4;
            this.EditTask.Text = "Edit Task";
            this.EditTask.UseVisualStyleBackColor = true;
            this.EditTask.Click += new System.EventHandler(this.EditTask_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Location = new System.Drawing.Point(39, 300);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(107, 43);
            this.RemoveItem.TabIndex = 5;
            this.RemoveItem.Text = "Remove List Item";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(39, 349);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(107, 49);
            this.MoveUp.TabIndex = 6;
            this.MoveUp.Text = "Move Task Priority Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(39, 404);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(107, 48);
            this.MoveDown.TabIndex = 7;
            this.MoveDown.Text = "Move Task Priority Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskName,
            this.DueDate,
            this.TaskDesc});
            this.ListView.HideSelection = false;
            this.ListView.LabelEdit = true;
            this.ListView.Location = new System.Drawing.Point(179, 22);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(639, 330);
            this.ListView.TabIndex = 8;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // TaskName
            // 
            this.TaskName.Text = "Task Name";
            this.TaskName.Width = 129;
            // 
            // DueDate
            // 
            this.DueDate.Text = "Due Date";
            this.DueDate.Width = 135;
            // 
            // TaskDesc
            // 
            this.TaskDesc.Text = "Task Description";
            this.TaskDesc.Width = 323;
            // 
            // TaskDate
            // 
            this.TaskDate.Location = new System.Drawing.Point(18, 61);
            this.TaskDate.Name = "TaskDate";
            this.TaskDate.Size = new System.Drawing.Size(155, 22);
            this.TaskDate.TabIndex = 10;
            this.TaskDate.Text = "Enter Due Date Here";
            // 
            // TaskDescript
            // 
            this.TaskDescript.Location = new System.Drawing.Point(18, 89);
            this.TaskDescript.Name = "TaskDescript";
            this.TaskDescript.Size = new System.Drawing.Size(155, 96);
            this.TaskDescript.TabIndex = 11;
            this.TaskDescript.Text = "Enter Task Description Here";
            // 
            // SaveTasks
            // 
            this.SaveTasks.Location = new System.Drawing.Point(188, 418);
            this.SaveTasks.Name = "SaveTasks";
            this.SaveTasks.Size = new System.Drawing.Size(123, 47);
            this.SaveTasks.TabIndex = 12;
            this.SaveTasks.Text = "Save all tasks";
            this.SaveTasks.UseVisualStyleBackColor = true;
            this.SaveTasks.Click += new System.EventHandler(this.SaveTasks_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(345, 417);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(150, 47);
            this.LoadFile.TabIndex = 13;
            this.LoadFile.Text = "Load in List";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // fileString
            // 
            this.fileString.Location = new System.Drawing.Point(345, 362);
            this.fileString.Multiline = true;
            this.fileString.Name = "fileString";
            this.fileString.Size = new System.Drawing.Size(150, 49);
            this.fileString.TabIndex = 14;
            this.fileString.Text = "Enter text file name to load here";
            // 
            // fileNameString
            // 
            this.fileNameString.Location = new System.Drawing.Point(188, 362);
            this.fileNameString.Multiline = true;
            this.fileNameString.Name = "fileNameString";
            this.fileNameString.Size = new System.Drawing.Size(121, 49);
            this.fileNameString.TabIndex = 15;
            this.fileNameString.Text = "Enter File name to Save to a text file";
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(534, 389);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(122, 46);
            this.ClearList.TabIndex = 16;
            this.ClearList.Text = "Clear List";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 515);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.fileNameString);
            this.Controls.Add(this.fileString);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.SaveTasks);
            this.Controls.Add(this.TaskDescript);
            this.Controls.Add(this.TaskDate);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.RemoveItem);
            this.Controls.Add(this.EditTask);
            this.Controls.Add(this.TaskToEnter);
            this.Controls.Add(this.AddItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Abu Khawaja - Advanced System Concepts To-Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.TextBox TaskToEnter;
        private System.Windows.Forms.Button EditTask;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveDown;
        public System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader TaskName;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ColumnHeader TaskDesc;
        private System.Windows.Forms.TextBox TaskDate;
        private System.Windows.Forms.RichTextBox TaskDescript;
        private System.Windows.Forms.Button SaveTasks;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.TextBox fileString;
        private System.Windows.Forms.TextBox fileNameString;
        private System.Windows.Forms.Button ClearList;
    }
}

