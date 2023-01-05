using UnityEngine;

public class DiaryScriptWithCoin : MonoBehaviour
{
    [SerializeField] GameObject dairyMenu,koinaN;

 
    
    // Start is called before the first frame update
    public void Open()
    {
        
        
        if(dairyMenu)
        {
            
            dairyMenu.SetActive(true);
            koinaN.SetActive(false);

     
            
        }
        else
        {
           
            Time.timeScale = 0f;
           

            
        }
    }

    // Update is called once per frame
    public void Close()
    {

        if (dairyMenu)
        {
            dairyMenu.SetActive(false);
            koinaN.SetActive(true);

            Time.timeScale = 1f;
         
            
        }
        else
        {
           
        }
        //

    }
}