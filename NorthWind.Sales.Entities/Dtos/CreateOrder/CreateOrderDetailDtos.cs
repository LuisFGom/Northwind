namespace NorthWind.Sales.Entities.Dtos.CreateOrder;

// PARA COMENTAR TODO UNA SOLA SEÑALAR Y CONTROL + K + C

// PARA DESCOMENTAR TODO UNA SOLA SEÑALAR Y CONTROL + K + U

#region Primary Constructors c# 12
public class CreateOrderDetailDto (int productId, decimal unitPrice, short quantity)
{
public int ProductId => productId;  //expresion blanda, utilice solo la propiedad de lectura
    public decimal UnitPrice => unitPrice;
    public short Quantity => quantity;
}

#endregion


#region c# 2.0

//EL DTO ES INMUTABLE POR ESO SOLO NECESITA EL GET

//public class CreateOrderDetailDto
//{
//en los private se recomienda poner con el guion bajo y estilo camello (primera minuscula luego mayucula)
//el guion bajo significa que es de clase
//   private int _productId;
//   private decimal _unitPrice; 
//   private short _quantity;

//   public CreateOrderDetailDto(int productId, decimal unitPrice, short quantity)
//   {
//       _productId = productId;
//       _unitPrice = unitPrice;
//       _quantity = quantity;
//   }

//   public int ProductId
//   {
//       get
//       {
//           return _productId;
//       }
//   }

//public decimal UnitPrice
//   {
//       get
//       {
//           return _unitPrice;
//       }
//   }

//public short Quantity
//   {
//        get
//       {
//          return _quantity;
//      }
//   }
//}

#endregion


#region Propiedades automaticas c# 3.0

//public class  CreateOrderDetailDto
//{
//    public int ProductId { get; private set; }  
//    public decimal UnitPrice { get; private set; }
//    public short Quantity { get; private set; }


//    //PONINEDO ctor y con el tab crea automaticamente este constructor 
//    public CreateOrderDetailDto(int productId, decimal unitPrice, short quantity)
//    {
//        ProductId = productId;
//        UnitPrice = unitPrice;
//        Quantity = quantity;
//    }
//}

#endregion