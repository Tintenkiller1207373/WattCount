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


        int[] _teamA = new int[6];

        int[] _teamB = new int[6];

        [ObservableProperty]
        bool _isVisibleGestrichenA = false;

        [ObservableProperty]
        bool _isVisibleGestrichenB = false;

        //TEAM A
        [ObservableProperty]
        int _a1;

        [ObservableProperty]
        bool _isVisibleA1 = false;

        [ObservableProperty]
        int _a2;

        [ObservableProperty]
        bool _isVisibleA2 = false;

        [ObservableProperty]
        int _a3;

        [ObservableProperty]
        bool _isVisibleA3 = false;

        [ObservableProperty]
        int _a4;

        [ObservableProperty]
        bool _isVisibleA4 = false;

        [ObservableProperty]
        int _a5;

        [ObservableProperty]
        bool _isVisibleA5 = false;

        [ObservableProperty]
        int _a6;

        [ObservableProperty]
        bool _isVisibleA6 = false;


        //TEAM B
        [ObservableProperty]
        int _b1;

        [ObservableProperty]
        bool _isVisibleB1 = false;

        [ObservableProperty]
        int _b2;

        [ObservableProperty]
        bool _isVisibleB2 = false;

        [ObservableProperty]
        int _b3;

        [ObservableProperty]
        bool _isVisibleB3 = false;

        [ObservableProperty]
        int _b4;

        [ObservableProperty]
        bool _isVisibleB4 = false;

        [ObservableProperty]
        int _b5;

        [ObservableProperty]
        bool _isVisibleB5 = false;

        [ObservableProperty]
        int _b6;

        [ObservableProperty]
        bool _isVisibleB6 = false;





        // Team 1 Punkte
        [RelayCommand]
        public async Task AddTwoA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 2;
                    UpdateTeamA();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddThreeA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 3;
                    UpdateTeamA();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddFourA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 4;
                    UpdateTeamA();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddFiveA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 5;
                    UpdateTeamA();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddSixA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 6;
                    UpdateTeamA();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddSevenA() {
            for (int i = 0; i < _teamA.Length; i++) {
                if (_teamA[i] == 0) {
                    _teamA[i] = 7;
                    UpdateTeamA();
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
                    UpdateTeamB();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddThreeB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 3;
                    UpdateTeamB();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddFourB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 4;
                    UpdateTeamB();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddFiveB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 5;
                    UpdateTeamB();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddSixB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 6;
                    UpdateTeamB();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task AddSevenB() {
            for (int i = 0; i < _teamB.Length; i++) {
                if (_teamB[i] == 0) {
                    _teamB[i] = 7;
                    UpdateTeamB();
                    break;
                }
            }
        }


        //Updates
        private void UpdateTeamA() {
            A1 = _teamA[0];
            if(A1 > 0) {
                IsVisibleA1 = true;
            }
            
            A2 = _teamA[1];
            if (A2 > 0) {
                IsVisibleA2 = true;
            }

            A3 = _teamA[2];
            if (A3 > 0) {
                IsVisibleA3 = true;
            }

            A4 = _teamA[3];
            if (A4 > 0) {
                IsVisibleA4 = true;
            }

            A5 = _teamA[4];
            if (A5 > 0) {
                IsVisibleA5 = true;
            }

            A6 = _teamA[5];
            if (A6 > 0) {
                IsVisibleA6 = true;
            }

            //Gestrichen
            if (_teamA.Sum() >= 9) {
                IsVisibleGestrichenA = true;
            }

        }

        private void UpdateTeamB() {
            B1 = _teamB[0];
            if (B1 > 0) {
                IsVisibleB1 = true;
            }

            B2 = _teamB[1];
            if (B2 > 0) {
                IsVisibleB2 = true;
            }

            B3 = _teamB[2];
            if (B3 > 0) {
                IsVisibleB3 = true;
            }

            B4 = _teamB[3];
            if (B4 > 0) {
                IsVisibleB4 = true;
            }

            B5 = _teamB[4];
            if (B5 > 0) {
                IsVisibleB5 = true;
            }

            B6 = _teamB[5];
            if (B6 > 0) {
                IsVisibleB6 = true;
            }

            //Gestrichen
            if (_teamB.Sum() >= 9) {
                IsVisibleGestrichenB = true;
            }
        }

    }
}
