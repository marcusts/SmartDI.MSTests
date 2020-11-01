#region License

// Copyright (c) 2019  Marcus Technical Services, Inc. <marcus@marcusts.com>
//
// This file, HighLevelTests.cs, is a part of a program called Com.MarcusTS.SmartDI.MSTests.
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
   using MarcusTS.LifecycleAware.ViewModels;
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using System;
   using System.Linq;
   using LifecycleAware;
   using SharedUtils.Utils;

   /// <summary>
   /// Defines test class HighLevelTests.
   /// Implements the <see cref="Com.MarcusTS.SmartDI.MSTests.LowLevelTests" />
   /// Implements the <see cref="System.IDisposable" />
   /// </summary>
   /// <seealso cref="Com.MarcusTS.SmartDI.MSTests.LowLevelTests" />
   /// <seealso cref="System.IDisposable" />
   [TestClass]
   public class HighLevelTests : LowLevelTests, IDisposable
   {
<<<<<<< HEAD
=======
      // This container provides lifecycle support
      /// <summary>
      /// The container
      /// </summary>
      private readonly ISmartDIContainerWithLifecycleForUnitTesting _container =
         new SmartDIContainerWithLifecycleForUnitTesting();

>>>>>>> cae8d63ffd44c40adcfcfc2808c6012236ec5637
      /// <summary>
      /// Note that we did not test the DerivedContentViewWithLifecycle,
      /// as it is identical to the page other than the fact that it derived a different base class.
      /// </summary>
      [TestMethod]
      public void TestSharedInstanceRemovalAfterParentLosesScope()
      {
         // Create a lifecycle aware page
         var derivedContentPageWithLifecycle1 = new DerivedContentPageWithLifecycle();

         // Register it as shared, and instantiate using our provided instance
         _container.RegisterTypeAsInterface<ViewModelWithLifecycle>(typeof(IViewModelWithLifecycle),
                                                                    StorageRules.SharedDependencyBetweenInstances);

         // Verify that all went well
         Assert.IsTrue(_container.ExposedRegisteredTypeContracts.IsNotEmpty(),
                       "Failed to register a type for any access level.");
         Assert.IsTrue(_container.ExposedSharedInstancesWithBoundMembers.IsEmpty(),
                       "Added a shared instance upon registration rather than on Resolve.");

         // Resolve the view model by interface
         var viewModel =
            _container.Resolve<IViewModelWithLifecycle>(StorageRules.SharedDependencyBetweenInstances,
                                                        derivedContentPageWithLifecycle1);

         // Verify that we stored the view model as expected.
         Assert.IsTrue(_container.ExposedSharedInstancesWithBoundMembers.Count == 1,
                       "Failed to add a new shared instance.");

         // Set the page binding context to the view model. This sets the page view model's lifecycle reporter as the page.
         derivedContentPageWithLifecycle1.BindingContext = viewModel;

         // Force the page to "disappear" as if it had gone out of scope.
         derivedContentPageWithLifecycle1.CallForceDisappearing();

         // Verify that the container removed the now-unlinked view model
         Assert.IsTrue(_container.ExposedSharedInstancesWithBoundMembers.IsEmpty(),
                       "Failed to remove an orphaned instance after its linked parent fell out of scope.");

         // DO AGAIN WITH MULTIPLE PARENTS
         _container.ResetUnitTestContainer();

         // Create another lifecycle aware page
         var derivedContentPageWithLifecycle2 = new DerivedContentPageWithLifecycle();

         // Register it as shared, and instantiate using our provided instance
         _container.RegisterTypeAsInterface<ViewModelWithLifecycle>(typeof(IViewModelWithLifecycle),
                                                                    StorageRules.SharedDependencyBetweenInstances);

         // Verify that all went well
         Assert.IsTrue(_container.ExposedRegisteredTypeContracts.IsNotEmpty(),
                       "Failed to register a type for any access level.");
         Assert.IsTrue(_container.ExposedSharedInstancesWithBoundMembers.IsEmpty(),
                       "Added a shared instance upon registration rather than on Resolve.");

         // Resolve the view model by interface
         viewModel =
            _container.Resolve<IViewModelWithLifecycle>(StorageRules.SharedDependencyBetweenInstances,
                                                        derivedContentPageWithLifecycle1);

         // Verify that we stored the view model's bound, linked parents as expected.
         Assert.IsTrue(_container.ExposedSharedInstancesWithBoundMembers.Count == 1,
                       "Failed to add a new shared instance.");

         // Resolve a second time with a new parent -- now two objects rely on the view model
         var viewModel2 =
            _container.Resolve<IViewModelWithLifecycle>(StorageRules.SharedDependencyBetweenInstances,
                                                        derivedContentPageWithLifecycle2);

         // This second registration does not increase the count in the _container.ExposedSharedInstancesWithBoundMembers.
         // That remains at 1.  This new linked object gets inserted into a dictionary at position _container.ExposedSharedInstancesWithBoundMembers[0].
         // We will verify both facts.
         Assert.IsTrue(_container.ExposedSharedInstancesWithBoundMembers.Count == 1,
                       "Added two instancess when only one dictionary was required.");
         var linkedDict = _container.ExposedSharedInstancesWithBoundMembers.First().Value;
         Assert.IsTrue(linkedDict.Count == 2,
                       "Failed to add a second dictionary entry for a second shared/linked/bound object.");

         // Set the second page binding context to the second view model. This sets the page view model's lifecycle reporter as the page.
         derivedContentPageWithLifecycle2.BindingContext = viewModel2;

         // Force the FIRST page to "disappear" as if it had gone out of scope.
         derivedContentPageWithLifecycle1.CallForceDisappearing();

         // The _container.ExposedSharedInstancesWithBoundMembers is NOT empty now because there is still a linked member.
         Assert.IsTrue(_container.ExposedSharedInstancesWithBoundMembers.Count == 1,
                       "Removed the ExposedSharedInstancesWithBoundMembers member when there was still a valid linked parent object.");

         // The stored dictionary now has 1 member instead dof 2.
         linkedDict = _container.ExposedSharedInstancesWithBoundMembers.First().Value;
         Assert.IsTrue(linkedDict.Count == 1,
                       "Failed to remove one of two bound members when that member fell out of scope.");

         // Force the SECOND page to "disappear" as if it had gone out of scope.
         derivedContentPageWithLifecycle2.CallForceDisappearing();

         // Now the bound members really will be empty
         Assert.IsTrue(_container.ExposedSharedInstancesWithBoundMembers.IsEmpty(),
                       "Failed to remove an orphaned instance after its linked parent fell out of scope.");
      }
   }
}