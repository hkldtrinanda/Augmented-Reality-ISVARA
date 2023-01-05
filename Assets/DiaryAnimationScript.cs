using UnityEngine;

public class DiaryAnimationScript : MonoBehaviour
{
    [SerializeField] GameObject dairyMenu;

    public Animator anim;
    
    
    // Start is called before the first frame update
    public void Open()
    {
        
        
        if(dairyMenu)
        {
            
            dairyMenu.SetActive(true);
        

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
