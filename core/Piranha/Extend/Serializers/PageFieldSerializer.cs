/*
 * Copyright (c) 2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using System;

namespace Piranha.Extend.Serializers
{
    public class PageFieldSerializer : ISerializer
    {        
        /// <summary>
        /// Serializes the given object.
        /// </summary>
        /// <param name="obj">The object</param>
        /// <returns>The serialized value</returns>
        public string Serialize(object obj) {
            if (obj is Fields.PageField) {
                return ((Fields.PageField)obj).Id.ToString();
            }
            throw new ArgumentException("The given object doesn't match the serialization type");
        }

        /// <summary>
        /// Deserializes the given string.
        /// </summary>
        /// <param name="str">The serialized value</param>
        /// <returns>The object</returns>
        public object Deserialize(string str) {
            return new Fields.PageField() {
                Id = !string.IsNullOrEmpty(str) ? new Guid(str) : (Guid?)null
            };
        }
    }
}
