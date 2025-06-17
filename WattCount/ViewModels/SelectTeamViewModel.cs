using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBasics.Services;
using WattCount.Models;

namespace WattCount.ViewModels
{
    public partial class SelectTeamViewModel : ObservableObject
    {

        [ObservableProperty]
        private string _name;

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

    }
}
