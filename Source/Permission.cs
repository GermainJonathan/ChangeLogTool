using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Source
{
    /**
     * Model de donnée des permissions
     */
    class Permission
    {
        /**
         * Identifiant de la permission
         */
        [JsonProperty("id")]
        private string id { get; }

        /**
         * Clé de la permission
         */
        [JsonProperty("key")]
        private string key { get; }

        /**
         * Nom de la permission
         */
        [JsonProperty("name")]
        private string name { get; }

        /**
         * Type de permission
         */
        [JsonProperty("type")]
        private string type { get; }

        /**
         * Explication de la premission
         */
        [JsonProperty("description")]
        private string description { get; }

        /**
         * Etat de la permission - Indique si elle est active
         */
        [JsonProperty("havePermission")]
        private bool havePermission { get; }

        /**
         * Propriété optionnel - Indique si la permission est obsolète
         */
        private bool deprecatedKey { get; }
    }
}
