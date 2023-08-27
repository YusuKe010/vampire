using UnityEngine;

public class ItemBase : MonoBehaviour
{
    [SerializeField] Item _item = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && _item.ItemType == Item.ItemTypeEnum.HealItem)
        {
            //Player�̃X�e�[�^�X����肷��
            //���̌�ItemGet�̐��l�ŕω���������
            PlayerController playerController = collision.GetComponent<PlayerController>();
            PlayerController.Instance.PlayerHeal(_item.ItemGet);
        }
        else if (collision.tag == "Player" && _item.ItemType == Item.ItemTypeEnum.WeaponItem)
        {

        }

        Destroy(this.gameObject);
    }
}
