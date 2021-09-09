using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{
    public static camera instance;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam_utama;
    public GameObject cam_outfit;
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
        float distance = Vector3.Distance (cam1.transform.position, cam2.transform.position);
        Debug.Log(distance);

        if(distance > 1.2){
            // Debug.Log("bb");
            cam_utama.SetActive(true);
            cam_utama.transform.localPosition = new Vector3(0,0,0);
            cam_outfit.SetActive(false);
            gui_utama.SetActive(true);
            info1.text = "DSLR (Digital Single Lens Reflex) adalah kamera digital yang menggunakan cermin untuk memindahkan cahaya dari lensa ke jendela bidik (viewfinder), yang merupakan lubang di bagian belakang kamera dimana Anda dapat melihat melaluinya untuk melihat gambar apa yang Anda ambil.";
            btn_play.SetActive(false);
        }
        else if(distance < 1.2){
            // Debug.Log("aa");
            cam_utama.SetActive(true);
            cam_outfit.SetActive(true);
            cam_utama.transform.SetParent(cam_utama.transform, false);
            cam_outfit.transform.SetParent(cam_utama.transform, false);
            cam_outfit.transform.localPosition = new Vector3(-0.13f, -1.4f, 0.55f);
            cam_outfit.transform.localScale = new Vector3(0.26f,0.26f,0.26f);
            cam_outfit.transform.localRotation = Quaternion.Euler(270,0,0);
            info1.text = "Lensa Kamera adalah merupakan alat vital dari kamera yang berfungsi memfokuskan cahaya hingga mampu membakar medium penangkap. Terdiri atas beberapa lensa yang berjauhan yang bisa diatur sehingga menghasilkan ukuran tangkapan gambar dan variasi fokus yang berbeda.";
            btn_play.SetActive(true);
        }
        // Debug.Log(distance);
    }

    public void TutupInfo(){
        informasi.SetActive(false);
    }

    public void PlayQuiz(string scene){
        Application.LoadLevel(scene);
    }
}
