using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidcam : MonoBehaviour
{
    public static vidcam instance;
    public GameObject vid1;
    public GameObject vid2;
    public GameObject vid_utama;
    public GameObject vid_outfit;
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
        float distance = Vector3.Distance (vid1.transform.position, vid2.transform.position);
        Debug.Log(distance);

        if(distance > 0.7){
            // Debug.Log("bb");
            vid_utama.SetActive(true);
            vid_utama.transform.localPosition = new Vector3(0,0,0);
            vid_outfit.SetActive(false);
            gui_utama.SetActive(true);
            info1.text = "Kamera Video adalah perangkat perekam gambar video yang mampu menyimpan gambar digital dari mode gambar analog. Kamera Video termasuk salah satu produk teknologi digital yang memiliki kemampuan mengambil input data analog berupa frekuensi sinar dan mengubah ke mode digital elektronis.";
            btn_play.SetActive(false);
        }
        else if(distance < 0.7){
            // Debug.Log("aa");
            vid_utama.SetActive(true);
            vid_outfit.SetActive(true);
            vid_utama.transform.SetParent(vid_utama.transform, false);
            vid_outfit.transform.SetParent(vid_utama.transform, false);
            vid_utama.transform.localPosition = new Vector3(0,2.4f,0.1f);
            vid_outfit.transform.localPosition = new Vector3(0,0.7f,-0.1f);
            vid_outfit.transform.localScale = new Vector3(11,11,11);
            vid_outfit.transform.localRotation = Quaternion.identity;
            info1.text = "Tripod adalah alat bantu fotografi atau videografi supaya dapat berdiri tegak. Tripod dapat digunakan untuk menstabilkan dan meninggikan peralatan fotografi atau videografi. Tripod memiliki tiga kaki dan kepala dudukan yang dipasangkan dengan peralatan fotografi atau videografi.";
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
