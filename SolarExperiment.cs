//Make sure we're using all available stuff
using System;
using UnityEngine;

namespace PraiseTheSun
{
	//Inherit ModuleScienceExperiment stuff
	public class SolarExperiment : ModuleScienceExperiment{

	// Check if you're around the Sun and height from the surface, and if false post the message
	public bool checkBody() {
			if (vessel.mainBody.name == "Sun" && vessel.mainBody.GetAltitude (vessel.CoM) <= 10000000000d)
				return true;
				ScreenMessages.PostScreenMessage("This experiment only operates closely around Kerbol (the Sun) !", 3, ScreenMessageStyle.UPPER_CENTER);
				 return false;
			}
	// If deploying an Experiment, check the boolean and act accordingly
	new public void DeployExperiment() {
		if(checkBody())
			base.DeployExperiment();
	}
	// If doing an action, check the boolean and act accordingly
	new public void DeployAction(KSPActionParam p) {
		if(checkBody())
			base.DeployAction(p);
	}
	
	}}