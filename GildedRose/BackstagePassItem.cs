namespace GildedRoseKata;

public class BackstagePassItem : BetterItem
{
    public void Update()
    {
        if (SellIn <= 10)
        {
            DegradeWeight += 1;
        }
                
        if (SellIn <= 5)
        {
            DegradeWeight += 1;
        }

        if (SellIn <= 0)
        {
            Quality = 0;
            DegradeWeight = 0;
        }
        
        
        Quality += DegradeWeight;
        SellIn -= 1;

        if (Quality <= 0)
        {
            Quality = 0;
        }
            
        if (Quality > 50)
        {
            Quality = 50;
        }
    }
}