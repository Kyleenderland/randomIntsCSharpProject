using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace randomInts
{
    public partial class Form1 : Form
    {
        public List<ListViewItem> mainDataList = new List<ListViewItem>();
        public Color[] colors = { Color.Red, Color.Yellow, Color.White };
        delegate ListViewItem sortDescendingItems(ListViewItem item);
        public Form1()
        {
            InitializeComponent();
            initializeColorLists();
            initializeListView();
        }

        public void initializeListView(){
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                ListViewItem newListItem = new ListViewItem();
                newListItem.Text = (rand.Next(100) + 1).ToString();
                newListItem.BackColor = colors[i % colors.Length];
                mainDataList.Add(newListItem);
            }

            foreach (ListViewItem currentItem in mainDataList)
            {
                listView1.Items.Add(currentItem);
            }//foreach
        }//'initializeListView'

        private void updateListView(){
            foreach (ListViewItem currentItem in listView1.Items) listView1.Items.Remove( currentItem );
            foreach (ListViewItem currentItem in mainDataList) listView1.Items.Add( currentItem );
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            updateListView();
            switch (sortAscDescComboBox.SelectedIndex)
            {
                case 0:
                    listView1.Sorting = (SortOrder.Ascending);
                    break;
                case 1:
                    listView1.Sorting = SortOrder.Descending;
                    break;
                default:
                    break;
            }//switch

            switch (sortEvenOddComboBox.SelectedIndex)
            {
                case 0:
                    foreach (ListViewItem currentItem in listView1.Items)
                        if (int.Parse(currentItem.Text) % 2 == 1)
                        {
                            listView1.Items.Remove(currentItem);
                        }
                    break;
                case 1:
                    foreach (ListViewItem currentItem in listView1.Items)
                        if (int.Parse(currentItem.Text) % 2 == 0)
                        {
                            listView1.Items.Remove(currentItem);
                        }
                    break;
                default:
                    break;
            }

            if (sortColorComboBox.SelectedItem != null)
            {
                foreach (ListViewItem currentItem in listView1.Items)
                {
                    if (currentItem.BackColor != colors[sortColorComboBox.SelectedIndex])
                    {
                        listView1.Items.Remove(currentItem);
                    }//if
                }//foreach
            }//if
        }//'Sort_Click'

        private void initializeColorLists()
        {
            Random rand = new Random();
            int loopCounter = 0;

            foreach (ListViewItem currentItem in mainDataList)
            {
                label1.Text = currentItem.ToString();
                currentItem.Text = (rand.Next(100) + 1).ToString();
                currentItem.BackColor = colors[loopCounter % colors.Length];
                loopCounter++;
            }

            foreach (Color currentColor in colors)
            {
                String colorName = currentColor.ToString().Substring(7).Trim(']');
                sortColorComboBox.Items.Add(colorName);
                delColorComboBox.Items.Add(colorName);
            } //foreach
        } //'initializeList'

        private void Remove_Click(object sender, EventArgs e)
        {
            List<ListViewItem> mainDataCopy = new List<ListViewItem>();
            foreach (ListViewItem currentItem in mainDataList){
                mainDataCopy.Add( currentItem );
            }

            switch (delEvenOddComboBox.SelectedIndex){
                case 0:
                    foreach (ListViewItem currentItem in mainDataList){
                        if ((int.Parse(currentItem.Text)) % 2 == 0){
                            mainDataCopy.Remove(currentItem);
                        }//if
                    }//foreach
                    break;
                case 1:
                    foreach (ListViewItem currentItem in mainDataList)
                    {
                        if ((int.Parse(currentItem.Text)) % 2 == 1)
                        {
                            mainDataCopy.Remove(currentItem);
                        }//if
                    }//foreach
                    break;
                default:
                    break;
            }//switch

            if (delColorComboBox.SelectedItem != null) {
                foreach (ListViewItem currentItem in mainDataList){
                    if (currentItem.BackColor == colors[delColorComboBox.SelectedIndex]) mainDataCopy.Remove( currentItem );
                } //foreach
            }; //if


            mainDataList.Clear();
            foreach (ListViewItem currentItem in mainDataCopy){
                mainDataList.Add(currentItem);
            }
            updateListView();
        }//'Remove_Click'

        private void reset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            mainDataList.Clear();
            initializeListView();
        }
    }//'Form1'
}//namespace
