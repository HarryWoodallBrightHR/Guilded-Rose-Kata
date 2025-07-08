namespace GildedRoseKata;

public class ItemMapper
{
    public dynamic MapItem(Item item)
    {
        

        if (item.Name.Contains("Sulfuras"))
        {
            var betterItem = new SulfurasItem()
            {
                Name = item.Name,
                Quality = item.Quality,
                SellIn = item.SellIn
            };
            
            betterItem.Type = ItemType.Sulfuras;
            betterItem.DegradeWeight = 0;

            return betterItem;
        }

        if (item.Name.Contains("Backstage"))
        {
            var betterItem = new BackstagePassItem()
            {
                Name = item.Name,
                Quality = item.Quality,
                SellIn = item.SellIn
            };

            
            betterItem.Type = ItemType.BackstagePasses;
            betterItem.DegradeWeight = 1;

            return betterItem;
        }
        
        else if (item.Name.Contains("Aged"))
        {
            var betterItem = new AgedBriItem()
            {
                Name = item.Name,
                Quality = item.Quality,
                SellIn = item.SellIn
            };
            
            betterItem.Type = ItemType.AgedBrie;
            betterItem.DegradeWeight = 1;

            return betterItem;
        }

        if (item.Name.Contains("Conjured"))
        {
            var betterItem = new ConjuredItem()
            {
                Name = item.Name,
                Quality = item.Quality,
                SellIn = item.SellIn
            };
            
            betterItem.Type = ItemType.Conjured;
            betterItem.DegradeWeight = -2;

            return betterItem;
        }

        else
        {
            var betterItem = new BetterItem()
            {
                Name = item.Name,
                Quality = item.Quality,
                SellIn = item.SellIn
            };
            
            betterItem.Type = ItemType.Normal;
            return betterItem;
        }
    }
}