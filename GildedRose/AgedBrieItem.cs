namespace GildedRoseKata;

public class AgedBriItem : BetterItem
{
    public void Update()
    {
        if (SellIn <= 0)
        {
            DegradeWeight *= 2;
        }
        
        Quality += DegradeWeight;
        SellIn -= 1;
            
        if (Quality > 50)
        {
            Quality = 50;
        }
    }
}