/* Solar Science (SOL)
 * Solar Science is an add-on by Logan Hardin, also known as Snoopy 20111, for Kerbal Space Program by Squad.
 * "I would prefer to be referred to as Snoopy 20111 in any attributions. Let's be honest, I'm not going to track you down, I would just appreciate it."
 * Praise the Sun
 
 * Copyright (C) 2015, 2016 Snoopy 20111 (Logan Hardin)
 * Copyright (C) 2019, 2022 zer0Kerbal (zer0Kerbal at hotmail dot com)
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

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
                ScreenMessages.PostScreenMessage(Localizer.Format("#SOL-000"), 3, ScreenMessageStyle.UPPER_CENTER);
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
                ScreenMessages.PostScreenMessage(Localizer.Format("#SOL-001"), 3, ScreenMessageStyle.UPPER_CENTER);
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
                ScreenMessages.PostScreenMessage(Localizer.Format("#SOL-002"), 3, ScreenMessageStyle.UPPER_CENTER);
                return false;
            }
        }
    }
}
