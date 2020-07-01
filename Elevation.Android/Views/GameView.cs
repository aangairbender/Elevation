using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Elevation.Core.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.ViewModels;

namespace Elevation.Android.Views
{
    [Activity(Label = "Elevation")]
    [MvxViewFor(typeof(GameViewModel))]
    public class GameView : MvxFragmentActivity<GameViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.game);

            var navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.NavigationItemSelected += Navigation_NavigationItemSelected;
        }

        private void Navigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            MvxFragment selectedFragment = new GameMainView();
            switch (e.Item.ItemId)
            {
                case Resource.Id.navigation_knowledge:
                    selectedFragment = new GameKnowledgeView();
                    break;
                case Resource.Id.navigation_quests:
                    selectedFragment = new GameQuestsView();
                    break;
                case Resource.Id.navigation_game:
                    selectedFragment = new GameMainView();
                    break;
                case Resource.Id.navigation_inventory:
                    selectedFragment = new GameInventoryView();
                    break;
                case Resource.Id.navigation_character:
                    selectedFragment = new GameCharacterView();
                    break;
            }

            SupportFragmentManager
                .BeginTransaction()
                .Replace(Resource.Id.frame_layout, selectedFragment)
                .Commit();
        }
    }
}