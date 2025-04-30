using System;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
        private void addTaskButton_Click(object sender, EventArgs e)
        {

            string taskName = taskTextBox.Text;
            int taskDuration = (int)durationNumericUpDown.Value;

            
            ListViewItem item = new ListViewItem(taskName);
            item.SubItems.Add(taskDuration.ToString());
            item.SubItems.Add("Ожидает");

            taskListView.Items.Add(item);

           
            taskTextBox.Clear();
            durationNumericUpDown.Value = 5;
        }

        
        private void removeTaskButton_Click(object sender, EventArgs e)
        {
           
            if (taskListView.SelectedItems.Count > 0)
            {
                taskListView.Items.Remove(taskListView.SelectedItems[0]);
            }
        }

        
        private void startTimerButton_Click(object sender, EventArgs e)
        {
            
            if (taskListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedTask = taskListView.SelectedItems[0];
                int duration = int.Parse(selectedTask.SubItems[1].Text);

                
                selectedTask.SubItems[2].Text = "В процессе";

                countdownTimer.Tag = selectedTask; 
                countdownTimer.Start();
            }
        }
        
        private void pauseResumeButton_Click(object sender, EventArgs e)
        {
            if (countdownTimer.Tag is ListViewItem taskItem)
            {
                if (countdownTimer.Enabled)
                {
                    countdownTimer.Stop();
                    taskItem.SubItems[2].Text = "Пауза";
                }
                else
                {
                    countdownTimer.Start();
                    taskItem.SubItems[2].Text = "В процессе";
                }
            }
        }

        
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (countdownTimer.Tag is ListViewItem taskItem)
            {
                int remainingTime = int.Parse(taskItem.SubItems[1].Text) - 1;
                taskItem.SubItems[1].Text = remainingTime.ToString();

                
                if (remainingTime <= 0)
                {
                    countdownTimer.Stop();
                    taskItem.SubItems[2].Text = "Завершено";
                }
            }
        }
    }
}
