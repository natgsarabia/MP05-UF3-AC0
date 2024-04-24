public class Cars
{
    public int ID;
    public string model;
    public string brand;
    public int fabricationYear;
    public string purchaseDate;
    public double purchasePrice;
    public bool carTested;
    public double sellPrice;

    public Cars(int ID, string model, string brand,  int fabricationYear, string purchaseDate, double purchasePrice, bool carTested){

        this.ID = ID;
        this.model = model;
        this.brand=brand;
        this.fabricationYear = fabricationYear;
        this.purchaseDate=purchaseDate;
        this.purchasePrice=purchasePrice;
        this.carTested=carTested;
        sellPrice=CalculateSellPrice();
    }

    public double CalculateSellPrice(){
        double sellPrice=purchasePrice*1.30;
        return sellPrice;
    }
    
}


