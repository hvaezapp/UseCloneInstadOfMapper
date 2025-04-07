using UseCloneInstadOfMapper.Dtos.Product;

namespace UseCloneInstadOfMapper.Entities;

public class Product : ICloneable
{
    #region props
    public long Id { get; private set; }
    public string? Title { get; private set; }
    public string? FullDescription { get; private set; }
    public decimal Price { get; private set; }
    public bool IsAvailable { get; private set; }
    #endregion

    #region ctors

    public Product(long id,
                  string? title,
                  string? fullDescription,
                  decimal price)
    {
        Id = id;
        Title = title;
        FullDescription = fullDescription;
        Price = price;
        IsAvailable = true;

    }
    #endregion

    #region methods
    public static IEnumerable<Product> GetAll() =>
        [
             new (1001 , "laptop asus" , "Explore a range of ASUS laptops designed for home use, from premium OLED laptops to AI PCs" , 350000),
             new (1002 , "iphone 16" , "The versatile new iPhone 16 camera system captures beautiful photos — from up close or far away.",  250000),
             new (1003 , "headphone lenovo" , "Whether you love to listen to music or talk on the phone, Lenovo has you covered: Wireless headphones for in-home entertainment" , 150000),
        ];

    public object Clone() => new GetProductDto(Id, Title, FullDescription, Price);
    #endregion
}
