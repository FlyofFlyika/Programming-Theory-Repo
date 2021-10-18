using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeSkin{
	Berserk,
	SpaceShooterWarrior
}
public class GlobalDataController : MonoBehaviour
{
    public static GlobalDataController Instance;
	public TypeSkin typeSkin{get;set;}
    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
