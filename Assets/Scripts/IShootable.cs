using UnityEngine;

public interface IShootable
{
    //Auto Property
    public GameObject Bullet { get; set; }

    public Transform ShootPoint { get; set; }

    public float ReloadTime { get; set; }

    public float WaitTime { get; set; }

    //Method
    public void Shoot();
}
