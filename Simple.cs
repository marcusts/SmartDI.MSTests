#region License

// Copyright (c) 2019  Marcus Technical Services, Inc. <marcus@marcusts.com>
//
// This file, Simple.cs, is a part of a program called Com.MarcusTS.SmartDI.MSTests.
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
   /// Interface IAmReallySimple
   /// </summary>
   public interface IAmReallySimple
   {
   }

   /// <summary>
   /// Interface IAmSimple
   /// </summary>
   public interface IAmSimple
   {
   }

   /// <summary>
   /// Interface IDerivedSimpleClass
   /// Implements the <see cref="IAmSimple" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// <seealso cref="IAmSimple" />
   public interface IDerivedSimpleClass : IAmSimple
   {
   }

   /// <summary>
   /// Class SimpleClass_Static.
   /// </summary>
   public static class SimpleClass_Static
   {
      /// <summary>
      /// Creates the simple instance.
      /// </summary>
      /// <returns>IAmSimple.</returns>
      public static IAmSimple CreateSimpleInstance()
      {
         return new SimpleClass();
      }
   }

   /// <summary>
   /// Class AnotherSimpleClass.
   /// Implements the <see cref="IAmSimple" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// <seealso cref="IAmSimple" />
   public class AnotherSimpleClass : IAmSimple
   {
   }

   /// <summary>
   /// Class DerivedSimpleClass.
   /// Implements the <see cref="SimpleClass" />
   /// Implements the <see cref="IDerivedSimpleClass" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.SimpleClass" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IDerivedSimpleClass" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.SimpleClass" />
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IDerivedSimpleClass" />
   /// <seealso cref="SimpleClass" />
   /// <seealso cref="IDerivedSimpleClass" />
   public class DerivedSimpleClass : SimpleClass, IDerivedSimpleClass
   {
   }

   /// <summary>
   /// Class SimpleClass.
   /// Implements the <see cref="IAmSimple" />
   /// Implements the <see cref="IAmReallySimple" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IAmReallySimple" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmSimple" />
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IAmReallySimple" />
   /// <seealso cref="IAmSimple" />
   /// <seealso cref="IAmReallySimple" />
   public class SimpleClass : IAmSimple, IAmReallySimple
   {
      /// <summary>
      /// Gets or sets a value indicating whether this instance has been set.
      /// </summary>
      /// <value><c>true</c> if this instance has been set; otherwise, <c>false</c>.</value>
      public bool HasBeenSet { get; set; }
   }
}