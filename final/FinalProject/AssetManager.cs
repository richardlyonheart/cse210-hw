using System.Runtime.Serialization;

class AssetManager
{
    private List<Assets> _assets;
    private int _totalValue;
    public AssetManager()
    {
        _assets = new List<Assets>();
        _totalValue = 0;
    }

    public void AddAsset(Assets assets)
    {
        _assets.Add(assets);
    }

    public void DisplayAssets()
    {
        Console.WriteLine("\nYour Current Assets Include: ");
        for (int i =0; i < _assets.Count; i++)
        {
            Console.Write($"{i}. ");
            _assets[i].DisplayValue();
        }
        Console.WriteLine($"Total Value: ${_totalValue}");
    }

      public void SaveAsset(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Assets asset in _assets)
                {
                    if (asset is Assets SingleFamily)
                    {
                        writer.WriteLine($"SingleFamily Home:{asset.Name},Rent:{SingleFamily.Rent},Expense:{Singlefamily.Expense},{asset.Description}");
                    }
                    else if (asset is Assets MultiFamily)
                    {
                        writer.WriteLine($"MultiFamily Home:{asset.Name},Vacant:{MultiFamily.Vacant}, TotalRent: {MultiFamily.TotalRent}, Total Expense: {MultiFamily.TotalExpense}, {asset.Description}.")
                    }
                    else
                    {
                        writer.WriteLine($"{asset.Name},{asset.Description}, {asset.Value}");
                    }
                }
                writer.WriteLine($"Total Value:{_totalValue}");
            }
            Console.WriteLine("Assets Saved to File!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving progress: {ex.Message}");
        }
    }


}
