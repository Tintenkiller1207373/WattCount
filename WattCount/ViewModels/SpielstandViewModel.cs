using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattCount.ViewModels
{
    public partial class SpielstandViewModel : ObservableObject  
    {

        // Team 1 Seite

        [ObservableProperty]
        private string _a1;

        [ObservableProperty]
        private string _a2;

        [ObservableProperty]
        private string _a3;

        [ObservableProperty]
        private string _a4;

        [ObservableProperty]
        private string _a5;

        [ObservableProperty]
        private string _a6;


        // Team 2 Seite

        [ObservableProperty]
        private string _b1;

        [ObservableProperty]
        private string _b2;

        [ObservableProperty]
        private string _b3;

        [ObservableProperty]
        private string _b4;

        [ObservableProperty]
        private string _b5;

        [ObservableProperty]
        private string _b6;


        // Team 1 Punkte
        [RelayCommand]
        public async Task AddTwoA() {
        }

        [RelayCommand]
        public async Task AddThreeA() {
        }

        [RelayCommand]
        public async Task AddFourA() {
        }

        [RelayCommand]
        public async Task AddFiveA() {
        }

        [RelayCommand]
        public async Task AddSixA() {
        }

        [RelayCommand]
        public async Task AddSevenA() {
        }


        // Team 2 Punkte
        [RelayCommand]
        public async Task AddTwoB() {
        }

        [RelayCommand]
        public async Task AddThreeB() {
        }

        [RelayCommand]
        public async Task AddFourB() {
        }

        [RelayCommand]
        public async Task AddFiveB() {
        }

        [RelayCommand]
        public async Task AddSixB() {
        }

        [RelayCommand]
        public async Task AddSevenB() {
        }


    }
}
