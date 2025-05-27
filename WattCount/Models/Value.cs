using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WattCount.Models
{
    public partial class Value : ObservableObject
    {
        [ObservableProperty]
        private int _val;

    }
}
