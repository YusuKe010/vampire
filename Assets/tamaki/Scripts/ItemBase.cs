using UnityEngine;

public class ItemBase : MonoBehaviour
{
    [SerializeField] Item _item = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && _item.ItemType == Item.ItemTypeEnum.HealItem)
        {
            //Playerのステータスを入手する
            //その後ItemGetの数値で変化をさせる
        }
        else if (collision.tag == "Player" && _item.ItemType == Item.ItemTypeEnum.WeaponItem)
        {

        }

        Destroy(this.gameObject);
    }
}
