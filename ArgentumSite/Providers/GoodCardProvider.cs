using ArgentumSite.Models;
using ArgentumSite.Interfaces;
using ArgentumSite.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ArgentumSite.Providers;

/// <summary>
/// Провайдер для работы с карточками товаров
/// </summary>
public class GoodCardProvider : IGoodCardsProvider
{
    public readonly ApplicationDbContext Context;

    public GoodCardProvider(ApplicationDbContext context)
    {
        Context = context;
    }

    /// <summary>
    /// Получение коллекции сущностей по предикату
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    private async Task<List<GoodCard>> GetListAsync(Expression<Func<GoodCard, bool>> predicate)
    {
        var result = Context.Set<GoodCard>().AsNoTracking().Where(predicate).Include(x => x.Size).Include(x => x.Category);
        var list = new List<GoodCard>();
        foreach (var item in result)
        {
            item.ImageUrl = GetImageUrl(item);
            list.Add(item);
        }
        return list;
    }

    /// <summary>
    /// Получение сущности по ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    private async Task<GoodCard> GetItemAsync(int id)
    {
        var result = Context.Set<GoodCard>().Include(x => x.Size).Include(x => x.Category).AsNoTracking().SingleOrDefault(x => x.Id == id);
        result.ImageUrl = GetImageUrl(result);
        return result;
    }

    /// <summary>
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    private async Task<GoodCard> GetItemAsync(Expression<Func<GoodCard, bool>> predicate)
    {
        var list = await GetListAsync(predicate);
        var result = list?.FirstOrDefault();
        return result;
    }

    /// <summary>
    /// Заполнение url картинки
    /// </summary>
    /// <param name="goodCard"></param>
    /// <returns></returns>
    private string GetImageUrl(GoodCard goodCard)
    {
        var category = goodCard.Category.Id switch
        {
            1 => "rings",
            2 => "bracelets",
            3 => "chains",
            _ => "necklace"
        };
        return $"img/Goods/{category}/{goodCard.IdNumber.TrimEnd()}.png";
    }

    /// <inheritdoc />
    public async Task<List<GoodCard>> GetMainGoodCardList()
    {
        return await GetListAsync(x => x.IsFavorite == true);
    }

    /// <inheritdoc />
    public async Task<List<GoodCard>> GetGoodCardsCategory(int categoryId)
    {
        return await GetListAsync(x => x.Category.Id == categoryId);
    }

    /// <inheritdoc />
    public async Task<GoodCard> GetGoodCard(int id)
    {
        return await GetItemAsync(id);
    }

    /// <inheritdoc />
    public async Task<List<GoodCard>> GetSearchCards(string searchText)
    {
        return await GetListAsync(x => x.Name.ToLower().Contains(searchText.ToLower()) || x.Category.Name.ToLower().Contains(searchText.ToLower())
        || x.Material.ToLower().Contains(searchText.ToLower()) || x.Description.ToLower().Contains(searchText.ToLower()) || x.Country.ToLower().Contains(searchText.ToLower()));
    }
}
