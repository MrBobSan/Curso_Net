using CsBases.Fundamentals;

public class ProductManager
{
    private readonly ILabelService _labelService;

    public ProductManager(ILabelService labelService)
    {
        _labelService = labelService;
    }

    public void PrintLabel(Product product)
    {
        string label = _labelService.GenerateLabel(product);
        Console.WriteLine(label);
    }
}