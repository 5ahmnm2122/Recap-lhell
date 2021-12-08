using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    public void OnMouseDown()
    {
        Destroy(this.gameObject);
        ScoreManager.scoreValue += 1;
    }
}
