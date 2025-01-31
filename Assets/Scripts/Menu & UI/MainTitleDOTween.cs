using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainTitleDOTween : MonoBehaviour
{
    [SerializeField] Animator animFadeOut;
    [SerializeField] GameObject _Panel, _TitlePanel;
    public void OnPressAnywhere() {
        _TitlePanel.gameObject.SetActive(false);
        animFadeOut.Play("FadeOut");
        StartCoroutine(Fade());
    }
    IEnumerator Fade() {
        yield return new WaitForSeconds(1.35f);
        _Panel.SetActive(false);
    }

}
