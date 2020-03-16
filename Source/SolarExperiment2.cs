//Make sure we're using all available stuff
using System;
using UnityEngine;

namespace PraiseTheSun
{
//Inherit ModuleScienceExperiment stuff
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
                ScreenMessages.PostScreenMessage("This experiment only operates closely around Kerbol (the Sun) !", 3, ScreenMessageStyle.UPPER_CENTER);
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
                ScreenMessages.PostScreenMessage("Point it towards Kerbol! You can't take the pictures if you aren't looking at it!", 3, ScreenMessageStyle.UPPER_CENTER);
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
                ScreenMessages.PostScreenMessage("Steady your craft! You'll make the pictures blurry!", 3, ScreenMessageStyle.UPPER_CENTER);
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