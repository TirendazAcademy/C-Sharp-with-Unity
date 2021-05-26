// 06-OOP
// Demo 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;

    // Start is called before the first frame update
    void Start()
    {      
        /*
        Character kahraman = new Character();
        //Debug.LogFormat("Kahraman: {0} - {1} Tecrübe", kahraman.isim, kahraman.tecrube);
        kahraman.BilgiYazdir();

        Character kadin_kahraman = new Character("Bilge");
        //Debug.LogFormat("Kadın kahraman: {0} - {1} Tecrübe", kadin_kahraman.isim, kadin_kahraman.tecrube);
        kadin_kahraman.BilgiYazdir();
        */
        Silah avciYayi = new Silah("Avcı Yayı", 105);
        

        /*
        Character kahraman= new Character();
        Character kahraman2 = kahraman;
        kahraman2.isim = "Deli Yürek";
        kahraman.BilgiYazdir();
        kahraman2.BilgiYazdir();
        //kahraman2.Reset();
        Paladin knight = new Paladin("Cesur Yürek", avciYayi); 
        knight.BilgiYazdir();
        */

        /*
        Silah avciYayi = new Silah("Avcı Yayı", 105); 
        Silah savasYayi= avciYayi;
        savasYayi.isim = "Savaş Yayı";
        savasYayi.hasar = 155;
        avciYayi.SilahBilgiYazdir();
        savasYayi.SilahBilgiYazdir();
        */

        /*
        directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        lightTransform = GameObject.Find("Directional Light").GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}