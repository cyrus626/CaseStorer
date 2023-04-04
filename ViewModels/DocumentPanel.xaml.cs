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
using EFCC.Models;
using EFCC.Services;
namespace EFCC.ViewModels
{
    /// <summary>
    /// Interaction logic for DocumentPanel.xaml
    /// </summary>
    public partial class DocumentPanel : Window
    {
        private CaseFile caseFile { get; set; }
        public DocumentPanel()
        {
            InitializeComponent();
            switch (DocumentStatus.Type)
            {
                case "new": IsNewDocument();
                    break;
                case "view": IsViewDocument();
                    break;
                case "update": IsUpdateDocument();
                    break;
            }
            //TimeSaved.Content = DateTime.Today.ToString();
        }
        private void IsNewDocument()
        {
            Save.Visibility = Visibility.Visible;
            Update.Visibility = Visibility.Hidden;
            Edit.Visibility = Visibility.Hidden;
            DocContentRichTxtBox.Visibility = Visibility.Visible;
            DocContnetTxtBlock.Visibility = Visibility.Hidden;
            
            CaseTitleTextBox.Visibility = Visibility.Visible;
            CaseTitleTextBox.Text = DocumentStatus.Name;
            CaseTitle.Visibility = Visibility.Hidden;
        }
        private void IsUpdateDocument()
        {
            Save.Visibility = Visibility.Hidden;
            Update.Visibility = Visibility.Visible;
            Edit.Visibility = Visibility.Hidden;

            DocContentRichTxtBox.Visibility = Visibility.Visible;
            DocContnetTxtBlock.Visibility = Visibility.Visible;
            DocContnetTxtBlock.Text = DocumentStatus.Description;

            //Makes the title box editable
            CaseTitleTextBox.Visibility = Visibility.Visible;
            CaseTitleTextBox.Text = DocumentStatus.Name;
            CaseTitle.Visibility = Visibility.Hidden;
            DocContentRichTxtBox.Focus();
            DocContentRichTxtBox.SelectAll();

        }
        private void IsViewDocument()
        {
            Save.Visibility = Visibility.Hidden;
            Update.Visibility = Visibility.Hidden;
            Edit.Visibility = Visibility.Visible;

            //Set TextBlock to visible
            DocContentRichTxtBox.Visibility = Visibility.Hidden;
            DocContnetTxtBlock.Visibility = Visibility.Visible;
            DocContnetTxtBlock.Text = DocumentStatus.Description;

            //Sets the title box to dispaly the title only
            CaseTitleTextBox.Visibility = Visibility.Hidden;
            CaseTitle.Visibility = Visibility.Visible;
            CaseTitle.Content = DocumentStatus.Name;
        }
        private void SavingData()
        {
            caseFile = new CaseFile();
            caseFile.Title = CaseTitleTextBox.Text;
            DocumentStatus.Name = caseFile.Title;
            if (DocumentStatus.Type == "new")
            {
                caseFile.Description = $"[{DateTime.Now}]: {ConvertDocumentToString()}\n";
            }
            else
            {
                caseFile.Description = $"{DocumentStatus.Description}\n" +
                $"[{DateTime.Now}]: {ConvertDocumentToString()}";
            }
            caseFile.DateSaved = DateTime.Now.ToString();
            caseFile.Id = DocumentStatus.Id;

            EFCCDB.SaveCase(caseFile);

            DocumentStatus.Type = "view";
            DocumentStatus.TimeSaved = caseFile.DateSaved;
            DocumentStatus.Description = caseFile.Description;
            DocumentStatus.Id = caseFile.Id;
        }
        //buttons
        #region
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //Saves the document
            SavingData();
            IsViewDocument();
        }
        
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //Finally updates the document
            SavingData();
            IsViewDocument();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            IsUpdateDocument();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            AppMenu appMenu = new AppMenu();
            this.Close();
            appMenu.Show();
        }
        private string ConvertDocumentToString()
        { 
            // Convertion of Rich text box contents to string.
            TextRange textRange = new TextRange(
                DocContentRichTxtBox.Document.ContentStart,
                DocContentRichTxtBox.Document.ContentEnd);
            return textRange.Text;
        }

        #endregion

        private void DocContentRichTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                e.Handled = true;
                DocContentRichTxtBox.CaretPosition.InsertTextInRun("\r");
            }
            
        }
    }
}
