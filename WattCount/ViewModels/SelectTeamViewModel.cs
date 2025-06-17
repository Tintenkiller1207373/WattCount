using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBasics.Services;
using Microsoft.EntityFrameworkCore;
using WattCount.Models;

namespace WattCount.ViewModels
{
    public partial class SelectTeamViewModel : ObservableObject {

        public SelectTeamViewModel() {
            LoadTeams();
        }


        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        ObservableCollection<Teams> _teams = new();

        private readonly DbManagerSQLite _dbManagerSQLite;

        public SelectTeamViewModel(DbManagerSQLite dbManagerSQLite) {
            this._dbManagerSQLite = dbManagerSQLite;
        }

        [RelayCommand]
        public async Task Send() {
            Teams team = new() {
                TeamsId = 0,
                TeamName = this.Name,
            };
            this._dbManagerSQLite.Teams.Add(team);
            await this._dbManagerSQLite.SaveChangesAsync();
        }


        // Methode um die Teams in die ObservableColletion zu laden
        public async void LoadTeams() {
          Teams = new ObservableCollection<Teams>(await _dbManagerSQLite.Teams.ToListAsync());
        }
    }
}
