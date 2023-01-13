using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Button : MonoBehaviour
{
    [SerializeField] private Image _buttonFilledVersion;
    [SerializeField] private float _changeTime;
    [SerializeField] [Range(0f, 1f)] private float _defaultPercentTransparency;
    [SerializeField] [Range(0f, 1f)] private float _changedPercentTransparency;

    private void OnMouseEnter()
    {
        _buttonFilledVersion.DOFade(_changedPercentTransparency, _changeTime);
    }

    private void OnMouseExit()
    {
        _buttonFilledVersion.DOFade(_defaultPercentTransparency, _changeTime);
    }
}
