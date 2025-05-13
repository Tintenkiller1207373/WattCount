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


        [ObservableProperty]
        int[] _teamA = new int[6];

        [ObservableProperty]
        int[] _teamB = new int[6];

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
