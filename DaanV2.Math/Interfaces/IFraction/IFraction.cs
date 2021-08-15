using System;

namespace DaanV2.Math {
    ///<summary>Numerator / Denominator</summary>
    public interface IFraction<T>
        where T : struct {
        /// <summary>
        /// 
        /// </summary>
        public T Denominator { get; }

        /// <summary>
        /// 
        /// </summary>
        public T Numerator { get; }
    }
}
