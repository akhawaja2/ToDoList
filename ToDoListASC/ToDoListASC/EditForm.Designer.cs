namespace ToDoListASC
{
    public partial class EditForm
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
            this.TaskDescript = new System.Windows.Forms.RichTextBox();
            this.TaskDate = new System.Windows.Forms.TextBox();
            this.TaskToEnter = new System.Windows.Forms.TextBox();
            this.CompleteEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskDescript
            // 
            this.TaskDescript.Location = new System.Drawing.Point(38, 87);
            this.TaskDescript.Name = "TaskDescript";
            this.TaskDescript.Size = new System.Drawing.Size(138, 96);
            this.TaskDescript.TabIndex = 14;
            this.TaskDescript.Text = "Enter Task Description Here";
            // 
            // TaskDate
            // 
            this.TaskDate.Location = new System.Drawing.Point(38, 59);
            this.TaskDate.Name = "TaskDate";
            this.TaskDate.Size = new System.Drawing.Size(138, 22);
            this.TaskDate.TabIndex = 13;
            this.TaskDate.Text = "Enter Due Date Here";
            // 
            // TaskToEnter
            // 
            this.TaskToEnter.Location = new System.Drawing.Point(38, 31);
            this.TaskToEnter.Name = "TaskToEnter";
            this.TaskToEnter.Size = new System.Drawing.Size(138, 22);
            this.TaskToEnter.TabIndex = 12;
            this.TaskToEnter.Text = "Enter Task Name Here";
            // 
            // CompleteEdit
            // 
            this.CompleteEdit.Location = new System.Drawing.Point(38, 206);
            this.CompleteEdit.Name = "CompleteEdit";
            this.CompleteEdit.Size = new System.Drawing.Size(138, 46);
            this.CompleteEdit.TabIndex = 15;
            this.CompleteEdit.Text = "Make Changes";
            this.CompleteEdit.UseVisualStyleBackColor = true;
            this.CompleteEdit.Click += new System.EventHandler(this.CompleteEdit_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 293);
            this.Controls.Add(this.CompleteEdit);
            this.Controls.Add(this.TaskDescript);
            this.Controls.Add(this.TaskDate);
            this.Controls.Add(this.TaskToEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox TaskDescript;
        public System.Windows.Forms.TextBox TaskDate;
        public System.Windows.Forms.TextBox TaskToEnter;
        private System.Windows.Forms.Button CompleteEdit;
    }
}