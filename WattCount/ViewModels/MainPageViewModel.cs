using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WattCount.ViewModels
{
    public partial class MainPageViewModel : ObservableObject {

        [RelayCommand]
        public async Task GoToSpielstandPage() {
            await Shell.Current.GoToAsync("//SpielstandPage");
        }


    }
}
