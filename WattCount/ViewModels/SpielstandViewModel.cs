using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBasics.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WattCount.Models;

namespace WattCount.ViewModels
{
    public partial class SpielstandViewModel : ObservableObject {

        
            


        [ObservableProperty]
        ObservableCollection<int> _teamA = new();

        [ObservableProperty]
        ObservableCollection<int> _teamB = new();

        [ObservableProperty]
        bool _isVisibleGestrichenA = false;

        [ObservableProperty]
        bool _isVisibleGestrichenB = false;

        private DbManagerSQLite _dbManagerSQLite;

        public SpielstandViewModel(DbManagerSQLite dbManagerSQLite) {
            this._dbManagerSQLite = dbManagerSQLite;
        }



        [RelayCommand]
        public async Task Add(string id) {
            int index = Convert.ToInt32(id.Substring(1));
            if (id.StartsWith("A")){
               TeamA.Add(index);
            }
            else if (id.StartsWith("B")) {
                TeamB.Add(index);
            }
            UpdateScore();
        }


        private void UpdateScore() {
            bool win = false;
            if(_teamA.Sum() >= 9) {
                IsVisibleGestrichenA = true;
                if(_teamA.Sum() >= 11) {
                    win = true;
                }
            }
            if(_teamB.Sum() >= 9){
                IsVisibleGestrichenB = true;
                if (_teamB.Sum() >= 11) {
                    win = true;
                }
            }
            if (win) {
                resetGame();
            }
        }

        private void resetGame() {
            _teamA.Clear();
            _teamB.Clear();
            IsVisibleGestrichenA = false;
            IsVisibleGestrichenB = false;
        }

        }     
    }
