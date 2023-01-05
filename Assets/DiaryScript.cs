using UnityEngine;

public class DiaryScript : MonoBehaviour
{
    [SerializeField] GameObject dairyMenu;

 
    
    // Start is called before the first frame update
    public void Open()
    {
        
        
        if(dairyMenu)
        {
            
            dairyMenu.SetActive(true);
            

     
            
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
            

            Time.timeScale = 1f;
         
            
        }
        else
        {
           
        }
        //

    }
}
