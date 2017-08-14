﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace JV.Wpf.Utilities.Collections
{
    /// <summary>
    /// Extension of <see cref="System.Collections.ObjectModel.ObservableCollection{T}"/>, which implements <see cref="IObservableCollection{T}"/>,
    /// allowing for complete abstraction/dependency injection in Unit Testing.
    /// </summary>
    public class ObservableCollection<T> : System.Collections.ObjectModel.ObservableCollection<T>, IObservableCollection<T>, IReadOnlyObservableCollection<T>
    {
        /**********************************************************************/
        #region Constructors

        /// <summary>
        /// See <see cref="System.Collections.ObjectModel.ObservableCollection{T}"/>.
        /// </summary>
        internal ObservableCollection()
            : base() { }

        /// <summary>
        /// See <see cref="System.Collections.ObjectModel.ObservableCollection{T}"/>.
        /// </summary>
        internal ObservableCollection(List<T> list)
            : base(list) { }

        /// <summary>
        /// See <see cref="System.Collections.ObjectModel.ObservableCollection{T}"/>.
        /// </summary>
        internal ObservableCollection(IEnumerable<T> collection)
            : base(collection) { }

        #endregion Constructors
    }
}
