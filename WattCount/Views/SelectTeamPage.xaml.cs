using WattCount.ViewModels;
using WattCount.Views;

namespace WattCount.Views {
    public partial class SelectTeamPage : ContentPage {
        public SelectTeamPage(SelectTeamViewModel vm) {
            InitializeComponent();
            this.BindingContext = vm;
        }


    }

}