﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// TODO: refactor code to get; set 
namespace Tsinghua.HCI.IoTVRP
{
    public class LightItem : MonoBehaviour
    {
        private Light _light;
        // Start is called before the first frame update

        public 
        void Start()
        {
            _light = GetComponent<Light>();
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void SetColor(Color newColor)
        {
            _light.color = newColor;
        }

        public void Toggle()
        {
            _light.enabled = !_light.enabled;
        }

        public void TurnOff()
        {
            _light.enabled = false;
        }

        public void TurnOn()
        {
            _light.enabled = true;
        }

        public void SetRange(float newRange)
        {
            _light.range = newRange;
        }

        public void SetIntensity(float newIntensity)
        {
            _light.intensity = newIntensity;
        }

        public void SetType(LightType lightType)
        {
            _light.type = lightType;
        }

        public Light GetLight()
        {
            return _light;
        }
        public void IncreaseIntensity(float num)
        {
            _light.intensity += num;
        }
        public void DecreaseIntensity(float num)
        {
            _light.intensity -= num;
        }


        public void GestureControl(GestureEventData gestureEventData)
        {
            switch (gestureEventData.GestureType)
            {
                case GestureType.TurnOn:
                    TurnOn();
                    break;
                case GestureType.TurnOff:
                    TurnOff();
                    break;

                default:
                    break;
            }
            // gameObject.name
        }

        public void UnsetGestureControl()
        {

        }
    }
}
