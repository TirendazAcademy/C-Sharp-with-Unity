//06-OOP
//Character

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

    public virtual void BilgiYazdir()
    {
        Debug.LogFormat("Kahraman: {0} - {1} Tecrübe", isim, tecrube);
    }

    private void Reset()
    {
        this.isim = "Değer atanmadı";
        this.tecrube = 0;
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

public class Paladin: Character
{
    public Silah silah;

    public Paladin(string isim, Silah silah): base(isim)
    {
        this.silah = silah;
    }

    public override void BilgiYazdir()
    {
        Debug.LogFormat("Selam {0} - Senin {1} al!", isim, silah.isim);
    }
}