using System.Collections;
using UnityEngine;


public class Door : MonoBehaviour
{

    public float openedHeight = 5f;
    public float openTime = 1f;
    public bool IsOpen;
    private Vector3 _startPosition;

    private void Start(){
        _startPosition = transform.position;
    }

    public IEnumerator Open(){
        float t = 0f;
        while (t < 1){
            t += Time.deltaTime / openTime;
            transform.position = Vector3.Lerp(_startPosition, _startPosition + Vector3.up * openedHeight, t *t);
            yield return null;
        }
    }

    public IEnumerator Close(){
        float t = 0f;
        while (t < 1){
            t += Time.deltaTime / openTime;
            transform.position = Vector3.Lerp(_startPosition + Vector3.up * openedHeight, _startPosition, t * t);
            yield return null;
        }
    }
}
