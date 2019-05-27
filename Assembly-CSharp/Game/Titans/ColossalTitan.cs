using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assembly_CSharp.Game.Titans
{
    public class ColossalTitan
    {
        #region strings

        private string State = "idle";

        private string AttackAnimation;
        
        #endregion

        #region Floats

        private float AttackTime;

        private float AttackTimeA;

        private float AttackTimeB;

        private float HitCapsuleR;

        #endregion

        private Transform HitCapsuleStart;

        private Transform HitCapsuleEnd;

        private void SweepAttack(string type = "")
        {
            this.State = "SweepingAttack";
            this.AttackAnimation = "Sweeping" + type;
            this.AttackTimeA = 0.4f;
            this.AttackTimeB = 0.57f;
        }
    }
}
