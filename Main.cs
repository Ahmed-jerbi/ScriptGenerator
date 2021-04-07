using System;
using System.Drawing;
using System.Windows.Forms;

namespace JungleDiamond
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

/// <summary>
/// Handles the choice of the functions in the dropdown: puts the corresponding Box in the active panel and shows it.
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void functionBox_indexChanged(object sender, EventArgs e)
        {
        
            switch (functionBox.SelectedItem.ToString())
            {
                case "Load SPS":
                    activePanel.Controls.Clear();
                    activePanel.Controls.Add(LoadBox);
                    LoadBox.Visible = true;
                    LoadBox.Location = new Point(0,0);
                    break;
                    

                case "Copy/transfer":
                    activePanel.Controls.Clear();
                    activePanel.Controls.Add(CopyBox);
                    CopyBox.Visible = true;
                    CopyBox.Location = new Point(0, 0);
                    break;

                case "Wait":
                    activePanel.Controls.Clear();
                    activePanel.Controls.Add(WaitBox);
                    WaitBox.Visible = true;
                    WaitBox.Location = new Point(0, 0);
                    break;

                case "Save":
                    activePanel.Controls.Clear();
                    activePanel.Controls.Add(WaitBox);
                    WaitBox.Visible = true;
                    WaitBox.Location = new Point(0, 0);
                    break;
                default:
                    activePanel.Controls.Clear();
                    Console.WriteLine("No Valid Selection");
                    break;
            }

            //activate the add button
            addButton.Enabled = true;


        }
        
/// <summary>
/// Adds the user entries to the ScriptList
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void addButton_click(object sender, EventArgs e)
        {
            //create a list item
            ListViewItem lvi = new ListViewItem();
            //fill the item depending on the function
            switch (functionBox.SelectedItem.ToString())
            {
                case "Load SPS":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(loadText.Text+".sps");
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                    //clear panel
                    activePanel.Controls.Clear();
                    break;


                case "Copy/transfer":
                    //Nb
                    lvi.Text = scriptList.Items.Count.ToString();
                    //Name
                    lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                    //argument
                    lvi.SubItems.Add(srcText.Text + ".sps --> "+ destText.Text);
                    //--> add the ScriptList
                    scriptList.Items.Add(lvi);
                    //clear panel
                    activePanel.Controls.Clear();
                    break;

                case "Wait":
                    activePanel.Controls.Clear();
                    activePanel.Controls.Add(WaitBox);
                    WaitBox.Visible = true;
                    WaitBox.Location = new Point(0, 0);
                    break;

                case "Save":
                    activePanel.Controls.Clear();
                    activePanel.Controls.Add(WaitBox);
                    WaitBox.Visible = true;
                    WaitBox.Location = new Point(0, 0);
                    break;
                default:
                    activePanel.Controls.Clear();
                    Console.WriteLine("No Valid Selection");
                    break;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
