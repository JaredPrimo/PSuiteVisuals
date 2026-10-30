using System.Collections.Generic;
using System.Collections.ObjectModel;
using CsvHelper;
using Tmds.DBus.Protocol;

[CsvRecord]
public partial class Sku
{
    public Sku()
    {
        //Empty 
    }
    [CsvColumn("IDnum")]
    public int IDnumber {get; set;}    
    [CsvColumn("Name")]
    public string Name{ get; set;}= "";
    [CsvColumn("Expiry")]
    public string Expiry{ get; set;}= "";

    public ObservableCollection<Sku> RetrieveSkuInfo()
    {
        ObservableCollection<Sku> skus = new ObservableCollection<Sku>();
        using CsvReader reader = CsvReader.FromFile("/Users/jbox/Documents/doNetApps/P-SuiteVisual/Assets/Inventory.csv");
        foreach(Sku sku in reader.GetRecords<Sku>())
        {
            skus.Add(sku);
        }
        return skus;
    }
}


// namespace SKUmodel
// {
//     class SKUmodel
//     {
//         int IDnumber;
//         string name = " "; 
//         string ExpDate= "";

//         Collection<SKUmodel> sKUmodels = new Collection<SKUmodel>(); 


//     }
    
// }




        
    

