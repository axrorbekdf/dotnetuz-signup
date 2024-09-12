using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using dotnetuz_signup.ServiceLayer.User;
using dotnetuz_signup.ServiceLayer.User.Concrete;

namespace dotnetuz_signup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();


        IUserService userService = new UserService();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var users = await userService.GetALl();
            //MessageBox.Show("Userlarni soni:"+users.Count().ToString);

            //var user = await userService.Get(1);
            //MessageBox.Show("Userlarni soni:"+user.ToString);

            //acountFullNameTxt.Text = user.Firstname + " " + user.Lastname;
            //userFirstNameTxt.Text = user.Firstname;
            //userLastNameTxt.Text = user.Lastname;
            //userUsernameTxt.Text = user.Username;
            //userPhoneTxt.Text = user.Phone;
            //userCarTxt.Text = user.CarID;

        }

        private async void signUpBtn_Click(object sender, RoutedEventArgs e)
        {
            //UserModel userModel = new UserModel()
            //{
            //    Firstname = firstNameTxt.Text,
            //    Lastname = lastNameTxt.Text,
            //    Username = usernameTxt.Text,
            //    Phone = phoneTxt.Text,
            //    CarID = int.Parse(carTxt.Text),
            //};

            //bool res = await userService.Post(userModel);

            //if (res == true)
            //{
            //    MessageBox.Show("Saved successfuly!");
            //    mainTabControl.TabIndex = 1;
            //}
            //else
            //{
            //    MessageBox.Show("There are some errors!");
            //}


            UserModel userModel = new UserModel()
            {
                Firstname = firstNameTxt.Text,
                Lastname = lastNameTxt.Text,
                Username = usernameTxt.Text,
                Phone = phoneTxt.Text,
                CarID = int.Parse(carTxt.Text),
            };

            int ID = int.Parse(IDTxt.Text);

            bool res = await userService.Update(ID, userModel);

            if (res == true)
            {
                MessageBox.Show("Updated successfuly!");
                mainTabControl.TabIndex = 1;
            }
            else
            {
                MessageBox.Show("There are some errors!");
            }
        }

        private void logoutBtn_click(object sender, RoutedEventArgs e)
        {
            mainTabControl.TabIndex = 0;
            firstNameTxt.Clear();
            lastNameTxt.Clear();
            usernameTxt.Clear();
            phoneTxt.Clear();
            carTxt.Clear();
        }
    }
}