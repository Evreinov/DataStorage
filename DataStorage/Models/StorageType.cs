namespace DataStorage.Models;

/// <summary>
/// Тип комнаты данных.
/// </summary>
internal enum StorageType : byte
{
    /// <summary>Комната данных для обмена данными общего доступа (не КИ, КТ, ПДн).</summary>
    Common = 0,
    /// <summary>Комната данных персональная, для обмена данными общего досту-па (не КИ, КТ, ПДн).</summary>
    Personal = 1,
    /// <summary>Комната данных для обмена данными содержащими КТ, КИ, ПДн.</summary>
    Confidential = 2,
}

