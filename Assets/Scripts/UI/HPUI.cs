using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUI : MonoBehaviour
{

    [SerializeField] private Image _hpBar;

    private IEnumerator lossAnimation;

    private void Start()
    {
    
    }

    public void TriggerHPLossAnimation(float target_percentage)
    {
        lossAnimation = AnimateHPLoss(target_percentage);
        StartCoroutine(lossAnimation);
    }

    public IEnumerator AnimateHPLoss(float target_percentage)
    {
        //Will not run current routine if there is last one running. 
        //Needs to be tested though
        yield return new WaitUntil(() => !lossAnimation.MoveNext());


        Debug.Log("Test");
        yield return new WaitForSeconds(1F);
        while (_hpBar.fillAmount > target_percentage)
        {
            _hpBar.fillAmount -= 0.01F;
            yield return new WaitForSeconds(0.001F);
        }

        _hpBar.fillAmount = target_percentage;
       
    }

}
