﻿using Microsoft.Extensions.Logging;
using WattCount.ViewModels;
using WattCount.Views;
using CommunityToolkit.Maui;
using MauiBasics.Services;

namespace WattCount;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();

		builder.Services.AddTransient<SpielstandPage>();
        builder.Services.AddTransient<SpielstandViewModel>();

        builder.Services.AddTransient<SelectTeamPage>();
        builder.Services.AddTransient<SelectTeamViewModel>();

        builder.Services.AddDbContext<DbManagerSQLite>();

        return builder.Build();
    }
}