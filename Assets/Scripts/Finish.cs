using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        int p = other.GetComponent<Player>().Point;
        MainUI.instance.ShowNotiText("YOU WIN!!\nScore: "+ p);

    }
}
