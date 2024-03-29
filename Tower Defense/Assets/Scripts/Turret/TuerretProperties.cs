using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public sealed class TuerretProperties : ScriptableObject
{
    public enum TurretMode
    {
        Primary,
        Secondary
    }
    [SerializeField] private TurretMode m_Mode;
    public TurretMode Mode => m_Mode;

    [SerializeField] private Projectile m_PerojectilePrefab;
    public Projectile PerojectilePrefab => m_PerojectilePrefab;

    [SerializeField] private float m_RateOfFire;
    public float RateOfFire => m_RateOfFire;

    [SerializeField] private int m_EnergyUsage;
    public int EnergyUsage => m_EnergyUsage;

    [SerializeField] private int m_AmmoUsage;
    public int AmmoUsage => m_AmmoUsage;

    [SerializeField] private Sound m_LaunchSFX;
    public Sound LaunchSFX => m_LaunchSFX;
}