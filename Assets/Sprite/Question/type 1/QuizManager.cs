using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject End;
    public Text Scoring;
    private int score;
    /*public string scene;*/
    public GameObject panelUtama,panelPertanyaan, iconPertanyaanFalse,iconPertanyaanTrue,panelCard,Carddeck,koinaN;
    

    int currentLevel;
    void Start () 
    {
   
        Scoring.text = "";
        panelCard.SetActive(false);
        koinaN.SetActive(false);
 
    }

    private void Update()
    {
        Scoring.text = "Nilai Kamu!\n" + score;
    }

    public void wrongAnswer()
    {
        // ResetScreen.SetActive(true);
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
            score = score + 0;
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
            score = score + 0;
        }
    }

    public void NextScene ()
    {
        panelUtama.SetActive(true);
        panelPertanyaan.SetActive(false);
        iconPertanyaanFalse.SetActive(false);
        iconPertanyaanTrue.SetActive(true);
        Carddeck.SetActive(true);
        panelCard.SetActive(true);
        koinaN.SetActive(true);
        /*SceneManager.LoadScene(scene);*/
        Debug.Log("Selesai!");
    }

    
    public void correctAnswer()
    {
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
            score = score + 10;
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
            score = score + 10;
        }
    }




}
