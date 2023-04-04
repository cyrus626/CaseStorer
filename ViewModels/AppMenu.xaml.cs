using EFCC.Models;
using EFCC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EFCC.ViewModels
{
    /// <summary>
    /// Interaction logic for AppMenu.xaml
    /// </summary>
    public partial class AppMenu : Window
    {
        public AppMenu()
        {
            InitializeComponent();
            ShowAllCases();
        }
        //Buttons
        #region
        private void NewCase_Click(object sender, RoutedEventArgs e)
        {
            //Opens a new file for recording
            DocumentStatus.Type = "new";
            DocumentStatus.Id = 0;
            DocumentStatus.Name = "Enter Case title";
            DocumentStatus.Description = "Enter description";
            DocumentStatus.TimeSaved = "Never saved";
            OpenNewDocument();
        }

        private void ViewCase_Click(object sender, RoutedEventArgs e)
        {
            //View Selected case

            if (CaseList.SelectedItem is null)
            {
                MessageBox.Show("Info: Nothing is selected");
            }
            else
            {
                ViewSelectedCase();
                DocumentStatus.Type = "view";
                OpenNewDocument();
            }
        }

        private void UpdateCase_Click(object sender, RoutedEventArgs e)
        {
            if (CaseList.SelectedItem is null)
            {
                MessageBox.Show("Info: Nothing is selected");
            }
            else
            {
                ViewSelectedCase();
                DocumentStatus.Type = "update";
                OpenNewDocument();
            }
        }
        #endregion
        #region
        private void CaseList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //View Selected case
            ViewSelectedCase();
            DocumentStatus.Type = "view";
            OpenNewDocument();
        }
        #endregion
        //Other methods
        #region
        private void OpenNewDocument()
        {
            DocumentPanel documentPanel = new DocumentPanel();
            this.Close();
            documentPanel.Show();
        }
        private void ShowAllCases()
        {
            if (!(EFCCDB.GetAllCases() is null))
            {
                CaseList.ItemsSource = EFCCDB.GetAllCases();
                CaseList.DisplayMemberPath = nameof(CaseFile.Title);
            }
        }
        private void ViewSelectedCase()
        {
            CaseFile casefile = new CaseFile();
            casefile = CaseList.SelectedItem as CaseFile;
            DocumentStatus.Name = casefile.Title;
            DocumentStatus.Id = casefile.Id;
            DocumentStatus.Description = casefile.Description;
            DocumentStatus.TimeSaved = casefile.DateSaved;
        }
        #endregion
        //private void ShowFooter()
        //{
        //    Footer.Content = DateTime.Now.ToLocalTime().ToString();
        //}
    }
}
