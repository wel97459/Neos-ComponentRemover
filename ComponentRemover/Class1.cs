using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseX;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace ComponentRemover
{
    [Category("Util")]
    public class ComponentRemover : Component
    {
        public readonly Sync<bool> HasRun;
        protected override void OnAwake()
        {
            base.OnAwake();
        }

        protected override void OnCommonUpdate()
        {
            if (!HasRun.Value)
            {
                var list = Slot.GetComponentsInChildren<LogixReference>();
                list.ForEach(lRef => lRef.Destroy(sendDestroyingEvent: true));
             }
             
            HasRun.Value = true;
        }
    }
}
