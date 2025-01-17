// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The status of the long running operation. </summary>
    public partial class OperationStatus
    {
        /// <summary> Initializes a new instance of OperationStatus. </summary>
        internal OperationStatus()
        {
        }

        /// <summary> Initializes a new instance of OperationStatus. </summary>
        /// <param name="status"> The status of the long running operation. </param>
        /// <param name="reportUri"> The CSV file from the reportUrl blob link consists of reservation usage data with the following schema at daily granularity. </param>
        /// <param name="validUntil"> The time at which report URL becomes invalid. </param>
        internal OperationStatus(OperationStatusType? status, ReservationReportSchema? reportUri, DateTimeOffset? validUntil)
        {
            Status = status;
            ReportUri = reportUri;
            ValidUntil = validUntil;
        }

        /// <summary> The status of the long running operation. </summary>
        public OperationStatusType? Status { get; }
        /// <summary> The CSV file from the reportUrl blob link consists of reservation usage data with the following schema at daily granularity. </summary>
        public ReservationReportSchema? ReportUri { get; }
        /// <summary> The time at which report URL becomes invalid. </summary>
        public DateTimeOffset? ValidUntil { get; }
    }
}
