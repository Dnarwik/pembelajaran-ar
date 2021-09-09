using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credit : MonoBehaviour
{
    public void Credit(string scene){
        Application.LoadLevel(scene);
    }
}
