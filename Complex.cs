#region License

// Copyright (c) 2019  Marcus Technical Services, Inc. <marcus@marcusts.com>
//
// This file, Complex.cs, is a part of a program called Com.MarcusTS.SmartDI.MSTests.
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
   /// Interface IRecursiveService
   /// Implements the <see cref="IServiceOne" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IServiceOne" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IServiceOne" />
   /// <seealso cref="IServiceOne" />
   public interface IRecursiveService : IServiceOne
   {
   }

   /// <summary>
   /// Interface IServiceOne
   /// </summary>
   public interface IServiceOne
   {
   }

   /// <summary>
   /// Interface IServiceThree
   /// </summary>
   public interface IServiceThree
   {
   }

   /// <summary>
   /// Interface IServiceTwo
   /// </summary>
   public interface IServiceTwo
   {
   }

   /// <summary>
   /// Class RecursiveService.
   /// Implements the <see cref="ServiceOne" />
   /// Implements the <see cref="IRecursiveService" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.ServiceOne" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IRecursiveService" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.ServiceOne" />
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IRecursiveService" />
   /// <seealso cref="ServiceOne" />
   /// <seealso cref="IRecursiveService" />
   public class RecursiveService : ServiceOne, IRecursiveService
   {
      /// <summary>
      /// The service one
      /// </summary>
      private readonly IServiceOne _serviceOne;

      /// <summary>
      /// Initializes a new instance of the <see cref="RecursiveService" /> class.
      /// </summary>
      /// <param name="serviceOne">The service one.</param>
      public RecursiveService(IServiceOne serviceOne)
      {
         _serviceOne = serviceOne;
      }
   }

   /// <summary>
   /// Class ServiceOne.
   /// Implements the <see cref="IServiceOne" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IServiceOne" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IServiceOne" />
   /// <seealso cref="IServiceOne" />
   public class ServiceOne : IServiceOne
   {
   }

   /// <summary>
   /// Class ServiceThree.
   /// Implements the <see cref="IServiceThree" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IServiceThree" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IServiceThree" />
   /// <seealso cref="IServiceThree" />
   public class ServiceThree : IServiceThree
   {
      /// <summary>
      /// The service one
      /// </summary>
      private readonly IServiceOne _serviceOne;

      /// <summary>
      /// The service two
      /// </summary>
      private readonly IServiceTwo _serviceTwo;

      /// <summary>
      /// Initializes a new instance of the <see cref="ServiceThree" /> class.
      /// </summary>
      /// <param name="serviceOne">The service one.</param>
      /// <param name="serviceTwo">The service two.</param>
      public ServiceThree
      (
         IServiceOne serviceOne,
         IServiceTwo serviceTwo
      )
      {
         _serviceOne = serviceOne;
         _serviceTwo = serviceTwo;
      }
   }

   /// <summary>
   /// Class ServiceTwo.
   /// Implements the <see cref="IServiceTwo" />
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IServiceTwo" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IServiceTwo" />
   /// <seealso cref="IServiceTwo" />
   public class ServiceTwo : IServiceTwo
   {
      /// <summary>
      /// The service one
      /// </summary>
      private readonly IServiceOne _serviceOne;

      /// <summary>
      /// Initializes a new instance of the <see cref="ServiceTwo" /> class.
      /// </summary>
      /// <param name="serviceOne">The service one.</param>
      public ServiceTwo(IServiceOne serviceOne)
      {
         _serviceOne = serviceOne;
      }
   }
}