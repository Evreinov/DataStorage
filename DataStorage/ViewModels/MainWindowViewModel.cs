using System;
using System.Collections.ObjectModel;
using DataStorage.ViewModels.Base;
using DataStorage.ViewModels.Models;
using System.Linq;

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

    #region SelectedStorage : StorageViewModel - Выбранное хранилище

    /// <summary>Выбранное хранилище</summary>
    private StorageViewModel _SelectedStorage;

    /// <summary>Выбранное хранилище</summary>
    public StorageViewModel SelectedStorage
    {
        get => _SelectedStorage;
        set => Set(ref _SelectedStorage, value);
    }

    #endregion

    #region SelectedItem : object - Выбранный элемент

    /// <summary>Выбранный элемент</summary>
    private object _SelectedItem;

    /// <summary>Выбранный элемент</summary>
    public object SelectedItem
    {
        get => _SelectedItem;
        set => Set(ref _SelectedItem, value);
    }

    #endregion

    public MainWindowViewModel()
    {
        Title = "Главное окно программы DataStorage";

        SelectedStorage = new StorageViewModel()
        {
            Name = "Тестовое хранилище",
            Content = new ObservableCollection<object>(Enumerable.Range(1, 10).Select((_, index) => new FolderViewModel()
            {
                Id = Guid.NewGuid(),
                Name = $"Folder {index}",
                Content = new ObservableCollection<object>(Enumerable.Range(1, 5).Select((_, i) => new FolderViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = $"SubFolder {i}",
                    Content = new ObservableCollection<object>(Enumerable.Range(1, 2).Select((_, j) => new FolderViewModel()
                    {
                        Id = Guid.NewGuid(),
                        Name = $"SubSubFolder {j}",
                        Content = new ObservableCollection<object>(Enumerable.Range(1, 10).Select((_, j) => new FileViewModel()
                        {
                            Id = Guid.NewGuid(),
                            Name = $"File {j}",
                        }))
                    }))
                }))
            })),
         };
    }
}

