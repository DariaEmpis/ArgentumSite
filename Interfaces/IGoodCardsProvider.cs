using ArgentumSite.Models;

namespace ArgentumSite.Interfaces;

public interface IGoodCardsProvider
{
    /// <summary>
    /// Получение списка карточек товаров
    /// </summary>
    /// <returns></returns>
    Task<List<GoodCard>> GetGoodCardList();
}
