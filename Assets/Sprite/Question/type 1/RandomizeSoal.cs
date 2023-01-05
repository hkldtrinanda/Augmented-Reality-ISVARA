using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomizeSoal : MonoBehaviour
{
    public TextAsset assetSoal;

    private string[] soal;

    private string[,] soalBag;

    int indexSoal;

    int maxSoal;
    
    bool ambilSoal;

    char kunciJ;

    bool[] soalSelesai;
    //UI
    public Text txtSoal, txtA,txtB,txtC,txtD;
    public GameObject panel;
    public GameObject ImgPenilaian, ImgHasil, SalahObj, BenarObj;
    public Text txtHasil;
    

    bool isHasil;

    private float durasi;

    public float durasiPenilaian;
    
    int jwbBenar, jwbSalah;

    float nilai;
    // Start is called before the first frame update
    void Start()
    {
        durasi = durasiPenilaian;
        soal = assetSoal.ToString().Split('#');
        soalBag= new string[soal.Length,6];
        OlahSoal();
        maxSoal = soal.Length;
        TampilkanSoal();
        ambilSoal = true;
        print (maxSoal);
        soalSelesai = new bool[soal.Length];
    }

    private void OlahSoal()
    {
        for (int i = 0; i < soal.Length; i++)
        {
            string[] tempSoal = soal[i].Split('+');
            for (int j = 0; j < tempSoal.Length; j++)
            {
                soalBag[i, j] = tempSoal[j];
                continue;
            }
            continue;
            
        }
    }

    private void TampilkanSoal()
    {
        if (indexSoal < maxSoal)
        {
            if (ambilSoal)
            {
                for (int i = 0; i < soal.Length; i++)
                {
                    int indexSoal = Random.Range(0, soal.Length);
                    if (!soalSelesai[indexSoal])
                    {
                        txtSoal.text = soalBag[indexSoal, 0];
                        txtA.text = soalBag[indexSoal, 1];
                        txtB.text = soalBag[indexSoal, 2];
                        txtC.text = soalBag[indexSoal, 3];
                        txtD.text = soalBag[indexSoal, 4];
                        kunciJ = soalBag[indexSoal, 5][0];
                
                        soalSelesai[indexSoal] = true;
            
                        ambilSoal = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                
            }

        }
    }

    
    public void Opsi (string opsiHuruf)
    {
        CheckJawaban(opsiHuruf[0]);
        if (indexSoal == maxSoal - 1)
        {
            isHasil = true;
        }
        else
        {
            ambilSoal = true;
            indexSoal++;
        }
        
        panel.SetActive(true);
    }

    private float HitungNilai()
    {
       return nilai = (float)jwbBenar / maxSoal * 100;
    }

    
    
    private void CheckJawaban(char huruf)
    {
        if (huruf.Equals(kunciJ))
        {
            BenarObj.SetActive(true);
            SalahObj.SetActive(false);
            jwbBenar++;
        }
        else
        {
            SalahObj.SetActive(true);
            BenarObj.SetActive(false);
            jwbSalah++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf)
        {
            durasiPenilaian -= Time.deltaTime;
            if (durasiPenilaian <= 0)
            {
                panel.SetActive(false);
                durasiPenilaian = durasi;
                TampilkanSoal();
            }

            if (isHasil)
            {
                ImgPenilaian.SetActive(true);
                ImgHasil.SetActive(false);
                if (durasiPenilaian <= 0)
                {
                    txtHasil.text = "jumlah benar : " + jwbBenar + "\n jumlah salah : " + jwbSalah +"\nnilai" + HitungNilai();
                    ImgPenilaian.SetActive(false);
                    ImgHasil.SetActive(true);
                    durasiPenilaian = 0;
                }
            }

            else
            {
                ImgHasil.SetActive(false);
                ImgPenilaian.SetActive(true);
                if (durasiPenilaian <= 0)
                {
                    panel.SetActive(false);
                    durasiPenilaian = durasi;
                    
                    TampilkanSoal();
                }
            }
        }
    }
}
