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
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 2;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddThreeA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 3;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddFourA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 4;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddFiveA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 5;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddSixA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 6;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddSevenA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 7;
                    break;
                }
            }
        }


        // Team 2 Punkte
        [RelayCommand]
        public async Task AddTwoB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 2;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddThreeB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 3;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddFourB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 4;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddFiveB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 5;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddSixB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 6;
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddSevenB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 7;
                    break;
                }
            }
        }


    }
}
