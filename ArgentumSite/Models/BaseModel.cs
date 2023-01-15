using ArgentumSite.Interfaces;

namespace ArgentumSite.Models;

/// <summary>
/// Базовая модель
/// </summary>
public class BaseModel : IBaseModel
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; set; }
}
