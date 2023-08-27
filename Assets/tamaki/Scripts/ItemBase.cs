using UnityEngine;

public class ItemBase : MonoBehaviour
{
    [SerializeField] Item _item = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Playerのステータスを入手する
            //その後ItemGetの数値で変化をさせる
            Destroy(this.gameObject);
        }
    }
}
