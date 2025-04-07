using UseCloneInstadOfMapper.Dtos.Product;

namespace UseCloneInstadOfMapper.Entities;

public class Product : ICloneable
{
    #region props
    public long Id { get; set; }
    public string? Title { get; set; }
    public string? FullDescription { get; set; }
    public decimal Price { get; set; }
    #endregion


    #region methods
    public object Clone() => new GetProductDto(Id, Title, FullDescription, Price);
    #endregion
}
