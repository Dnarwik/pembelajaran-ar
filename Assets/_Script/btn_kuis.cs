using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_kuis : MonoBehaviour
{
    public GameObject g_mulai,g_kuis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void scale(float scale){
        transform.localScale = new Vector2(1/scale,1*scale);
    }

    public void play(){
        g_mulai.SetActive(false);
        g_kuis.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
