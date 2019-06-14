#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#endregion

namespace Infrastructure
{
    public class CollectionBase<T>
        : Collection<T>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Collection&lt;T&gt;"/> class.
        /// </summary>
        protected CollectionBase()
            : base(new List<T>()) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Collection&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="initialList">Accepts an IList of T as the initial list.</param>
        protected CollectionBase(IList<T> initialList)
            : base(initialList) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Collection&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="initialList">Accepts a CollectionBase of T as the initial list.</param>
        protected CollectionBase(CollectionBase<T> initialList)
            : base(initialList) { }

        #endregion

        #region Member Methods

        /// <summary>
        /// Sorts the collection based on the specified comparer.
        /// </summary>
        /// <param name="comparer">The comparer.</param>
        public void Sort(IComparer<T> comparer)
        {
            if (Items is List<T> list)
                list.Sort(comparer);
        }

        /// <summary>
        /// Sorts the collection.  Uses equals on the objects being compared.
        /// </summary>
        public void Sort()
        {
            if (Items is List<T> list)
                list.Sort();
        }

        /// <summary>
        /// Adds a range of T instances to the current collection.
        /// </summary>
        /// <param name="collection"></param>
        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection), "Parameter collection is null.");

            foreach (var item in collection)
                Add(item);
        }

        #endregion
    }
}
