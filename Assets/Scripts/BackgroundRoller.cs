using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(RectTransform))]
public class BackgroundRoller : MonoBehaviour
{
    [SerializeField] private float _timeForFullRoll;
    [SerializeField] private float _topYPosition;
    [SerializeField] private float _bottomYPosition;

    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        Vector3 targetPosition = new Vector3(_rectTransform.position.x, _topYPosition, _rectTransform.position.z);

        DOTween.To(() => _rectTransform.position, x => _rectTransform.position = x, targetPosition, _timeForFullRoll);
    }
}
