using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public BaseController baseControl;

    [Header("Resource Texts")]
    public Text WoodText;
    public Text GoldText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WoodText.text = "Wood: " + baseControl.resourceWood;
        GoldText.text = "Gold: " + baseControl.resourceGold;
    }
}
