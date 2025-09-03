namespace NorthWind.Sales.Entities.Dtos.CreateOrder;


// Primary Constructors c# 12
public class CreateOrderDetailDtos (int ProductId, decimal UnitPrice)
{
    public int ProductId => ProductId;  //expresion blanda, utilice solo la propiedad de lectura
    public decimal UnitPrice => UnitPrice;
    public short Quantity => Quantity; 
}

