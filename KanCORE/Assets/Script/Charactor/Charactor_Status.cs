using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor_Status : MonoBehaviour
{

    [Serializable]
    public class statusSettings
    {
        public int HitPoint = 30000;   // Speed when walking forward
        public float Energy = 1000;   // Speed when walking forward
        public float E_Recover = 1.5f;   // Speed when walking forward
        public float EM_Boost = 0.8f;
        public float EM_Limit = 5;
    }

    [Serializable]
    public class moveSettings
    {
        public float Ground_MoveSpeed = 0.5f;   // Speed when ground
        public float Hover_MoveSpeed = 0.5f;   // Speed when water
        public float Air_MoveSpeed = 0.5f;   // Speed when air
        public float Jump_MoveSpeed = 0.2f;   // Speed when air
        public float m_AnimSpeedMultiplier = 1f;
        [Range(0f, 10f)] public float m_GroundGravityMultiplier = 0.5f;
        [Range(0f, 10f)] public float m_AirGravityMultiplier = 3.5f;
        [HideInInspector] public float CurrentTargetSpeed = 8f;
        [Range(1f, 10f)] public float Move_ReactionRate = 7.5f;
        public float m_CameraSensility = 2;
        public float m_CameraTurnSpeed = 10;
        public float BoostOn_Gravity = 1f;
        public float BoostOff_Gravity = 5f;
    }

    [Serializable]
    public class jumpSettings
    {
        public float StartForce = 20f;
        public float BoostForce = 50f;
        public float JumpEnergy = 300f;
        public float BoostEnergy = 100f;
    }
    [Serializable]
    public class BoostSettings
    {
        public float StartForce = 40f;
        public float StepTime = 4f;
        public float BoostForce = 25f;
        public float BoostEnergy = 2000f;
    }
    [Serializable]
    public class DashSettings
    {
        public float StartForce = 50f;
        public float StraightForce = 3f;
        public float SideForce = 3f;
        public float DelayTime = 4f;
        public float BoostEnergy = 120;
        public float ChargeEnergy = 80;
    }

    [Serializable]
    public class AdvancedSettings
    {
        public float groundCheckDistance = 0.01f;
        public float stickToGroundHelperDistance = 0.5f;
        public float slowDownRate = 20f;
        public float k_Half = 0.55f;
        public float Stability = 100f;
        public float Stability_Time = 0.5f;
    }

    [Serializable]
    public class OWSettings
    {
        public float Limit = 60f;
    }

    [Serializable]
    public class BreakDownSettings
    {
        public float UnderLimit = -100f;
    }

}
