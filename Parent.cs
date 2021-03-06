﻿#region License

// Copyright (c) 2019  Marcus Technical Services, Inc. <marcus@marcusts.com>
//
// This file, Parent.cs, is a part of a program called Com.MarcusTS.SmartDI.MSTests.
//
// Com.MarcusTS.SmartDI.MSTests is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// Permission to use, copy, modify, and/or distribute this software
// for any purpose with or without fee is hereby granted, provided
// that the above copyright notice and this permission notice appear
// in all copies.
//
// Com.MarcusTS.SmartDI.MSTests is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// For the complete GNU General Public License,
// see <http://www.gnu.org/licenses/>.

#endregion

namespace Com.MarcusTS.SmartDI.MSTests
{
   /// <summary>
   /// Interface IAmAParent
   /// </summary>
   public interface IAmAParent
   {
   }

   /// <summary>
   /// Class ParentClass.
   /// Implements the <see cref="IAmAParent" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmAParent" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmAParent" />
   /// <seealso cref="IAmAParent" />
   public class ParentClass : IAmAParent
   {
   }
}