using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class headphone : MonoBehaviour
{
    public GameObject hp1;
    public GameObject hp2;
    public GameObject hp_utama;
    public GameObject hp_outfit;
    AudioSource audio;
    public Text info1;
    public GameObject gui_utama,btn_play,informasi;

    // Start is called before the first frame update
    void Start()
    {
        btn_play.SetActive(false);
        gui_utama.SetActive(false);
        audio = GetComponent<AudioSource>();
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (hp1.transform.position, hp2.transform.position);
        Debug.Log(distance);
        audio = GetComponent<AudioSource>();
        if(distance > 1.2){
            // Debug.Log("bb");
            hp_utama.SetActive(true);
            hp_outfit.SetActive(false);
			audio.PlayDelayed(1);
            gui_utama.SetActive(true);
            info1.text = "Headphone merupakan aksesori alat dengar sederhana yang hanya bisa digunakan untuk mendengarkan tanpa bisa digunakan untuk komunikasi. Biasanya, kualitas suara dari headphone lebih bagus daripada headset karena headphone didesain untuk mendengarkan audio saja.";
            btn_play.SetActive(false);
        }
        else if(distance < 1.2){
            // Debug.Log("aa");
            hp_utama.SetActive(true);
            hp_outfit.SetActive(true);
            hp_utama.transform.SetParent(hp_utama.transform, false);
            hp_outfit.transform.SetParent(hp_utama.transform, false);
            hp_outfit.transform.localPosition = new Vector3(-0.58f, -1.2f, -0.7f);
            hp_outfit.transform.localRotation = Quaternion.Euler(0,180,-30);
            hp_outfit.transform.localScale = new Vector3(7,7,7);
            info1.text = "SD (Secure Digital) Card merupakan memory Card flash ultra kecil yang dirancang untuk menyediakan memori berkapasitas tinggi dalam ukuran yang kecil.";
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
