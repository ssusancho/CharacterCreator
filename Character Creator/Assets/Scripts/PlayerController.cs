using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer;
   
    public SpriteRenderer WeaponRenderer;
   
    public UnityEngine.UI.Text ElementName;
    public UnityEngine.UI.Text ElementDescription;
    public UnityEngine.UI.Text ElementPrice;

     public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }

       public void SetWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }


    public void SetName(string newname)
    {
        ElementName.text = newname;
    }
    
    public void SetDescription(string newdescription)
    {
        ElementDescription.text = newdescription;
    }

  
    
    public void SetPrice(string newprice)
    {
        ElementPrice.text = newprice;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }  

    // Update is called once per frame
    void Update()
    {
        
    }
}
