using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pentab : MonoBehaviour
{
    public static pentab instance;
    public GameObject pentab1;
    public GameObject pentab2;
    public GameObject pentab_utama;
    public GameObject pentab_outfit;
    public Text info1;
    public GameObject gui_utama,btn_play,informasi;

    // Start is called before the first frame update
    void Start()
    {
        btn_play.SetActive(false);
        gui_utama.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (pentab1.transform.position, pentab2.transform.position);
        Debug.Log(distance);

        if(distance > 1.2){
            // Debug.Log("bb");
            pentab_utama.SetActive(true);
            pentab_utama.transform.localPosition = new Vector3(0,0,0);
            pentab_outfit.SetActive(false);
            gui_utama.SetActive(true);
            info1.text = "Tablet grafis adalah perangkat keras yang membolehkan pemakainya untuk menggambar dengan tangan dan memasukkan gambar atau sketsa langsung ke komputer. Tablet digital dapat mendeteksi gerakan kursor atau pena digital kemudian menerjemahkannya menjadi sinyal digital yang dikirim ke komputer.";
            btn_play.SetActive(false);
        }
        else if(distance < 1.2){
            // Debug.Log("aa");
            pentab_utama.SetActive(true);
            pentab_outfit.SetActive(true);
            pentab_utama.transform.SetParent(pentab_utama.transform, false);
            pentab_outfit.transform.SetParent(pentab_utama.transform, false);
            pentab_outfit.transform.localPosition = new Vector3(0.1f, 0, -0.1f);
            pentab_outfit.transform.localRotation = Quaternion.Euler(-45,-45,0);
            info1.text = "Pena digital mirip dengan pena yang berfungsi layaknya mouse pada komputer, hanya saja memakai tidak memakai tinta melainkan dilengkapi oleh ujung elektronik.";
            btn_play.SetActive(true);
        }
    }

    public void TutupInfo(){
        informasi.SetActive(false);
    }

    public void PlayQuiz(string scene){
        Application.LoadLevel(scene);
    }
}
