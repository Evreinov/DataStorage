using System;
using System.Runtime.Serialization;

namespace DataStorage.Models;
    
/// <summary>
/// Комната данных.
/// </summary>
[DataContract]
internal class Storage
{
    /// <summary>
    /// Уникальный идентификатор хранилища.
    /// </summary>
    [DataMember(Name = "roomID")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Наименование хранилища.
    /// </summary>
    [DataMember(Name = "roomName")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Тип хранилища.
    /// </summary>
    [DataMember(Name = "roomType")]
    public StorageType Type { get; set; }

    /// <summary>
    /// Размер хранилища, байт.
    /// </summary>
    /// <remarks>
    /// Определяет общий возможный размер файлов данных единовременно хранимых в хранилище.
    /// </remarks>
    [DataMember(Name = "roomSize")]
    public long Size { get; set; }

    /// <summary>
    /// Размер данных в хранилище, байт.
    /// </summary>
    /// <remarks>
    /// Определяет общий размер файлов данных размещенных в хранилище на текущий момент.
    /// </remarks>
    [DataMember(Name = "roomSizeUsed")]
    public long SizeUsed { get; set; }

    /// <summary>
    /// Число файлов данных в хранилище.
    /// </summary>
    /// <remarks>
    /// Определяет общее количество файлов данных размещенных в хранилище на текущий момент.
    /// </remarks>
    [DataMember(Name = "roomNumFiles")]
    public long NumFiles { get; set; }

    /// <summary>
    /// Срок действия хранилища.
    /// </summary>
    /// <remarks>
    /// Определяет дату, при наступлении которой хранилеще будет удалено (вместе со всем содержимым).
    /// </remarks>
    [DataMember(Name = "roomExpires")]
    public DateTime Expires { get; set; }

    /// <summary>
    /// Уникальный идентификатор корневой папки хранилища.
    /// </summary>
    [DataMember(Name = "rootFolderID")]
    public Guid? RootFolderId { get; set; }
}
