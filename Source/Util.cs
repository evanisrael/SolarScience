using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using KSP.Localization;

namespace SolarScience
{
    class Util
    {
        public bool debugMode = false;
        internal bool CheckBody()
        {
            if (vessel.mainBody.name == "Sun" && vessel.mainBody.GetAltitude(vessel.CoM) <= 10000000000d)
            {
                if (debugMode)
                    Debug.Log("[Solar Science] Triggered checkBody, returned true");
                return true;
            }
            else
            {
                Debug.Log("[Solar Science] Triggered checkBody, returned false");
                // "This experiment only operates closely around Kerbol (the Sun) !"
                ScreenMessages.PostScreenMessage(Localizer.Format("#SolarScience_000"), 3, ScreenMessageStyle.UPPER_CENTER);
                return false;
            }
        }

        //Check if the instrument is pointing at least close to the sun
        internal bool CheckDirection()
        {
            bool temp;

            if (Vector3.Angle(part.transform.forward, FlightGlobals.currentMainBody.position - vessel.transform.position) <= 10)
            {
                if (debugMode)
                    Debug.Log("[Solar Science] Triggered checkDirection, returned true");
                temp = true;
            }
            else
            {
                if (debugMode)
                    Debug.Log("[Solar Science] Triggered checkDirection, returned false");
                // "Point it towards Kerbol! You can't take the pictures if you aren't looking at it!"
                ScreenMessages.PostScreenMessage(Localizer.Format("#SolarScience_001"), 3, ScreenMessageStyle.UPPER_CENTER);
                temp = false;
            }

            if (debugMode)
                Debug.Log("[Solar Science] Angle from part to body: " + Vector3.Angle(part.transform.forward, FlightGlobals.currentMainBody.position - vessel.transform.position));
            return temp;
        }

        //Check if the Angular Velocity is less than .05
        public bool CheckAngularVelocity()
        {
            if (vessel.angularVelocity.magnitude <= .05)
            {
                if (debugMode)
                    Debug.Log("[Solar Science] Triggered checkAngularVelocity, returned true");
                return true;
            }
            else
            {
                if (debugMode)
                    Debug.Log("[Solar Science] Triggered checkAngularVelocity, returned false");

                // "Steady your craft! You'll make the pictures blurry!"
                ScreenMessages.PostScreenMessage(Localizer.Format("#SolarScience_002"), 3, ScreenMessageStyle.UPPER_CENTER);
                return false;
            }
        }
    }
}
