using UnityEngine;

public class ItemBase : MonoBehaviour
{
    [SerializeField] Item _item = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Player�̃X�e�[�^�X����肷��
            //���̌�ItemGet�̐��l�ŕω���������
            Destroy(this.gameObject);
        }
    }
}
