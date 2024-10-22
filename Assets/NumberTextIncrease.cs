using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    int num = 0000;
    int ChangeCount = 0;

    public void ButtonClick()
    {
        if (ChangeCount == 0)
        {
            num++;
            numberText.text = num.ToString().PadLeft(4, '0');
        }
        else
        {
            num = num + 2;
            
            numberText.text = num.ToString().PadLeft(4, '0');
        }
        
        
    }
    public void ButtonMinus()
    {
        if (ChangeCount == 0)
        {
            
            if (num == 0)
            {
                num = num;
            }
            else
            {
                num--;
                numberText.text = num.ToString().PadLeft(4, '0');
            }
        }
        else
        {
            if (num == 0)
            {
                num = num;
            }
            else
            {
                num=num-2;
                
                numberText.text = num.ToString().PadLeft(4, '0');
            }
        }


    }

    public void ButtonReset()
    {
        num = 0;
        numberText.text = num.ToString().PadLeft(4, '0');   
    }

    public void ButtonChangeCount()
    {
        if (ChangeCount == 0)
        { ChangeCount=ChangeCount+1; }
        else 
        { ChangeCount=ChangeCount-1; }
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

