using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CompletionTest;
public partial class TestViewModel : ObservableObject {
    [ObservableProperty]
    private int _id;

    [RelayCommand]
    private void DoSomething() {

    }
}
