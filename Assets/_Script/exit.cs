using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public void Exit(string scene){
        Application.LoadLevel(scene);
    }
}
