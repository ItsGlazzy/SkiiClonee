using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        player.HP -= 15;

        if (player.HP <= 0)
        {
            player.HP = 0;
            MainUI.instance.ShowNotiText("You are Dead");
        }

    }
}
