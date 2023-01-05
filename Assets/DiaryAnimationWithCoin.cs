using UnityEngine;

public class DiaryAnimationWithCoin : MonoBehaviour
{
    [SerializeField] GameObject dairyMenu,koinaN;

    public Animator anim;
    
    // Start is called before the first frame update
    public void Open()
    {
        
        
        if(dairyMenu)
        {
            
            dairyMenu.SetActive(true);
            koinaN.SetActive(false);

            anim.SetBool("AnimateOut", true);
            
        }
        else
        {
           
            Time.timeScale = 0f;
           
            anim.SetBool("AnimateOut", false);
            
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
         
            anim.SetBool("AnimateOut", false);
        }
        else
        {
            anim.SetBool("AnimateOut", true);
        }
        //

    }
}