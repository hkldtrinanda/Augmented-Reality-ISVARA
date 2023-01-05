using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ARCamera : MonoBehaviour
{
    public GameObject Kamerad,KameradKW,Panela;
    // Start is called before the first frame update
    void Start()
    {
        Kamerad.SetActive(false);
        KameradKW.SetActive(true);
        Panela.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void KameraAktivieren()
    {
        Panela.SetActive(false);
        Kamerad.SetActive(true);
        KameradKW.SetActive(false);
    }
    
    public void KameraDeaktivieren()
    {
        Panela.SetActive(true);
        Kamerad.SetActive(false);
        KameradKW.SetActive(true);
    }
}
