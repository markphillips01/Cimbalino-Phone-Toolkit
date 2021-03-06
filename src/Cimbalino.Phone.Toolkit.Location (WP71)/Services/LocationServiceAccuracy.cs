﻿// ****************************************************************************
// <copyright file="LocationServiceAccuracy.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2013
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <date>20-04-2013</date>
// <project>Cimbalino.Phone.Toolkit.Location</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

namespace Cimbalino.Phone.Toolkit.Services
{
    /// <summary>
    /// Indicates the requested accuracy level for the location data that the application uses.
    /// </summary>
    public enum LocationServiceAccuracy
    {
        /// <summary>
        /// Optimize for power, performance, and other cost considerations.
        /// </summary>
        Default,
        
        /// <summary>
        /// Deliver the most accurate report possible. This includes using services that might charge money, or consuming higher levels of battery power or connection bandwidth. An accuracy level of High may degrade system performance and should be used only when necessary.
        /// </summary>
        High
    }
}