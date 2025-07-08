namespace GildedRoseKata;

public class ConjuredItem : BetterItem
{

    public ConjuredItem()
    {
        DegradeWeight = -2;
    }
    
    
    public void Update()
    {
        if (SellIn <= 0)
        {
            DegradeWeight *= 2;
        }
        
        Quality += DegradeWeight;
        SellIn -= 1;
            
        if (Quality <= 0)
        {
            Quality = 0;
        }
    }
}