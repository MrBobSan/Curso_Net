using CsBases.Fundamentals;
public class LabelService : ILabelService
{
    public string GenerateLabel(Product product)
    {
        return $"Producto: {product.Name}, Precio: {product.Price} - Código: {product.GetType().Name}-{product.GetHashCode()}";
    }
}