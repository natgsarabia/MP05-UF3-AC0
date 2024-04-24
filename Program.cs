internal class Program
{
    
    private static void Main(string[] args)
    {
        Cars car = new Cars(001, "Civic", "Honda",  2004, "24/03/2024", 8500, true);

        Client client = new Client("Pablo", "Ibanez", "08798624R", 001, 11050, 4500);

        Supplier supplier = new Supplier("Natalia", "Garcia", "47963578F", 001);

     
        Console.Write("INFORMACIÓN VENDEDOR COCHE:\nNombre: {0} {1}\nDNI: {2}\n\n",supplier.name,supplier.subname,supplier.dni);
        Console.WriteLine("INFORMACIÓN DEL COCHE:\nModelo: {0}\nMarca: {1}\nAño matriculación: {2}",car.model,car.brand,car.fabricationYear);
        Console.WriteLine("Fecha venta vehículo: {0}\nPrecio compra: {1}€\nPrecio venta: {2}€",car.purchaseDate,car.purchasePrice,car.sellPrice);
        if (car.carTested){
                Console.WriteLine("Coche testeado\n\n");
        }else{
                Console.WriteLine("Coche pendiente de testeo\n\n");
        }  

        Console.WriteLine("INFORMACIÓN COMPRADOR COCHE:\nNombre: {0} {1}\nDNI: {2}",client.name,client.subname,client.dni);
        Console.WriteLine("Paga y señal: {0}€\nPrecio Total: {1}€",client.deposit,client.purchaseCarPrice);
        
        
    }
    
}
