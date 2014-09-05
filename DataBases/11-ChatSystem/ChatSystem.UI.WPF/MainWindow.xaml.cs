using ChatSystem.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatSystem.UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string username;
        private MongoChatSystemDatabase data;

        public MainWindow()
        {
            InitializeComponent();
            var connectionConfiguration = ConfigurationManager.ConnectionStrings["MongoDBConnection"];
            this.data = new MongoChatSystemDatabase(connectionConfiguration.ConnectionString);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("Username cannot be whitespace, null or empty!");
            }
            else
            {
                this.loginPrompt.Visibility = Visibility.Hidden;
                this.chatRoom.Visibility = Visibility.Visible;

                this.username = this.txtUsername.Text;
                this.LoadMessages();
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMessage.Text))
            {
                MessageBox.Show("Message cannot be whitespace, null or empty!");
            }
            else
            {
                data.AddNewMessage(this.txtMessage.Text, this.username);
                this.txtMessage.Clear();
                this.LoadMessages();
            }
        }

        private void LoadMessages()
        {
            this.lbMessages.Items.Clear();

            var messages = data.GetAllMessages();
            var messagePattern = "{0}: {1}";
            foreach (var message in messages)
            {
                var textElement = new TextBlock();
                textElement.Text = string.Format(messagePattern, message.User.Name, message.Text);
                this.lbMessages.Items.Add(textElement);
            }

            this.lbMessages.SelectedIndex = this.lbMessages.Items.Count - 1;
            this.lbMessages.ScrollIntoView(this.lbMessages.SelectedItem);
        }
    }
}
