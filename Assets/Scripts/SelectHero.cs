using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHero : MonoBehaviour
{
	public TypeSkin typeSkin;
    public MenuController menuController;
    private void OnMouseDown()
    {
        GlobalDataController.Instance.typeSkin = typeSkin;
        menuController.StartNew();
    }
}
