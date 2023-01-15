using ArgentumSite.Models;

namespace ArgentumSite.Interfaces;

public interface IGoodCardsProvider
{
    /// <summary>
    /// Получение списка карточек товаров
    /// </summary>
    /// <returns></returns>
    Task<List<GoodCard>> GetMainGoodCardList();

    /// <summary>
    /// Получение карточки товара по Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<GoodCard> GetGoodCard(int id);

    /// <summary>
    /// Получение категории товаров
    /// </summary>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    Task<List<GoodCard>> GetGoodCardsCategory(int categoryId);

    /// <summary>
    /// Поиск
    /// </summary>
    /// <param name="searchText"></param>
    /// <returns></returns>
    Task<List<GoodCard>> GetSearchCards(string searchText);
}
