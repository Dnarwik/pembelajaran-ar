using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printer : MonoBehaviour
{
    public GameObject printer1;
    public GameObject printer2;
    public GameObject printer_utama;
    public GameObject printer_outfit;
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
        float distance = Vector3.Distance (printer1.transform.position, printer2.transform.position);
        Debug.Log(distance);
        if(distance > 1.2){
            // Debug.Log("bb");
            printer_utama.SetActive(true);
            printer_outfit.SetActive(false);
            gui_utama.SetActive(true);
            info1.text = "Printer berasal dari kata “Print” yang artinya adalah cetak, sehingga printer adalah alat untuk mencetak. Pada dunia komputer, printer merupakan perangkat tambahan (peripheral) output yang menampilkan hasil tulisan atau gambar di sebuah kertas atau media sejenis.";
            btn_play.SetActive(false);
        }
        else if(distance < 1.2){
            // Debug.Log("aa");
            printer_utama.SetActive(true);
            printer_outfit.SetActive(true);
            printer_utama.transform.SetParent(printer_utama.transform, false);
            printer_outfit.transform.SetParent(printer_utama.transform, false);
            printer_outfit.GetComponent<Animation>().Play("paper");
            printer_outfit.transform.localPosition = new Vector3(0, 0.2f, 0.3f);
            printer_outfit.transform.localRotation = Quaternion.Euler(65,0,0);
            info1.text = "Kertas adalah bahan yang tipis, yang dihasilkan dengan kompresi serat yang berasal dari pulp. Serat yang digunakan biasanya adalah alami, dan mengandung selulosa dan hemiselulosa.";
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
