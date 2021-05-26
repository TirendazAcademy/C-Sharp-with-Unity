// 05- C# Class and Struct | OOP 
// Character

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string isim;
    public int tecrube = 0;
    public Character()
    {
        isim= "Atama yok";
    }
    public Character(string isim)
    {
        this.isim = isim;
    }

    public void BilgiYazdir()
    {
        Debug.LogFormat("Kahraman: {0} - {1} Tecrübe", isim, tecrube);
    }
}

public struct Silah
{
    public string isim;
    public int hasar;

    public Silah(string isim, int hasar)
    {
        this.isim = isim;
        this.hasar = hasar;
    }

    public void SilahBilgiYazdir()
    {
        Debug.LogFormat("Silah: {0} - {1} Hasar", isim, hasar);
    }
}