using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public SpaceShooterWarriorPlayer spaceShooterWarriorPlayer;
    public BerserkPlayer berserkPlayer;
    // Start is called before the first frame update
    void Start()
    {
        if (!GlobalDataController.Instance)
        {
            berserkPlayer.gameObject.SetActive(true);
            return;
        }
        switch (GlobalDataController.Instance.typeSkin)
        {
            case TypeSkin.Berserk:
                berserkPlayer.gameObject.SetActive(true);
                break;
            case TypeSkin.SpaceShooterWarrior:
                spaceShooterWarriorPlayer.gameObject.SetActive(true);
                break;
            default:
                Debug.LogError(GlobalDataController.Instance.typeSkin.GetType().Name + " error in PlayerLoader");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
