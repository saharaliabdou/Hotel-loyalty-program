﻿
using System.Text;


namespace Kata2_IEquitable
{
    interface IMemberList
    {
        /// <summary>
        /// number of members in the list
        /// </summary>
        /// <returns>number of members in the list</returns>
        int Count();

        /// <summary>
        /// number of members that joined in a specific year
        /// </summary>
        /// <param name="year"></param>
        /// <returns>number of members that joined in a specific year</returns>
        int Count(int year);

        /// <summary>
        /// Sorts the dates in year, month, day order
        /// </summary>
        void Sort();
        

    }
}
