﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

namespace QuantConnect.Securities.Cfd
{
    /// <summary>
    /// Represents a simple, constant margining model by specifying the percentages of required margin.
    /// This implementation differs from the base <see cref="SecurityMarginModel"/> in that it applies
    /// conversion rates from quote currency to the account currency
    /// </summary>
    public class CfdMarginModel : SecurityMarginModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CfdMarginModel"/>
        /// </summary>
        /// <param name="leverage">The leverage</param>
        public CfdMarginModel(decimal leverage)
            : base(leverage)
        {
        }
    }
}