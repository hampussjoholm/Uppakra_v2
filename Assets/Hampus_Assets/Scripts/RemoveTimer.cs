using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RemoveTimer : MonoBehaviour
{
    public float deactivateAfterSeconds = 5f;
    public GameObject newCanvas;

    private void OnEnable() {
        StartCoroutine(DeactivateAfterDelay());
    }

    private System.Collections.IEnumerator DeactivateAfterDelay() {
        yield return new WaitForSeconds(deactivateAfterSeconds);
        gameObject.SetActive(false);
        newCanvas.SetActive(true);
    }
}
