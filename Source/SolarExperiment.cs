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
using KSP.Localization;

namespace PraiseTheSun
{
    /// <summary>Inherit ModuleScienceExperiment stuff</summary>
    public class SolarExperiment : ModuleScienceExperiment
    {

        // Check if you're around the Sun and height from the surface, and if false post the message
    public bool checkBody()
        {
            if (vessel.mainBody.name == "Sun" && vessel.mainBody.GetAltitude(vessel.CoM) <= 10000000000d)
            {
                Debug.Log("Triggered checkBody, returned true");
                return true;
            }
            else
            {
                Debug.Log("Triggered checkBody, returned false");
//                "This experiment only operates closely around Kerbol (the Sun) !"
                ScreenMessages.PostScreenMessage(Localizer.Format("#SOL-000")", 3, ScreenMessageStyle.UPPER_CENTER);
                return false;
            }
        }

//Check if the instrument is pointing 
        public bool checkDirection()
        {
            if ("vector forward from the instrument >= 5 degrees from vector from part to vessel.mainBody")
            {
                Debug.Log("Triggered checkDirection, returned true");
                return true;
            }
            else
            {
                Debug.Log("Triggered checkDirection, returned false");
                // "Point it towards Kerbol! You can't take the pictures if you aren't looking at it!"
                ScreenMessages.PostScreenMessage(Localizer.Format("#SOL-001"), 3, ScreenMessageStyle.UPPER_CENTER);
                return false;
            }
        }

//Check if the Angular Velocity is less than .05
        public bool checkAngularVelocity()
        {
            if (vessel.angularVelocity.magnitude <= .05)
            {
                Debug.Log("Triggered checkAngularVelocity, returned true");
                return true;
            }
            else
            {
                Debug.Log("Triggered checkAngularVelocity, returned false");
                // "Steady your craft! You'll make the pictures blurry!"
                ScreenMessages.PostScreenMessage(Localizer.Format("#SOL-002", 3, ScreenMessageStyle.UPPER_CENTER);
                return false;
            }
        }

// If deploying an Experiment, check the booleans and act accordingly

        new public void DeployExperiment()
        {
        if (checkBody() && checkAngularVelocity() && checkDirection())
            base.DeployExperiment();
        }

// If doing an action, check the booleans and act accordingly

    new public void DeployAction(KSPActionParam p)
        {
        if (checkBody() && checkAngularVelocity() && checkDirection())
            base.DeployAction(p);
        }

    }
}