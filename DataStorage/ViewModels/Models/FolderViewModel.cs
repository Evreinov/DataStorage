using DataStorage.ViewModels.Base;
using System;

namespace DataStorage.ViewModels.Models;

internal class FolderViewModel : ViewModel
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

    #region AuthorId : Guid? - Уникальный идентификатор пользователя владельца папки (отвественного)

    /// <summary>Уникальный идентификатор пользователя владельца папки (отвественного)</summary>
    private Guid? _AuthorId;

    /// <summary>Уникальный идентификатор пользователя владельца папки (отвественного)</summary>
    public Guid? AuthorId
    {
        get => _AuthorId;
        set => Set(ref _AuthorId, value);
    }

    #endregion

    #region AuthorName : string - Наименование пользователя владельца папки (отвественного)

    /// <summary>Наименование пользователя владельца папки (отвественного)</summary>
    private string _AuthorName;

    /// <summary>Наименование пользователя владельца папки (отвественного)</summary>
    public string AuthorName
    {
        get => _AuthorName;
        set => Set(ref _AuthorName, value);
    }

    #endregion

    #region Created : DateTime - Дата создания папки

    /// <summary>Дата создания папки</summary>
    private DateTime _Created;

    /// <summary>Дата создания папки</summary>
    public DateTime Created
    {
        get => _Created;
        set => Set(ref _Created, value);
    }

    #endregion

    #region FilesCountInFolder : long - Количество файлов, размещенных непосредственно в папке

    /// <summary>Количество файлов, размещенных непосредственно в папке</summary>
    private long _FilesCountInFolder;

    /// <summary>Количество файлов, размещенных непосредственно в папке</summary>
    public long FilesCountInFolder
    {
        get => _FilesCountInFolder;
        set => Set(ref _FilesCountInFolder, value);
    }

    #endregion

    #region FilesCountInTreeFolders : long - Количество файлов, размещенных в папке и во всех дочерних папках папки

    /// <summary>Количество файлов, размещенных в папке и во всех дочерних папках папки</summary>
    private long _FilesCountInTreeFolders;

    /// <summary>Количество файлов, размещенных в папке и во всех дочерних папках папки</summary>
    public long FilesCountInTreeFolders
    {
        get => _FilesCountInTreeFolders;
        set => Set(ref _FilesCountInTreeFolders, value);
    }

    #endregion

    #region FilesSizeInFolder : long - Размер файлов (в байтах), размещённых непосредственно в папке

    /// <summary>Размер файлов (в байтах), размещённых непосредственно в папке</summary>
    private long _FilesSizeInFolder;

    /// <summary>Размер файлов (в байтах), размещённых непосредственно в папке</summary>
    public long FilesSizeInFolder
    {
        get => _FilesSizeInFolder;
        set => Set(ref _FilesSizeInFolder, value);
    }

    #endregion

    #region FilesSizeInTreeFolders : long - Размер файлов (в байтах), размещённых в папке и во всех дочерних папках папки

    /// <summary>Размер файлов (в байтах), размещённых в папке и во всех дочерних папках папки</summary>
    private long _FilesSizeInTreeFolders;

    /// <summary>Размер файлов (в байтах), размещённых в папке и во всех дочерних папках папки</summary>
    public long FilesSizeInTreeFolders
    {
        get => _FilesSizeInTreeFolders;
        set => Set(ref _FilesSizeInTreeFolders, value);
    }

    #endregion
}

