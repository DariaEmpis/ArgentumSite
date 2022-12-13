using ArgentumSite.Models;
using ArgentumSite.Interfaces;

namespace ArgentumSite.Providers;

/// <summary>
/// Провайдер для работы с карточками товаров
/// </summary>
public class GoodCardProvider : IGoodCardsProvider
{
    /// <inheritdoc />
    public async Task<List<GoodCard>> GetGoodCardList()
    {
        var goodCards = new List<GoodCard>
        {
            new GoodCard { Id = 1, Name = "Название", Description="Описание", Price = 1000, ImageUrl ="img/Goods/Cep_na_sheu_2599.webp"},
            new GoodCard { Id = 2, Name = "Название", Description="Описание", Price = 1000, ImageUrl ="img/Goods/Cep_na_sheu_2599.webp"},
            new GoodCard { Id = 3, Name = "Название", Description="Описание", Price = 1000, ImageUrl ="img/Goods/Cep_na_sheu_2599.webp"},
            new GoodCard { Id = 4, Name = "Название", Description="Описание", Price = 1000, ImageUrl ="img/Goods/Cep_na_sheu_2599.webp"},
            new GoodCard { Id = 5, Name = "Название", Description="Описание", Price = 1000, ImageUrl ="img/Goods/Cep_na_sheu_2599.webp"},
            new GoodCard { Id = 6, Name = "Название", Description="Описание", Price = 1000, ImageUrl ="img/Goods/Cep_na_sheu_2599.webp"},
            new GoodCard { Id = 7, Name = "Название", Description="Описание", Price = 1000, ImageUrl ="img/Goods/Cep_na_sheu_2599.webp"},
            new GoodCard { Id = 8, Name = "Название", Description="Описание", Price = 1000, ImageUrl ="img/Goods/Cep_na_sheu_2599.webp"}
        };
        return goodCards;
    }


}
