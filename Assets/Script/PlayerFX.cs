using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class PlayerFX : MonoBehaviour
{
    [Header("Screen Shake FX")]
    private CinemachineImpulseSource screenShake;
    [SerializeField] private float shakeMultiplier;
    public Vector3 shakeHighDamage;

    private void Start()
    {
        screenShake = GetComponent<CinemachineImpulseSource>();
    }


    public void HitStopEffect(float _duration, float _slowdownFactor)
    {
        ScreenShake(shakeHighDamage);
        StartCoroutine(HitStop(_duration, _slowdownFactor));
    }

    IEnumerator HitStop(float duration, float slowdownFactor)
    {
        Time.timeScale = slowdownFactor;
        yield return new WaitForSecondsRealtime(duration);
        Time.timeScale = 1f;
    }

    public void ScreenShake(Vector3 _shakePower)
    {
        screenShake.m_DefaultVelocity = new Vector3(_shakePower.x * 1, _shakePower.y) * shakeMultiplier;
        screenShake.GenerateImpulse();
    }
}
