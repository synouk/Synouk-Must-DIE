using UnityEngine;
using System.Collections;

public class BaseItem {

    string _itemName;
    string _itemDescription;
    int _itemID;
    
    ItemTypes _itemType;

    public string ItemName
    {
        get
        {
            return _itemName;
        }

        set
        {
            _itemName = value;
        }
    }

    public string ItemDescription
    {
        get
        {
            return _itemDescription;
        }

        set
        {
            _itemDescription = value;
        }
    }

    public int ItemID
    {
        get
        {
            return _itemID;
        }

        set
        {
            _itemID = value;
        }
    }

    public ItemTypes ItemType
    {
        get
        {
            return _itemType;
        }

        set
        {
            _itemType = value;
        }
    }
}
