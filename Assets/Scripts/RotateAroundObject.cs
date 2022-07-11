using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RotateAroundObject : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float rotationSpeed;
    [SerializeField] TMP_Text _text;
    private float _distance;
    private int _cycle=0;


    // void Start()
    // {
    //     StartCoroutine(Rotate());
    // }

    // IEnumerator Rotate(){
        
    //     yield return new WaitForEndOfFrame();
    //     StartCoroutine(Rotate());
    // }

    private void Update() {
        transform.RotateAround(target.transform.position,Vector3.up,rotationSpeed*Time.deltaTime);
        _distance+=rotationSpeed*Time.deltaTime;

        if (_distance>360)
        {
            _distance=0;
            _cycle++;
            _text.text= gameObject.name + " has completed a full rotation! Cycle: "+_cycle;
        }
    }
}
