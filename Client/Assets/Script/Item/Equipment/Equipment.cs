﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item
{
    public enum Part { Helmet, Bag, Vest, Weapon };

    public Part _part;

    [SerializeField]
    protected int _level;

    public override void OnPickUp(Inventory inventory)
    {
        base.OnPickUp(inventory);
        //TODO: 캐릭터에 같은 부위가 있으면 그 부위 삭제 후 장착
    }

    public override string GetData()
    {
        return _name + " 레벨" + '(' + _level.ToString() + ')';
    }
}
