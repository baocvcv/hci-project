﻿using UnityEngine;
using UnityEngine.Assertions;

namespace Tsinghua.HCI.IoTVRP
{
	public class Controller : MonoBehaviour
	{
		[SerializeField] private LightItem _lightitem = null;
		[SerializeField] private TMPro.TextMeshPro modetext = null;
		[SerializeField] private TMPro.TextMeshPro modetext2 = null;
		[SerializeField] private float increase;
		[SerializeField] private float decrease;

        private void Start()
        {
            if (modetext)
            {
				modetext.text = LightItem.GetMode();
				modetext2.text = LightItem.GetMode();
			}
		}

        private void Awake()
		{
		}
		public void Toggle(OculusSampleFramework.InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == OculusSampleFramework.InteractableState.ActionState)
			{
				_lightitem.Toggle();
			}
		}
		public void Increase(OculusSampleFramework.InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == OculusSampleFramework.InteractableState.ActionState)
			{
				_lightitem.IncreaseIntensity(increase);
			}
		}
		public void Decrease(OculusSampleFramework.InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == OculusSampleFramework.InteractableState.ActionState)
			{
				_lightitem.DecreaseIntensity(increase);
			}
		}
		public void ToggleMode(OculusSampleFramework.InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == OculusSampleFramework.InteractableState.ActionState)
			{
                    LightItem.ToggleMode();
				modetext.text = LightItem.GetMode();
				modetext2.text = LightItem.GetMode();
			}
		}
		public void Reset(OculusSampleFramework.InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == OculusSampleFramework.InteractableState.ActionState)
			{
				LightItem.ResetIntensity();
			}
		}
    }
}

