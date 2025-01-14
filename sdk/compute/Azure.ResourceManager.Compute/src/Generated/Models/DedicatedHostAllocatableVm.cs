// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Represents the dedicated host unutilized capacity in terms of a specific VM size. </summary>
    public partial class DedicatedHostAllocatableVm
    {
        /// <summary> Initializes a new instance of DedicatedHostAllocatableVm. </summary>
        internal DedicatedHostAllocatableVm()
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostAllocatableVm. </summary>
        /// <param name="vmSize"> VM size in terms of which the unutilized capacity is represented. </param>
        /// <param name="count"> Maximum number of VMs of size vmSize that can fit in the dedicated host's remaining capacity. </param>
        internal DedicatedHostAllocatableVm(string vmSize, double? count)
        {
            VmSize = vmSize;
            Count = count;
        }

        /// <summary> VM size in terms of which the unutilized capacity is represented. </summary>
        public string VmSize { get; }
        /// <summary> Maximum number of VMs of size vmSize that can fit in the dedicated host's remaining capacity. </summary>
        public double? Count { get; }
    }
}
