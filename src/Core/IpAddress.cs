﻿// <airvpn_source_header>
// This file is part of AirVPN Client software.
// Copyright (C)2014-2014 AirVPN (support@airvpn.org) / https://airvpn.org )
//
// AirVPN Client is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AirVPN Client is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AirVPN Client. If not, see <http://www.gnu.org/licenses/>.
// </airvpn_source_header>

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AirVPN.Core
{
	public class IpAddress
	{
		public string Value = "";

		public IpAddress()
		{
			Value = "";
		}

		public IpAddress(string value)
		{
			Value = value;
		}

		public static implicit operator IpAddress(string value)
		{
			return new IpAddress(value);
		}

		public bool Empty
		{
			get
			{
				return (Value == "");
			}
		}

		public bool Valid
		{
			get
			{
				return System.Text.RegularExpressions.Regex.IsMatch(Value, @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$\b");
			}
		}

		public bool Loopback
		{
			get
			{
				return Value.StartsWith("127.0.0.1");
			}
		}

		public void Clear()
		{
			Value = "";
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;

			IpAddress two = obj as IpAddress;
			if (two == null)
				return false;

			return Value == two.Value;
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public override string ToString()
		{
			return Value;
		}
	}
}
