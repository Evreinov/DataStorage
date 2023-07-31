using System;
using System.Runtime.Serialization;

namespace DataStorage.Models;

/// <summary>
/// Папка хранилища.
/// </summary>
[DataContract]
internal class Folder
{
    /// <summary>
    /// Уникальный идентификатор папки хранилища.
    /// </summary>
    [DataMember(Name = "folderID")]
    public Guid Id { get; set; }

    /// <summary>
    /// Наименование папки хранилища.
    /// </summary>
    [DataMember(Name = "folderName")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Уникальный идентификатор пользователя владельца папки (ответственного).
    /// </summary>
    [DataMember(Name = "authorID")]
    public Guid? AuthorId { get; set; }

    /// <summary>
    /// Наименование пользователя владельца папки (ответственного).
    /// </summary>
    [DataMember(Name = "authorName")]
    public string AuthorName { get; set; } = string.Empty;

    /// <summary>
    /// Дата создания папки.
    /// </summary>
    [DataMember(Name = "folderCreated")]
    public DateTime Created { get; set; }

    /// <summary>
    /// Количество файлов, размещённых непосредственно в папке.
    /// </summary>
    [DataMember(Name = "filesCountInFolder")]
    public long FilesCountInFolder { get; set; }

    /// <summary>
    /// Количество файлов, размещённых в папке и во всех дочерних папках папки.
    /// </summary>
    [DataMember(Name = "filesCountInTreeFolders")]
    public long FilesCountInTreeFolders { get; set; }

    /// <summary>
    /// Размер файлов (в байтах), размещённых непосредственно в папке.
    /// </summary>
    [DataMember(Name = "filesSizeInFolder")]
    public long FilesSizeInFolder { get; set; }

    /// <summary>
    /// Размер файлов (в байтах), размещённых в папке и во всех дочерних папках папки.
    /// </summary>
    [DataMember(Name = "filesSizeInTreeFolders")]
    public long FilesSizeInTreeFolders { get; set; }
}
