using DataStorage.ViewModels.Base;

namespace DataStorage.ViewModels;

internal class MainWindowViewModel : ViewModel
{
    #region Title : string - Заголовок окна программы

    /// <summary>Заголовок окна программы</summary>
    private string _Title;

    /// <summary>Заголовок окна программы</summary>
    public string Title
    {
        get => _Title;
        set => Set(ref _Title, value);
    }

    #endregion

    public MainWindowViewModel()
    {
        Title = "Главное окно программы DataStorage";
    }
}

