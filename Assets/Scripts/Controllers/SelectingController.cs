using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectingController : MonoBehaviour
{
    bool isUnitSelected = false;
    bool isObjectSelected = false;
    GameObject objectSelected;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                SelectingUnit(hit);
                SelectingResource(hit);
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (isUnitSelected)
            {
                isUnitSelected = false;
                objectSelected.GetComponent<UnitMovement>().ToggleSelect(isUnitSelected);
            }
            else if (isObjectSelected)
            {
                isObjectSelected = false;
                //Send deselect
            }
            objectSelected = null;
            
        }
    }

    void SelectingUnit(RaycastHit _hit)
    {
        if (_hit.collider.CompareTag("Unit"))
        {
            isUnitSelected = true;
            isObjectSelected = false;
            objectSelected = _hit.collider.gameObject;
            objectSelected.GetComponent<UnitMovement>().ToggleSelect(isUnitSelected);
        }
        else if (!_hit.collider.CompareTag("Unit") && isUnitSelected)
        {
            objectSelected.GetComponent<UnitMovement>().MoveToTarget(_hit.point);
        }

    }

    void SelectingResource(RaycastHit _hit)
    {
        if (_hit.collider.CompareTag("Resource"))
        {
            isObjectSelected = true;
            isUnitSelected = false;
            objectSelected = _hit.collider.gameObject;
        }
        else if (!_hit.collider.CompareTag("Resource") && isUnitSelected)
        {
            //objectSelected.GetComponent<Resource>().MoveToTarget(_hit.point);
        }
    }
}
