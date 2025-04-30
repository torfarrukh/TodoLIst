using System.Drawing;
using System.Windows.Forms;

namespace project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox taskTextBox;
        private Label label2;
        private NumericUpDown durationNumericUpDown;
        private Button addTaskButton;
        private ListView taskListView;
        private ColumnHeader Task;
        private ColumnHeader Duration;
        private ColumnHeader Status;
        private Button removeTaskButton;
        private Button startTimerButton;
        private Timer countdownTimer;
        private Button pauseResumeButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            taskTextBox = new TextBox();
            label2 = new Label();
            durationNumericUpDown = new NumericUpDown();
            addTaskButton = new Button();
            taskListView = new ListView();
            Task = new ColumnHeader();
            Duration = new ColumnHeader();
            Status = new ColumnHeader();
            removeTaskButton = new Button();
            startTimerButton = new Button();
            countdownTimer = new Timer(components);
            pauseResumeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)durationNumericUpDown).BeginInit();
            SuspendLayout();
             
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Действие";
             
            taskTextBox.Location = new Point(125, 25);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(156, 23);
            taskTextBox.TabIndex = 1;
             
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 2;
            label2.Text = "Длительность\r\n(в минутах)";
            
            durationNumericUpDown.Location = new Point(125, 77);
            durationNumericUpDown.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            durationNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            durationNumericUpDown.Name = "durationNumericUpDown";
            durationNumericUpDown.Size = new Size(107, 23);
            durationNumericUpDown.TabIndex = 3;
            durationNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
         
            addTaskButton.Location = new Point(12, 367);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(188, 71);
            addTaskButton.TabIndex = 4;
            addTaskButton.Text = "Добавить";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            
            taskListView.Columns.AddRange(new ColumnHeader[] { Task, Duration, Status });
            taskListView.Location = new Point(335, 12);
            taskListView.Name = "taskListView";
            taskListView.Size = new Size(453, 198);
            taskListView.TabIndex = 5;
            taskListView.UseCompatibleStateImageBehavior = false;
            taskListView.View = View.Details;
           
            Task.Text = "Действие";
            Task.Width = 200;
             
            Duration.Text = "Длительность";
            Duration.Width = 150;
            
            Status.Text = "Статус";
            Status.Width = 100;
            removeTaskButton.Location = new Point(206, 367);
            removeTaskButton.Name = "removeTaskButton";
            removeTaskButton.Size = new Size(188, 71);
            removeTaskButton.TabIndex = 6;
            removeTaskButton.Text = "Удалить";
            removeTaskButton.UseVisualStyleBackColor = true;
            removeTaskButton.Click += removeTaskButton_Click;
            startTimerButton.Location = new Point(412, 367);
            startTimerButton.Name = "startTimerButton";
            startTimerButton.Size = new Size(180, 71);
            startTimerButton.TabIndex = 7;
            startTimerButton.Text = "Начать таймер";
            startTimerButton.UseVisualStyleBackColor = true;
            startTimerButton.Click += startTimerButton_Click;
            // 
            // pauseResumeButton
            // 
            pauseResumeButton.Location = new Point(614, 367);
            pauseResumeButton.Name = "pauseResumeButton";
            pauseResumeButton.Size = new Size(174, 71);
            pauseResumeButton.TabIndex = 8;
            pauseResumeButton.Text = "Пауза/Возобновить";
            pauseResumeButton.UseVisualStyleBackColor = true;
            pauseResumeButton.Click += pauseResumeButton_Click;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pauseResumeButton);
            Controls.Add(startTimerButton);
            Controls.Add(removeTaskButton);
            Controls.Add(taskListView);
            Controls.Add(addTaskButton);
            Controls.Add(durationNumericUpDown);
            Controls.Add(label2);
            Controls.Add(taskTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Task Management";
            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)durationNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
