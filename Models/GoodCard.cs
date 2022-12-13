namespace ArgentumSite.Models;

/// <summary>
/// Карточка товара
/// </summary>
public class GoodCard : BaseModel
{

    /// <summary>
    /// Имя товара
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// url картинки
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Индивидуальный номер
    /// </summary>
    public string IdNumber { get; set; }

    /// <summary>
    /// Страна-производитель
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Пол
    /// </summary>
    public string Sex { get; set; }

    /// <summary>
    /// Размер
    /// </summary>
    public string Size { get; set; }

    /// <summary>
    /// Id категории
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// На главной
    /// </summary>
    public bool IsFavorite { get; set; }
}
