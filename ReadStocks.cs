using Newtonsoft.Json;
using StockManagement;


public class ReadStocks{

    public StockPortfolio read(string path){
        using( StreamReader file = new StreamReader(path)){
        try{
            String json = file.ReadToEnd();
            return JsonConvert.DeserializeObject<StockPortfolio>(json);
        }catch(Exception ex){
            return null;
        }
        }
    }

}