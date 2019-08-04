using Matrix.Client;
using Matrix.Structures;
using MatrixApp.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatrixApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        public void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);

            RoomsViewModel rooms = GetUserRooms(user);

           if(user.CheckInformation())
            {
                foreach (var room in rooms.rooms)
                {
                    DisplayAlert(room.Name, room.Messages[1].ToString(), "okie");
                }

                
            }
            else
            {
              DisplayAlert("Login","Login not Correct", "okie");
            }
        }

        private RoomsViewModel GetUserRooms(User user)
        {
            string homeserverUrl = "https://matrix.org";
            MatrixClient client;
            string username = user.Username;
            string password = user.Password;
            client = new MatrixClient(homeserverUrl);
            MatrixLoginResponse login = client.LoginWithPassword(username, password);
           

            client.StartSync();
            RoomsViewModel rmv = new RoomsViewModel();
            rmv.rooms = client.GetAllRooms();


            return rmv;
        }
    }
}