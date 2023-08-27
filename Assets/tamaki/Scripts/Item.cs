using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CreateItem")]
public class Item : ScriptableObject
{
    [SerializeField] string _itemName = string.Empty;
    public string ItemName => _itemName;
    [SerializeField] ItemTypeEnum _itemType = ItemTypeEnum.HealItem;
    public ItemTypeEnum ItemType => _itemType;
    [SerializeField] int _itemGet = 1;
    public int ItemGet => _itemGet;

    public enum ItemTypeEnum
    {
        HealItem,
        WeaponItem,
    }
}
