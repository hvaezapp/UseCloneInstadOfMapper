namespace UseCloneInstadOfMapper.Dtos.Product;
public record GetProductDto(long id,
                            string? title,
                            string? fullDescription,
                            decimal price);
