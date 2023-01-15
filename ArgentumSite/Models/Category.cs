namespace ArgentumSite.Models;

/// <summary>
/// Категория
/// </summary>
public class Category : BaseModel
{
    /// <summary>
    /// Навазние категории
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Список товаров
    /// </summary>
    public List<GoodCard> GoodCards { get; set; }
}