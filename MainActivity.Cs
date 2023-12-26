using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using static Android.Icu.Text.IDNA;
using static Java.Util.Jar.Attributes;

namespace TicTacToe
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, reset, btnx, btno; // Buttons
        TextView info; // TextView
        int count_X = 0, count_O = 0, count_winnings_X = 0, count_winnings_O = 0;
        bool winner_X = false, winner_O = false, tie = true, game_started = false, x_turn = false, o_turn = false;
        int[,] TicTac = {   { -1, -1, -1 },  // Matrix, 1 - X, 0 - O
                            { -1, -1, -1 }, 
                            { -1, -1, -1 } };

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btn1 = FindViewById<Button>(Resource.Id.btn1);
            btn2 = FindViewById<Button>(Resource.Id.btn2);
            btn3 = FindViewById<Button>(Resource.Id.btn3);
            btn4 = FindViewById<Button>(Resource.Id.btn4);
            btn5 = FindViewById<Button>(Resource.Id.btn5);
            btn6 = FindViewById<Button>(Resource.Id.btn6);
            btn7 = FindViewById<Button>(Resource.Id.btn7);
            btn8 = FindViewById<Button>(Resource.Id.btn8);
            btn9 = FindViewById<Button>(Resource.Id.btn9);
            reset = FindViewById<Button>(Resource.Id.reset);
            btnx = FindViewById<Button>(Resource.Id.btnx);
            btno = FindViewById<Button>(Resource.Id.btno);
            info = FindViewById<TextView>(Resource.Id.info);


            // If one of the buttons is clicked
            btn1.Click += Btn_Click;
            btn2.Click += Btn_Click;
            btn3.Click += Btn_Click;
            btn4.Click += Btn_Click;
            btn5.Click += Btn_Click;
            btn6.Click += Btn_Click;
            btn7.Click += Btn_Click;
            btn8.Click += Btn_Click;
            btn9.Click += Btn_Click;
            reset.Click += Btn_Click;
            btno.Click += Btn_Click;
            btnx.Click += Btn_Click;

        }
        private void Btn_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;



            if (btno == btn) // If the player chose to be the O player
            {
                // Changing the the buttons to invisible
                btno.Visibility = Android.Views.ViewStates.Invisible;
                btnx.Visibility = Android.Views.ViewStates.Invisible;
                o_turn = true;
                game_started = true; // The game has started
                info.Text = $"Count O: {count_winnings_O}\nCount X: {count_winnings_X}"; // Changing the text and showing how many wins each player has
            }
            if (btnx == btn) // If the player chose to be the X player
            {
                // Changing the the buttons to invisible
                btno.Visibility = Android.Views.ViewStates.Invisible;
                btnx.Visibility = Android.Views.ViewStates.Invisible;
                x_turn = true;
                game_started = true; // The game has started
                info.Text = $"Count O: {count_winnings_O}\nCount X: {count_winnings_X}"; // Changing the text and showing how many wins each player has

            }

            if (btn == btn1 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[0, 0] == -1) //If it is the turn of X and the button is empty
                {
                    btn1.Text = "X"; // Changing the button text to X
                    TicTac[0, 0] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                }
                else if(o_turn && TicTac[0, 0] == -1) //If it is the turn of O and the button is empty
                {
                    btn1.Text = "O"; // Changing the button text to O
                    TicTac[0, 0] = 0; // Entering the value into the matrix
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player X Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if (btn == btn2 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[0, 1] == -1) //If it is the turn of X and the button is empty
                {
                    btn2.Text = "X"; // Changing the button text to X
                    TicTac[0, 1] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                }
                else if(o_turn && TicTac[0, 1] == -1) //If it is the turn of O and the button is empty
                {
                    btn2.Text = "O"; // Changing the button text to O
                    TicTac[0, 1] = 0; // Entering the value into the matrix
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player X Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if (btn == btn3 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[0, 2] == -1) //If it is the turn of X and the button is empty
                {
                    btn3.Text = "X"; // Changing the button text to X
                    TicTac[0, 2] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                } 
                else if(o_turn && TicTac[0, 2] == -1) //If it is the turn of O and the button is empty
                {
                    btn3.Text = "O"; // Changing the button text to O
                    TicTac[0, 2] = 0; // Entering the value into the matrix
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player X Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if (btn == btn4 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[1, 0] == -1) //If it is the turn of X and the button is empty
                {
                    btn4.Text = "X"; // Changing the button text to X
                    TicTac[1, 0] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                }
                else if(o_turn && TicTac[1, 0] == -1) //If it is the turn of O and the button is empty
                {
                    btn4.Text = "O"; // Changing the button text to O
                    TicTac[1, 0] = 0; // Entering the value into the matrix
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player X Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if (btn == btn5 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[1, 1] == -1) //If it is the turn of X and the button is empty
                {

                    btn5.Text = "X"; // Changing the button text to X
                    TicTac[1, 1] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                }
                else if (o_turn && TicTac[1, 1] == -1) //If it is the turn of O and the button is empty
                {
                    btn5.Text = "O"; // Changing the button text to O
                    TicTac[1, 1] = 0; // Entering the value into the matrix
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player X Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if (btn == btn6 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[1, 2] == -1) //If it is the turn of X and the button is empty
                {
                    btn6.Text = "X"; // Changing the button text to X
                    TicTac[1, 2] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                }
                else if (o_turn && TicTac[1, 2] == -1) //If it is the turn of O and the button is empty
                {
                    btn6.Text = "O"; // Changing the button text to O
                    TicTac[1, 2] = 0; // Entering the value into the matrix
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player XO Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if (btn == btn7 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[2, 0] == -1) //If it is the turn of X and the button is empty
                {
                    btn7.Text = "X"; // Changing the button text to X
                    TicTac[2, 0] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                }
                else if (o_turn && TicTac[2, 0] == -1) //If it is the turn of O and the button is empty
                {
                    btn7.Text = "O";  // Changing the button text to O
                    TicTac[2, 0] = 0; // Entering the value into the matrix
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player X Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if (btn == btn8 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[2, 1] == -1) //If it is the turn of X and the button is empty
                {
                    btn8.Text = "X"; // Changing the button text to X
                    TicTac[2, 1] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                }
                else if(o_turn && TicTac[2, 1] == -1) //If it is the turn of O and the button is empty
                {
                    btn8.Text = "O"; // Changing the button text to O
                    TicTac[2, 1] = 0;
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player X Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if (btn == btn9 && game_started) // If the button was clicked && if the game is still active
            {
                if (x_turn && TicTac[2, 2] == -1) //If it is the turn of X and the button is empty
                {
                    btn9.Text = "X"; // Changing the button text to X
                    TicTac[2, 2] = 1; // Entering the value into the matrix
                    o_turn = true;
                    x_turn = false;
                    info.Text = "Player O Turn"; // Announcing the turn
                    count_X++; // Adding one to the count
                }
                else if(o_turn && TicTac[2, 2] == -1) //If it is the turn of O and the button is empty
                {
                    btn9.Text = "O"; // Changing the button text to O
                    TicTac[2, 2] = 0; // Entering the value into the matrix
                    x_turn = true;
                    o_turn = false;
                    info.Text = "Player X Turn"; // Announcing the turn
                    count_O++; // Adding one to the count
                }
            }
            else if(reset == btn) // If the button was clicked
            {
                // Reset all the buttons
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
                Toast.MakeText(Application.Context, "Game restarted", ToastLength.Short).Show(); // Pop a toast that says the game restarted
                btno.Visibility = Android.Views.ViewStates.Visible; // Make the button visible
                btnx.Visibility = Android.Views.ViewStates.Visible; // Make the button visible
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        TicTac[i, j] = -1; //Reset the matrix
                    }
                }
                info.Text = "Game started plz choose a player"; //Changin the text 
            }



            if (game_started) // Checking if the game ended
            {
                for (int i = 0; i < 3; i++)
                {
                    // Check rows
                    if (TicTac[i, 0] == TicTac[i, 1] && TicTac[i, 1] == TicTac[i, 2])
                    {
                        if (TicTac[i, 0] == 1) winner_X = true;
                        else if (TicTac[i, 0] == 0) winner_O = true;
                    }
                    // Check columns
                    if (TicTac[0, i] == TicTac[1, i] && TicTac[1, i] == TicTac[2, i])
                    {
                        if (TicTac[0, i] == 1) winner_X = true;
                        else if (TicTac[0, i] == 0) winner_O = true;
                    }
                }
                // Check diagonals
                if (TicTac[0, 0] == TicTac[1, 1] && TicTac[1, 1] == TicTac[2, 2])
                {
                    if (TicTac[0, 0] == 1) winner_X = true;
                    else if (TicTac[0, 0] == 0) winner_O = true;
                }
                if (TicTac[0, 2] == TicTac[1, 1] && TicTac[1, 1] == TicTac[2, 0])
                {
                    if (TicTac[0, 2] == 1) winner_X = true;
                    else if (TicTac[0, 2] == 0) winner_O = true;
                }
                // Check if there are any empty spaces in the game in order to check if it is a tie
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (TicTac[i, j] == -1 && game_started)
                        {
                            // There is an empty space, so it's not a tie
                            tie = false;

                        }
                    }
                }

                if (winner_X) //Checks if X is the winner
                {
                    Toast.MakeText(Application.Context, "X is the winner!", ToastLength.Short).Show(); // Pop a Toast that says X is the winner
                    count_winnings_X++; // Adding to the count of winnings
                    game_started = false; // Changing the bool paramter to false (game ended)
                    winner_X = false;
                }
                else if (winner_O)
                {
                    Toast.MakeText(Application.Context, "O is the winner!", ToastLength.Short).Show(); // Pop a Toast that says O is the winner
                    count_winnings_O++; // Adding to the count of winnings
                    game_started = false; // Changing the bool paramter to false (game ended)
                    winner_O = false;
                }

                else if (tie)
                {
                    Toast.MakeText(Application.Context, "It is a tie!", ToastLength.Short).Show(); // Pop a Toast that says the game is tied
                    game_started = false; // Changing the bool paramter to false (game ended)
                    tie = false; 
                }
            }

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
