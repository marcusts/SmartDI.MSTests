// *********************************************************************************
// <copyright file=Complex.cs company="Marcus Technical Services, Inc.">
//     Copyright @2019 Marcus Technical Services, Inc.
// </copyright>
//
// MIT License
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// *********************************************************************************

namespace Com.MarcusTS.SmartDI.MSTests
{
   /// <summary>
   ///    Interface IRecursiveService
   ///    Implements the <see cref="IServiceOne" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IServiceOne" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IServiceOne" />
   /// <seealso cref="IServiceOne" />
   public interface IRecursiveService : IServiceOne
   {
   }

   /// <summary>
   ///    Interface IServiceOne
   /// </summary>
   public interface IServiceOne
   {
   }

   /// <summary>
   ///    Interface IServiceThree
   /// </summary>
   public interface IServiceThree
   {
   }

   /// <summary>
   ///    Interface IServiceTwo
   /// </summary>
   public interface IServiceTwo
   {
   }

   /// <summary>
   ///    Class RecursiveService.
   ///    Implements the <see cref="ServiceOne" />
   ///    Implements the <see cref="IRecursiveService" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.ServiceOne" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IRecursiveService" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.ServiceOne" />
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IRecursiveService" />
   /// <seealso cref="ServiceOne" />
   /// <seealso cref="IRecursiveService" />
   public class RecursiveService : ServiceOne, IRecursiveService
   {
      /// <summary>
      ///    The service one
      /// </summary>
      private readonly IServiceOne _serviceOne;

      /// <summary>
      ///    Initializes a new instance of the <see cref="RecursiveService" /> class.
      /// </summary>
      /// <param name="serviceOne">The service one.</param>
      public RecursiveService(IServiceOne serviceOne)
      {
         _serviceOne = serviceOne;
      }
   }

   /// <summary>
   ///    Class ServiceOne.
   ///    Implements the <see cref="IServiceOne" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IServiceOne" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IServiceOne" />
   /// <seealso cref="IServiceOne" />
   public class ServiceOne : IServiceOne
   {
   }

   /// <summary>
   ///    Class ServiceThree.
   ///    Implements the <see cref="IServiceThree" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IServiceThree" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IServiceThree" />
   /// <seealso cref="IServiceThree" />
   public class ServiceThree : IServiceThree
   {
      /// <summary>
      ///    The service one
      /// </summary>
      private readonly IServiceOne _serviceOne;

      /// <summary>
      ///    The service two
      /// </summary>
      private readonly IServiceTwo _serviceTwo;

      /// <summary>
      ///    Initializes a new instance of the <see cref="ServiceThree" /> class.
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
   ///    Class ServiceTwo.
   ///    Implements the <see cref="IServiceTwo" />
   ///    Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.IServiceTwo" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.IServiceTwo" />
   /// <seealso cref="IServiceTwo" />
   public class ServiceTwo : IServiceTwo
   {
      /// <summary>
      ///    The service one
      /// </summary>
      private readonly IServiceOne _serviceOne;

      /// <summary>
      ///    Initializes a new instance of the <see cref="ServiceTwo" /> class.
      /// </summary>
      /// <param name="serviceOne">The service one.</param>
      public ServiceTwo(IServiceOne serviceOne)
      {
         _serviceOne = serviceOne;
      }
   }
}