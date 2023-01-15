namespace ArgentumSite.Models
{
    /// <summary>
    /// Размер
    /// </summary>
    public class Size : BaseModel
    {
        /// <summary>
        /// Навзание
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Товары
        /// </summary>
        public List<GoodCard> GoodCards { get; set; }
    }
}
