using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting;
using ThunderRoad;
using UnityEditor;
//using UnityEditor.Build.Pipeline;
using UnityEngine;
using UnityEngine.XR;


public class supercooleffect : MonoBehaviour
{
    /*public GameObject sword;
    public Material normalMat;
    public Material shaderMat;
    public GameObject start;
    public GameObject loop;
    public GameObject VFX;
    public GameObject blade;
    public GameObject SpellSword;
    public EffectAudio dude;
    public AudioSource awd;
    public AudioSource awdd;




    bool gripped;
    bool wasPressed = false;
    bool isActivated = false;

    void Start()
    {
       // /*var inputDevices = new List<UnityEngine.XR.InputDevice>();
       // UnityEngine.XR.InputDevices.GetDevices(inputDevices);
       // foreach (var device in inputDevices)
       // {
       //    Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
       //}
       // var rightInput = inputDevices[1];
       //rightInput.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out gripped);
            
        SpellSword.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        var inputDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(inputDevices);
        var rightInput = inputDevices[2];
        Debug.Log(gripped + ":gripped - wasPressed:" + wasPressed);
        Debug.Log(dude.audioContainer.sounds[0] + "  " + dude.audioContainer.sounds[1]);
        if (rightInput.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryButton, out gripped) && gripped || Input.GetKeyDown(KeyCode.L))
        {
            Activate();
            isActivated = true;
        }
        if (!isActivated)
        {
            Deactivate();
        }
        if (Input.GetKeyDown(KeyCode.L)) isActivated = false;
        //sword.GetComponent<MeshRenderer>().material = shaderMat;
    }

    void Deactivate()
    {
        SpellSword.SetActive(false);
        //sword.GetComponent<MeshRenderer>().material = normalMat;
        sword.GetComponent<MeshRenderer>().material = normalMat;
        VFX.SetActive(false);
        start.SetActive(false);
        loop.SetActive(false);
        blade.SetActive(true);
    }

    void Activate()
    {
        awd.clip = dude.audioContainer.sounds[0];
        awdd.clip = dude.audioContainer.sounds[1];
        SpellSword.SetActive(true);
        blade.SetActive(false);
        sword.GetComponent<MeshRenderer>().material = shaderMat;
        VFX.SetActive(true);
        start.SetActive(true);
        loop.SetActive(true);
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.mass /= 2;

    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    */
}
