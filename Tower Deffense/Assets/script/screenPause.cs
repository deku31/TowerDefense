using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenPause : MonoBehaviour
{
    //resume game pause
    [SerializeField]private LevelManager lv;
   
    public void resume() 
    {
        gameObject.SetActive(false);
        lv.pausegame = false;
    }
}
