﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsNotBusy))]
    private bool isBusy;

    [ObservableProperty]
    private string title;

    public bool IsNotBusy => !IsBusy;
}