using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class UIscript : MonoBehaviour
{
    public Vector3 targetPos, originalPos;
    public Vector3 targetSize;

    public GameObject targetGameObj;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void MoveTween()
    {
        targetGameObj.transform.DOLocalMove(targetPos, speed).SetEase(Ease.Linear).OnComplete(() => ReturnPos());
    }
    public void ReturnPos()
    {
        targetGameObj.transform.DOLocalMove(originalPos, speed).SetEase(Ease.Linear);
    }   
    public void ScaleTween()
    {
        targetGameObj.transform.DOScale(Vector3.zero, speed).SetEase(Ease.Linear);
    }
}