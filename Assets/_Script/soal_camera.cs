using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soal_camera : MonoBehaviour
{
    private int nilaiAcak;
    public Text textSoal, textA, textB, textC, textD, textWaktu, textSkor;
    public GameObject g_mulai,g_bg,g_selesai;
    public List<Soal> KumpulanSoal;
    public float waktu;
    public int skor;
    [System.Serializable]
    public class Soal{
        [TextArea]
        [Header("Soal")]
        public string soal;

        [Header("Pilihan untuk jawaban")]
        public string pilA;
        public string pilB, pilC, pilD;

        [Header("Kunci jawaban")]
        public bool A;
        public bool B,C,D;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        g_mulai.SetActive(true);
        if(g_bg.active){
            textSoal = GameObject.Find("TextSoal").GetComponent<Text>();
            textA = GameObject.Find("A").GetComponent<Text>();
            textB = GameObject.Find("B").GetComponent<Text>();
            textC = GameObject.Find("C").GetComponent<Text>();
            textD = GameObject.Find("D").GetComponent<Text>();
            textWaktu = GameObject.Find("TextWaktu").GetComponent<Text>();

            nilaiAcak = Random.RandomRange(0,KumpulanSoal.Count);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(g_bg.active){
            if(KumpulanSoal.Count > 0){
                textSoal.text = KumpulanSoal[nilaiAcak].soal;
                textA.text = KumpulanSoal[nilaiAcak].pilA;
                textB.text = KumpulanSoal[nilaiAcak].pilB;
                textC.text = KumpulanSoal[nilaiAcak].pilC;
                textD.text = KumpulanSoal[nilaiAcak].pilD;
                textWaktu.text = waktu.ToString("0");
                waktu -= Time.deltaTime;
                if(waktu <= 0){
                    KumpulanSoal.RemoveAt(nilaiAcak);
                    waktu = 60;
                    nilaiAcak = Random.RandomRange(0,KumpulanSoal.Count);
                }
            }
            else{
                g_bg.SetActive(false);
                g_selesai.SetActive(true);
                textSkor.text = skor.ToString();
            }
        }
    }

    public void CekJawaban(string jawaban){
        if(KumpulanSoal[nilaiAcak].A == true && jawaban == "a"){
            skor += 5;
        }
        if(KumpulanSoal[nilaiAcak].B == true && jawaban == "b"){
            skor += 5;
        }
        if(KumpulanSoal[nilaiAcak].C == true && jawaban == "c"){
            skor += 5;
        }
        if(KumpulanSoal[nilaiAcak].D == true && jawaban == "d"){
            skor += 5;
        }
        
        KumpulanSoal.RemoveAt(nilaiAcak);
        nilaiAcak = Random.RandomRange(0,KumpulanSoal.Count);
        waktu = 60;
    }

    public void ExitQuiz(string scene){
        Application.LoadLevel(scene);
    }
}
