#region License
//   Copyright 2013 Ken Worst - R.C. Worst & Company Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using Newtonsoft.Json;

namespace BigCommerce4Net.Domain
{
    public class State : EntityBase
    {
        /// <summary>
        /// The ID of the state.
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the state.
        /// 
        /// [string(255)]
        /// </summary>
        [JsonProperty("state")]
        public virtual string StateName { get; set; }

        /// <summary>
        /// The abbreviation of the state.
        /// 
        /// [string(5)]
        /// </summary>
        [JsonProperty("state_abbreviation")]
        public virtual string StateAbbreviation { get; set; }


        /// <summary>
        /// The ID of the country this state belongs to.
        /// 
        /// </summary>
        [JsonProperty("country_id")]
        public virtual int CountryId { get; set; }


        [JsonIgnore]
        public virtual Country Country { get; set; }

    }
}
