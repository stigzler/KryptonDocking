using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Toolkit;
using KryptonDocking.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Console = KryptonDocking.UserControls.Console;
using PropertyGrid = KryptonDocking.UserControls.PropertyGrid;

namespace KryptonDocking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Console console = new Console();

        int pageCount = 2;

        private void Form1_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = dockingManager.ManageWorkspace("Workspace", kryptonDockableWorkspace1);
            dockingManager.ManageControl("Control", kryptonPanel1, w);
            dockingManager.ManageFloating("Floating", this);


            dockingManager.AddDockspace("Control", DockingEdge.Left, new KryptonPage[] { NewPage(new SelectorList() , "Selector") } );
            dockingManager.AddDockspace("Control", DockingEdge.Right, new KryptonPage[] { NewPage(new PropertyGrid() , "Properites") });
            dockingManager.AddToWorkspace("Workspace", new KryptonPage[] { NewPage(new TextEditor(), "Text Document"), NewPage(new TextEditor(), "Text Document 2") });
                      

            console.AddText("Persisted docking states not loaded.");
            console.AddText("My.Settings location: " + ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath);

        }

        private KryptonPage NewPage(Control control, string controlName)
        {
            // Create and uniquely name the page
            KryptonPage page = new KryptonPage();
            page.Text = controlName;
            page.TextTitle = page.Text;
            page.UniqueName = page.Text;

            control.Dock = DockStyle.Fill;
            page.Controls.Add(control);

            return page;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.DockingPersistenceString = Convert.ToBase64String(dockingManager.SaveConfigToArray());
            Properties.Settings.Default.Save();
        }

        private void LoadWindowsBT_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DockingPersistenceString != "")
                dockingManager.LoadConfigFromArray(Convert.FromBase64String(Properties.Settings.Default.DockingPersistenceString));
            console.AddText("Windows Loaded.");
        }

        private void ResetDockingBT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DockingPersistenceString = "";
            Properties.Settings.Default.Save();
            console.AddText("Docking Persistence String reset to null.");
        }

        private void SaveDockingBT_Click(object sender, EventArgs e)
        {
            SaveWindows();
            console.AddText("Windows Saved.");
        }

        private void SaveWindows()
        {
            Properties.Settings.Default.DockingPersistenceString = Convert.ToBase64String(dockingManager.SaveConfigToArray());
            Properties.Settings.Default.Save();
        }

        private void ViewWindowsStringBT_Click(object sender, EventArgs e)
        {
            console.AddText("Docking Persistence String:");
            console.AddText(Properties.Settings.Default.DockingPersistenceString);
        }

        private void AddTextDocumentBT_Click(object sender, EventArgs e)
        {
            pageCount += 1;
            dockingManager.AddToWorkspace("Workspace", new KryptonPage[] { NewPage(new TextEditor() { Name = $"Text Document {pageCount}" }, $"Text Document {pageCount}") });
            console.AddText($"New Document added. No of Workspace Cells: {dockingManager.Cells.Count()}. No of Pages: {dockingManager.Pages.Count()}");



        }

        private void GetInfoBT_Click(object sender, EventArgs e)
        {
            console.AddText("State Info:");
            console.AddText($"No of Workspace Cells: {dockingManager.Cells.Count()}. No of Pages: {dockingManager.Pages.Count()}");
            console.AddText("Pages:");
            foreach (var page in dockingManager.Pages)
            {
                console.AddText($"Name: {page.TextTitle}. Size: {page.ClientSize}");
            }
        }
    }
}
