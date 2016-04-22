using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class BasePsycho
{
    string _name;
    int _priceToRemove;
    string _description;

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    public int PriceToRemove
    {
        get
        {
            return _priceToRemove;
        }

        set
        {
            _priceToRemove = value;
        }
    }

    public string Description
    {
        get
        {
            return _description;
        }

        set
        {
            _description = value;
        }
    }
}