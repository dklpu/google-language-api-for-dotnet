﻿/**
 * ArgumentAttribute.cs
 *
 * Copyright (C) 2008,  iron9light
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 */

using System;

namespace Google.API.Translate
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class ArgumentAttribute : Attribute
    {
        /// <summary>
        /// Constructor of ArgumentAttribute
        /// </summary>
        /// <param name="name">The argument name.</param>
        public ArgumentAttribute(string name)
        {
            Name = name;
            Optional = true;
            DefaultValue = null;
            NeedEncode = false;
        }

        /// <summary>
        /// Constructor of ArgumentAttribute
        /// </summary>
        /// <param name="name">The argument name.</param>
        /// <param name="defaultValue">Default value.</param>
        public ArgumentAttribute(string name, object defaultValue)
        {
            Name = name;
            if (defaultValue == null)
            {
                Optional = true;
            }
            else
            {
                Optional = false;
            }
            DefaultValue = defaultValue;
            NeedEncode = false;
        }

        /// <summary>
        /// Get the argument name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Get or set whether this argument is optional.
        /// The default value is true.
        /// </summary>
        public bool Optional { get; set; }

        /// <summary>
        /// Get the default value. Or return null is no default value.
        /// </summary>
        public object DefaultValue { get; private set; }

        /// <summary>
        /// Get or set whether this argument need to be encoded.
        /// The default value is false.
        /// </summary>
        public bool NeedEncode { get; set; }
    }
}
