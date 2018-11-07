﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Domain.Timing
{
    /// <summary>
	/// Defines interface to perform some common date-time operations.
	/// </summary>
	public interface IClockProvider
    {
        /// <summary>
        /// Gets Now.
        /// </summary>
        DateTime Now
        {
            get;
        }

        /// <summary>
        /// Gets kind.
        /// </summary>
        DateTimeKind Kind
        {
            get;
        }

        /// <summary>
        /// Is that provider supports multiple time zone.
        /// </summary>
        bool SupportsMultipleTimezone
        {
            get;
        }

        /// <summary>
        /// Normalizes given <see cref="T:System.DateTime" />.
        /// </summary>
        /// <param name="dateTime">DateTime to be normalized.</param>
        /// <returns>Normalized DateTime</returns>
        DateTime Normalize(DateTime dateTime);
    }
}
