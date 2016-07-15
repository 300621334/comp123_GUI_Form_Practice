using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //individual check box
            if (checkBox1.Checked)
            {
                MessageBox.Show("First CheckBox", "checkBox1");
            }
            //group of chk boxes=checkListBox
            if (checkedListBox1.CheckedItems.Contains("Lunch"))
            {
                MessageBox.Show("Second CheckListBox Checked", "checkedListBox1");
            }
            //Drop Down List=comboBox
            if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("Second ComboBox Selected", "comboBox1");
            }
            //numbers with spinner=numericUpDown
            if (numericUpDown1.Value >=60  && numericUpDown1.Value <= 80)
          {
              MessageBox.Show("numericUpDown value between 60-80", "numericUpDown1");
          }
            //radioButton if inside a 'group box' only one can be selected.
            if (radioButton1.Checked)
            {
                MessageBox.Show("radioButton1 checked", "radioButton1");
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("radioButton2 checked", "radioButton2");
            }
            //radBtn out in open take whole window as it's container. Onlt one can be selected inside that window acting as container.
            if (radioButton4.Checked)
            {
                MessageBox.Show("radioButton4 checked", "radioButton4");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  System.Diagnostics.Process.Start("http://www.hotmail.com");
            System.Diagnostics.Process.Start("http://google.com");
        }


        //Date time custon format: http://stackoverflow.com/questions/13711358/datetime-picker-c-sharp-format
        //select 'custom' in 'Format' & then type 'dd-MMM-yyyy  hh:mm' in 'Custom Format'
        //code for formatting is located in 'Form1.Designer.cs' file.
        private void button1_Click(object sender, EventArgs e)
        {
           




            ////displays today's date
            //DateTime today = DateTime.Now; 
            //MessageBox.Show(today.ToString());


            ////to desplay what user selected from picker:
            //MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show(dateTimePicker1.Value.ToString("dd-MMM-yyyy hh:mm tt")); //hhmm=12hr HHMM=24hr.tt=AM/PM
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(maskedTextBox1.Text);
            //f.Show(); //can switch b/w 2 windows
            f.ShowDialog(); //2nd window becomes a dialogue box & cannot switch to Form1 till u close Form2.

        }


        //hide Form1 & display icon in sys tray & a balloonTip window with a message
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides form1 & icon shown in sys Tray.
            notifyIcon1.ShowBalloonTip(2000, "Still Running", "icon in system Tray", ToolTipIcon.Info);
        }

        //click NotifyIcon1 & click Bolt sign for events>>doubleclich in empty box aft MouseDoubleClick>>this event is created. type this.show. In systen tray, click icon to bring up the Form1 to foreground
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        //single click also display Form1
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
