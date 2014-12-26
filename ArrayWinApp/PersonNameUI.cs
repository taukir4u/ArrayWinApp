using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace ArrayWinApp
{
    public partial class PersonNameUI : Form
    {

        string[] mylist = new string[10];
        ArrayList personList = new ArrayList();
       
        public PersonNameUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            personList.Add(nameBox.Text);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            foreach (string aName in personList)
            {
                    nameListBox.Items.Add(aName);
            }
            
            countBox.Text = personList.Count.ToString();

        }
    }
}
