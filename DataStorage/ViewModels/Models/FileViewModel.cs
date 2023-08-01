using DataStorage.ViewModels.Base;
using System;

namespace DataStorage.ViewModels.Models;

internal class FileViewModel : ViewModel
{
    #region Id : Guid - Уникальный идентфикатор папки хранилища

    /// <summary>Уникальный идентфикатор папки хранилища</summary>
    private Guid _Id;

    /// <summary>Уникальный идентфикатор папки хранилища</summary>
    public Guid Id
    {
        get => _Id;
        set => Set(ref _Id, value);
    }

    #endregion

    #region Name : string - Наименование папки хранилища

    /// <summary>Наименование папки хранилища</summary>
    private string _Name;

    /// <summary>Наименование папки хранилища</summary>
    public string Name
    {
        get => _Name;
        set => Set(ref _Name, value);
    }

    #endregion
}

