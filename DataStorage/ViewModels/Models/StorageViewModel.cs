using System;
using DataStorage.Models;
using DataStorage.ViewModels.Base;

namespace DataStorage.ViewModels.Models;

internal class StorageViewModel : ViewModel
{
    #region Id : Guid? - Уникальный идентификатор хранилища

    /// <summary>Уникальный идентификатор хранилища</summary>
    private Guid? _Id;

    /// <summary>Уникальный идентификатор хранилища</summary>
    public Guid? Id
    {
        get => _Id;
        set => Set(ref _Id, value);
    }

    #endregion

    #region Name : string - Наименование хранилища

    /// <summary>Наименование хранилища</summary>
    private string _Name;

    /// <summary>Наименование хранилища</summary>
    public string Name
    {
        get => _Name;
        set => Set(ref _Name, value);
    }

    #endregion

    #region Type : RoomType - Тип хранилища

    /// <summary>Тип хранилища</summary>
    private StorageType _Type;

    /// <summary>Тип хранилища</summary>
    public StorageType Type
    {
        get => _Type;
        set => Set(ref _Type, value);
    }

    #endregion

    #region Size : long - Размер хранилища, байт

    /// <summary>Размер хранилища, байт</summary>
    private long _Size;

    /// <summary>Размер хранилища, байт</summary>
    public long Size
    {
        get => _Size;
        set => Set(ref _Size, value);
    }

    #endregion

    #region SizeUsed : long - Размер данных в хранилище

    /// <summary>Размер данных в хранилище</summary>
    private long _SizeUsed;

    /// <summary>Размер данных в хранилище</summary>
    public long SizeUsed
    {
        get => _SizeUsed;
        set => Set(ref _SizeUsed, value);
    }

    #endregion

    #region NumFiles : long - Число файлов данных в хранилище

    /// <summary>Число файлов данных в хранилище</summary>
    private long _NumFiles;

    /// <summary>Число файлов данных в хранилище</summary>
    public long NumFiles
    {
        get => _NumFiles;
        set => Set(ref _NumFiles, value);
    }

    #endregion

    #region Expires : DateTime - Срок действия хранилища

    /// <summary>Срок действия хранилища</summary>
    private DateTime _Expires;

    /// <summary>Срок действия хранилища</summary>
    public DateTime Expires
    {
        get => _Expires;
        set => Set(ref _Expires, value);
    }

    #endregion

    #region RootFolderId : Guid? - Уникальный идентификатор корневой папки хранилища

    /// <summary>Уникальный идентификатор корневой папки хранилища</summary>
    private Guid? _RootFolderId;

    /// <summary>Уникальный идентификатор корневой папки хранилища</summary>
    public Guid? RootFolderId
    {
        get => _RootFolderId;
        set => Set(ref _RootFolderId, value);
    }

    #endregion
}

