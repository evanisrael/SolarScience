﻿//34
// 
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// 
#region License Solar Science (SOL)
/*
 * Solar Science is an add-on by Logan Hardin, also known as Snoopy 20111, for Kerbal Space Program by Squad.
 * "I would prefer to be referred to as Snoopy 20111 in any attributions. Let's be honest, I'm not going to track you down, I would just appreciate it."
 * Praise the Sun
 *
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
#endregion


using System.Reflection;

[assembly: AssemblyFileVersion("1.3.1.34")]
[assembly: AssemblyVersion("1.3.1.0")]
[assembly: AssemblyInformationalVersion("1.3.1")]
[assembly: KSPAssembly("SolarScience", 1,3,1)]

namespace SolarScience
{
	public static class Version
	{
		public const int major = 1;
		public const int minor = 3;
		public const int patch = 1;
		public const int build = 0;
		public const string Number = "1.3.1.0";
#if DEBUG
        public const string Text = Number + "-zed'K BETA DEBUG";
        public const string SText = Number + "-zed'K BETA DEBUG";
#else
        public const string Text = Number + "-zed'K";
		public const string SText = Number;
#endif
	}
}